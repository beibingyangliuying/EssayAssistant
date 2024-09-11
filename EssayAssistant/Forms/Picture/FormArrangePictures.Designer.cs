namespace EssayAssistant.Forms.Picture
{
    partial class FormArrangePictures
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
            this.numericUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.labelColumn = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Location = new System.Drawing.Point(73, 7);
            this.numericUpDownColumn.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownColumn.TabIndex = 0;
            this.numericUpDownColumn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(12, 9);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(55, 13);
            this.labelColumn.TabIndex = 1;
            this.labelColumn.Text = "子图列数";
            this.labelColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInformation.Location = new System.Drawing.Point(12, 39);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 13);
            this.labelInformation.TabIndex = 9;
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(90, 65);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(29, 65);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(56, 23);
            this.buttonAccept.TabIndex = 10;
            this.buttonAccept.Text = "确定";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // FormArrangeFigures
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = global::EssayAssistant.Properties.Settings.Default.FormAutoScaleMode;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(163, 98);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.numericUpDownColumn);
            this.Font = global::EssayAssistant.Properties.Settings.Default.FormFont;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArrangeFigures";
            this.StartPosition = global::EssayAssistant.Properties.Settings.Default.FormStartPosition;
            this.Text = "批量排列子图";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownColumn;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelColumn;
    }
}