﻿namespace AutoTradDH
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.loginButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.logoutBt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NAMElb = new System.Windows.Forms.Label();
            this.IDlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCodeText = new System.Windows.Forms.TextBox();
            this.ItemSerchbt = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.list_realtime = new System.Windows.Forms.ListBox();
            this.dailybt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.serchtx = new System.Windows.Forms.TextBox();
            this.serchbt = new System.Windows.Forms.Button();
            this.stockdatagrid = new System.Windows.Forms.DataGridView();
            this.serchstock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serchstock_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stock_name = new System.Windows.Forms.Label();
            this.stock_nowprice = new System.Windows.Forms.Label();
            this.stock_cplastday = new System.Windows.Forms.Label();
            this.stock_deal = new System.Windows.Forms.Label();
            this.stock_updown = new System.Windows.Forms.Label();
            this.deal = new System.Windows.Forms.TabControl();
            this.deal_buy = new System.Windows.Forms.TabPage();
            this.buybt = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.매수주문가격textbox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.매수종목코드textbox = new System.Windows.Forms.TextBox();
            this.매수종목이름textbox = new System.Windows.Forms.TextBox();
            this.매수주문수량textbox = new System.Windows.Forms.NumericUpDown();
            this.매수거래구분combox = new System.Windows.Forms.ComboBox();
            this.deal_sell = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.매도주문가격value = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.매도종목이름textbox = new System.Windows.Forms.TextBox();
            this.매도주문수량value = new System.Windows.Forms.NumericUpDown();
            this.매도거래구분value = new System.Windows.Forms.ComboBox();
            this.매도종목코드textbox = new System.Windows.Forms.TextBox();
            this.sellbt = new System.Windows.Forms.Button();
            this.deal_change = new System.Windows.Forms.TabPage();
            this.changbt = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.잔고page = new System.Windows.Forms.TabPage();
            this.미체결page = new System.Windows.Forms.TabPage();
            this.잔고datagrid = new System.Windows.Forms.DataGridView();
            this.미체결datagrid = new System.Windows.Forms.DataGridView();
            this.잔고미채결bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockdatagrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.deal.SuspendLayout();
            this.deal_buy.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매수주문가격textbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.매수주문수량textbox)).BeginInit();
            this.deal_sell.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매도주문가격value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.매도주문수량value)).BeginInit();
            this.deal_change.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.잔고page.SuspendLayout();
            this.미체결page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.잔고datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.미체결datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 12);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(37, 68);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(934, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 148);
            this.listBox1.TabIndex = 2;
            // 
            // logoutBt
            // 
            this.logoutBt.Location = new System.Drawing.Point(37, 98);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(75, 23);
            this.logoutBt.TabIndex = 3;
            this.logoutBt.Text = "로그아웃";
            this.logoutBt.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(662, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // NAMElb
            // 
            this.NAMElb.AutoSize = true;
            this.NAMElb.Location = new System.Drawing.Point(946, 31);
            this.NAMElb.Name = "NAMElb";
            this.NAMElb.Size = new System.Drawing.Size(29, 12);
            this.NAMElb.TabIndex = 5;
            this.NAMElb.Text = "이름";
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Location = new System.Drawing.Point(1055, 31);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(41, 12);
            this.IDlb.TabIndex = 6;
            this.IDlb.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1172, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "종목코드";
            // 
            // itemCodeText
            // 
            this.itemCodeText.Location = new System.Drawing.Point(1227, 28);
            this.itemCodeText.Name = "itemCodeText";
            this.itemCodeText.Size = new System.Drawing.Size(100, 21);
            this.itemCodeText.TabIndex = 8;
            // 
            // ItemSerchbt
            // 
            this.ItemSerchbt.Location = new System.Drawing.Point(1333, 26);
            this.ItemSerchbt.Name = "ItemSerchbt";
            this.ItemSerchbt.Size = new System.Drawing.Size(75, 23);
            this.ItemSerchbt.TabIndex = 9;
            this.ItemSerchbt.Text = "조회";
            this.ItemSerchbt.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(1174, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(234, 400);
            this.listBox2.TabIndex = 10;
            // 
            // list_realtime
            // 
            this.list_realtime.FormattingEnabled = true;
            this.list_realtime.ItemHeight = 12;
            this.list_realtime.Location = new System.Drawing.Point(934, 230);
            this.list_realtime.Name = "list_realtime";
            this.list_realtime.Size = new System.Drawing.Size(229, 280);
            this.list_realtime.TabIndex = 11;
            // 
            // dailybt
            // 
            this.dailybt.Location = new System.Drawing.Point(1199, 493);
            this.dailybt.Name = "dailybt";
            this.dailybt.Size = new System.Drawing.Size(85, 28);
            this.dailybt.TabIndex = 12;
            this.dailybt.Text = "일봉조회";
            this.dailybt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1172, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "기준일자(ex 20180709)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1199, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1199, 527);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "연속조회";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(662, 50);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(266, 448);
            this.listBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "계좌번호";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.serchtx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.serchbt, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(119, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 31);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // serchtx
            // 
            this.serchtx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchtx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serchtx.Location = new System.Drawing.Point(3, 3);
            this.serchtx.Name = "serchtx";
            this.serchtx.Size = new System.Drawing.Size(98, 21);
            this.serchtx.TabIndex = 0;
            // 
            // serchbt
            // 
            this.serchbt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchbt.Location = new System.Drawing.Point(107, 3);
            this.serchbt.Name = "serchbt";
            this.serchbt.Size = new System.Drawing.Size(99, 25);
            this.serchbt.TabIndex = 1;
            this.serchbt.Text = "종목검색";
            this.serchbt.UseVisualStyleBackColor = true;
            // 
            // stockdatagrid
            // 
            this.stockdatagrid.AllowUserToAddRows = false;
            this.stockdatagrid.AllowUserToDeleteRows = false;
            this.stockdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serchstock_code,
            this.serchstock_name});
            this.stockdatagrid.Location = new System.Drawing.Point(118, 68);
            this.stockdatagrid.Name = "stockdatagrid";
            this.stockdatagrid.RowHeadersVisible = false;
            this.stockdatagrid.RowTemplate.Height = 23;
            this.stockdatagrid.Size = new System.Drawing.Size(240, 512);
            this.stockdatagrid.TabIndex = 19;
            this.stockdatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockdatagrid_CellClick);
            // 
            // serchstock_code
            // 
            this.serchstock_code.HeaderText = "종목코드";
            this.serchstock_code.Name = "serchstock_code";
            this.serchstock_code.ReadOnly = true;
            // 
            // serchstock_name
            // 
            this.serchstock_name.HeaderText = "종목명";
            this.serchstock_name.Name = "serchstock_name";
            this.serchstock_name.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.stock_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.stock_nowprice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.stock_cplastday, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.stock_deal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.stock_updown, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(374, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 130);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 28);
            this.label10.TabIndex = 6;
            this.label10.Text = "등락율";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "종목이름";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "현재가";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "전일대비";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "거래량";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_name
            // 
            this.stock_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_name.AutoSize = true;
            this.stock_name.Location = new System.Drawing.Point(103, 1);
            this.stock_name.Name = "stock_name";
            this.stock_name.Size = new System.Drawing.Size(93, 24);
            this.stock_name.TabIndex = 5;
            this.stock_name.Text = "-";
            this.stock_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_nowprice
            // 
            this.stock_nowprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_nowprice.AutoSize = true;
            this.stock_nowprice.Location = new System.Drawing.Point(103, 26);
            this.stock_nowprice.Name = "stock_nowprice";
            this.stock_nowprice.Size = new System.Drawing.Size(93, 24);
            this.stock_nowprice.TabIndex = 4;
            this.stock_nowprice.Text = "-";
            this.stock_nowprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_cplastday
            // 
            this.stock_cplastday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_cplastday.AutoSize = true;
            this.stock_cplastday.Location = new System.Drawing.Point(103, 51);
            this.stock_cplastday.Name = "stock_cplastday";
            this.stock_cplastday.Size = new System.Drawing.Size(93, 24);
            this.stock_cplastday.TabIndex = 7;
            this.stock_cplastday.Text = "-";
            this.stock_cplastday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_deal
            // 
            this.stock_deal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_deal.AutoSize = true;
            this.stock_deal.Location = new System.Drawing.Point(103, 76);
            this.stock_deal.Name = "stock_deal";
            this.stock_deal.Size = new System.Drawing.Size(93, 24);
            this.stock_deal.TabIndex = 8;
            this.stock_deal.Text = "-";
            this.stock_deal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_updown
            // 
            this.stock_updown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock_updown.AutoSize = true;
            this.stock_updown.Location = new System.Drawing.Point(103, 101);
            this.stock_updown.Name = "stock_updown";
            this.stock_updown.Size = new System.Drawing.Size(93, 28);
            this.stock_updown.TabIndex = 9;
            this.stock_updown.Text = "-";
            this.stock_updown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deal
            // 
            this.deal.Controls.Add(this.deal_buy);
            this.deal.Controls.Add(this.deal_sell);
            this.deal.Controls.Add(this.deal_change);
            this.deal.Location = new System.Drawing.Point(374, 252);
            this.deal.Name = "deal";
            this.deal.SelectedIndex = 0;
            this.deal.Size = new System.Drawing.Size(200, 291);
            this.deal.TabIndex = 21;
            // 
            // deal_buy
            // 
            this.deal_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deal_buy.Controls.Add(this.buybt);
            this.deal_buy.Controls.Add(this.tableLayoutPanel3);
            this.deal_buy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deal_buy.Location = new System.Drawing.Point(4, 22);
            this.deal_buy.Name = "deal_buy";
            this.deal_buy.Padding = new System.Windows.Forms.Padding(3);
            this.deal_buy.Size = new System.Drawing.Size(192, 265);
            this.deal_buy.TabIndex = 0;
            this.deal_buy.Text = "매수";
            // 
            // buybt
            // 
            this.buybt.Location = new System.Drawing.Point(22, 174);
            this.buybt.Name = "buybt";
            this.buybt.Size = new System.Drawing.Size(138, 41);
            this.buybt.TabIndex = 2;
            this.buybt.Text = "매수 주문";
            this.buybt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.24051F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.75949F));
            this.tableLayoutPanel3.Controls.Add(this.매수주문가격textbox, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.매수종목코드textbox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.매수종목이름textbox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.매수주문수량textbox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.매수거래구분combox, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(159, 153);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // 매수주문가격textbox
            // 
            this.매수주문가격textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수주문가격textbox.Location = new System.Drawing.Point(66, 94);
            this.매수주문가격textbox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.매수주문가격textbox.Name = "매수주문가격textbox";
            this.매수주문가격textbox.Size = new System.Drawing.Size(89, 21);
            this.매수주문가격textbox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 31);
            this.label12.TabIndex = 3;
            this.label12.Text = "거래구분";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "주문가격";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "주문수량";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "종목이름";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "종목코드";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 매수종목코드textbox
            // 
            this.매수종목코드textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수종목코드textbox.Location = new System.Drawing.Point(66, 4);
            this.매수종목코드textbox.Name = "매수종목코드textbox";
            this.매수종목코드textbox.Size = new System.Drawing.Size(89, 21);
            this.매수종목코드textbox.TabIndex = 5;
            // 
            // 매수종목이름textbox
            // 
            this.매수종목이름textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수종목이름textbox.Location = new System.Drawing.Point(66, 34);
            this.매수종목이름textbox.Name = "매수종목이름textbox";
            this.매수종목이름textbox.Size = new System.Drawing.Size(89, 21);
            this.매수종목이름textbox.TabIndex = 6;
            // 
            // 매수주문수량textbox
            // 
            this.매수주문수량textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수주문수량textbox.Location = new System.Drawing.Point(66, 64);
            this.매수주문수량textbox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.매수주문수량textbox.Name = "매수주문수량textbox";
            this.매수주문수량textbox.Size = new System.Drawing.Size(89, 21);
            this.매수주문수량textbox.TabIndex = 7;
            // 
            // 매수거래구분combox
            // 
            this.매수거래구분combox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매수거래구분combox.FormattingEnabled = true;
            this.매수거래구분combox.Items.AddRange(new object[] {
            "00:지정가",
            "03:시장가"});
            this.매수거래구분combox.Location = new System.Drawing.Point(66, 124);
            this.매수거래구분combox.Name = "매수거래구분combox";
            this.매수거래구분combox.Size = new System.Drawing.Size(89, 20);
            this.매수거래구분combox.TabIndex = 9;
            this.매수거래구분combox.Text = "선택";
            // 
            // deal_sell
            // 
            this.deal_sell.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deal_sell.Controls.Add(this.tableLayoutPanel4);
            this.deal_sell.Controls.Add(this.sellbt);
            this.deal_sell.Location = new System.Drawing.Point(4, 22);
            this.deal_sell.Name = "deal_sell";
            this.deal_sell.Padding = new System.Windows.Forms.Padding(3);
            this.deal_sell.Size = new System.Drawing.Size(192, 265);
            this.deal_sell.TabIndex = 1;
            this.deal_sell.Text = "매도";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.24051F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.75949F));
            this.tableLayoutPanel4.Controls.Add(this.매도주문가격value, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.매도종목이름textbox, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.매도주문수량value, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.매도거래구분value, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.매도종목코드textbox, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(21, 15);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(159, 153);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // 매도주문가격value
            // 
            this.매도주문가격value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매도주문가격value.Location = new System.Drawing.Point(66, 94);
            this.매도주문가격value.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.매도주문가격value.Name = "매도주문가격value";
            this.매도주문가격value.Size = new System.Drawing.Size(89, 21);
            this.매도주문가격value.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 31);
            this.label14.TabIndex = 3;
            this.label14.Text = "거래구분";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 29);
            this.label15.TabIndex = 2;
            this.label15.Text = "주문가격";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 29);
            this.label16.TabIndex = 1;
            this.label16.Text = "주문수량";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = "종목이름";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 29);
            this.label18.TabIndex = 4;
            this.label18.Text = "종목코드";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 매도종목이름textbox
            // 
            this.매도종목이름textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매도종목이름textbox.Location = new System.Drawing.Point(66, 34);
            this.매도종목이름textbox.Name = "매도종목이름textbox";
            this.매도종목이름textbox.Size = new System.Drawing.Size(89, 21);
            this.매도종목이름textbox.TabIndex = 6;
            // 
            // 매도주문수량value
            // 
            this.매도주문수량value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매도주문수량value.Location = new System.Drawing.Point(66, 64);
            this.매도주문수량value.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.매도주문수량value.Name = "매도주문수량value";
            this.매도주문수량value.Size = new System.Drawing.Size(89, 21);
            this.매도주문수량value.TabIndex = 7;
            // 
            // 매도거래구분value
            // 
            this.매도거래구분value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매도거래구분value.FormattingEnabled = true;
            this.매도거래구분value.Items.AddRange(new object[] {
            "00:지정가",
            "03:시장가"});
            this.매도거래구분value.Location = new System.Drawing.Point(66, 124);
            this.매도거래구분value.Name = "매도거래구분value";
            this.매도거래구분value.Size = new System.Drawing.Size(89, 20);
            this.매도거래구분value.TabIndex = 9;
            this.매도거래구분value.Text = "선택";
            // 
            // 매도종목코드textbox
            // 
            this.매도종목코드textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.매도종목코드textbox.Location = new System.Drawing.Point(66, 4);
            this.매도종목코드textbox.Name = "매도종목코드textbox";
            this.매도종목코드textbox.Size = new System.Drawing.Size(89, 21);
            this.매도종목코드textbox.TabIndex = 5;
            // 
            // sellbt
            // 
            this.sellbt.Location = new System.Drawing.Point(21, 174);
            this.sellbt.Name = "sellbt";
            this.sellbt.Size = new System.Drawing.Size(138, 41);
            this.sellbt.TabIndex = 3;
            this.sellbt.Text = "매도 주문";
            this.sellbt.UseVisualStyleBackColor = true;
            // 
            // deal_change
            // 
            this.deal_change.BackColor = System.Drawing.Color.PaleGreen;
            this.deal_change.Controls.Add(this.changbt);
            this.deal_change.Controls.Add(this.tableLayoutPanel5);
            this.deal_change.Location = new System.Drawing.Point(4, 22);
            this.deal_change.Name = "deal_change";
            this.deal_change.Padding = new System.Windows.Forms.Padding(3);
            this.deal_change.Size = new System.Drawing.Size(192, 265);
            this.deal_change.TabIndex = 2;
            this.deal_change.Text = "정정";
            // 
            // changbt
            // 
            this.changbt.Location = new System.Drawing.Point(26, 150);
            this.changbt.Name = "changbt";
            this.changbt.Size = new System.Drawing.Size(138, 41);
            this.changbt.TabIndex = 3;
            this.changbt.Text = "매수 주문";
            this.changbt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.56522F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(161, 115);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.잔고page);
            this.tabControl1.Controls.Add(this.미체결page);
            this.tabControl1.Location = new System.Drawing.Point(121, 603);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 185);
            this.tabControl1.TabIndex = 22;
            this.tabControl1.TabStop = false;
            // 
            // 잔고page
            // 
            this.잔고page.Controls.Add(this.잔고datagrid);
            this.잔고page.Location = new System.Drawing.Point(4, 22);
            this.잔고page.Name = "잔고page";
            this.잔고page.Padding = new System.Windows.Forms.Padding(3);
            this.잔고page.Size = new System.Drawing.Size(756, 159);
            this.잔고page.TabIndex = 0;
            this.잔고page.Text = "잔고";
            this.잔고page.UseVisualStyleBackColor = true;
            // 
            // 미체결page
            // 
            this.미체결page.Controls.Add(this.미체결datagrid);
            this.미체결page.Location = new System.Drawing.Point(4, 22);
            this.미체결page.Name = "미체결page";
            this.미체결page.Padding = new System.Windows.Forms.Padding(3);
            this.미체결page.Size = new System.Drawing.Size(756, 159);
            this.미체결page.TabIndex = 1;
            this.미체결page.Text = "미체결";
            this.미체결page.UseVisualStyleBackColor = true;
            // 
            // 잔고datagrid
            // 
            this.잔고datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.잔고datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.잔고datagrid.Location = new System.Drawing.Point(0, 0);
            this.잔고datagrid.Name = "잔고datagrid";
            this.잔고datagrid.RowTemplate.Height = 23;
            this.잔고datagrid.Size = new System.Drawing.Size(756, 163);
            this.잔고datagrid.TabIndex = 0;
            // 
            // 미체결datagrid
            // 
            this.미체결datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.미체결datagrid.Location = new System.Drawing.Point(0, 0);
            this.미체결datagrid.Name = "미체결datagrid";
            this.미체결datagrid.RowTemplate.Height = 23;
            this.미체결datagrid.Size = new System.Drawing.Size(756, 159);
            this.미체결datagrid.TabIndex = 0;
            // 
            // 잔고미채결bt
            // 
            this.잔고미채결bt.BackColor = System.Drawing.Color.White;
            this.잔고미채결bt.Location = new System.Drawing.Point(382, 556);
            this.잔고미채결bt.Name = "잔고미채결bt";
            this.잔고미채결bt.Size = new System.Drawing.Size(154, 47);
            this.잔고미채결bt.TabIndex = 23;
            this.잔고미채결bt.Text = "잔고미채결조회";
            this.잔고미채결bt.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1420, 812);
            this.Controls.Add(this.잔고미채결bt);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.deal);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.stockdatagrid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dailybt);
            this.Controls.Add(this.list_realtime);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ItemSerchbt);
            this.Controls.Add(this.itemCodeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDlb);
            this.Controls.Add(this.NAMElb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.logoutBt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.axKHOpenAPI1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "종목검색";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockdatagrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.deal.ResumeLayout(false);
            this.deal_buy.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매수주문가격textbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.매수주문수량textbox)).EndInit();
            this.deal_sell.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.매도주문가격value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.매도주문수량value)).EndInit();
            this.deal_change.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.잔고page.ResumeLayout(false);
            this.미체결page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.잔고datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.미체결datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button logoutBt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label NAMElb;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemCodeText;
        private System.Windows.Forms.Button ItemSerchbt;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox list_realtime;
        private System.Windows.Forms.Button dailybt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox serchtx;
        private System.Windows.Forms.Button serchbt;
        private System.Windows.Forms.DataGridView stockdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn serchstock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn serchstock_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label stock_name;
        private System.Windows.Forms.Label stock_nowprice;
        private System.Windows.Forms.Label stock_cplastday;
        private System.Windows.Forms.Label stock_deal;
        private System.Windows.Forms.Label stock_updown;
        private System.Windows.Forms.TabControl deal;
        private System.Windows.Forms.TabPage deal_buy;
        private System.Windows.Forms.TabPage deal_sell;
        private System.Windows.Forms.TabPage deal_change;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buybt;
        private System.Windows.Forms.Button sellbt;
        private System.Windows.Forms.Button changbt;
        private System.Windows.Forms.NumericUpDown 매수주문가격textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox 매수종목코드textbox;
        private System.Windows.Forms.TextBox 매수종목이름textbox;
        private System.Windows.Forms.NumericUpDown 매수주문수량textbox;
        private System.Windows.Forms.ComboBox 매수거래구분combox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown 매도주문가격value;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox 매도종목이름textbox;
        private System.Windows.Forms.NumericUpDown 매도주문수량value;
        private System.Windows.Forms.ComboBox 매도거래구분value;
        private System.Windows.Forms.TextBox 매도종목코드textbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 잔고page;
        private System.Windows.Forms.DataGridView 잔고datagrid;
        private System.Windows.Forms.TabPage 미체결page;
        private System.Windows.Forms.DataGridView 미체결datagrid;
        private System.Windows.Forms.Button 잔고미채결bt;
    }
}

