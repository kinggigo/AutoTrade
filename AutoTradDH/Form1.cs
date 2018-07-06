using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTradDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.loginButton.Click += this.ButtonCliked;
            this.logoutBt.Click += this.ButtonCliked;
            this.ItemSerchbt.Click += this.ButtonCliked;
            this.axKHOpenAPI1.OnEventConnect += this.axKHOpenAPI1_OnEventConnect;
            this.axKHOpenAPI1.OnReceiveTrData += this.axKHOpenAPI1_OnReceiverTrData;
        }
        public void ButtonCliked(object sender, EventArgs e)
        {
            if (sender.Equals(this.loginButton))
            {
                if (axKHOpenAPI1.CommConnect() == 0)
                {
                    this.listBox1.Items.Add("로그인 시작");
                }
                else
                    this.listBox1.Items.Add("로그인 실패");
            }else if (sender.Equals(this.logoutBt))
            {
                axKHOpenAPI1.CommTerminate();
                //로그아웃 하는 함수  CommTerminate이제 안먹힘
                this.listBox1.Items.Add(axKHOpenAPI1.GetConnectState());
                if (axKHOpenAPI1.GetConnectState().Equals(0))
                { this.listBox1.Items.Add("로그아웃"); }
            }else if(sender.Equals(this.ItemSerchbt))
            {
                axKHOpenAPI1.SetInputValue("종목코드", this.itemCodeText.Text.Trim());
                
                int nRet = axKHOpenAPI1.CommRqData("주식기본정보", "opt10001", 0, "1001");

                if (nRet == 0)
                {
                    this.listBox1.Items.Add("주식정보요청 성공");
                    this.listBox1.Items.Add(nRet);
                }
                else
                    this.listBox1.Items.Add("주식정보요청 실패");
                    
            }
        }

       

        public void axKHOpenAPI1_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                this.listBox1.Items.Add("로그인성공");
            }
            else
                this.listBox1.Items.Add("로그인 실패");


            getlogInfo();
        }

        private void getlogInfo()
        {
            this.IDlb.Text += this.axKHOpenAPI1.GetLoginInfo("USER_ID");
            this.NAMElb.Text += this.axKHOpenAPI1.GetLoginInfo("USER_NAME");

            String[] accoutarray = this.axKHOpenAPI1.GetLoginInfo("ACCNO").Split(';');

            this.comboBox1.Items.AddRange(accoutarray);
            this.comboBox1.SelectedIndex = 0;

        }

        //요청한 정보에 의한 정보뿌려주기
        private void axKHOpenAPI1_OnReceiverTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

            this.listBox1.Items.Add("e.sRQName = " + e.sRQName);
            if (e.sRQName =="주식기본정보")
            {
                
                    this.listBox2.Items.Add("종목코드" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드"));
                    this.listBox2.Items.Add(("종목명     " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명")).Replace(" ",""));
                    this.listBox2.Items.Add("거래량" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량"));
                    this.listBox2.Items.Add("시가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가"));
                    this.listBox2.Items.Add("고가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가"));
                    this.listBox2.Items.Add("저가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));
                    this.listBox2.Items.Add("현재가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가"));
                    this.listBox2.Items.Add("등락율" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율"));
                
            }
        }


    }
}
