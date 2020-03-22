using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFilters
{
    public class FastImage
    {
        byte[] ByteImage;
        public int Height;
        public int Width;


        public FastImage(Bitmap bmp)
        {
            ByteImage = ToByteArray(bmp);
            Height = bmp.Height;
            Width = bmp.Width;
        }

        public FastImage(FastImage img)
        {
            ByteImage = (byte[])img.ByteImage.Clone();
            Height = img.Height;
            Width = img.Width;
        }

        public Bitmap ToBitmap()
        {
            using (MemoryStream ms = new MemoryStream(ByteImage))
            {
                ms.Position = 0;
                return new Bitmap(ms);
            }
        }

        public IEnumerable<(int r, int g, int b)> GetAll()
        {
            for (int i = 56; i < ByteImage.Length; i += 3)
            {
                yield return (ByteImage[i - 2], ByteImage[i - 1], ByteImage[i]);
            }
        }

        public void SetAll(Func<int, int> func)
        {
            for (int i = 54; i < ByteImage.Length; i++)
            {
                ByteImage[i] = (byte)func(ByteImage[i]);
            }
        }

        public void SetAll(Func<(int r, int g, int b), (int, int, int)> func)
        {
            for (int i = 56; i < ByteImage.Length; i += 3)
            {
                (ByteImage[i - 2], ByteImage[i - 1], ByteImage[i]) = (ValueTuple<byte, byte, byte>)func((ByteImage[i - 2], ByteImage[i - 1], ByteImage[i]));
            }
        }

        public (int, int, int) GetPixel(int x, int y)
        {
            int idx = GetIndex(x, y);
            return (ByteImage[idx], ByteImage[idx + 1], ByteImage[idx + 2]);
        }

        public void SetPixel(int x, int y, int r, int g, int b)
        {
            int idx = GetIndex(x, y);

            ByteImage[idx] = (byte)r;
            ByteImage[idx + 1] = (byte)g;
            ByteImage[idx + 2] = (byte)b;
        }

        private int GetIndex(int x, int y)
        {
            int idx = 54;
            idx += y * Width * 3;
            idx += x * 3;
            return idx;
        }

        private byte[] ToByteArray(Bitmap bitmap)
        {
            using (var stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                return stream.ToArray();
            }
        }
    }
}
