using System.Drawing;

namespace Capture.Action
{
    interface ActionInterface
    {
        
        ActionResult Execute(Bitmap bmp);
        string GetErrorMessage();
    }
}
