using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EssayAssistant.Extensions;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Forms.Picture
{
    public partial class FormReplacePictures : Form
    {
        private readonly List<Word.InlineShape> _shapes;
        private readonly ImageList _afterFigures = new ImageList() { ImageSize = new Size(80, 80) };

        private void PostInit()
        {
            listViewAfter.LargeImageList = _afterFigures;
        }

        public FormReplacePictures(List<Word.InlineShape> shapes)
        {
            InitializeComponent();

            _shapes = shapes;
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
                if (!(i < _shapes.Count))
                {
                    break;
                }

                _afterFigures.Images.Add(Image.FromFile(p));
                listViewAfter.Items.Add(
                    new ListViewItem(Path.GetFileName(p)) { ImageIndex = i, ToolTipText = p }
                );
            }
            listViewAfter.EndUpdate();

            string information;
            var beforeCount = _shapes.Count;
            var afterCount = _afterFigures.Images.Count;
            if (beforeCount > afterCount)
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
                var size = (oldShape.Width, oldShape.Height);
                oldShape
                    .Application.Selection.InlineShapes.AddPicture(item.ToolTipText)
                    .ResizeTo(size);
            }

            DialogResult = DialogResult.OK;
        }

        private void ListViewAfter_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var buttons = new Button[] { buttonMoveUp, buttonMoveDown };
            if (listViewAfter.SelectedIndices.Count == 0)
            {
                foreach (var button in buttons)
                {
                    button.Enabled = false;
                }
            }
            else
            {
                foreach (var button in buttons)
                {
                    button.Enabled = true;
                }
            }
        }

        private void ButtonMoveUp_Click(object sender, System.EventArgs e) { }

        private void ButtonMoveDown_Click(object sender, System.EventArgs e) { }
    }
}
