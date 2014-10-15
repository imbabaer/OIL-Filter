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
            //List<string> wer = testNamedRangeFind();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.dropDown1 = this.Factory.CreateRibbonDropDown();
            this.cbKGR = this.Factory.CreateRibbonCheckBox();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "MyTab";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.toggleButton1);
            this.group1.Label = "ActionPaneManager";
            this.group1.Name = "group1";
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
            // group2
            // 
            this.group2.Items.Add(this.dropDown1);
            this.group2.Items.Add(this.cbKGR);
            this.group2.Label = "Zuständig";
            this.group2.Name = "group2";
            // 
            // dropDown1
            // 
            ribbonDropDownItemImpl1.Label = "David";
            ribbonDropDownItemImpl2.Label = "Ruben";
            ribbonDropDownItemImpl3.Label = "Alle anzeigen";
            this.dropDown1.Items.Add(ribbonDropDownItemImpl1);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl2);
            this.dropDown1.Items.Add(ribbonDropDownItemImpl3);
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
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }


        public List<string> testNamedRangeFind()
        {
            Microsoft.Office.Interop.Excel.Workbook m_workbook;
            var _1 = Globals.ThisWorkbook.Application;
            m_workbook = _1.ActiveWorkbook;
            int i = m_workbook.Names.Count;
            List<string> wer = new List<string>();

            if (i != 0)
            {
                foreach (Microsoft.Office.Interop.Excel.Name name in m_workbook.Names)
                {
                    string value = name.Value;
                    //Sheet and Cell e.g. =Sheet1!$A$1 or =#REF!#REF! if refers to nothing
                    string linkName = name.Name;
                    //gives the name of the link e.g. sales
                    if (value == "Wer")
                    {
                        wer.Add(name.RefersToRange.Cells.get_Address(true, true, Microsoft.Office.Interop.Excel.XlReferenceStyle.xlA1));
                    }
                }
            }
            return wer;
        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox cbKGR;
    }


    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
