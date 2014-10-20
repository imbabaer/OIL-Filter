using System.Collections.Generic;
namespace ExcelWorkbook1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl14 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl15 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl16 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl17 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl18 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.dropDown1 = this.Factory.CreateRibbonDropDown();
            this.cbKGR = this.Factory.CreateRibbonCheckBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.ebProjectName = this.Factory.CreateRibbonEditBox();
            this.tab1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "KGR OPL";
            this.tab1.Name = "tab1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.dropDown1);
            this.group2.Items.Add(this.cbKGR);
            this.group2.Label = "Zuständig";
            this.group2.Name = "group2";
            // 
            // dropDown1
            // 
            ribbonDropDownItemImpl1.Label = "Alber, Kirsten";
            ribbonDropDownItemImpl2.Label = "BauA";
            ribbonDropDownItemImpl3.Label = "Eisenbraun, Frank";
            ribbonDropDownItemImpl4.Label = "KGR";
            ribbonDropDownItemImpl5.Label = "KiGaA";
            ribbonDropDownItemImpl6.Label = "Killgus, Christoph";
            ribbonDropDownItemImpl7.Label = "König, Angela";
            ribbonDropDownItemImpl8.Label = "Kurfess, David";
            ribbonDropDownItemImpl9.Label = "Luedecke, Heike";
            ribbonDropDownItemImpl10.Label = "Luikart, Ulrike";
            ribbonDropDownItemImpl11.Label = "Müller, Anne";
            ribbonDropDownItemImpl12.Label = "Müller, Ruben";
            ribbonDropDownItemImpl13.Label = "Scheible, David";
            ribbonDropDownItemImpl14.Label = "Schöck, Michael";
            ribbonDropDownItemImpl15.Label = "Stephan, Susanne";
            ribbonDropDownItemImpl16.Label = "Streich, Andreas";
            ribbonDropDownItemImpl17.Label = "VerwA";
            ribbonDropDownItemImpl18.Label = "Alle anzeigen";
            this.dropDown1.Items.Add(ribbonDropDownItemImpl1);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl2);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl3);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl4);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl5);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl6);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl7);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl8);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl9);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl10);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl11);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl12);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl13);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl14);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl15);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl16);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl17);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl18);
            this.dropDown1.Label = "Wer";
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown1_SelectionChanged);
            // 
            // cbKGR
            // 
            this.cbKGR.Label = "KGR";
            this.cbKGR.Name = "cbKGR";
            this.cbKGR.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.cbKGR_Click);
            // 
            // button1
            // 
            this.button1.Label = "show action pane";
            this.button1.Name = "button1";
            // 
            // button2
            // 
            this.button2.Label = "  show aciton pane 2";
            this.button2.Name = "button2";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Label = "hide action pane";
            this.toggleButton1.Name = "toggleButton1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.ebProjectName);
            this.group1.Label = "Projekt";
            this.group1.Name = "group1";
            // 
            // ebProjectName
            // 
            this.ebProjectName.Label = "Name";
            this.ebProjectName.Name = "ebProjectName";
            this.ebProjectName.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBox1_TextChanged);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }


        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbKGR;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox ebProjectName;
    }


    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
