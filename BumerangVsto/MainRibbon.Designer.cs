namespace BumerangVsto
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.priceTagGroup = this.Factory.CreateRibbonGroup();
            this.tagsLayoutGallery = this.Factory.CreateRibbonGallery();
            this.template2button = this.Factory.CreateRibbonButton();
            this.template3button = this.Factory.CreateRibbonButton();
            this.template5button = this.Factory.CreateRibbonButton();
            this.overviewButton = this.Factory.CreateRibbonButton();
            this.addTagSheets = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.priceTagGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.priceTagGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // priceTagGroup
            // 
            this.priceTagGroup.Items.Add(this.tagsLayoutGallery);
            this.priceTagGroup.Items.Add(this.overviewButton);
            this.priceTagGroup.Items.Add(this.addTagSheets);
            this.priceTagGroup.Label = "Работа с ценниками";
            this.priceTagGroup.Name = "priceTagGroup";
            // 
            // tagsLayoutGallery
            // 
            this.tagsLayoutGallery.Buttons.Add(this.template2button);
            this.tagsLayoutGallery.Buttons.Add(this.template3button);
            this.tagsLayoutGallery.Buttons.Add(this.template5button);
            this.tagsLayoutGallery.Label = "Добавить ценники из реестра";
            this.tagsLayoutGallery.Name = "tagsLayoutGallery";
            // 
            // template2button
            // 
            this.template2button.Label = "по 2 в строке";
            this.template2button.Name = "template2button";
            this.template2button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateTagsTemplate2Button_Click);
            // 
            // template3button
            // 
            this.template3button.Label = "по 3 в строке";
            this.template3button.Name = "template3button";
            this.template3button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateTagsTemplate3Button_Click);
            // 
            // template5button
            // 
            this.template5button.Label = "по 5 в строке";
            this.template5button.Name = "template5button";
            this.template5button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateTagsTemplate5Button_Click);
            // 
            // overviewButton
            // 
            this.overviewButton.Label = "Просмотр набора ценников";
            this.overviewButton.Name = "overviewButton";
            this.overviewButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OverviewButton_Click);
            // 
            // addTagSheets
            // 
            this.addTagSheets.Label = "Сформировать листы ценников";
            this.addTagSheets.Name = "addTagSheets";
            this.addTagSheets.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddTagSheets_Click);
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.priceTagGroup.ResumeLayout(false);
            this.priceTagGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup priceTagGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGallery tagsLayoutGallery;
        private Microsoft.Office.Tools.Ribbon.RibbonButton template2button;
        private Microsoft.Office.Tools.Ribbon.RibbonButton template3button;
        private Microsoft.Office.Tools.Ribbon.RibbonButton template5button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton overviewButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton addTagSheets;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon MainRibbon
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}
