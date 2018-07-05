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
            this.axKHOpenAPI1.OnEventConnect += this.axKHOpenAPI1_OnEventConnect;
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

        public void getlogInfo()
        {
            this.axKHOpenAPI1.GetLoginInfo("USER_ID");
            this.axKHOpenAPI1.GetLoginInfo("USER_NAME");
        }





    }
}
