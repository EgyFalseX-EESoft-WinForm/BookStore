﻿namespace BookStore
{
    partial class Qry03Frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qry03Frm));
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cardViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsBookStoreQueries = new BookStore.DataSources.dsBookStoreQueries();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cardViewSells = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.qry03BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qry03TableAdapter = new BookStore.DataSources.dsBookStoreQueriesTableAdapters.Qry03TableAdapter();
            this.colCountNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreTrDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            this.CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookStoreQueries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewSells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry03BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMain
            // 
            this.gridControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMain.ContextMenuStrip = this.CMS;
            this.gridControlMain.DataSource = this.qry03BindingSource;
            this.gridControlMain.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlMain.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.gridControlMain.Location = new System.Drawing.Point(0, 41);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.gridControlMain.Size = new System.Drawing.Size(643, 421);
            this.gridControlMain.TabIndex = 0;
            this.gridControlMain.UseEmbeddedNavigator = true;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain,
            this.cardViewSells});
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cardViewToolStripMenuItem,
            this.gridViewToolStripMenuItem});
            this.CMS.Name = "CMSPartnerStaff";
            this.CMS.Size = new System.Drawing.Size(172, 98);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::BookStore.Properties.Resources.Refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.refreshToolStripMenuItem.Text = "اعادة تحميل البيانات";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::BookStore.Properties.Resources.Print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.printToolStripMenuItem.Text = "طباعه";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // cardViewToolStripMenuItem
            // 
            this.cardViewToolStripMenuItem.Name = "cardViewToolStripMenuItem";
            this.cardViewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cardViewToolStripMenuItem.Text = "عرض كروت";
            this.cardViewToolStripMenuItem.Click += new System.EventHandler(this.cardViewToolStripMenuItem_Click);
            // 
            // gridViewToolStripMenuItem
            // 
            this.gridViewToolStripMenuItem.Name = "gridViewToolStripMenuItem";
            this.gridViewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gridViewToolStripMenuItem.Text = "عرض جدولي";
            this.gridViewToolStripMenuItem.Click += new System.EventHandler(this.gridViewToolStripMenuItem_Click);
            // 
            // dsBookStoreQueries
            // 
            this.dsBookStoreQueries.DataSetName = "dsBookStoreQueries";
            this.dsBookStoreQueries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewMain.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewMain.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewMain.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMain.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewMain.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewMain.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gridViewMain.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(86)))), ((int)(((byte)(156)))));
            this.gridViewMain.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gridViewMain.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(218)))), ((int)(((byte)(210)))));
            this.gridViewMain.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewMain.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewMain.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMain.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMain.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMain.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewMain.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewMain.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.gridViewMain.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMain.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewMain.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMain.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMain.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.gridViewMain.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(46)))), ((int)(((byte)(116)))));
            this.gridViewMain.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewMain.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewMain.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMain.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCountNum,
            this.colCategory,
            this.colStoreTrDate});
            this.gridViewMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", null, "")});
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewMain.OptionsBehavior.ReadOnly = true;
            this.gridViewMain.OptionsCustomization.AllowRowSizing = true;
            this.gridViewMain.OptionsPrint.AutoWidth = false;
            this.gridViewMain.OptionsPrint.ExpandAllDetails = true;
            this.gridViewMain.OptionsPrint.PrintDetails = true;
            this.gridViewMain.OptionsPrint.PrintFilterInfo = true;
            this.gridViewMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewMain.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMain.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMain.OptionsView.ShowFooter = true;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // cardViewSells
            // 
            this.cardViewSells.Appearance.CardCaption.BackColor = System.Drawing.Color.DarkGray;
            this.cardViewSells.Appearance.CardCaption.BorderColor = System.Drawing.Color.DarkGray;
            this.cardViewSells.Appearance.CardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.CardCaption.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.EmptySpace.BackColor = System.Drawing.Color.DimGray;
            this.cardViewSells.Appearance.EmptySpace.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.cardViewSells.Appearance.EmptySpace.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FieldCaption.BackColor = System.Drawing.Color.White;
            this.cardViewSells.Appearance.FieldCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.cardViewSells.Appearance.FieldValue.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.cardViewSells.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.cardViewSells.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.cardViewSells.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.cardViewSells.Appearance.FilterPanel.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FilterPanel.Options.UseForeColor = true;
            this.cardViewSells.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.Black;
            this.cardViewSells.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.Black;
            this.cardViewSells.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.cardViewSells.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.cardViewSells.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.LightSlateGray;
            this.cardViewSells.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.LightSlateGray;
            this.cardViewSells.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.cardViewSells.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.DimGray;
            this.cardViewSells.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.cardViewSells.Appearance.SeparatorLine.BackColor = System.Drawing.Color.LightGray;
            this.cardViewSells.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.cardViewSells.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.cardViewSells.FocusedCardTopFieldIndex = 0;
            this.cardViewSells.GridControl = this.gridControlMain;
            this.cardViewSells.Name = "cardViewSells";
            this.cardViewSells.OptionsBehavior.ReadOnly = true;
            this.cardViewSells.OptionsPrint.PrintFilterInfo = true;
            this.cardViewSells.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم الصنف";
            this.gridColumn1.FieldName = "SanfName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الكميه";
            this.gridColumn2.FieldName = "Quantity";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "السعر";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "التاريخ";
            this.gridColumn4.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn4.FieldName = "StoreTrDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(504, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // qry03BindingSource
            // 
            this.qry03BindingSource.DataMember = "Qry03";
            this.qry03BindingSource.DataSource = this.dsBookStoreQueries;
            // 
            // qry03TableAdapter
            // 
            this.qry03TableAdapter.ClearBeforeFill = true;
            // 
            // colCountNum
            // 
            this.colCountNum.AppearanceCell.Options.UseTextOptions = true;
            this.colCountNum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCountNum.AppearanceHeader.Options.UseTextOptions = true;
            this.colCountNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCountNum.Caption = "العدد";
            this.colCountNum.FieldName = "CountNum";
            this.colCountNum.Name = "colCountNum";
            this.colCountNum.OptionsColumn.ReadOnly = true;
            this.colCountNum.Visible = true;
            this.colCountNum.VisibleIndex = 2;
            // 
            // colCategory
            // 
            this.colCategory.AppearanceCell.Options.UseTextOptions = true;
            this.colCategory.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCategory.Caption = "التصنيف";
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 0;
            this.colCategory.Width = 189;
            // 
            // colStoreTrDate
            // 
            this.colStoreTrDate.AppearanceCell.Options.UseTextOptions = true;
            this.colStoreTrDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStoreTrDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colStoreTrDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStoreTrDate.Caption = "التاريخ";
            this.colStoreTrDate.FieldName = "StoreTrDate";
            this.colStoreTrDate.Name = "colStoreTrDate";
            this.colStoreTrDate.Visible = true;
            this.colStoreTrDate.VisibleIndex = 1;
            this.colStoreTrDate.Width = 144;
            // 
            // Qry03Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 462);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Qry03Frm";
            this.Text = "استعلام المبيعات التصنيفات اجمالي";
            this.Load += new System.EventHandler(this.QryPartnerStaffFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            this.CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBookStoreQueries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardViewSells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qry03BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private DevExpress.XtraGrid.Views.Card.CardView cardViewSells;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cardViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridViewToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DataSources.dsBookStoreQueries dsBookStoreQueries;
        private System.Windows.Forms.BindingSource qry03BindingSource;
        private DataSources.dsBookStoreQueriesTableAdapters.Qry03TableAdapter qry03TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCountNum;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreTrDate;
    }
}