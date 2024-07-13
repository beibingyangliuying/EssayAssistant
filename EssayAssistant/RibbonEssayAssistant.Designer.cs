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
            this.buttonInitStyles = this.Factory.CreateRibbonButton();
            this.buttonViewStyleTree = this.Factory.CreateRibbonButton();
            this.groupImage = this.Factory.CreateRibbonGroup();
            this.buttonInsertFigures = this.Factory.CreateRibbonButton();
            this.buttonArrangeFigures = this.Factory.CreateRibbonButton();
            this.buttonSetFigureSizes = this.Factory.CreateRibbonButton();
            this.tabEssayAssistant.SuspendLayout();
            this.groupStyle.SuspendLayout();
            this.groupImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEssayAssistant
            // 
            this.tabEssayAssistant.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabEssayAssistant.Groups.Add(this.groupStyle);
            this.tabEssayAssistant.Groups.Add(this.groupImage);
            resources.ApplyResources(this.tabEssayAssistant, "tabEssayAssistant");
            this.tabEssayAssistant.Name = "tabEssayAssistant";
            // 
            // groupStyle
            // 
            this.groupStyle.Items.Add(this.buttonInitStyles);
            this.groupStyle.Items.Add(this.buttonViewStyleTree);
            resources.ApplyResources(this.groupStyle, "groupStyle");
            this.groupStyle.Name = "groupStyle";
            // 
            // buttonInitStyles
            // 
            resources.ApplyResources(this.buttonInitStyles, "buttonInitStyles");
            this.buttonInitStyles.Name = "buttonInitStyles";
            this.buttonInitStyles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonInitStyles_Click);
            // 
            // buttonViewStyleTree
            // 
            resources.ApplyResources(this.buttonViewStyleTree, "buttonViewStyleTree");
            this.buttonViewStyleTree.Name = "buttonViewStyleTree";
            this.buttonViewStyleTree.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonViewStyleTree_Click);
            // 
            // groupImage
            // 
            this.groupImage.Items.Add(this.buttonInsertFigures);
            this.groupImage.Items.Add(this.buttonArrangeFigures);
            this.groupImage.Items.Add(this.buttonSetFigureSizes);
            resources.ApplyResources(this.groupImage, "groupImage");
            this.groupImage.Name = "groupImage";
            // 
            // buttonInsertFigures
            // 
            resources.ApplyResources(this.buttonInsertFigures, "buttonInsertFigures");
            this.buttonInsertFigures.Name = "buttonInsertFigures";
            this.buttonInsertFigures.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonInsertFigures_Click);
            // 
            // buttonArrangeFigures
            // 
            resources.ApplyResources(this.buttonArrangeFigures, "buttonArrangeFigures");
            this.buttonArrangeFigures.Name = "buttonArrangeFigures";
            this.buttonArrangeFigures.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonArrangeFigures_Click);
            // 
            // buttonSetFigureSizes
            // 
            resources.ApplyResources(this.buttonSetFigureSizes, "buttonSetFigureSizes");
            this.buttonSetFigureSizes.Name = "buttonSetFigureSizes";
            this.buttonSetFigureSizes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonSetFigureSizes_Click);
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
            this.groupImage.ResumeLayout(false);
            this.groupImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabEssayAssistant;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonViewStyleTree;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupImage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonArrangeFigures;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonSetFigureSizes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonInsertFigures;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonInitStyles;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonEssayAssistant RibbonEssayAssistant
        {
            get { return this.GetRibbon<RibbonEssayAssistant>(); }
        }
    }
}
