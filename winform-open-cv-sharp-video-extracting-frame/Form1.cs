using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace winform_open_cv_sharp_video_extracting_frame {
  public partial class frmMain : Form {
    private const string newLine = "\r\n";
    private const string outputImagePath = "./output/images";

    public frmMain() {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e) {

    }
    private void btnFileSelect_Click(object sender, EventArgs e) {
      openFileDialog1.Title = "请选择视频文件";
      openFileDialog1.Filter = "所有文件(*.*)|*.*";
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        string file = openFileDialog1.FileName;
        textFilepath.Text = file;
      }
    }

    private void btnExtracingImage_Click(object sender, EventArgs e) {
      string md5String = Md5Utils.GetMD5HashFromFile(textFilepath.Text);
      if (string.IsNullOrEmpty(md5String)) {
        return;
      }

      Mat frame = new Mat();
      var videoCapture = new VideoCapture(textFilepath.Text);
      bool readSuccess = videoCapture.Read(frame);
      if (!readSuccess) {
        MessageBox.Show("无从视频中读取图片！！！", "提示：");
        return;
      }
      int timeF = Convert.ToInt32(textFrameCount.Text);
      
      string outputDir = outputImagePath + "/" + md5String;
      int i = 0;
      string sn = null;
      Bitmap image = null;
      while (readSuccess) {
        i = i + 1;
        if (i % timeF == 0) {
          sn = formatSn(i);
          image = BitmapConverter.ToBitmap(frame);

          saveImage(image, outputDir, sn);
          print("save image:", sn);
        }
        readSuccess = videoCapture.Read(frame);
      }
      print("提取完成,保存到的文件夹是:","");
      print(Path.GetFullPath(outputDir),"");
    }
    private string formatSn(int i) {
      if (i < 10) {
        return "0000" + i;
      }

      if (i < 100) {
        return "000" + i;
      }

      if (i < 1000) {
        return "00" + i;
      }

      if (i < 10000) {
        return "0" + i;
      }
      return i + "";
    }

    private void saveImage(Bitmap image, string outputPath, string sn) {
      if (!Directory.Exists(outputPath)) {
        Directory.CreateDirectory(outputPath);
      }
      string fileFullName = outputPath + "/" + "image-" + sn + ".png";
      image.Save(fileFullName, ImageFormat.Png);
    }
    private void print(string message1, string message2) {
      textLog.AppendText(message1 + " " + message2 + newLine);
    }

    private void btnLogClear_Click(object sender, EventArgs e) {
      textLog.Text = "";
    }
  }
}