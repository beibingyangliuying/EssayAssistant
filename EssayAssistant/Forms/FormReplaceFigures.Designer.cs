namespace EssayAssistant.Forms
{
    partial class FormReplaceFigures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReplaceFigures));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.listViewAfter = new System.Windows.Forms.ListView();
            this.labelAfter = new System.Windows.Forms.Label();
            this.buttonSelectFigures = new System.Windows.Forms.Button();
            this.listViewBefore = new System.Windows.Forms.ListView();
            this.labelBefore = new System.Windows.Forms.Label();
            this.openFileDialogAddFigures = new System.Windows.Forms.OpenFileDialog();
            this.labelInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(851, 329);
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
            this.buttonAccept.Location = new System.Drawing.Point(790, 329);
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
            this.listViewAfter.Location = new System.Drawing.Point(400, 28);
            this.listViewAfter.Name = "listViewAfter";
            this.listViewAfter.Size = new System.Drawing.Size(373, 324);
            this.listViewAfter.TabIndex = 14;
            this.listViewAfter.UseCompatibleStateImageBehavior = false;
            // 
            // labelAfter
            // 
            this.labelAfter.AutoSize = true;
            this.labelAfter.Location = new System.Drawing.Point(397, 9);
            this.labelAfter.Name = "labelAfter";
            this.labelAfter.Size = new System.Drawing.Size(91, 13);
            this.labelAfter.TabIndex = 15;
            this.labelAfter.Text = "将要插入的图片";
            // 
            // buttonSelectFigures
            // 
            this.buttonSelectFigures.Location = new System.Drawing.Point(790, 28);
            this.buttonSelectFigures.Name = "buttonSelectFigures";
            this.buttonSelectFigures.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectFigures.TabIndex = 0;
            this.buttonSelectFigures.Text = "选择图片";
            this.buttonSelectFigures.UseVisualStyleBackColor = true;
            this.buttonSelectFigures.Click += new System.EventHandler(this.ButtonSelectFigures_Click);
            // 
            // listViewBefore
            // 
            this.listViewBefore.HideSelection = false;
            this.listViewBefore.Location = new System.Drawing.Point(15, 28);
            this.listViewBefore.Name = "listViewBefore";
            this.listViewBefore.Size = new System.Drawing.Size(373, 324);
            this.listViewBefore.TabIndex = 17;
            this.listViewBefore.UseCompatibleStateImageBehavior = false;
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.Location = new System.Drawing.Point(12, 9);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(103, 13);
            this.labelBefore.TabIndex = 18;
            this.labelBefore.Text = "将要被替换的图片";
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
            // FormReplaceFigures
            // 
            this.AcceptButton = this.buttonAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(918, 390);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelBefore);
            this.Controls.Add(this.buttonSelectFigures);
            this.Controls.Add(this.listViewBefore);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ListView listViewAfter;
        private System.Windows.Forms.Label labelAfter;
        private System.Windows.Forms.Button buttonSelectFigures;
        private System.Windows.Forms.ListView listViewBefore;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.OpenFileDialog openFileDialogAddFigures;
        private System.Windows.Forms.Label labelInformation;
    }
}