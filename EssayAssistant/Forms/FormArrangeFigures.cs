using System.Collections.Generic;
using System.Windows.Forms;
using EssayAssistant.Extensions;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Forms
{
    public partial class FormArrangeFigures : Form
    {
        private readonly List<Word.InlineShape> _shapes;
        private readonly int _start;

        private void PostInit()
        {
            labelInformation.Text = $"共计{_shapes.Count}张图片";
        }

        public FormArrangeFigures(List<Word.InlineShape> shapes, int start)
        {
            InitializeComponent();

            _shapes = shapes;
            _start = start;
            PostInit();
        }

        private void ButtonAccept_Click(object sender, System.EventArgs e)
        {
            var columnCount = (int)numericUpDown1.Value;
            var rowCount = _shapes.Count % columnCount == 0 ? 0 : 1;
            rowCount += _shapes.Count / columnCount;

            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var location = doc.Range(_start);
            var table = doc.Tables.Add(location, rowCount, columnCount);

            var enumerator = table.GetCellsEnumerator();
            while (enumerator.MoveNext())
            {
                var cell = enumerator.Current;
                cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                var range = doc.Range(cell.Range.Start, cell.Range.Start);
                var field = range.Fields.Add(
                    range,
                    Word.WdFieldType.wdFieldSequence,
                    @"子图 \* alphabetic"
                );
                range = field.Result;
                range.InsertBefore("(");
                range.InsertAfter(")");
                range.InsertParagraphBefore();
                range.set_Style(doc.Styles[Word.WdBuiltinStyle.wdStyleCaption]);
                range.Collapse(Word.WdCollapseDirection.wdCollapseStart);
                range.set_Style(doc.Styles["图表"]);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
