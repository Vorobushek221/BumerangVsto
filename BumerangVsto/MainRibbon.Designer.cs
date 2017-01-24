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
            this.bumerangVstoGroup = this.Factory.CreateRibbonGroup();
            this.createTagsBut = this.Factory.CreateRibbonButton();
            this.byrToBynBut = this.Factory.CreateRibbonButton();
            this.bynToByrBut = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.bumerangVstoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.bumerangVstoGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // bumerangVstoGroup
            // 
            this.bumerangVstoGroup.Items.Add(this.byrToBynBut);
            this.bumerangVstoGroup.Items.Add(this.bynToByrBut);
            this.bumerangVstoGroup.Items.Add(this.createTagsBut);
            this.bumerangVstoGroup.Label = "Bumerang VSTO";
            this.bumerangVstoGroup.Name = "bumerangVstoGroup";
            // 
            // createTagsBut
            // 
            this.createTagsBut.Label = "Сформировать ценники";
            this.createTagsBut.Name = "createTagsBut";
            this.createTagsBut.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.createTagsBut_Click);
            // 
            // byrToBynBut
            // 
            this.byrToBynBut.Label = "BYR -> BYN";
            this.byrToBynBut.Name = "byrToBynBut";
            this.byrToBynBut.ShowImage = true;
            this.byrToBynBut.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.byrToBynBut_Click);
            // 
            // bynToByrBut
            // 
            this.bynToByrBut.Label = "BYN -> BYR";
            this.bynToByrBut.Name = "bynToByrBut";
            this.bynToByrBut.ShowImage = true;
            this.bynToByrBut.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bynToByrBut_Click);
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.bumerangVstoGroup.ResumeLayout(false);
            this.bumerangVstoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup bumerangVstoGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton createTagsBut;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton byrToBynBut;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bynToByrBut;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon MainRibbon
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}
