using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Warehouse
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //declare event handler for printing in constructor
       public Excel.Application Application = new Excel.Application();
        public ChildForm cf = new ChildForm();
        //Rest of the code
        Bitmap MemoryImage;
        #region Excel Document
        public void GetPrintArea(Panel pnl)
        {
            #region Create Properties
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            
            
            try
            {
                //Start Excel and Get Application Object
                oXL = new Excel.Application();
                oXL.Visible = true;
                oXL.WindowState = Excel.XlWindowState.xlMaximized;
                //Get A New Workbook
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            #endregion
             #region Create Layout
                #region Row Heights
            oSheet.Range["A1:K1"].RowHeight = 15.75;
                oSheet.Range["A2:K2"].RowHeight = 11.25;
                oSheet.Range["A3:K3"].RowHeight = 15.75;
                oSheet.Range["A4:K4"].RowHeight = 11.5;
                oSheet.Range["A5:K5"].RowHeight = 12.25;
                oSheet.Range["A6:K6"].RowHeight = 12.25;
                oSheet.Range["A7:K7"].RowHeight = 12.25;
                oSheet.Range["A8:K8"].RowHeight = 15;
                oSheet.Range["A9:K9"].RowHeight = 15;
                oSheet.Range["A10:K10"].RowHeight = 15;
                oSheet.Range["A11:K11"].RowHeight = 15;
                oSheet.Range["A12:K12"].RowHeight = 15;
                oSheet.Range["A13:K13"].RowHeight = 15;
                oSheet.Range["A14:K14"].RowHeight = 15;
                oSheet.Range["A15:K15"].RowHeight = 15;
                oSheet.Range["A16:K16"].RowHeight = 10.5;
                oSheet.Range["A17:K17"].RowHeight = 15;
                oSheet.Range["A18:K18"].RowHeight = 15;
                oSheet.Range["A19:K19"].RowHeight = 15;
                oSheet.Range["A20:K20"].RowHeight = 15;
                oSheet.Range["A21:K21"].RowHeight = 15;
                #endregion
                #region Column Width
                oSheet.Range["A1:A51"].ColumnWidth = 6.43;
                oSheet.Range["B1:B51"].ColumnWidth = 2;
                oSheet.Range["C1:C51"].ColumnWidth = 16.43;
                oSheet.Range["D1:D51"].ColumnWidth = 7.57;
                oSheet.Range["E1:E51"].ColumnWidth = 3.57;
                oSheet.Range["F1:F51"].ColumnWidth = 8.47;
                oSheet.Range["G1:G51"].ColumnWidth = 8.47;
                oSheet.Range["H1:H51"].ColumnWidth = 8.47;
                oSheet.Range["I1:I51"].ColumnWidth = 8.47;
                oSheet.Range["J1:J51"].ColumnWidth = 8.47;
                oSheet.Range["K1:K51"].ColumnWidth = 8.47;
                oSheet.Range["L1:L51"].ColumnWidth = 8.47;
                #endregion
                #region Text


                #endregion
                #region Format Text
                #region Header
                oSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlPortrait;
                oSheet.PageSetup.TopMargin = .44;
                
                oSheet.PageSetup.RightMargin = .29;
                oSheet.PageSetup.LeftMargin = .29;
                oSheet.get_Range("A2:B2").Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                oSheet.get_Range("A2:B2").Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("H2:L2").Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                oSheet.get_Range("H2:L2").Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                    oSheet.Cells[1, 3] = "Therm-Air Sales Corp.";
                        oSheet.Cells[1, 3].Font.Name = "Monotype Corsiva";
                        oSheet.Cells[1, 3].Font.Size = 32;
                        oSheet.Cells[1, 3].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("C1:G3");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                    oSheet.Cells[4, 3] = "Manufacturer's Representative for Mechanical Equipment";
                        oSheet.Cells[4, 3].Font.Name = "Times New Roman";
                        oSheet.Cells[4, 3].Font.Size = 8;
                        oSheet.Cells[4, 3].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("C4:G4");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                oSheet.Cells[5, 9] = "Box 9004";
                        oSheet.Cells[5, 9].Font.Name = "Calibri";
                        oSheet.Cells[5, 9].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("I5:L5");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                oSheet.Cells[6, 9] = "1413 - 41st ST NW Fargo, ND 58106-9004";
                        oSheet.Cells[6, 9].Font.Name = "Calibri";
                        oSheet.Cells[6, 9].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("I6:L6");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                oSheet.Cells[7, 9] = "Telephone:(701)282-9500";
                        oSheet.Cells[7, 9].Font.Name = "Calibri";
                        oSheet.Cells[7, 9].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("I7:L7");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                oSheet.Cells[8, 1] = "Sold To:";
                        oSheet.Cells[8, 1].Font.Name = "Calibri";
                        oSheet.Cells[8, 1].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("A8:A8");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                
                            oRng = oSheet.get_Range("A10:A10");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;

                            oRng = oSheet.get_Range("B7:B7");
                            oRng.Merge(Missing.Value);
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                            oRng = oSheet.get_Range("B11:B11");
                            oRng.Merge(Missing.Value);
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
               
                        oSheet.Cells[8, 2] = lblSoldTo.Text; 
               
                        oSheet.Cells[8, 2].Font.Name = "Calibri";
                        
                            oRng = oSheet.get_Range("B8:D10");
                            oRng.Merge(Missing.Value);
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            oRng.WrapText = true;

                oSheet.Cells[8, 7] = "Tag:";
                        oSheet.Cells[8, 7].Font.Name = "Calibri";
                        oSheet.Cells[8, 7].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("G8:G8");
                            oRng.Merge(Missing.Value);
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                            oRng = oSheet.get_Range("H8:L10");
                            oRng.Merge(Missing.Value);
                            oRng.Name = "lblTag";
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            oRng.WrapText = true;

                oSheet.Cells[12, 1] = "Ship To:";
                        oSheet.Cells[12, 1].Font.Name = "Calibri";
                        oSheet.Cells[12, 1].Font.Color = Color.Black;
                            oRng = oSheet.get_Range("A12:A12");
                            oRng.Merge(Missing.Value);
                            
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;

                            oRng = oSheet.get_Range("B12:D14");
                            oRng.Merge(Missing.Value);
                            
                            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                            oRng.WrapText = true;

                            oRng = oSheet.get_Range("A14:A14");
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;

                            oRng = oSheet.get_Range("B15:B15");
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                            oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oSheet.Cells[16, 1] = "Date";
                    oSheet.Cells[16, 1].Font.Name = "Calibri";
                    oSheet.Cells[16, 1].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("A16:B16");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oSheet.Cells[17, 1] = lblDO.Text;
                    oSheet.Cells[17, 1].Font.Name = "Calibri";
                        oRng = oSheet.get_Range("A17:B18");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[16, 3] = "Customer P.O NO.";
                    oSheet.Cells[16, 3].Font.Name = "Calibri";
                    oSheet.Cells[16, 3].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("C16:C16");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[17,3] = lblPO.Text;
                    oSheet.Cells[17, 3].Font.Name = "Calibri";
                        oRng = oSheet.get_Range("C17:C18");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[16, 4] = "Ship VIA";
                    oSheet.Cells[16, 4].Font.Name = "Calibri";
                    oSheet.Cells[16, 4].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("D16:E16");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[17, 3] = lblShipVIA.Text;
                    oSheet.Cells[17, 3].Font.Name = "Calibri";
                        oRng = oSheet.get_Range("D17:E18");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[16, 6] = "Date Shipped";
                    oSheet.Cells[16, 6].Font.Name = "Calibri";
                    oSheet.Cells[16, 6].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("F16:G16");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[17, 6] = lblPU.Text;
                    oSheet.Cells[17, 6].Font.Name = "Calibri";
                        oRng = oSheet.get_Range("F17:G18");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[16, 8] = "Back Order";
                    oSheet.Cells[16, 8].Font.Name = "Calibri";
                    oSheet.Cells[16, 8].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("H16:L16");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[17, 8] = "To:";
                    oSheet.Cells[17, 8].Font.Name = "Calibri";
                    oSheet.Cells[17, 8].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("H17:H17");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;


                oSheet.Cells[18, 8] = "From:";
                oSheet.Cells[18, 8].Font.Name = "Calibri";
                oSheet.Cells[18, 8].Font.Color = Color.Black;
                oRng = oSheet.get_Range("H18:H18");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                
                
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[17, 9] = lblTransto.Text;
                oSheet.Cells[17, 9].Font.Name = "Calibri";
                oRng = oSheet.get_Range("I17:L17");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;


                oSheet.Cells[18, 9] = lblTransfrom.Text;
                    oSheet.Cells[18, 9].Font.Name = "Calibri";
                        oRng = oSheet.get_Range("I18:L18");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[19, 1] = "Code";
                    oSheet.Cells[19, 1].Font.Name = "Calibri";
                    oSheet.Cells[19, 1].Font.Color = Color.Black;
                        oRng = oSheet.get_Range("A19:A19");
                        oRng.Merge(Missing.Value);
                        oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                        oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                        
                oSheet.Cells[20, 1] = "No.";
                    oSheet.Cells[20, 1].Font.Name = "Calibri";
                    oSheet.Cells[20, 1].Font.Color = Color.Black;
                oRng = oSheet.get_Range("A20:A20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[19, 2] = "Product Description";
                oSheet.Cells[19, 2].Font.Name = "Calibri";
                oSheet.Cells[19, 2].Font.Color = Color.Black;
                oRng = oSheet.get_Range("B19:F20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[19, 7] = "Back";
                oSheet.Cells[19, 7].Font.Name = "Calibri";
                oSheet.Cells[19, 7].Font.Color = Color.Black;
                oRng = oSheet.get_Range("G19:G19");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oSheet.Cells[20, 7] = "Order";
                oSheet.Cells[20, 7].Font.Name = "Calibri";
                oSheet.Cells[20, 7].Font.Color = Color.Black;
                oRng = oSheet.get_Range("G20:G20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[19, 8] = "Quantity";
                oSheet.Cells[19, 8].Font.Name = "Calibri";
                oSheet.Cells[19, 8].Font.Color = Color.Black;
                oRng = oSheet.get_Range("H19:H19");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oSheet.Cells[20, 8] = "Ordered";
                oSheet.Cells[20, 8].Font.Name = "Calibri";
                oSheet.Cells[20, 8].Font.Color = Color.Black;
                oRng = oSheet.get_Range("H20:H20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[19, 9] = "Quantity";
                oSheet.Cells[19, 9].Font.Name = "Calibri";
                oSheet.Cells[19, 9].Font.Color = Color.Black;
                oRng = oSheet.get_Range("I19:I19");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oSheet.Cells[20, 9] = "Shipped";
                oSheet.Cells[20, 9].Font.Name = "Calibri";
                oSheet.Cells[20, 9].Font.Color = Color.Black;
                oRng = oSheet.get_Range("I20:I20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;

                oSheet.Cells[19, 10] = "Price";
                oSheet.Cells[19, 10].Font.Name = "Calibri";
                oSheet.Cells[19, 10].Font.Color = Color.Black;
                oRng = oSheet.get_Range("J19:J20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oSheet.Cells[19, 11] = "Extension";
                oSheet.Cells[19, 11].Font.Name = "Calibri";
                oSheet.Cells[19, 11].Font.Color = Color.Black;
                oRng = oSheet.get_Range("K19:K20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oSheet.Cells[19, 12] = "Total";
                oSheet.Cells[19, 12].Font.Name = "Calibri";
                oSheet.Cells[19, 12].Font.Color = Color.Black;
                oRng = oSheet.get_Range("L19:L20");
                oRng.Merge(Missing.Value);
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;

                oRng = oSheet.get_Range("A21:A51");
                
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Color = Color.Black;
               
                oRng = oSheet.get_Range("B21:F21");
                oRng.Merge(Missing.Value);
                
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("B21:F21", "B51:F51").FillDown();

                oRng = oSheet.get_Range("G21:G21");
                oRng.Merge(Missing.Value);

                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("G21:G21", "G51:G51").FillDown();

                oRng = oSheet.get_Range("H21:H21");
                oRng.Merge(Missing.Value);

                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("H21:H21", "H51:H51").FillDown();

                oRng = oSheet.get_Range("I21:I21");
                oRng.Merge(Missing.Value);

                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("I21:I21", "I51:I51").FillDown();

                oRng = oSheet.get_Range("J21:J21");
                oRng.Merge(Missing.Value);

                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("J21:J21", "J51:J51").FillDown();

                oRng = oSheet.get_Range("K21:K21");
                oRng.Merge(Missing.Value);

                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("K21:K21", "K51:K51").FillDown();

                oRng = oSheet.get_Range("L21:L21");
                oRng.Merge(Missing.Value);

                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeRight].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeLeft].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                oRng.Borders[Excel.XlBordersIndex.xlEdgeTop].Color = Color.Black;
                oSheet.get_Range("L21:L21", "L51:L51").FillDown();

                oRng = oSheet.get_Range("A1:L51");
                oRng.Cells.Interior.Color = Color.White;

                
                #endregion
                //oSheet.get_Range("A1", "D1").Font.Name = "Monotype Corsiva";
                #endregion
                #endregion
            }
            catch { }

            //MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            //pnl.DrawToBitmap(MemoryImage, new System.Drawing.Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            //if (MemoryImage != null)
            //{
            //    e.Graphics.DrawImage(MemoryImage, 0, 0);
            //    base.OnPaint(e);
            //}
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
        //    System.Drawing.Rectangle pagearea = e.PageBounds;
        //    e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel.Width / 2), this.panel.Location.Y);
           
        }
        public void Print(Panel pnl)
        {
            //panel = pnl;
            GetPrintArea(pnl);
            //printPrev.Document = printDoc;
            //printPrev.UseAntiAlias = false;
            //printPrev.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panel);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            
            cf.TopLevel = false;
            panel.Controls.Add(cf);
            cf.Show();
        }
    }
}
