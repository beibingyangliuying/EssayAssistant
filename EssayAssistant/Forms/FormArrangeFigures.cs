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

            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            doc.InitStyle();
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
            var columnCount = (int)numericUpDownColumn.Value;
            var rowCount = _shapes.Count % columnCount == 0 ? 0 : 1;
            rowCount += _shapes.Count / columnCount;

            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var location = doc.Range(_start);
            var table = doc.Tables.Add(location, rowCount, columnCount);

            var styleCaption = doc.GetStyle(Word.WdBuiltinStyle.wdStyleCaption);
            var styleImage = doc.GetStyle("图表");

            var enumerator = table.GetCellsEnumerator();
            while (enumerator.MoveNext())
            {
                var cell = enumerator.Current;
                cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                cell.Range.InsertBefore("(");
                cell.Range.InsertAfter(")");

                var range = doc.Range(cell.Range.Start + 1, cell.Range.Start + 1);
                var field = cell.Range.Fields.Add(
                    range,
                    Word.WdFieldType.wdFieldSequence,
                    @"子图 \* alphabetic"
                );
                cell.Range.InsertParagraphBefore();

                range = field.Result;
                range.set_Style(styleCaption);
                range.Move(Word.WdUnits.wdParagraph, -1);
                range.Move(Count: -1);
                range.set_Style(styleImage);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
