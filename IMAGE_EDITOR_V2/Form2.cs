
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;


namespace IMAGE_EDITOR_V2
{
    
    public partial class Form2 : Form
    {
        Bitmap adjustBitmap = null;
        public Form2()
        {
            InitializeComponent();
           
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = adjustBitmap;
        }
        //If the user selects a file and clicks the OK button, the code sets the Image property of a pictureBox1 object to the selected image file and assigns the image to a adjustBitmap variable.
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = new Bitmap(ofd.FileName);
                adjustBitmap = pictureBox1.Image as Bitmap;
            }
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = AdjustBrightnessContrast(adjustBitmap, trkContrast.Value, trkBrightness.Value);
            lblCurrentContrast.Text = ((trkContrast.Value) / 100.0f).ToString();
            lblCurrentBrightness.Text = ((trkBrightness.Value) / 100.0f).ToString();
        }

                /*AdjustBrightnessContrast that takes an Image object and two integer values for contrast and brightness,
                and returns a Bitmap object. The code applies the specified contrast and brightness values to the input image and returns a new
                Bitmap object with the adjusted brightness and contrast. To do this, the code creates a new
                ColorMatrix object and sets its values based on the specified brightness and contrast values.
                The code then uses a Graphics object to draw the input image onto the Bitmap object using
                the ColorMatrix to apply the brightness and contrast adjustments*/
        public Bitmap AdjustBrightnessContrast(Image image, int contrastValue, int brightnessValue)
        {
            try
            {
                float brightness = -(brightnessValue / 100.0f);
                float contrast = contrastValue / 100.0f;
                var bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

                using (var g = Graphics.FromImage(bitmap))
                using (var attributes = new ImageAttributes())
                {
                    float[][] matrix = {
                    new float[] { contrast, 0, 0, 0, 0},
                    new float[] {0, contrast, 0, 0, 0},
                    new float[] {0, 0, contrast, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {brightness, brightness, brightness, 1, 1} 
                    };

                    ColorMatrix colorMatrix = new ColorMatrix(matrix);
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                        0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                    return bitmap;
                }
            }
            catch (Exception)
            {
               
                throw new Exception("!Please  please please select image!");
            }
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save image
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
            
        }
    }
}
