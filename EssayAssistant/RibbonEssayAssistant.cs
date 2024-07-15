using System.Linq;
using System.Windows.Forms;
using EssayAssistant.Forms;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant
{
    public partial class RibbonEssayAssistant
    {
        #region Operate Styles

        private void ButtonViewStyleTree_Click(object sender, RibbonControlEventArgs e)
        {
            // todo: show style tree
            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var styles = doc.Styles.Cast<Word.Style>().Where(s => s.InUse).ToList();
        }

        #endregion

        #region Operate Figures

        private void ButtonInsertFigures_Click(object sender, RibbonControlEventArgs e)
        {
            var dialog = Globals.ThisAddIn.Application.Dialogs[
                Word.WdWordDialog.wdDialogInsertPicture
            ];
            dialog.Show();
        }

        private void ButtonArrangeFigures_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            var inlineShapes = selection
                .InlineShapes.Cast<Word.InlineShape>()
                .Where(s =>
                {
                    switch (s.Type)
                    {
                        case Word.WdInlineShapeType.wdInlineShapePicture:
                        case Word.WdInlineShapeType.wdInlineShapeLinkedPicture:
                            return true;
                        default:
                            return false;
                    }
                })
                .ToList();
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
            selection.Range.InsertParagraphAfter();

            var form = new FormArrangeFigures(inlineShapes, selection.Range.End - 1);
            form.ShowDialog();
        }

        private void ButtonSetFigureSizes_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            var inlineShapes = selection
                .InlineShapes.Cast<Word.InlineShape>()
                .Where(s =>
                {
                    switch (s.Type)
                    {
                        case Word.WdInlineShapeType.wdInlineShapePicture:
                        case Word.WdInlineShapeType.wdInlineShapeLinkedPicture:
                            return true;
                        default:
                            return false;
                    }
                })
                .ToList();
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
            form.ShowDialog();
        }

        private void ButtonReplaceFigures_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            var inlineShapes = selection
                .InlineShapes.Cast<Word.InlineShape>()
                .Where(s =>
                {
                    switch (s.Type)
                    {
                        case Word.WdInlineShapeType.wdInlineShapePicture:
                        case Word.WdInlineShapeType.wdInlineShapeLinkedPicture:
                            return true;
                        default:
                            return false;
                    }
                })
                .ToList();
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

            var form = new FormReplaceFigures(inlineShapes);
            form.ShowDialog();
        }

        #endregion
    }
}
