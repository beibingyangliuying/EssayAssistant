using System.Linq;
using System.Windows.Forms;
using EssayAssistant.Extensions;
using EssayAssistant.Forms.Picture;
using EssayAssistant.Utils;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant
{
    public partial class RibbonEssayAssistant
    {
        #region Style

        private void ButtonViewStyleTree_Click(object sender, RibbonControlEventArgs e)
        {
            // todo: show style tree
            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var styles = doc.Styles.Cast<Word.Style>().Where(s => s.InUse).ToList();
        }

        #endregion

        #region Character

        private void ButtonCorrectCharacterFormat_Click(object sender, RibbonControlEventArgs e) { }

        private void ButtonCorrectPunctuation_Click(object sender, RibbonControlEventArgs e) { }

        private void ButtonCorrectWordSpacing_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            Character.CorrectWordSpacing(selection.Range);
        }

        private void ButtonSelectCJHChar_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = Globals.ThisAddIn.Application.Selection;
            selection.Range.SelectCJKChar();
        }

        #endregion

        #region Picture

        private void ButtonInsertPictures_Click(object sender, RibbonControlEventArgs e)
        {
            var dialog = Globals.ThisAddIn.Application.Dialogs[
                Word.WdWordDialog.wdDialogInsertPicture
            ];
            dialog.Show();
        }

        private void ButtonArrangePictures_Click(object sender, RibbonControlEventArgs e)
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

            var form = new FormArrangePictures(inlineShapes, selection.Range.End - 1);
            form.ShowDialog();
        }

        private void ButtonSetPicturesSizes_Click(object sender, RibbonControlEventArgs e)
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

            var form = new FormSetFigurePictures(inlineShapes);
            form.ShowDialog();
        }

        private void ButtonReplacePictures_Click(object sender, RibbonControlEventArgs e)
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

            var form = new FormReplacePictures(inlineShapes);
            form.ShowDialog();
        }

        #endregion
    }
}
