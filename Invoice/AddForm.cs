using System;
using System.Windows.Forms;

namespace Invoice
{
  public partial class AddForm : Form
  {
    public INVOICE_NUM invoiceNum { get; set; }

    public AddForm()
    {
      InitializeComponent();
    }
    public AddForm(INVOICE_NUM obj)
    {
      InitializeComponent();
      invoiceNum = obj;
    }

    private void AddForm_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(invoiceNum.Year))
      {
        txtYear.Text = (DateTime.Now.Year - 1911).ToString();
      }
      else
      {
        txtYear.Text = invoiceNum.Year;
      }
      txtMonth.Text = invoiceNum.Month;
      txtLetter.Text = invoiceNum.Letter;
      txtStartNum.Text = invoiceNum.StartNum;
      txtEndNum.Text = invoiceNum.EndNum;
      txtCurrentNum.Text = invoiceNum.CurrentNum;
    }

    private void submitBtn_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtYear.Text))
      {
        MessageBox.Show("請輸入年份", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (string.IsNullOrEmpty(txtMonth.Text))
      {
        MessageBox.Show("請輸入月份", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (string.IsNullOrEmpty(txtLetter.Text))
      {
        MessageBox.Show("請輸入字軌", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (string.IsNullOrEmpty(txtStartNum.Text))
      {
        MessageBox.Show("請輸入起始編號", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (string.IsNullOrEmpty(txtEndNum.Text))
      {
        MessageBox.Show("請輸入結束編號", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      invoiceNum.Year = txtYear.Text.Trim();
      invoiceNum.Month = txtMonth.Text.Trim();
      invoiceNum.Letter = txtLetter.Text.Trim();
      invoiceNum.StartNum = txtStartNum.Text.Trim();
      invoiceNum.EndNum = txtEndNum.Text.Trim();
      invoiceNum.CurrentNum = txtCurrentNum.Text.Trim();

      DialogResult = DialogResult.OK;
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }
  }
}
