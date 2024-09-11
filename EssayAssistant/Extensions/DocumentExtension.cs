using System;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Extensions
{
    [Flags]
    internal enum DocumentInitType
    {
        Style = 1,
        CaptionLabel = 1 << 1,
    }

    internal static class DocumentExtension
    {
        private static Word.Style GetStyle(this Word.Document doc, object index)
        {
            try
            {
                return doc.Styles[index];
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                return null;
            }
        }

        public static Word.Style GetStyle(this Word.Document doc, string index) =>
            doc.GetStyle(index as object);

        public static Word.Style GetStyle(this Word.Document doc, Word.WdBuiltinStyle index) =>
            doc.GetStyle(index as object);

        public static void Init(this Word.Document doc, DocumentInitType type)
        {
            if (type.HasFlag(DocumentInitType.Style))
            {
                var styleNormal = doc.GetStyle(Word.WdBuiltinStyle.wdStyleNormal);
                Word.Style style;

                style = doc.GetStyle("图表");
                if (style is null)
                {
                    style = doc.Styles.Add("图表", Word.WdStyleType.wdStyleTypeParagraphOnly);
                    style.set_BaseStyle(styleNormal);
                    style.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    style.ParagraphFormat.KeepWithNext = -1;
                }

                style = doc.GetStyle("正文段落");
                if (style is null)
                {
                    style = doc.Styles.Add("正文段落", Word.WdStyleType.wdStyleTypeParagraphOnly);
                    style.set_BaseStyle(styleNormal);
                    style.set_NextParagraphStyle(styleNormal);
                    style.ParagraphFormat.FirstLineIndent = styleNormal.Font.Size * 2;
                }
            }

            if (type.HasFlag(DocumentInitType.CaptionLabel))
            {
                doc.Application.CaptionLabels.Add("子图");
            }
        }
    }
}
