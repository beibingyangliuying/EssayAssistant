using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Extensions
{
    internal static class DocumentExtension
    {
        /// <summary>
        /// Get the style by index.
        /// </summary>
        /// <seealso cref="Word.WdBuiltinStyle"/>
        /// <param name="doc">Document object.</param>
        /// <param name="index">An Object indicating the ordinal position or a string representing the name of the individual object.</param>
        /// <returns>A style object if exists, otherwise null.</returns>
        public static Word.Style GetStyle(this Word.Document doc, object index)
        {
            if (index is string || index.GetType().IsEnum)
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
            return null;
        }

        /// <summary>
        /// Initialize styles needed in the document.
        /// </summary>
        /// <param name="doc">Document object.</param>
        /// <returns>No return.</returns>
        public static void InitStyle(this Word.Document doc)
        {
            Word.Style style;

            style = doc.GetStyle("图表");
            if (style is null)
            {
                style = doc.Styles.Add("图表", Word.WdStyleType.wdStyleTypeParagraphOnly);
                style.set_BaseStyle(doc.GetStyle(Word.WdBuiltinStyle.wdStyleNormal));
                style.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                style.ParagraphFormat.KeepWithNext = -1;
            }

            style = doc.GetStyle("正文段落");
            if (style is null)
            {
                style = doc.Styles.Add("正文段落", Word.WdStyleType.wdStyleTypeParagraphOnly);
                style.set_BaseStyle(doc.GetStyle(Word.WdBuiltinStyle.wdStyleNormal));
                style.ParagraphFormat.FirstLineIndent = 20; // todo: the first line indent is not accurate
            }
        }
    }
}
