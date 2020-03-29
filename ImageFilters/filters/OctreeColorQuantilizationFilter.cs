using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters.filters
{
    class OctreeColorQuantilizationFilter : Filter
    {
        const int MAX_DEPTH = 8;
        int MaxColorsCount, CurrentColorCount;

        public OctreeColorQuantilizationFilter(FastImage image, int maxColors) : base(image)
        {
            MaxColorsCount = maxColors;
        }

        public override FastImage Apply()
        {
            List<(int r, int g, int b)> colors = Image.GetAll().Distinct().ToList();

            OctreeNode root = BuildTree(colors);

            ReduceTree(root);

            Image.SetAll(px => ReplaceColor(root, px));

            return Image;
        }

        private OctreeNode BuildTree(List<(int r, int g, int b)> colors)
        {
            OctreeNode root = new OctreeNode();

            foreach (var color in colors)
            {
                Insert(root, color, 0);
            }

            return root;

        }

        private void Insert(OctreeNode node, (int r, int g, int b) color, int depth)
        {
            if (depth == MAX_DEPTH)
            {
                node.IsLeaf = true;
                node.Add(color);
                return;
            }

            int childKey = GetChildKey(color, depth);
            if (!node.Children.ContainsKey(childKey))
            {
                if (depth == MAX_DEPTH - 1)
                {
                    CurrentColorCount += 1;
                }
                node.Children.Add(childKey, new OctreeNode());
            }
            Insert(node.Children[childKey], color, depth + 1);
        }

        private void ReduceTree(OctreeNode root)
        {
            int depth = MAX_DEPTH - 1;
            while (CurrentColorCount > MaxColorsCount && depth >= 0)
            {
                List<OctreeNode> leafsParents = GetParentsLeafs(root).OrderBy(node => node.Pixels).ToList();

                foreach (var leafsParent in leafsParents)
                {
                    if (CurrentColorCount > MaxColorsCount)
                    {
                        ReduceNode(leafsParent);
                    }
                    else
                    {
                        return;
                    }
                }

                depth--;
            }
        }

        private void ReduceNode(OctreeNode node)
        {
            if (node.IsLeaf) return;

            foreach (var child in node.Children.Values)
            {
                ReduceNode(child);
                node.Add(child);
            }

            CurrentColorCount = CurrentColorCount - node.Children.Count + 1;
            node.Children.Clear();
            node.IsLeaf = true;
        }


        private List<OctreeNode> GetParentsLeafs(OctreeNode node)
        {
            if (node.IsLeafParent())
            {
                return new List<OctreeNode>() { node };
            }

            var leafs = new List<OctreeNode>();

            foreach (OctreeNode child in node.Children.Values)
            {
                leafs.AddRange(GetParentsLeafs(child));
            }

            return leafs;
        }

        private (int r, int g, int b) ReplaceColor(OctreeNode root, (int r, int g, int b) color)
        {
            OctreeNode node = root;
            int depth = 0;
            while (!node.IsLeaf)
            {
                node = node.Children[GetChildKey(color, depth)];
                depth += 1;
            }

            return node.GetColor();
        }

        private int GetChildKey((int r, int g, int b) color, int depth)
        {
            int bit = 1 << (8 - depth - 1);
            return 4 * ((color.r & bit) != 0 ? 1 : 0) + 2 * ((color.g & bit) != 0 ? 1 : 0) + ((color.b & bit) != 0 ? 1 : 0);
        }
    }

    class OctreeNode
    {
        int r = 0, g = 0, b = 0;
        public int Pixels = 0;
        public Dictionary<int, OctreeNode> Children = new Dictionary<int, OctreeNode>();
        public bool IsLeaf = false;

        public OctreeNode() { }

        public void Add((int r, int g, int b) color)
        {
            Pixels += 1;
            r += color.r;
            g += color.g;
            b += color.b;
        }

        public void Add(OctreeNode node)
        {
            Pixels += node.Pixels;
            r += node.r;
            g += node.g;
            b += node.b;
        }

        public (int r, int g, int b) GetColor()
        {
            return (r / Pixels, g / Pixels, b / Pixels);
        }

        public int GetChildrenPixelCount()
        {
            int pxCount = 0;

            foreach (OctreeNode child in Children.Values)
            {
                pxCount += child.Pixels;
            }

            return pxCount;
        }

        public bool IsLeafParent()
        {
            foreach (OctreeNode child in Children.Values)
            {
                if (child.IsLeaf)
                    return true;
            }
            return false;
        }
    }
}
