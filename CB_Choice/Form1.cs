using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {

        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]{
            "김밥", "샐러드김밥", "야채김밥", "참치김밥",
            "소고기김밥" ,"계란김밥", "라볶이", "비빔밥",
            "모듬 캠핑 구이"
        };
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < this.SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            this.orgStr = lblResult.Text;
            if(cbList.Items.Count > 0) {
                this.cbList.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtList.Text != "")
            {
                this.cbList.Items.Add(txtList.Text);
                MessageBox.Show("추가되었습니다!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("추가할 항목을 입력해주세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
            this.txtList.Text = "";
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.orgStr + this.cbList.Text;
        }
    }
}
