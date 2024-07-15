using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EssayAssistant.Extensions;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Forms
{
    public partial class FormReplaceFigures : Form
    {
        private readonly List<Word.InlineShape> _shapes;
        private readonly ImageList _beforeFigures = new ImageList()
        {
            ImageSize = new Size(80, 80)
        };
        private readonly ImageList _afterFigures = new ImageList() { ImageSize = new Size(80, 80) };

        private void PostInit()
        {
            listViewAfter.LargeImageList = _afterFigures;
            listViewBefore.LargeImageList = _beforeFigures;
        }

        public FormReplaceFigures(List<Word.InlineShape> shapes)
        {
            InitializeComponent();

            _shapes = shapes;
            foreach (
                var (s, i) in _shapes.Zip(Enumerable.Range(0, _shapes.Count), (s, i) => (s, i))
            )
            {
                s.Select();
                _beforeFigures.Images.Add(
                    new Bitmap(new MemoryStream((byte[])s.Application.Selection.EnhMetaFileBits))
                );
                listViewBefore.Items.Add(new ListViewItem(s.AlternativeText) { ImageIndex = i });
            }

            PostInit();
        }

        private void ButtonSelectFigures_Click(object sender, System.EventArgs e)
        {
            if (openFileDialogAddFigures.ShowDialog(this) == DialogResult.Cancel)
            {
                return;
            }
            var paths = openFileDialogAddFigures.FileNames;

            listViewAfter.BeginUpdate();
            listViewAfter.Items.Clear();
            _afterFigures.Images.Clear();
            foreach (var (p, i) in paths.Zip(Enumerable.Range(0, paths.Count()), (p, i) => (p, i)))
            {
                _afterFigures.Images.Add(Image.FromFile(p));
                listViewAfter.Items.Add(
                    new ListViewItem(Path.GetFileName(p)) { ImageIndex = i, ToolTipText = p }
                );
            }
            listViewAfter.EndUpdate();

            string information;
            var beforeCount = _beforeFigures.Images.Count;
            var afterCount = _afterFigures.Images.Count;
            if (beforeCount < afterCount)
            {
                information = "将要插入的图片数量大于现有图片数量，多余的图片将被忽略。";
            }
            else if (beforeCount > afterCount)
            {
                information = "现有图片数量大于将要插入的图片数量，未补足的将不会替换。";
            }
            else
            {
                information = "图片数量相等，每张图片都将按顺序替换。";
            }
            labelInformation.Text = information;
        }

        private void ButtonAccept_Click(object sender, System.EventArgs e)
        {
            foreach (
                var (oldShape, item) in _shapes.Zip(
                    listViewAfter.Items.Cast<ListViewItem>(),
                    (s, i) => (s, i)
                )
            )
            {
                oldShape.Select();
                var size = (oldShape.Height, oldShape.Width);
                oldShape
                    .Application.Selection.InlineShapes.AddPicture(item.ToolTipText)
                    .ResizeTo(size);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
