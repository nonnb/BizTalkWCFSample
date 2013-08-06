using System;
using System.Windows.Forms;
using BizTalkServiceClient.BTSService;

namespace BizTalkServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var btsSvc = new BizTalkWCF_AddSuffixService_RcvSuffixServiceClient())
                {
                    var result = btsSvc.SuffixService(new Root
                    {
                        IsAddSuffix = checkBox1.Checked,
                        Name = textBox1.Text
                    });
                    label1.Text = result.ResponseMessage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Oops - {0}", ex.Message));                
            }
        }
    }
}
