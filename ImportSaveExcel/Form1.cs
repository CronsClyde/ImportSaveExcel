using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics.Eventing.Reader;

namespace ImportSaveExcel
{
    public partial class Form1 : Form
    {
        System.Data.DataSet _ds = new System.Data.DataSet();
        string[] _starry = new string[0];
        DataGridView[] _grdArray = new DataGridView[0];

        public Form1()
        {
            InitializeComponent();
            initEvent();
        }

        private void initEvent()
        {
            this.Load += form1_load;
            btnLoad.Click += btnLoad_click;

            btnResult.Click += btnResult_Click;
        }

        private void form1_load(object sender, EventArgs e)
        {
            //grdExcel.RowHeadersVisible = false;
            ////grdExcel.ColumnHeadersVisible = true;
            //grdExcel.AllowUserToAddRows = false;
            //grdExcel.RowSelectorVisibleStyle
            //    rdOrd.RowSelectorVisibleStyle(RowSelectorStyle.RowIndex);
            //grdOrd.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect;
        }

        private void btnLoad_click(object sender, EventArgs e)
        {
            txtLocation.Text = "";
            _ds = ImportExcel();
            if(_ds != null) ImportPageTabs(_ds);

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

        private void grdExcel_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewImageCell cell = (DataGridViewImageCell)
            //    grdExcel.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            
            string headerText = _grdArray[tabExcelLayout.SelectedIndex].Columns[e.ColumnIndex].HeaderText;
            string rowIndex = Convert.ToString(e.RowIndex);

            txtLocation.Text = headerText + " , " + rowIndex;



            if (txtLocation.Text.Trim().Length > 0)
            {
                //_starry = new string[_dt.Rows.Count];

                System.Data.DataTable dt = _ds.Tables[tabExcelLayout.SelectedIndex];
                _starry = new string[dt.Rows.Count];

                //int i = 0;

                //foreach (DataRow dr in _dt.Rows)
                //{
                //    starry[i] = Convert.ToString(dr[headerText]);
                //    i++;
                //}

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (e.RowIndex + i >= dt.Rows.Count) break;
                    _starry[i] = Convert.ToString(dt.Rows[e.RowIndex + i][e.ColumnIndex]);
                }
            }
        }

        private void btnResult_Click(object sender , EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource == null) return;

                if (txtResult.Visible == false)
                {
                    Form2 f2 = new Form2(_starry);
                    f2.ShowDialog();
                    txtResult.Text = "";

                    if (f2.customQuery != "")
                    {
                        txtResult.Text = f2.customQuery;
                    }
                    else
                    {
                        for (int i = 0; i < _starry.Length; i++)
                        {
                            if (_starry[i] != null && _starry[i].Trim().Length > 0)
                            {
                                txtResult.Text += _starry[i] + Environment.NewLine;
                            }
                        }
                    }

                    tabExcelLayout.SelectedIndex = 0;

                    txtResult.Dock = DockStyle.Fill;
                    dataGridView1.Visible = false;
                    txtResult.Visible = true;
                    
                }
                else if (txtResult.Visible == true)
                {
                    txtResult.Visible = false;
                    dataGridView1.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("결과창 에러 " + ex.ToString()); }
        }


        private DataSet ImportExcel(string fileName = "")
        {
            try
            {
                clearScreen();

                DataSet excelDataset = new DataSet();

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
                            return null;
                        }
                    }
                }
                FileInfo fi = new FileInfo(fileName);
                if ((fi.Extension == ".xls" | fi.Extension == ".xlsx") == false)
                {
                    return null;
                }

                txtExcelLoad.Text = fileName;
                FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                var enc = CodePagesEncodingProvider.Instance.GetEncoding(1252);
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);

                excelDataset = reader.AsDataSet(new ExcelDataSetConfiguration() //데이터셋 변환하기
                {
                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                    {
                        //Column 자동생성을 무시하고 첫번째 행을 열로 자동 지정.
                        //UseHeaderRow = true,
                    }
                });

                reader.Close();

                return excelDataset;
            }
            catch (Exception ex) { MessageBox.Show("ImportExcel 오류" + ex.ToString());  return null; }
        }

        private void ImportPageTabs(DataSet ds)
        {
            //// Removes the selected tab:  
            //tabExcelLayout.TabPages.Remove(tabExcelLayout.SelectedTab);
            //// Removes all the tabs:  
            //tabExcelLayout.TabPages.Clear();

            try
            {
                //InitializeComponentDataGridView(ds);
                DataGridView[] grdArray = new DataGridView[ds.Tables.Count];

                for (int i = 1; i < ds.Tables.Count; i++)
                {
                    string title = "TabPage " + (i + 1).ToString();
                    TabPage myTabPage = new TabPage(title);
                    tabExcelLayout.TabPages.Add(myTabPage);
                }

                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    InitializeComponentGridView(ref grdArray[i], ds.Tables[i], i);


                    tabExcelLayout.TabPages[i].Controls.Add(grdArray[i]);
                }


                _grdArray = grdArray;
            }
            catch (Exception ex) { MessageBox.Show("ImportPageTabs 오류" + ex.ToString()); }

        }


        private void InitializeComponentGridView(ref DataGridView grd , System.Data.DataTable dt, int i)
        {

            // grd
           switch (i)
            {
                case 0: grd = dataGridView1; break;
                case 1: grd = dataGridView2; break;
                case 2: grd = dataGridView3; break;
                case 3: grd = dataGridView4; break;
                case 4: grd = dataGridView5; break;
                case 5: grd = dataGridView6; break;
                case 6: grd = dataGridView7; break;
                case 7: grd = dataGridView8; break;
                case 8: grd = dataGridView9; break;
                case 9: grd = dataGridView10; break;
                default: break;
            }

            grd.Dock = DockStyle.Fill;
            grd.BackgroundColor = SystemColors.Window;
            grd.RowHeadersVisible = false;
            //grd.ColumnHeadersVisible = true;
            grd.AllowUserToAddRows = false;


            grd.DataSource = dt;
            grd.CellClick += grdExcel_cellClick;
            grd.Visible = true;

        }

        private void clearScreen()
        {
            for (int i = 0; i < tabExcelLayout.TabPages.Count; i++)
            {
                if (i + 1 >= tabExcelLayout.TabPages.Count) break;
                tabExcelLayout.TabPages.Remove(tabExcelLayout.TabPages[i + 1]);
            }

            for (int i = 0; i < _grdArray.Length; i++)
            {
                _grdArray[i].Columns.Clear();
               if(_grdArray[i].Rows.Count > 0) _grdArray[i].Rows.Clear();
                _grdArray[i].Refresh();
                _grdArray[i].DataSource = null;
            }


        }


    }

}
