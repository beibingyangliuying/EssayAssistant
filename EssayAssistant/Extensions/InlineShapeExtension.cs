using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Extensions
{
    internal static class InlineShapeExtension
    {
        private static void ResizeTo(this Word.InlineShape shape, double width, double height)
        {
            shape.LockAspectRatio = Office.MsoTriState.msoTrue;

            if (shape.Height / shape.Width > height / width)
            {
                shape.Height = (float)height;
            }
            else
            {
                shape.Width = (float)width;
            }
        }

        public static void ResizeTo(this Word.InlineShape shape, Word.InlineShape other)
        {
            shape.ResizeTo(other.Width, other.Height);
        }

        public static void ResizeTo(this Word.InlineShape shape, (double width, double height) size)
        {
            shape.ResizeTo(size.width, size.height);
        }
    }
}
