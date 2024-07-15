using System.Collections.Generic;
using System.Linq;
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
            labelInformation.Text = $"共计{_shapes.Count}张图片。";

            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            doc.Init(DocumentInitType.Style);
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
            var rowCount = (_shapes.Count % columnCount == 0 ? 0 : 1) + _shapes.Count / columnCount;

            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var table = doc.Tables.Add(doc.Range(_start), rowCount, columnCount);

            var styleCaption = doc.GetStyle(Word.WdBuiltinStyle.wdStyleCaption);
            var styleImage = doc.GetStyle("图表");

            var ifFirst = true;
            foreach (var (c, s) in table.Cells().Zip(_shapes, (c, s) => (c, s)))
            {
                c.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                c.Range.InsertBefore("(");
                c.Range.InsertAfter(")");

                var range = doc.Range(c.Range.Start + 1, c.Range.Start + 1); // One character inserted before.
                var fieldText = ifFirst ? @"子图 \* alphabetic \r 1" : @"子图 \* alphabetic";
                ifFirst = false;
                var field = c.Range.Fields.Add(range, Word.WdFieldType.wdFieldSequence, fieldText);
                c.Range.InsertParagraphBefore();

                range = field.Result;
                range.set_Style(styleCaption);
                range.Move(Word.WdUnits.wdParagraph, -1);
                range.Move(Count: -1); // Skip paragraph marker.
                range.set_Style(styleImage);

                s.Range.Cut();
                range.Paste();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
