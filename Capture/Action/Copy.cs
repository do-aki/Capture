using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Capture.Action
{
    class Copy : ActionInterface
    {
        private string error_message;

        public ActionResult Execute(Bitmap bmp)
        {
            try
            {
                Clipboard.SetDataObject(bmp, true);
            }
            catch (Exception e)
            {
                error_message = "クリップボードへの貼り付けに失敗:" + e.Message;
            }
            return ActionResult.Completed;
        }

        public string GetErrorMessage()
        {
            return error_message;
        }

    }
}
