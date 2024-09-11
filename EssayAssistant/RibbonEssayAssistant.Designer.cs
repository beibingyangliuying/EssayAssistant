namespace EssayAssistant
{
    partial class RibbonEssayAssistant : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonEssayAssistant()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonEssayAssistant));
            this.tabEssayAssistant = this.Factory.CreateRibbonTab();
            this.groupStyle = this.Factory.CreateRibbonGroup();
            this.buttonViewStyleTree = this.Factory.CreateRibbonButton();
            this.groupCharacter = this.Factory.CreateRibbonGroup();
            this.buttonCorrectCharacterFormat = this.Factory.CreateRibbonButton();
            this.buttonCorrectPunctuation = this.Factory.CreateRibbonButton();
            this.buttonCorrectWordSpacing = this.Factory.CreateRibbonButton();
            this.groupFigure = this.Factory.CreateRibbonGroup();
            this.buttonInsertPictures = this.Factory.CreateRibbonButton();
            this.buttonArrangePictures = this.Factory.CreateRibbonButton();
            this.buttonSetPicturesSizes = this.Factory.CreateRibbonButton();
            this.buttonReplacePictures = this.Factory.CreateRibbonButton();
            this.buttonSelectCJHChar = this.Factory.CreateRibbonButton();
            this.tabEssayAssistant.SuspendLayout();
            this.groupStyle.SuspendLayout();
            this.groupCharacter.SuspendLayout();
            this.groupFigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEssayAssistant
            // 
            this.tabEssayAssistant.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabEssayAssistant.Groups.Add(this.groupStyle);
            this.tabEssayAssistant.Groups.Add(this.groupCharacter);
            this.tabEssayAssistant.Groups.Add(this.groupFigure);
            resources.ApplyResources(this.tabEssayAssistant, "tabEssayAssistant");
            this.tabEssayAssistant.Name = "tabEssayAssistant";
            // 
            // groupStyle
            // 
            this.groupStyle.Items.Add(this.buttonViewStyleTree);
            resources.ApplyResources(this.groupStyle, "groupStyle");
            this.groupStyle.Name = "groupStyle";
            // 
            // buttonViewStyleTree
            // 
            resources.ApplyResources(this.buttonViewStyleTree, "buttonViewStyleTree");
            this.buttonViewStyleTree.Name = "buttonViewStyleTree";
            this.buttonViewStyleTree.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonViewStyleTree_Click);
            // 
            // groupCharacter
            // 
            this.groupCharacter.Items.Add(this.buttonSelectCJHChar);
            this.groupCharacter.Items.Add(this.buttonCorrectCharacterFormat);
            this.groupCharacter.Items.Add(this.buttonCorrectPunctuation);
            this.groupCharacter.Items.Add(this.buttonCorrectWordSpacing);
            resources.ApplyResources(this.groupCharacter, "groupCharacter");
            this.groupCharacter.Name = "groupCharacter";
            // 
            // buttonCorrectCharacterFormat
            // 
            resources.ApplyResources(this.buttonCorrectCharacterFormat, "buttonCorrectCharacterFormat");
            this.buttonCorrectCharacterFormat.Name = "buttonCorrectCharacterFormat";
            this.buttonCorrectCharacterFormat.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonCorrectCharacterFormat_Click);
            // 
            // buttonCorrectPunctuation
            // 
            resources.ApplyResources(this.buttonCorrectPunctuation, "buttonCorrectPunctuation");
            this.buttonCorrectPunctuation.Name = "buttonCorrectPunctuation";
            this.buttonCorrectPunctuation.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonCorrectPunctuation_Click);
            // 
            // buttonCorrectWordSpacing
            // 
            resources.ApplyResources(this.buttonCorrectWordSpacing, "buttonCorrectWordSpacing");
            this.buttonCorrectWordSpacing.Name = "buttonCorrectWordSpacing";
            this.buttonCorrectWordSpacing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonCorrectWordSpacing_Click);
            // 
            // groupFigure
            // 
            this.groupFigure.Items.Add(this.buttonInsertPictures);
            this.groupFigure.Items.Add(this.buttonArrangePictures);
            this.groupFigure.Items.Add(this.buttonSetPicturesSizes);
            this.groupFigure.Items.Add(this.buttonReplacePictures);
            resources.ApplyResources(this.groupFigure, "groupFigure");
            this.groupFigure.Name = "groupFigure";
            // 
            // buttonInsertPictures
            // 
            resources.ApplyResources(this.buttonInsertPictures, "buttonInsertPictures");
            this.buttonInsertPictures.Name = "buttonInsertPictures";
            this.buttonInsertPictures.OfficeImageId = "PictureInsertFromFile";
            this.buttonInsertPictures.ShowImage = true;
            this.buttonInsertPictures.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonInsertPictures_Click);
            // 
            // buttonArrangePictures
            // 
            resources.ApplyResources(this.buttonArrangePictures, "buttonArrangePictures");
            this.buttonArrangePictures.Name = "buttonArrangePictures";
            this.buttonArrangePictures.OfficeImageId = "TableInsertDialog";
            this.buttonArrangePictures.ShowImage = true;
            this.buttonArrangePictures.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonArrangePictures_Click);
            // 
            // buttonSetPicturesSizes
            // 
            resources.ApplyResources(this.buttonSetPicturesSizes, "buttonSetPicturesSizes");
            this.buttonSetPicturesSizes.Name = "buttonSetPicturesSizes";
            this.buttonSetPicturesSizes.OfficeImageId = "GroupPictureCompress";
            this.buttonSetPicturesSizes.ShowImage = true;
            this.buttonSetPicturesSizes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonSetPicturesSizes_Click);
            // 
            // buttonReplacePictures
            // 
            resources.ApplyResources(this.buttonReplacePictures, "buttonReplacePictures");
            this.buttonReplacePictures.Name = "buttonReplacePictures";
            this.buttonReplacePictures.OfficeImageId = "PictureChange";
            this.buttonReplacePictures.ShowImage = true;
            this.buttonReplacePictures.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonReplacePictures_Click);
            // 
            // buttonSelectCJHChar
            // 
            resources.ApplyResources(this.buttonSelectCJHChar, "buttonSelectCJHChar");
            this.buttonSelectCJHChar.Name = "buttonSelectCJHChar";
            this.buttonSelectCJHChar.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonSelectCJHChar_Click);
            // 
            // RibbonEssayAssistant
            // 
            this.Name = "RibbonEssayAssistant";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tabEssayAssistant);
            this.tabEssayAssistant.ResumeLayout(false);
            this.tabEssayAssistant.PerformLayout();
            this.groupStyle.ResumeLayout(false);
            this.groupStyle.PerformLayout();
            this.groupCharacter.ResumeLayout(false);
            this.groupCharacter.PerformLayout();
            this.groupFigure.ResumeLayout(false);
            this.groupFigure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabEssayAssistant;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonViewStyleTree;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupFigure;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonArrangePictures;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSetPicturesSizes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonInsertPictures;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReplacePictures;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupCharacter;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCorrectCharacterFormat;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCorrectPunctuation;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCorrectWordSpacing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSelectCJHChar;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonEssayAssistant RibbonEssayAssistant
        {
            get { return this.GetRibbon<RibbonEssayAssistant>(); }
        }
    }
}
