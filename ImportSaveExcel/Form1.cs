using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace ImportSaveExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initEvent();
        }

        private void initEvent()
        {
            this.Load += form1_load;
            btnLoad.Click += btnLoad_click;
        }

        private void form1_load(object sender, EventArgs e)
        {
            //grdExcel.RowSelectorVisibleStyle
            //    rdOrd.RowSelectorVisibleStyle(RowSelectorStyle.RowIndex);
            //grdOrd.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
        }

        private void btnLoad_click(object sender, EventArgs e)
        {

            Import_Excel(grdExcel);

            ////File 경로
            //string filepath = txtExcelLoad.Text;

            ////APP 연결, WORKBOOK 설정, WORKSHEET 설정 
            //Microsoft.Office.Interop.Excel.Application _app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook _workbook = _app.Workbooks.Open(filepath, 0, true, 5, "", ":", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            ////첫 번째 SHEET 사용 / 만약 2번째 SHEET 사용 시 .get_Item(2) 
            //Microsoft.Office.Interop.Excel.Worksheet _worksheet = (Microsoft.Office.Interop.Excel.Worksheet)_workbook.Worksheets.get_Item(1);
            //object misvalue = System.Reflection.Missing.Value;

            ////사용되어진 column의 갯수와 row 갯수를 변수로 저장 
            //int column_Count = _worksheet.UsedRange.Columns.Count;
            //int row_Count = _worksheet.UsedRange.Rows.Count;

            //string acolumn = "";
            //string totAcolumn = "";

            ////1번째 줄부터, row_count까지 
            //for (int i = 1; i <= row_Count; i++)
            //{
            //    if (_worksheet.get_Range("A" + i).Value2 == null)
            //        acolumn = "";
            //    else
            //        acolumn = _worksheet.get_Range("A" + i).Value2.ToString();

            //    totAcolumn += acolumn + "','";
            //}
        }


        void Import_Excel(DataGridView grid, string fileName = "")
        {
            if (File.Exists(fileName) == false)
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel workbook|*.xlsx;*.xls", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        fileName = ofd.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            FileInfo fi = new FileInfo(fileName);
            if ((fi.Extension == ".xls" | fi.Extension == ".xlsx") == false)
            {
                return;
            }
            FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            var enc = CodePagesEncodingProvider.Instance.GetEncoding(1252);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);

            DataSet result = reader.AsDataSet();
            reader.Close();
            if (result == null)
            {
                return;
            }
            System.Data.DataTable dt = result.Tables[0];

            grid.DataSource = dt;
            //foreach (DataRow row in dt.Rows)
            //{
            //    if (DBNull.Value.Equals(row.ItemArray[0]) == false)
            //    {

            //        grid.Rows.Add(row.ItemArray);
            //    }
            //}

            string[] starry = new string[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows) 
            {
                starry[i] = Convert.ToString(dr["Column2"]);
                i++;
            }
        }

       
    }

}
