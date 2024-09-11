namespace EssayAssistant.Forms.Picture
{
    partial class FormReplacePictures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReplacePictures));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.listViewAfter = new System.Windows.Forms.ListView();
            this.labelAfter = new System.Windows.Forms.Label();
            this.buttonSelectFigures = new System.Windows.Forms.Button();
            this.openFileDialogAddFigures = new System.Windows.Forms.OpenFileDialog();
            this.labelInformation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(475, 327);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(414, 327);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(56, 23);
            this.buttonAccept.TabIndex = 12;
            this.buttonAccept.Text = "确定";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // listViewAfter
            // 
            this.listViewAfter.HideSelection = false;
            this.listViewAfter.Location = new System.Drawing.Point(12, 26);
            this.listViewAfter.MultiSelect = false;
            this.listViewAfter.Name = "listViewAfter";
            this.listViewAfter.ShowItemToolTips = true;
            this.listViewAfter.Size = new System.Drawing.Size(396, 324);
            this.listViewAfter.TabIndex = 14;
            this.listViewAfter.UseCompatibleStateImageBehavior = false;
            this.listViewAfter.SelectedIndexChanged += new System.EventHandler(this.ListViewAfter_SelectedIndexChanged);
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(9, 7);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(91, 13);
            this.labelAfter.TabIndex = 15;
            this.labelAfter.Text = "将要插入的图片";
            // 
            // buttonSelectFigures
            // 
            this.buttonSelectFigures.Location = new System.Drawing.Point(3, 3);
            this.buttonSelectFigures.Name = "buttonSelectFigures";
            this.buttonSelectFigures.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectFigures.TabIndex = 0;
            this.buttonSelectFigures.Text = "选择图片";
            this.buttonSelectFigures.UseVisualStyleBackColor = true;
            this.buttonSelectFigures.Click += new System.EventHandler(this.ButtonSelectFigures_Click);
            // 
            // openFileDialogAddFigures
            // 
            this.openFileDialogAddFigures.Filter = resources.GetString("openFileDialogAddFigures.Filter");
            this.openFileDialogAddFigures.Multiselect = true;
            this.openFileDialogAddFigures.Title = "添加图片";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInformation.Location = new System.Drawing.Point(12, 364);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 13);
            this.labelInformation.TabIndex = 19;
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectFigures, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMoveUp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonMoveDown, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(414, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(117, 90);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Enabled = false;
            this.buttonMoveUp.Location = new System.Drawing.Point(3, 32);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(111, 23);
            this.buttonMoveUp.TabIndex = 1;
            this.buttonMoveUp.Text = "上移";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.ButtonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Enabled = false;
            this.buttonMoveDown.Location = new System.Drawing.Point(3, 61);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(111, 23);
            this.buttonMoveDown.TabIndex = 2;
            this.buttonMoveDown.Text = "下移";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.ButtonMoveDown_Click);
            // 
            // FormReplaceFigures
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(540, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelAfter);
            this.Controls.Add(this.listViewAfter);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReplaceFigures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "批量替换图片";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ListView listViewAfter;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.Button buttonSelectFigures;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddFigures;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
    }
}