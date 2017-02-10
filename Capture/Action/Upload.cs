using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;

namespace Capture.Action
{
    class Upload : ActionInterface
    {
        private string uri;
        private string error_message;

        public Upload(string uri)
        {
            this.uri = uri;
        }

        public ActionResult Execute(Bitmap bmp)
        {
            var tmp = Path.GetTempFileName();
            bmp.Save(tmp, ImageFormat.Png);

            if (!Uri.IsWellFormedUriString(uri, UriKind.Absolute))
            {
                error_message = "URLの形式が正しくありません\n右クリックして設定ウィンドウを開き正しいURLを指定してください";
                return ActionResult.Failed;
            }

            try
            {
                UploadFile(uri, tmp);
                Properties.Settings.Default.Save();
            }
            catch (WebException exception)
            {
                error_message = "投稿に失敗しました\n\n" + exception.Message;
                return ActionResult.Failed;
            }
            finally
            {
                File.Delete(tmp);
            }

            return ActionResult.Completed;
        }

        public string GetErrorMessage()
        {
            return error_message;
        }


        private void UploadFile(string uri, string file)
        {
            string boundary = System.Environment.TickCount.ToString();
            var req = (HttpWebRequest)System.Net.WebRequest.Create(uri);
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=" + boundary;

            using (var reqStream = req.GetRequestStream())
            {
                StreamWriteBytes(reqStream, Encoding.UTF8.GetBytes("--" + boundary + "\r\n" +
                    "Content-Disposition: form-data; name=\"imagedata\"; filename=\"image.png\"\r\n" +
                    "Content-Type: application/octet-stream\r\n" +
                    "Content-Transfer-Encoding: binary\r\n" +
                    "\r\n"
                ));

                StreamWriteFile(reqStream, file);

                StreamWriteBytes(reqStream, Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n"));
            }

            string res;
            using (var sr = new StreamReader(((HttpWebResponse)req.GetResponse()).GetResponseStream(), Encoding.UTF8))
            {
                res = sr.ReadToEnd();
            }

            if (res.StartsWith("http://") || res.StartsWith("https://"))
            {
                Process.Start(res);
            }
        }

        private static void StreamWriteBytes(Stream stm, byte[] data)
        {
            stm.Write(data, 0, data.Length);
        }

        private static void StreamWriteFile(Stream stm, string file)
        {
            var fs = new FileStream(file, FileMode.Open, FileAccess.Read);

            byte[] readData = new byte[0x1024];
            int readSize = 0;
            while (true)
            {
                readSize = fs.Read(readData, 0, readData.Length);
                if (readSize == 0)
                    break;
                stm.Write(readData, 0, readSize);
            }

            fs.Close();
        }
    }
}
