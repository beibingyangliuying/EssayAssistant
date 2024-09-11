using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Utils
{
    internal static class Character
    {
        public static void CorrectWordSpacing(Word.Range range)
        {
            range.Find.ClearFormatting();
            range.Find.MatchWildcards = true;
            range.Find.Text = @"([!^1-^127])[ 　^s]{1,}([!^1-^127])";
            range.Find.Replacement.Text = @"\1\2";

            // Need to be executed twice.
            range.Find.Execute(Replace: Word.WdReplace.wdReplaceAll);
            range.Find.Execute(Replace: Word.WdReplace.wdReplaceAll);
        }
    }
}
