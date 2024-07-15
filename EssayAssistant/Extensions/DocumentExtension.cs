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
                Word.Style paragraphStyle;
                paragraphStyle = doc.GetStyle("图表");
                if (paragraphStyle is null)
                {
                    paragraphStyle = doc.Styles.Add(
                        "图表",
                        Word.WdStyleType.wdStyleTypeParagraphOnly
                    );
                    paragraphStyle.set_BaseStyle(doc.GetStyle(Word.WdBuiltinStyle.wdStyleNormal));
                    paragraphStyle.ParagraphFormat.Alignment =
                        Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    paragraphStyle.ParagraphFormat.KeepWithNext = -1;
                }

                paragraphStyle = doc.GetStyle("正文段落");
                if (paragraphStyle is null)
                {
                    paragraphStyle = doc.Styles.Add(
                        "正文段落",
                        Word.WdStyleType.wdStyleTypeParagraphOnly
                    );
                    paragraphStyle.set_BaseStyle(doc.GetStyle(Word.WdBuiltinStyle.wdStyleNormal));
                    paragraphStyle.ParagraphFormat.FirstLineIndent = 20; // todo: the first line indent is not accurate
                }
            }

            if (type.HasFlag(DocumentInitType.CaptionLabel))
            {
                doc.Application.CaptionLabels.Add("子图");
            }
        }
    }
}
