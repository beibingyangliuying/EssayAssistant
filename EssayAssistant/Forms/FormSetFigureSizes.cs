using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EssayAssistant.Utils;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace EssayAssistant.Forms
{
    public partial class FormSetFigureSizes : Form
    {
        private readonly List<Word.InlineShape> _shapes;

        private void PostInit()
        {
            labelInformation.Text = $"共计{_shapes.Count}张图片";
        }

        public FormSetFigureSizes(List<Word.InlineShape> shapes)
        {
            InitializeComponent();

            _shapes = shapes;
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
                var value = (float)
                    MeasureUnitCalculator.HeightToPoints((double)numericUpDownHeight.Value);
                foreach (var shape in _shapes)
                    shape.Height = value;
            }
            else if (radioButtonWidth.Checked)
            {
                var value = (float)
                    MeasureUnitCalculator.WidthToPoints((double)numericUpDownWidth.Value);
                foreach (var shape in _shapes)
                    shape.Width = value;
            }

            DialogResult = DialogResult.OK;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            var dict = new Dictionary<RadioButton, NumericUpDown>()
            {
                { radioButtonHeight, numericUpDownHeight },
                { radioButtonWidth, numericUpDownWidth },
            };
            var selectedButton = sender as RadioButton;

            foreach (var button in dict.Keys)
            {
                var numericUpDown = dict[button];
                if (button == selectedButton)
                    numericUpDown.Enabled = true;
                else
                    numericUpDown.Enabled = false;
            }
        }
    }
}
