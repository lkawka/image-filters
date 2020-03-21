using ImageFilters.filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilters
{
    public partial class Form1 : Form
    {

        private FastImage OriginalImage;
        private FastImage WorkingImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    OriginalImage = new FastImage(new Bitmap(dlg.FileName)); 
                    WorkingImage = new FastImage(OriginalImage);
                    pictureBox1.Image = WorkingImage.ToBitmap();

                    saveButton.Enabled = true;
                    restoreButton.Enabled = true;
                    FiltersComboBox.Enabled = true;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save image";
    

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(WorkingImage.ToBitmap());
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            Filter filter;
            switch(FiltersComboBox.SelectedItem)
            {
                case "Inversion":
                    filter = new InversionFilter(WorkingImage);
                    break;
                case "Brightness Correction":
                    filter = new BrightnessCorrectionFilter(WorkingImage);
                    break;
                case "Contrast Enhancement":
                    filter = new ContrastEnhancementFilter(WorkingImage);
                    break;
                case "Gamma Correction":
                    filter = new GammaCorrectionFilter(WorkingImage);
                    break;
                case "Box Blur":
                    filter = new BoxBlurFilter(WorkingImage);
                    break;
                case "Gaussian Blur":
                    filter = new GaussianBlurFilter(WorkingImage);
                    break;
                case "Sharpen":
                    filter = new SharpenFilter(WorkingImage);
                    break;
                case "Edge Detection":
                    filter = new EdgeDetectionFilter(WorkingImage);
                    break;
                case "Emboss":
                    filter = new EmbossFilter(WorkingImage);
                    break;
                case "Median":
                    filter = new MedianFilter(WorkingImage);
                    break;
                case "Greyscale":
                    filter = new GreyscaleFilter(WorkingImage);
                    break;
                default:
                    return;
            }

            WorkingImage = filter.Apply();
            pictureBox1.Image = WorkingImage.ToBitmap();
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            WorkingImage = new FastImage(OriginalImage);
            pictureBox1.Image = WorkingImage.ToBitmap();
        }

        private void FiltersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            applyFilterButton.Enabled = true;
        }
    }
}
