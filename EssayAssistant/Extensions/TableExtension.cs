using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Extensions
{
    internal static class TableExtension
    {
        public static IEnumerator<Word.Cell> GetCellsEnumerator(this Word.Table table)
        {
            var first = table.Cell(1, 1);
            yield return first;

            while (!(first.Next is null))
            {
                first = first.Next;
                yield return first;
            }
        }
    }
}
