namespace Invoice
{
  partial class Form1
  {
    /// <summary>
    /// 設計工具所需的變數。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清除任何使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 設計工具產生的程式碼

    /// <summary>
    /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
    /// 這個方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.toolStrip2 = new System.Windows.Forms.ToolStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
      this.monthComboBox = new System.Windows.Forms.ToolStripComboBox();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.searchBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.refreshBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.addBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.editBtn = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.delBtn = new System.Windows.Forms.ToolStripButton();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.verMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.startNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.endNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.currentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.toolStrip2.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToAddRows = false;
      this.dataGridView.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Year,
            this.month,
            this.letter,
            this.startNum,
            this.endNum,
            this.currentNum,
            this.CreateDate});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView.Location = new System.Drawing.Point(0, 101);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridView.RowTemplate.Height = 30;
      this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView.Size = new System.Drawing.Size(656, 349);
      this.dataGridView.TabIndex = 30;
      this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
      // 
      // toolStrip2
      // 
      this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
      this.toolStrip2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.searchTextBox,
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.monthComboBox,
            this.toolStripSeparator6,
            this.searchBtn});
      this.toolStrip2.Location = new System.Drawing.Point(0, 64);
      this.toolStrip2.Name = "toolStrip2";
      this.toolStrip2.Padding = new System.Windows.Forms.Padding(1);
      this.toolStrip2.Size = new System.Drawing.Size(656, 37);
      this.toolStrip2.TabIndex = 33;
      this.toolStrip2.Text = "toolStrip2";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(2);
      this.toolStripLabel1.Size = new System.Drawing.Size(52, 32);
      this.toolStripLabel1.Text = "年度";
      // 
      // searchTextBox
      // 
      this.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.searchTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.searchTextBox.Name = "searchTextBox";
      this.searchTextBox.Size = new System.Drawing.Size(80, 35);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
      // 
      // toolStripLabel3
      // 
      this.toolStripLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.toolStripLabel3.Name = "toolStripLabel3";
      this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(2);
      this.toolStripLabel3.Size = new System.Drawing.Size(52, 32);
      this.toolStripLabel3.Text = "月份";
      // 
      // monthComboBox
      // 
      this.monthComboBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.monthComboBox.Name = "monthComboBox";
      this.monthComboBox.Size = new System.Drawing.Size(100, 35);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
      // 
      // searchBtn
      // 
      this.searchBtn.BackColor = System.Drawing.SystemColors.MenuBar;
      this.searchBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.searchBtn.Image = global::Invoice.Properties.Resources.Zoom_icon;
      this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.searchBtn.Name = "searchBtn";
      this.searchBtn.Padding = new System.Windows.Forms.Padding(2);
      this.searchBtn.Size = new System.Drawing.Size(72, 32);
      this.searchBtn.Text = "查詢";
      this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
      this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshBtn,
            this.toolStripSeparator1,
            this.addBtn,
            this.toolStripSeparator2,
            this.editBtn,
            this.toolStripSeparator3,
            this.delBtn});
      this.toolStrip1.Location = new System.Drawing.Point(0, 27);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Padding = new System.Windows.Forms.Padding(1);
      this.toolStrip1.Size = new System.Drawing.Size(656, 37);
      this.toolStrip1.TabIndex = 32;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // refreshBtn
      // 
      this.refreshBtn.BackColor = System.Drawing.SystemColors.MenuBar;
      this.refreshBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.refreshBtn.Image = global::Invoice.Properties.Resources.Refresh_icon;
      this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.refreshBtn.Name = "refreshBtn";
      this.refreshBtn.Padding = new System.Windows.Forms.Padding(2);
      this.refreshBtn.Size = new System.Drawing.Size(110, 32);
      this.refreshBtn.Text = "重新整理";
      this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
      // 
      // addBtn
      // 
      this.addBtn.BackColor = System.Drawing.SystemColors.MenuBar;
      this.addBtn.Image = global::Invoice.Properties.Resources.Add_icon;
      this.addBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.addBtn.Name = "addBtn";
      this.addBtn.Padding = new System.Windows.Forms.Padding(2);
      this.addBtn.Size = new System.Drawing.Size(72, 32);
      this.addBtn.Text = "新增";
      this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
      // 
      // editBtn
      // 
      this.editBtn.BackColor = System.Drawing.SystemColors.MenuBar;
      this.editBtn.Image = global::Invoice.Properties.Resources.pencil_icon;
      this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.editBtn.Name = "editBtn";
      this.editBtn.Padding = new System.Windows.Forms.Padding(2);
      this.editBtn.Size = new System.Drawing.Size(72, 32);
      this.editBtn.Text = "編輯";
      this.editBtn.ToolTipText = "編輯";
      this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
      // 
      // delBtn
      // 
      this.delBtn.BackColor = System.Drawing.SystemColors.Control;
      this.delBtn.Image = global::Invoice.Properties.Resources.delete_sign;
      this.delBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.delBtn.Name = "delBtn";
      this.delBtn.Padding = new System.Windows.Forms.Padding(2);
      this.delBtn.Size = new System.Drawing.Size(72, 32);
      this.delBtn.Text = "刪除";
      this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenu});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(656, 27);
      this.menuStrip1.TabIndex = 31;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // helpMenu
      // 
      this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMenu});
      this.helpMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.helpMenu.Name = "helpMenu";
      this.helpMenu.Size = new System.Drawing.Size(72, 23);
      this.helpMenu.Text = "說明(H)";
      // 
      // verMenu
      // 
      this.verMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
      this.verMenu.Name = "verMenu";
      this.verMenu.Size = new System.Drawing.Size(138, 24);
      this.verMenu.Text = "目前版本";
      this.verMenu.Click += new System.EventHandler(this.verMenu_Click);
      // 
      // ID
      // 
      this.ID.DataPropertyName = "InvoiceID";
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Visible = false;
      // 
      // Year
      // 
      this.Year.DataPropertyName = "Year";
      this.Year.HeaderText = "年度";
      this.Year.Name = "Year";
      this.Year.ReadOnly = true;
      this.Year.Width = 80;
      // 
      // month
      // 
      this.month.DataPropertyName = "Month";
      this.month.HeaderText = "月份";
      this.month.Name = "month";
      this.month.ReadOnly = true;
      this.month.Width = 80;
      // 
      // letter
      // 
      this.letter.DataPropertyName = "Letter";
      this.letter.HeaderText = "字軌";
      this.letter.Name = "letter";
      this.letter.ReadOnly = true;
      this.letter.Width = 80;
      // 
      // startNum
      // 
      this.startNum.DataPropertyName = "StartNum";
      this.startNum.HeaderText = "起始編號";
      this.startNum.Name = "startNum";
      this.startNum.ReadOnly = true;
      this.startNum.Width = 120;
      // 
      // endNum
      // 
      this.endNum.DataPropertyName = "EndNum";
      this.endNum.HeaderText = "結束編號";
      this.endNum.Name = "endNum";
      this.endNum.ReadOnly = true;
      this.endNum.Width = 120;
      // 
      // currentNum
      // 
      this.currentNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.currentNum.DataPropertyName = "CurrentNum";
      this.currentNum.HeaderText = "目前編號";
      this.currentNum.Name = "currentNum";
      this.currentNum.ReadOnly = true;
      // 
      // CreateDate
      // 
      this.CreateDate.HeaderText = "建立日期";
      this.CreateDate.Name = "CreateDate";
      this.CreateDate.ReadOnly = true;
      this.CreateDate.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 450);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.toolStrip2);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "電子發票字軌維護程式";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.toolStrip2.ResumeLayout(false);
      this.toolStrip2.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.ToolStrip toolStrip2;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripTextBox searchTextBox;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    private System.Windows.Forms.ToolStripComboBox monthComboBox;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripButton searchBtn;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton refreshBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton addBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton editBtn;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton delBtn;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem helpMenu;
    private System.Windows.Forms.ToolStripMenuItem verMenu;
    private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    private System.Windows.Forms.DataGridViewTextBoxColumn month;
    private System.Windows.Forms.DataGridViewTextBoxColumn letter;
    private System.Windows.Forms.DataGridViewTextBoxColumn startNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn endNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn currentNum;
    private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
  }
}

