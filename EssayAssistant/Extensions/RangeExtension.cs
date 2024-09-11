using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Extensions
{
    internal static class RangeExtension
    {
        public static void SelectCJKChar(this Word.Range range)
        {
            range.Find.ClearFormatting();
            range.Find.MatchWildcards = true;
            range.Find.MatchWholeWord = true;
            range.Find.Text = "[一-鿿]";
            range.Find.Highlight = 1;
            range.Find.Execute();
        }
    }
}
