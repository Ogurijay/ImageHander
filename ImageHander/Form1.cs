using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = OpenCvSharp.Size;

namespace ImageHander
{
    public partial class Form1 : Form
    {
        public string modelPath = string.Empty;
        public string maskPath = string.Empty;
        public string mask2Path = string.Empty;
        public Mat showImg;

        public Form1()
        {
            InitializeComponent();
        }

        #region 处理方法

        public void ShowPicture(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            pictureBox.Image = Image.FromStream(fs);
            fs.Close();
        }

        public void ShowPicture(Mat img)
        {
            Image image = BitmapConverter.ToBitmap(img);
            pictureBox.Image = image;
        }

        public Mat Cut(Mat img, int width,int height)
        {
            img = img[0, height, 0, width];
            return img;
        }

        /// <summary>
        /// 反色处理算法
        /// </summary>
        /// <param name="i">原图色</param>
        /// <param name="j">水印色</param>
        /// <returns></returns>
        public byte AntiColor(double i, double j)
        {
            double val = 0;
            if (j != 0 && i != 0)
            {
                val = 255 - (255 - i) * 256 / j;
            }
            return val < 0 ? (byte)0 : (byte)val;
        }

        /// <summary>
        /// 图片修复
        /// </summary>
        /// <param name="imgModel">原图</param>
        /// <param name="imgMask">掩盖图</param>
        /// <param name="i">像素修复半径</param>
        /// <returns></returns>
        public Mat Inpaint(Mat imgModel, Mat imgMask, int i = 5)
        {
            imgMask = imgMask[0, imgModel.Height, 0, imgModel.Width];
            imgMask = imgMask.ExtractChannel(1);

            Mat outImg = Mat.Zeros(imgModel.Height, imgModel.Width, imgModel.Type());

            Cv2.Inpaint(imgModel, imgMask, outImg, i, InpaintMethod.Telea);
            return outImg;
        }

        /// <summary>
        /// 反色中和图片
        /// </summary>
        /// <param name="imgModel">原图</param>
        /// <param name="imgMask">掩盖图</param>
        /// <returns></returns>
        public Mat ReColor(Mat imgModel, Mat imgMask)
        {
            imgMask = imgMask[0, imgModel.Height, 0, imgModel.Width];
            Mat outImg = Mat.Zeros(imgModel.Height, imgModel.Width, imgModel.Type());
            //outImg = Mat.Zeros(imgModel.Size(), MatType.CV_8UC3);

            for (int y = 0; y < imgModel.Height; y++)
            {
                for (int x = 0; x < imgModel.Width; x++)
                {
                    //Vec3i是获取该像素值返回的指针值
                    //Scalar是获取该像素的RGB值

                    Vec3b color1 = imgModel.Get<Vec3b>(y, x);
                    Vec3b color2 = imgMask.Get<Vec3b>(y, x);
                    Vec3b newColor = new Vec3b(AntiColor(color1.Item0, color2.Item0), AntiColor(color1.Item1, color2.Item1), AntiColor(color1.Item2, color2.Item2));
                    outImg.Set(y, x, newColor);
                }
            }
            return outImg;
        }

        /// <summary>
        /// 怀旧滤镜处理
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public Mat Nostalgic(Mat img)
        {
            Mat outImg = new Mat(img.Size(), MatType.CV_8UC3);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < outImg.Width; x++)
                {
                    Vec3b color = img.Get<Vec3b>(y, x);
                    float B = color.Item0;
                    float G = color.Item1;
                    float R = color.Item2;
                    var NewB = (0.272 * R + 0.534 * G + 0.131 * B);
                    var NewG = (0.349 * R + 0.686 * G + 0.168 * B);
                    var NewR = (0.393 * R + 0.769 * G + 0.189 * B);
                    if (NewB < 0) NewB = 0;
                    if (NewB > 255) NewB = 255;
                    if (NewG < 0) NewG = 0;
                    if (NewG > 255) NewG = 255;
                    if (NewR < 0) NewR = 0;
                    if (NewR > 255) NewR = 255;
                    outImg.Set(y, x, new Vec3b((byte)NewB, (byte)NewG, (byte)NewR));
                }
            }
            return outImg;
        }


        /// <summary>
        /// 连环画滤镜处理
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public Mat Comic(Mat img)
        {
            Mat outImg = new Mat(img.Size(), MatType.CV_8UC3);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Vec3b color = img.Get<Vec3b>(y, x);
                    float B = color.Item0;
                    float G = color.Item1;
                    float R = color.Item2;
                    var NewB = (Math.Abs(B - G + G + R) * G / 256);
                    var NewG = (Math.Abs(B - G + B + R) * R / 256);
                    var NewR = (Math.Abs(G - B + G + R) * R / 256);
                    if (NewB < 0) NewB = 0;
                    if (NewB > 255) NewB = 255;
                    if (NewG < 0) NewG = 0;
                    if (NewG > 255) NewG = 255;
                    if (NewR < 0) NewR = 0;
                    if (NewR > 255) NewR = 255;
                    outImg.Set(y, x, new Vec3b((byte)NewB, (byte)NewG, (byte)NewR));
                }
            }
            //灰度处理
            Cv2.CvtColor(img, outImg, ColorConversionCodes.BGR2GRAY);
            Cv2.Normalize(outImg, outImg, 255, 0, NormTypes.MinMax);
            return outImg;
        }

        public Mat Warm(Mat img, float a = 0, float b = 0)
        {
            Mat outImg = new Mat(img.Size(), MatType.CV_8UC3);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Vec3b color = img.Get<Vec3b>(y, x);
                    float B = color.Item0;
                    float G = color.Item1;
                    float R = color.Item2;
                    var NewB = B * a + b;
                    var NewG = G * a + b;
                    var NewR = R * a + b;
                    if (NewB < 0) NewB = 0;
                    if (NewB > 255) NewB = 255;
                    if (NewG < 0) NewG = 0;
                    if (NewG > 255) NewG = 255;
                    if (NewR < 0) NewR = 0;
                    if (NewR > 255) NewR = 255;
                    outImg.Set(y, x, new Vec3b((byte)NewB, (byte)NewG, (byte)NewR));
                }
            }
            //灰度处理
            return outImg;
        }

        #endregion

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.*)|*.*";//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            openFileDialog.ShowDialog();
            modelPath = openFileDialog.FileName;
            tbModelUrl.Text = modelPath;
            showImg = new Mat(modelPath, ImreadModes.Color);
            ShowPicture(modelPath);
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.*)|*.*";//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            openFileDialog.ShowDialog();
            maskPath = openFileDialog.FileName;
            tbMask1Url.Text = maskPath;
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.*)|*.*";//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            openFileDialog.ShowDialog();
            mask2Path = openFileDialog.FileName;
            tbMask2Url.Text = mask2Path;
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modelPath)||string.IsNullOrEmpty(maskPath))
            {
                MessageBox.Show("请上传图片！");
                return;
            }
            Mat imgModel = new Mat(modelPath, ImreadModes.Color);
            Mat imgMask = new Mat(maskPath, ImreadModes.Color);
            //预览图像
            showImg = Inpaint(imgModel, imgMask);
            //Cv2.ImShow("test", showImg);
            ShowPicture(showImg);
            //获取边缘点
            //Cv2.Canny(img, outImg, 1, 50);
        }

        private void btnRemoveTag1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modelPath) || string.IsNullOrEmpty(maskPath))
            {
                MessageBox.Show("请上传图片！");
                return;
            }
            Mat imgModel = new Mat(modelPath, ImreadModes.Color);
            Mat imgMask = new Mat(maskPath, ImreadModes.Color);
            showImg = ReColor(imgModel, imgMask);
            //预览图像
            //Cv2.ImShow("test", showImg);
            ShowPicture(showImg);
        }

        private void btnRemoveTag2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modelPath) || string.IsNullOrEmpty(maskPath) || string.IsNullOrEmpty(mask2Path))
            {
                MessageBox.Show("请上传图片！");
                return;
            }
            Mat imgModel = new Mat(modelPath, ImreadModes.Color);
            Mat imgMask = new Mat(maskPath, ImreadModes.Color);
            Mat imgMask2 = new Mat(mask2Path, ImreadModes.Color);

            Mat outImg = ReColor(imgModel, imgMask);
            showImg = outImg = Inpaint(outImg, imgMask2);
            //预览图像
            //Cv2.ImShow("test", showImg);
            ShowPicture(showImg);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowPicture(modelPath);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cv2.ImWrite(AppDomain.CurrentDomain.BaseDirectory + "/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png", showImg);
        }

        private void btnNostalgic_Click(object sender, EventArgs e)
        {
            showImg = Nostalgic(new Mat(modelPath, ImreadModes.Color));
            //Cv2.ImShow("test", showImg);
            ShowPicture(showImg);
        }

        private void btnComic_Click(object sender, EventArgs e)
        {
            showImg = Comic(new Mat(modelPath, ImreadModes.Color));
            ShowPicture(showImg);
        }

        private void btnWarm_Click(object sender, EventArgs e)
        {
            showImg = Warm(new Mat(modelPath, ImreadModes.Color),float.Parse( textBox1.Text), float.Parse(textBox2.Text));
            ShowPicture(showImg);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            showImg = Cut(new Mat(modelPath, ImreadModes.Color), int.Parse(tbWidth.Text), int.Parse(tbHeight.Text));
            ShowPicture(showImg);
        }
    }
}
