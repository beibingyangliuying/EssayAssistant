using System.Collections.Generic;
using System.Windows.Forms;
using EssayAssistant.Forms;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant
{
    public partial class RibbonEssayAssistant
    {
        private void ButtonViewStyleTree_Click(object sender, RibbonControlEventArgs e)
        {
            // todo: show style tree
            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var styles = new List<Word.Style>();
            foreach (Word.Style style in doc.Styles)
            {
                if (style.InUse)
                    styles.Add(style);
            }
        }

        private void ButtonArrangeFigures_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new FormArrangeFigures();
            form.ShowDialog();
        }

        private void ButtonSetFigureSizes_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            var inlineShapes = new List<Word.InlineShape>();
            foreach (Word.InlineShape shape in selection.InlineShapes)
            {
                switch (shape.Type)
                {
                    case Word.WdInlineShapeType.wdInlineShapePicture:
                    case Word.WdInlineShapeType.wdInlineShapeLinkedPicture:
                        inlineShapes.Add(shape);
                        break;
                }
            }
            if (inlineShapes.Count == 0)
            {
                MessageBox.Show(
                    "没有选中任何图片！",
                    "信息",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            var form = new FormSetFigureSizes(inlineShapes);
            var result = form.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    MessageBox.Show(
                        $"已执行转换！",
                        "信息",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show(
                        "未执行转换！",
                        "信息",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;
            }
        }

        private void ButtonInsertFigures_Click(object sender, RibbonControlEventArgs e)
        {
            var dialog = Globals.ThisAddIn.Application.Dialogs[
                Word.WdWordDialog.wdDialogInsertPicture
            ];
            dialog.Show();
        }
    }
}
