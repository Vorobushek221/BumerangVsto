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
            this.PriceTagViewList = new System.Windows.Forms.ListView();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.providerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // PriceTagViewList
            // 
            this.PriceTagViewList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PriceTagViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.descriptionHeader,
            this.providerHeader,
            this.numberHeader,
            this.dateHeader,
            this.typeHeader});
            this.PriceTagViewList.Location = new System.Drawing.Point(12, 12);
            this.PriceTagViewList.Name = "PriceTagViewList";
            this.PriceTagViewList.Size = new System.Drawing.Size(1250, 622);
            this.PriceTagViewList.TabIndex = 0;
            this.PriceTagViewList.UseCompatibleStateImageBehavior = false;
            this.PriceTagViewList.View = System.Windows.Forms.View.Details;
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
            this.typeHeader.Text = "Тип ценника";
            // 
            // OverviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 646);
            this.Controls.Add(this.PriceTagViewList);
            this.Name = "OverviewWindow";
            this.Text = "TagsCreateWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PriceTagViewList;
        private System.Windows.Forms.ColumnHeader indexHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader providerHeader;
        private System.Windows.Forms.ColumnHeader numberHeader;
        private System.Windows.Forms.ColumnHeader dateHeader;
        private System.Windows.Forms.ColumnHeader typeHeader;
    }
}