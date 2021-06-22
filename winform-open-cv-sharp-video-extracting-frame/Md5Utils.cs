using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace winform_open_cv_sharp_video_extracting_frame {
  public class Md5Utils {
    /// <summary>
    /// 获取文件MD5值
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static string GetMD5HashFromFile(string fileName) {
      try {
        FileStream file = new FileStream(fileName, FileMode.Open);
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] retVal = md5.ComputeHash(file);
        file.Close();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < retVal.Length; i++) {
          sb.Append(retVal[i].ToString("x2"));
        }
        return sb.ToString();
      } catch (Exception ex) {
        String str = "";
        str += ex.Message + "\n";//异常消息
        str += ex.StackTrace + "\n";//提示出错位置，不会定位到方法内部去
        str += ex.ToString() + "\n";//将方法内部和外部所有出错的位置提示出来
        MessageBox.Show(str,"异常信息");
        return null;
      }
    }
  }
}
