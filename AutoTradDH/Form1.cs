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

        List<미체결> 미체결리스트;
        List<주식잔고> 주식잔고리스트;
        public Form1()
        {
            InitializeComponent();
            this.loginButton.Click += this.ButtonCliked;
            this.logoutBt.Click += this.ButtonCliked;
            this.ItemSerchbt.Click += this.ButtonCliked;

            this.serchbt.Click += this.ButtonCliked;
            //일봉차트 클릭
            this.dailybt.Click += this.ButtonCliked;

            //매수주문
            this.buybt.Click += this.ButtonCliked;
            //매도주문
            this.sellbt.Click += this.ButtonCliked;

            //계좌잔고조회클릭
            this.잔고미채결bt.Click += this.ButtonCliked;

            //로그인
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
            else if (sender.Equals(this.serchbt))
            {
                if (this.serchtx.Text.Trim().Length == 6)
                {
                    axKHOpenAPI1.SetInputValue("종목코드", this.serchtx.Text.Trim());
                    axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "55");
                }
                else
                {
                    MessageBox.Show("종목코드를 6자리에 맞게 입력하세요");
                }
            }
            else if (sender.Equals(this.buybt))
            {
                //매수버튼클릭시
                if(this.매수주문가격textbox.Value >0 && this.매수주문수량textbox.Value>0&& this.매수종목코드textbox.Text.Length > 0 && this.comboBox1.Text.Length > 0)
                {
                    String 계좌번호 = comboBox1.Text;
                    String 종목코드 = 매수종목코드textbox.Text;
                    int 주문수량 = int.Parse(매수주문수량textbox.Value.ToString());
                    int 주문가격 = int.Parse(매수주문가격textbox.Value.ToString());
                    String[] 거래구분목록 = 매수거래구분combox.Text.Split(':');
                    String 거래구분 = 거래구분목록[0];

                    int result =  axKHOpenAPI1.SendOrder("현금매수주문", "5001", 계좌번호, 1, 종목코드, 주문수량, 주문가격, 거래구분, "");
                    if(result == 0)
                    {
                        MessageBox.Show("주문성공");
                    }
                }
            }
            else if (sender.Equals(this.sellbt))
            {
                //매도버튼클릭시
                if(this.매도주문가격value.Value > 0 && this.매도주문수량value.Value > 0 && this.매도종목코드textbox.Text.Length > 0 && this.comboBox1.Text.Length > 0){
                    String 계좌번호 = comboBox1.Text;
                    String 종목코드 = 매수종목코드textbox.Text;
                    int 주문수량 = int.Parse(매수주문수량textbox.Value.ToString());
                    int 주문가격 = int.Parse(매수주문가격textbox.Value.ToString());
                    String[] 거래구분목록 = 매수거래구분combox.Text.Split(':');
                    String 거래구분 = 거래구분목록[0];

                    axKHOpenAPI1.SendOrder("현금매수주문", "5001", 계좌번호, 2, 종목코드, 주문수량, 주문가격, 거래구분, "");
                }
            }
            else if (sender.Equals(this.잔고미채결bt))
            {
                미체결리스트 = new List<미체결>();
                주식잔고리스트 = new List<주식잔고>();
                //계좌잔고조회
                axKHOpenAPI1.SetInputValue("계좌번호", this.comboBox1.Text);
                axKHOpenAPI1.SetInputValue("비밀번호", "");
                axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                axKHOpenAPI1.SetInputValue("조회구분","2");

                axKHOpenAPI1.CommRqData("계좌잔고조회", "opw00018", 0, "111");

                //미채결조회
                axKHOpenAPI1.SetInputValue("계좌번호", this.comboBox1.Text);
                axKHOpenAPI1.SetInputValue("체결구분", "1");
                axKHOpenAPI1.SetInputValue("매매구분", "0");
                axKHOpenAPI1.CommRqData("실시간미체결요청", "opt10075", 0, "5002");

            }

           
        }

       
        //로그인
        public void axKHOpenAPI1_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                this.listBox1.Items.Add("로그인성공");

                //개인정보
                getlogInfo();


                //주식목록가져오기
                getstocklists();
                
                
            }
            else
                this.listBox1.Items.Add("로그인 실패");

           
        }
        //주식목록가져오기
        private void getstocklists()
        {
            String stockcodelist = axKHOpenAPI1.GetCodeListByMarket("0");
            String[] stockcode = stockcodelist.Split(';');
            for(int i=0; i < stockcode.Length; i++)
            {
                stockdatagrid.Rows.Add();
                stockdatagrid["serchstock_code", i].Value = stockcode[i];
                stockdatagrid["serchstock_name", i].Value = axKHOpenAPI1.GetMasterCodeName(stockcode[i]);

                
            }
        }

        //개인 정보가져오기
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
            if (e.sRQName == "주식기본정보")
            {

                this.listBox2.Items.Add("종목코드" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드"));
                this.listBox2.Items.Add(("종목명     " + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명")).Replace(" ", ""));
                this.listBox2.Items.Add("거래량" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량"));
                this.listBox2.Items.Add("시가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가"));
                this.listBox2.Items.Add("고가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가"));
                this.listBox2.Items.Add("저가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));
                this.listBox2.Items.Add("현재가" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가"));
                this.listBox2.Items.Add("등락율" + axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율"));


            }
            else if (e.sRQName == "주식일봉차트조회")
            {
                int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                for (int i = 0; i < nCnt; i++)
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
            }
            else if (e.sRQName == "계좌평가현황요청")
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
                for (int i = 0; i < nCnt; i++)
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
            else if (e.sRQName == "종목정보요청")
            {
                //종목에정보
                this.stock_name.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Replace(" ", "");
                this.stock_nowprice.Text = string.Format("{0:#,###}", long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Replace("-", "").Trim()));
                this.stock_cplastday.Text = string.Format("{0:#,###}", long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비").Trim()));
                this.stock_deal.Text = string.Format("{0:#,###}", long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량").Trim()));
                this.stock_updown.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim();


                //매수혹은 매도에 올리기
                this.매수종목이름textbox.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Replace(" ", "");
                this.매수종목코드textbox.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                this.매수주문가격textbox.Value = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Replace("-", "").Trim());
                //매도
                this.매도종목이름textbox.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Replace(" ", "");
                this.매도종목코드textbox.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                this.매도주문가격value.Value = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Replace("-", "").Trim());

            }
            else if (e.sRQName == "계좌잔고조회")
            {
                //여러개 가져옴
                int cnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                잔고datagrid.Rows.Clear();
                for (int i = 0; i < cnt; i++)
                {
                    try
                    {
                        string 종목번호 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목번호").Trim();
                        string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                        double 수량 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                        double 매수금 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입가"));
                        double 현재가 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                        double 평가손익 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가손익"));
                        double 수익률 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "수익률(%)"));

                        주식잔고 stocklist = new 주식잔고(종목번호, 종목명, 수량, 매수금, 현재가, 평가손익, 수익률);
                        주식잔고리스트.Add(stocklist);
                    }catch(Exception excp)
                    {
                        Console.WriteLine(excp.ToString());
                    }
                }


                잔고datagrid.DataSource = 주식잔고리스트;

            }
            else if (e.sRQName == "실시간미체결요청")
            {
                int cnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                미체결datagrid.Rows.Clear();
                for(int i = 0; i < cnt; i++)
                {
                    try
                    {
                        string 주문번호 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문번호").Trim();
                        string 종목코드 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                        string 종목명 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                        int 주문수량 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문수량"));
                        int 주문가격 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문가격"));
                        int 현재가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                        int 미체결수량 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "미체결수량"));
                        string 주문구분 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "주문구분").Trim();
                        string 시간 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "시간").Trim();
                        미체결리스트.Add(new 미체결(주문번호, 종목코드, 종목명, 주문수량, 주문가격, 현재가, 미체결수량, 주문구분, 시간));

                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine(exception.ToString());

                    }
                    미체결datagrid.DataSource = 미체결리스트;

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

        //종목목록중 하나 눌렀을때
        private void stockdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String selected_stock_code = "";
            try
            {
                selected_stock_code = stockdatagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }catch(Exception exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
            axKHOpenAPI1.SetInputValue("종목코드", selected_stock_code);
            axKHOpenAPI1.CommRqData("종목정보요청", "opt10001", 0, "5000");

        }


        class 주식잔고
        {
            public string 종목코드 { get; set; }
            public string 종목명 { get; set; }
            public double 수량 { get; set; }
            public double 매수금 { get; set; }
            public double 현재가 { get; set; }
            public double 평가손익 { get; set; }
            public double 수익률 { get; set; }

            public 주식잔고() { }

            public 주식잔고(string 종목번호, string 종목명, double 수량, double 매수금, double 현재가, double 평가손익, double 수익률)
            {
                this.종목코드 = 종목번호;
                this.종목명 = 종목명;
                this.수량 = 수량;
                this.매수금 = 매수금;
                this.현재가 = 현재가;
                this.평가손익 = 평가손익;
                this.수익률 = 수익률;
            }
        }
        class 미체결
        {
            public string 주문번호 { get; set; }
            public string 종목코드 { get; set; }
            public string 종목명 { get; set; }
            public int 주문수량 { get; set; }
            public int 주문가격 { get; set; }
            public int 미체결수량 { get; set; }
            public string 주문구분 { get; set; }
            public string 시간 { get; set; }
            public int 현재가 { get; set; }

            public 미체결()
            {

            }
            public 미체결(string 주문번호, string 종목코드, string 종목명, int 주문수량, int 주문가격, int 현재가, int 미체결수량, string 주문구분, string 시간)
            {
                this.주문번호 = 주문번호;
                this.종목코드 = 종목코드;
                this.종목명 = 종목명;
                this.주문수량 = 주문수량;
                this.주문가격 = 주문가격;
                this.미체결수량 = 미체결수량;
                this.주문구분 = 주문구분;
                this.시간 = 시간;
                this.현재가 = 현재가;

            }
        }


        }
}
