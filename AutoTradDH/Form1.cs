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
            //일봉차트 클릭
            this.dailybt.Click += this.ButtonCliked;
            this.axKHOpenAPI1.OnEventConnect += this.axKHOpenAPI1_OnEventConnect;
            this.axKHOpenAPI1.OnReceiveTrData += this.axKHOpenAPI1_OnReceiverTrData;
            this.axKHOpenAPI1.OnReceiveRealData += this.axKHOPenAPI_OnReceiveRealData;

            //계좌정보조회
            this.comboBox1.SelectedIndexChanged += this.comboBox_Selecteindexchanged;
        }

        //계좌정보
        private void comboBox_Selecteindexchanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            //계좌정보 입력
            String selecteAccount = (string)comboBox.SelectedItem;
            axKHOpenAPI1.SetInputValue("계좌번호", selecteAccount.Trim());
            axKHOpenAPI1.SetInputValue("비밀번호", "");
            axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");

            this.listBox3.Items.Clear();

            int nRet = axKHOpenAPI1.CommRqData("계좌평가현황요청", "opw00004", 0, "6001");

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
                    
            }else if (sender.Equals(this.dailybt))
            {
                axKHOpenAPI1.SetInputValue("종목코드", this.itemCodeText.Text.Trim());
                axKHOpenAPI1.SetInputValue("기준일자", this.textBox1.Text.Trim());
                axKHOpenAPI1.SetInputValue("수정주가구분", "1");

                int nRet;
                if (!this.checkBox1.Checked)
                    nRet = axKHOpenAPI1.CommRqData("주식일봉차트조회", "opt10081", 0, "1002");
                else
                    nRet = axKHOpenAPI1.CommRqData("주식일봉차트조회", "opt10081", 2, "1002");

                if (nRet == 0)
                    this.listBox1.Items.Add("주식일봉 요청 성공");
                else
                    this.listBox1.Items.Add("주식일봉 요청 실패");
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
                
            }else if(e.sRQName == "주식일봉차트조회")
            {
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                for(int i =0; i < nCnt; i++)
                {
                    this.listBox2.Items.Add("일자" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim());
                    this.listBox2.Items.Add("현재가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim());
                    this.listBox2.Items.Add("거래량" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim());
                    this.listBox2.Items.Add("시가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim());
                    this.listBox2.Items.Add("거기" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim());
                    this.listBox2.Items.Add("저가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "일자").Trim());
                    this.listBox2.Items.Add("=========================구분선=================================");
                    this.listBox2.SelectedIndex = this.listBox2.Items.Count - 1;

                }
            }else if(e.sRQName == "계좌평가현황요청")
            {
                this.listBox3.Items.Add("예수금 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금").Trim()));
                this.listBox3.Items.Add("d+2추정예수금 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "D+2추정예수금").Trim()));
                this.listBox3.Items.Add("유가잔고평가액 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "유가잔고평가액").Trim()));
                this.listBox3.Items.Add("예탁자산평가액 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예탁자산평가액").Trim()));
                this.listBox3.Items.Add("총매입금액 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액").Trim()));
                this.listBox3.Items.Add("추정예탁자산 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산").Trim()));
                this.listBox3.Items.Add("당일투자원금 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자원금").Trim()));
                this.listBox3.Items.Add("당월투자원금 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당월투자원금").Trim()));
                this.listBox3.Items.Add("누적투자원금 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "누적투자원금").Trim()));
                this.listBox3.Items.Add("당일투자손익 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자손익").Trim()));
                this.listBox3.Items.Add("당월투자손익 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당월투자손익").Trim()));
                this.listBox3.Items.Add("누적투자손익 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "누적투자손익").Trim()));
                this.listBox3.Items.Add("당일손익율 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일손익율").Trim()));
                this.listBox3.Items.Add("당월손익율 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당월손익율").Trim()));
                this.listBox3.Items.Add("누적손익율 =" + Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "누적손익율").Trim()));

                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                for(int i=0; i < nCnt; i++)
                {
                    this.listBox3.Items.Add("종목명 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim());
                    this.listBox3.Items.Add("종목코드 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim());
                    this.listBox3.Items.Add("보유수량 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량").Trim());
                    this.listBox3.Items.Add("현재가 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가").Trim());
                    this.listBox3.Items.Add("평가금액 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가금액").Trim());
                    this.listBox3.Items.Add("손익금액 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액").Trim());
                    this.listBox3.Items.Add("손익율 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익율").Trim());
                    this.listBox3.Items.Add("매입금액 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액").Trim());
                    this.listBox3.Items.Add("결제잔고 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "결제잔고").Trim());
                    this.listBox3.Items.Add("금일매수수량 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "금일매수수량").Trim());
                    this.listBox3.Items.Add("금일매도수량 = " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "금일매도수량").Trim());
                    
                }

             
            }
        }

       private void axKHOPenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            this.list_realtime.Items.Add(e.sRealData);
            this.list_realtime.Items.Add(e.sRealKey);
            this.list_realtime.Items.Add(e.sRealType);
            this.list_realtime.Items.Add(axKHOpenAPI1.GetCommRealData(e.sRealData, 10).Trim());
            if(e.sRealType == "주식시세")
            {
                this.list_realtime.Items.Add("현재가 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 10).Trim());
                this.list_realtime.Items.Add("전일대비 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 11).Trim());
                this.list_realtime.Items.Add("등락율 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 12).Trim());
                this.list_realtime.Items.Add("(최우선)매도호가 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 27).Trim());
                this.list_realtime.Items.Add("(최우선)매수호가 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 28).Trim());
                this.list_realtime.Items.Add("누적 거래량 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 13).Trim());
                this.list_realtime.Items.Add("누적 거래대금 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 14).Trim());
                this.list_realtime.Items.Add("시가 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 16).Trim());
                this.list_realtime.Items.Add("고가 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 17).Trim());
                this.list_realtime.Items.Add("저가 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 18).Trim());
                this.list_realtime.Items.Add("전일대비기호 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 25).Trim());
                this.list_realtime.Items.Add("전일거래량대비(계약,주) = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 26).Trim());
                this.list_realtime.Items.Add("거래다금 증감 = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 27).Trim());
                this.list_realtime.Items.Add("전일 거래량댜비(비율) = " + axKHOpenAPI1.GetCommRealData(e.sRealData, 30).Trim());

            }
        }
    }
}
