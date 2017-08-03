namespace BumerangVsto
{
    partial class OverviewWindow
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
            this.priceTagViewList = new System.Windows.Forms.ListView();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.providerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // priceTagViewList
            // 
            this.priceTagViewList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.priceTagViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTagViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.descriptionHeader,
            this.priceHeader,
            this.providerHeader,
            this.numberHeader,
            this.dateHeader,
            this.typeHeader});
            this.priceTagViewList.FullRowSelect = true;
            this.priceTagViewList.Location = new System.Drawing.Point(12, 12);
            this.priceTagViewList.Name = "priceTagViewList";
            this.priceTagViewList.Size = new System.Drawing.Size(1250, 622);
            this.priceTagViewList.TabIndex = 0;
            this.priceTagViewList.UseCompatibleStateImageBehavior = false;
            this.priceTagViewList.View = System.Windows.Forms.View.Details;
            this.priceTagViewList.DoubleClick += new System.EventHandler(this.PriceTagViewListOnDoubleClick);
            // 
            // indexHeader
            // 
            this.indexHeader.Text = "№";
            this.indexHeader.Width = 43;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Наименование";
            this.descriptionHeader.Width = 136;
            // 
            // providerHeader
            // 
            this.providerHeader.Text = "Страна-производитель";
            // 
            // numberHeader
            // 
            this.numberHeader.Text = "Номер ТТН";
            // 
            // dateHeader
            // 
            this.dateHeader.Text = "Дата";
            // 
            // typeHeader
            // 
            this.typeHeader.Text = "Тип";
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Цена";
            // 
            // OverviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 646);
            this.Controls.Add(this.priceTagViewList);
            this.Name = "OverviewWindow";
            this.Text = "Просмотр ценников";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView priceTagViewList;
        private System.Windows.Forms.ColumnHeader indexHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader providerHeader;
        private System.Windows.Forms.ColumnHeader numberHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader typeHeader;
        private System.Windows.Forms.ColumnHeader priceHeader;
    }
}