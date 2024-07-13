using System.Collections.Generic;
using System.Text;
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
            selection.Range.InsertParagraphAfter();

            var form = new FormArrangeFigures(inlineShapes, selection.Range.End - 1);
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
            form.ShowDialog();
        }

        private void ButtonInsertFigures_Click(object sender, RibbonControlEventArgs e)
        {
            var dialog = Globals.ThisAddIn.Application.Dialogs[
                Word.WdWordDialog.wdDialogInsertPicture
            ];
            dialog.Show();
        }

        private void ButtonInitStyles_Click(object sender, RibbonControlEventArgs e)
        {
            var doc = Globals.ThisAddIn.Application.ActiveDocument;
            var styleNames = new List<string>();
            Word.Style style;
            try
            {
                style = doc.Styles["图表"];
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                style = doc.Styles.Add("图表", Word.WdStyleType.wdStyleTypeParagraphOnly);
                style.set_BaseStyle(doc.Styles[Word.WdBuiltinStyle.wdStyleNormal]);
                style.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                style.ParagraphFormat.KeepWithNext = -1;
                styleNames.Add(style.NameLocal);
            }

            try
            {
                style = doc.Styles["正文段落"];
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                style = doc.Styles.Add("正文段落", Word.WdStyleType.wdStyleTypeParagraphOnly);
                style.set_BaseStyle(doc.Styles[Word.WdBuiltinStyle.wdStyleNormal]);
                style.ParagraphFormat.FirstLineIndent = 20;
                styleNames.Add(style.NameLocal);
            }

            if (styleNames.Count > 0)
            {
                var builder = new StringBuilder();
                foreach (var s in styleNames)
                {
                    builder.Append(s);
                    builder.Append("，");
                }
                MessageBox.Show(
                    $"已添加如下样式：{builder}",
                    "信息",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("未添加样式！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
