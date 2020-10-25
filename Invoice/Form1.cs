using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Invoice
{
  public partial class Form1 : Form
  {
    private SqlCommandBuilder scb;
    SqlDataAdapter sda;
    DataTable dt;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string[] monthArray = { "全部", "1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月" };
      monthComboBox.ComboBox.DataSource = monthArray;
      LoadData("", "全部");
    }

    //版本資訊
    private void verMenu_Click(object sender, EventArgs e)
    {
      string version = Application.ProductVersion;

      MessageBox.Show($"目前版本為: {version}", "訊息");
    }

    //重新整理
    private void refreshBtn_Click(object sender, EventArgs e)
    {
      searchTextBox.Text = "";
      monthComboBox.SelectedItem = "全部";
      LoadData("", "全部");
    }

    //新增
    private void addBtn_Click(object sender, EventArgs e)
    {
      AddForm addForm = new AddForm
      {
        invoiceNum = new INVOICE_NUM()
      };

      if (addForm.ShowDialog() != DialogResult.OK) return;

      DataRow dr = dt.NewRow();

      dr["Year"] = addForm.invoiceNum.Year;
      dr["Month"] = addForm.invoiceNum.Month;
      dr["Letter"] = addForm.invoiceNum.Letter;
      dr["StartNum"] = addForm.invoiceNum.StartNum;
      dr["EndNum"] = addForm.invoiceNum.EndNum;
      dr["CurrentNum"] = addForm.invoiceNum.CurrentNum;
      dr["CreateDate"] = DateTime.Now;

      dt.Rows.Add(dr);

      scb = new SqlCommandBuilder(sda);
      sda.Update(dt);
    }

    //修改
    private void editBtn_Click(object sender, EventArgs e)
    {
      #region
      //int id = (int)dataGridView.CurrentRow.Cells["ID"].Value;
      //string query = $"select * from INVOICE_NUM where InvoiceID={id}";

      //SqlConnection conn = new SqlConnection(config);
      //SqlCommand cmd = new SqlCommand(query, conn);
      //conn.Open();

      //SqlDataReader dr = cmd.ExecuteReader();

      //INVOICE_NUM invoiceNum = new INVOICE_NUM();

      //while (dr.Read())
      //{
      //  invoiceNum.Year = dr["Year"].ToString();
      //  invoiceNum.Month = dr["Month"].ToString();
      //  invoiceNum.Letter = dr["Letter"].ToString();
      //  invoiceNum.StartNum = dr["StartNum"].ToString();
      //  invoiceNum.EndNum = dr["EndNum"].ToString();
      //  invoiceNum.CurrentNum = dr["CurrentNum"].ToString();
      //}

      //dr.Close();
      //conn.Close();
      #endregion
      int index = dataGridView.CurrentRow.Index;

      if (index == -1) return;

      INVOICE_NUM invoiceNum = new INVOICE_NUM
      {
        Year = dt.Rows[index]["Year"].ToString(),
        Month = dt.Rows[index]["Month"].ToString(),
        Letter = dt.Rows[index]["Letter"].ToString(),
        StartNum = dt.Rows[index]["StartNum"].ToString(),
        EndNum = dt.Rows[index]["EndNum"].ToString(),
        CurrentNum = dt.Rows[index]["CurrentNum"].ToString()
      };

      //透過建構式將資料傳到 AddForm
      AddForm addForm = new AddForm(invoiceNum);

      if (addForm.ShowDialog() != DialogResult.OK) return;

      dt.Rows[index]["Year"] = addForm.invoiceNum.Year;
      dt.Rows[index]["Month"] = addForm.invoiceNum.Month;
      dt.Rows[index]["Letter"] = addForm.invoiceNum.Letter;
      dt.Rows[index]["StartNum"] = addForm.invoiceNum.StartNum;
      dt.Rows[index]["EndNum"] = addForm.invoiceNum.EndNum;
      dt.Rows[index]["CurrentNum"] = addForm.invoiceNum.CurrentNum;
      dt.Rows[index]["CreateDate"] = DateTime.Now;

      scb = new SqlCommandBuilder(sda);//產生update命令
      sda.Update(dt);//將修改的資料寫入資料庫
    }

    //修改(點擊表格)
    private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      int index = dataGridView.CurrentRow.Index;

      if (index == -1) return;

      INVOICE_NUM invoiceNum = new INVOICE_NUM
      {
        Year = dt.Rows[index]["Year"].ToString(),
        Month = dt.Rows[index]["Month"].ToString(),
        Letter = dt.Rows[index]["Letter"].ToString(),
        StartNum = dt.Rows[index]["StartNum"].ToString(),
        EndNum = dt.Rows[index]["EndNum"].ToString(),
        CurrentNum = dt.Rows[index]["CurrentNum"].ToString()
      };

      //透過建構式將資料傳到 AddForm
      AddForm addForm = new AddForm(invoiceNum);

      if (addForm.ShowDialog() != DialogResult.OK) return;

      dt.Rows[index]["Year"] = addForm.invoiceNum.Year;
      dt.Rows[index]["Month"] = addForm.invoiceNum.Month;
      dt.Rows[index]["Letter"] = addForm.invoiceNum.Letter;
      dt.Rows[index]["StartNum"] = addForm.invoiceNum.StartNum;
      dt.Rows[index]["EndNum"] = addForm.invoiceNum.EndNum;
      dt.Rows[index]["CurrentNum"] = addForm.invoiceNum.CurrentNum;
      dt.Rows[index]["CreateDate"] = DateTime.Now;

      scb = new SqlCommandBuilder(sda);//產生update命令
      sda.Update(dt);//將修改的資料寫入資料庫
    }

    //刪除
    private void delBtn_Click(object sender, EventArgs e)
    {
      int index = dataGridView.CurrentRow.Index;

      if (!dataGridView.Rows[index].Selected)
      {
        MessageBox.Show("請點擊整列", "訊息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        return;
      }

      DialogResult result = MessageBox.Show("確定要刪除?", "訊息", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

      if (result != DialogResult.OK) return;

      dt.Rows[index].Delete();
      scb = new SqlCommandBuilder(sda);
      sda.Update(dt);
    }

    //查詢
    private void searchBtn_Click(object sender, EventArgs e)
    {
      string year = searchTextBox.Text;
      string month = monthComboBox.SelectedItem.ToString();
      LoadData(year, month);
    }

    /// <summary>
    /// 載入資料
    /// </summary>
    /// <param name="year">年度</param>
    /// <param name="month">月份</param>
    private void LoadData(string year, string month)
    {
      dataGridView.AutoGenerateColumns = false;
      string config = @"Data Source=.\SQLEXPRESS;Initial Catalog=Demo;Integrated Security=True";
      string query = "select * from INVOICE_NUM where 1=1";

      if (!string.IsNullOrEmpty(year))
      {
        query += $" and Year='{year}'";
      }

      if (month != "全部")
      {
        query += $" and Month='{month}'";
      }

      SqlConnection conn = new SqlConnection(config);
      sda = new SqlDataAdapter(query, conn);
      dt = new DataTable();
      sda.Fill(dt);
      dataGridView.DataSource = dt;
    }
  }
}
