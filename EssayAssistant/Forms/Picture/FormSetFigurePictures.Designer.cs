namespace EssayAssistant.Forms.Picture
{
    partial class FormSetFigurePictures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.radioButtonHeight = new System.Windows.Forms.RadioButton();
            this.radioButtonWidth = new System.Windows.Forms.RadioButton();
            this.checkBoxLockAspectRatio = new System.Windows.Forms.CheckBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.AutoSize = true;
            this.numericUpDownHeight.DecimalPlaces = 1;
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHeight.Location = new System.Drawing.Point(166, 3);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownHeight.TabIndex = 0;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.AutoSize = true;
            this.numericUpDownWidth.DecimalPlaces = 1;
            this.numericUpDownWidth.Enabled = false;
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWidth.Location = new System.Drawing.Point(166, 29);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // radioButtonHeight
            // 
            this.radioButtonHeight.AutoSize = true;
            this.radioButtonHeight.Checked = true;
            this.radioButtonHeight.Location = new System.Drawing.Point(3, 3);
            this.radioButtonHeight.Name = "radioButtonHeight";
            this.radioButtonHeight.Size = new System.Drawing.Size(157, 17);
            this.radioButtonHeight.TabIndex = 2;
            this.radioButtonHeight.TabStop = true;
            this.radioButtonHeight.Text = "统一高度（单位：厘米）";
            this.radioButtonHeight.UseVisualStyleBackColor = true;
            this.radioButtonHeight.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // radioButtonWidth
            // 
            this.radioButtonWidth.AutoSize = true;
            this.radioButtonWidth.Location = new System.Drawing.Point(3, 29);
            this.radioButtonWidth.Name = "radioButtonWidth";
            this.radioButtonWidth.Size = new System.Drawing.Size(157, 17);
            this.radioButtonWidth.TabIndex = 3;
            this.radioButtonWidth.TabStop = true;
            this.radioButtonWidth.Text = "统一宽度（单位：厘米）";
            this.radioButtonWidth.UseVisualStyleBackColor = true;
            this.radioButtonWidth.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // checkBoxLockAspectRatio
            // 
            this.checkBoxLockAspectRatio.AutoSize = true;
            this.checkBoxLockAspectRatio.Checked = true;
            this.checkBoxLockAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLockAspectRatio.Location = new System.Drawing.Point(3, 55);
            this.checkBoxLockAspectRatio.Name = "checkBoxLockAspectRatio";
            this.checkBoxLockAspectRatio.Size = new System.Drawing.Size(86, 17);
            this.checkBoxLockAspectRatio.TabIndex = 4;
            this.checkBoxLockAspectRatio.Text = "锁定纵横比";
            this.checkBoxLockAspectRatio.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(119, 94);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(56, 23);
            this.buttonAccept.TabIndex = 6;
            this.buttonAccept.Text = "确定";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(180, 94);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInformation.Location = new System.Drawing.Point(12, 99);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(7, 13);
            this.labelInformation.TabIndex = 8;
            this.labelInformation.Text = "\r\n";
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.radioButtonHeight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLockAspectRatio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownHeight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonWidth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownWidth, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 77);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // FormSetFigureSizes
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = global::EssayAssistant.Properties.Settings.Default.FormAutoScaleMode;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(246, 126);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonAccept);
            this.Font = global::EssayAssistant.Properties.Settings.Default.FormFont;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetFigureSizes";
            this.StartPosition = global::EssayAssistant.Properties.Settings.Default.FormStartPosition;
            this.Text = "批量设置图片尺寸";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.RadioButton radioButtonHeight;
        private System.Windows.Forms.RadioButton radioButtonWidth;
        private System.Windows.Forms.CheckBox checkBoxLockAspectRatio;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}