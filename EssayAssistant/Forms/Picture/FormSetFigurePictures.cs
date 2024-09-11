using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EssayAssistant.Utils;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Forms.Picture
{
    public partial class FormSetFigurePictures : Form
    {
        private readonly List<Word.InlineShape> _shapes;
        private readonly Dictionary<RadioButton, NumericUpDown> _dict;

        private void PostInit()
        {
            labelInformation.Text = $"共计{_shapes.Count}张图片。";
        }

        public FormSetFigurePictures(List<Word.InlineShape> shapes)
        {
            InitializeComponent();

            _shapes = shapes;
            _dict = new Dictionary<RadioButton, NumericUpDown>()
            {
                { radioButtonHeight, numericUpDownHeight },
                { radioButtonWidth, numericUpDownWidth },
            };
            PostInit();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            var lockAspectRatio = checkBoxLockAspectRatio.Checked
                ? Office.MsoTriState.msoTrue
                : Office.MsoTriState.msoFalse;

            foreach (var shape in _shapes)
                shape.LockAspectRatio = lockAspectRatio;

            if (radioButtonHeight.Checked)
            {
                var value = (float)MeasureUnit.HeightToPoints((double)numericUpDownHeight.Value);
                foreach (var shape in _shapes)
                    shape.Height = value;
            }
            else if (radioButtonWidth.Checked)
            {
                var value = (float)MeasureUnit.WidthToPoints((double)numericUpDownWidth.Value);
                foreach (var shape in _shapes)
                    shape.Width = value;
            }

            DialogResult = DialogResult.OK;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            var button = sender as RadioButton;

            foreach (var (b, n) in _dict.Keys.Zip(_dict.Values, (b, n) => (b, n)))
            {
                if (b == button)
                    n.Enabled = true;
                else
                    n.Enabled = false;
            }
        }
    }
}
