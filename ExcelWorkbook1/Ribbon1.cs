using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace ExcelWorkbook1
{
    public partial class Ribbon1
    {
        //ActionsPaneControl1 actionsPane1 = new ActionsPaneControl1();
        //ActionsPaneControl2 actionsPane2 = new ActionsPaneControl2();
        //private void button1_Click(object sender, RibbonControlEventArgs e)
        //{
        //    Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
        //    actionsPane2.Hide();
        //    actionsPane1.Show();
        //    toggleButton1.Checked = false;
        //}

        //private void button2_Click(object sender, RibbonControlEventArgs e)
        //{
        //    Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
        //    actionsPane1.Hide();
        //    actionsPane2.Show();
        //    toggleButton1.Checked = false;

        //}

        //private void toggleButton1_Click(object sender, RibbonControlEventArgs e)
        //{
        //    if (toggleButton1.Checked == true)
        //    {
        //        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;
        //    }
        //    else
        //    {
        //        Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
        //    }


        //}

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane1);
            //Globals.ThisWorkbook.ActionsPane.Controls.Add(actionsPane2);
            //actionsPane1.Hide();
            //actionsPane2.Hide();
            //Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;

            //this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(
            //    this.button1_Click);
            //this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(
            //    this.button2_Click);
            //this.toggleButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(
            //    this.toggleButton1_Click);
        }


        private void dropDown1_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            Filter();
        }

        private void cbKGR_Click(object sender, RibbonControlEventArgs e)
        {
            Filter();

        }

        private void Filter()
        {
            Microsoft.Office.Interop.Excel.Worksheet activeWorksheet = ((Microsoft.Office.Interop.Excel.Worksheet)Globals.ThisWorkbook.Application.ActiveSheet);

            Microsoft.Office.Interop.Excel.Range usedRange = activeWorksheet.UsedRange;

            if (this.dropDown1.SelectedItem.ToString().Equals("Alle anzeigen"))
            {
                foreach (Microsoft.Office.Interop.Excel.Range row in usedRange.Rows)
                {
                    row.Select();
                    row.Hidden = false;
                }
            }
            else
            {
                if (false)
                {

                }
                else
                {

                    //Iterate the rows in the used range
                    foreach (Microsoft.Office.Interop.Excel.Range row in usedRange.Rows)
                    {

                        if (this.cbKGR.Checked)
                        {
                            bool assignee = false;
                            if (row.Cells[1, 9].Value2 != null)
                            {
                                assignee = row.Cells[1, 9].Value2.ToString().Equals(this.dropDown1.SelectedItem.ToString())
                                            || row.Cells[1, 9].Value2.ToString().Equals("KGR");
                            }
                            //Do something with the row.
                            if (row.Cells[1, 9].Value2 == null
                                || (row.Cells[1, 9].Value2 != null
                                    && !assignee))
                            {
                                row.Hidden = true;
                            }
                            else
                            {
                                row.Select();
                                row.Hidden = false;
                            }
                        }
                        else
                        {

                            //Do something with the row.
                            if (row.Cells[1, 9].Value2 == null
                                || row.Cells[1, 9].Value2 != null
                                && !row.Cells[1, 9].Value2.ToString().Equals(this.dropDown1.SelectedItem.ToString())
                                )
                            {
                                row.Hidden = true;
                            }
                            else
                            {
                                row.Select();
                                row.Hidden = false;
                            }
                        }
                    }
                }
            }
        }

        private void editBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {
            string inputText =this.ebProjectName.Text;
            //if (!inputText.Equals(""))
            //{
                Microsoft.Office.Interop.Excel.Worksheet activeWorksheet = ((Microsoft.Office.Interop.Excel.Worksheet)Globals.ThisWorkbook.Application.ActiveSheet);
                Microsoft.Office.Interop.Excel.Range usedRange = activeWorksheet.UsedRange;
                foreach (Microsoft.Office.Interop.Excel.Range row in usedRange.Rows)
                {
                    //Do something with the row.
                    if (row.Cells[1,3].Value2 == null
                        || row.Cells[1,3].Value2 != null
                        && !(row.Cells[1, 3].Value2.ToString().IndexOf(inputText, StringComparison.OrdinalIgnoreCase) >= 0)
                        )
                    {
                        row.Hidden = true;
                    }
                    else
                    {
                        row.Select();
                        row.Hidden = false;
                    }
                }
            //}

        }
    }
}
