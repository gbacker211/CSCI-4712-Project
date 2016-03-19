using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSExcel = Microsoft.Office.Interop.Excel;

namespace SoftwareConfigurationManagementDBApp
{
    class PrintControl
    {
        private DataGridView _dataGrid;

        public PrintControl(DataGridView grid)
        {
            _dataGrid = grid;

        }

        public void ExportGridData()
        {
            if(_dataGrid.ColumnCount > 0)
            { 
                copyGridData();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new MSExcel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (MSExcel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                MSExcel.Range CR = (MSExcel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            else
            {
                MessageBox.Show("No data is selected, please select a view", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void copyGridData()
        {
            _dataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            _dataGrid.MultiSelect = true;

            _dataGrid.SelectAll();
            DataObject dataObject = _dataGrid.GetClipboardContent();
            if (dataObject != null)
                Clipboard.SetDataObject(dataObject);
        }

    }
}
