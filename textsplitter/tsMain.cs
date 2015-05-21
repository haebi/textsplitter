using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charbytearray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCharArr_Click(object sender, EventArgs e)
        {
            txtLog.Clear();

            string msgStr = txtMsg.Text;

            char[] charArr = msgStr.ToCharArray();

            printLog(string.Format("char array length : {0}", charArr.Length));

            string strCount = Convert.ToString(charArr.Length);


            int i = 0;
            foreach (char ch in charArr)
            {
                printLog(string.Format("[{0:D" + strCount.Length + "}] {1}", i, ch));
                i++;
            }
        }



        private void btnByteArr_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodePage.Text.Trim().Length < 1)
                    txtCodePage.Text = "ks_c_5601-1987";

                txtLog.Clear();

                string msgStr = txtMsg.Text;

                System.Text.Encoding AscEnc = System.Text.ASCIIEncoding.GetEncoding(txtCodePage.Text);

                byte[] byteArr = AscEnc.GetBytes(msgStr);
                
                printLog(string.Format("byte array length : {0}", byteArr.Length));

                string strCount = Convert.ToString(byteArr.Length);


                int i = 0;
                foreach (byte by in byteArr)
                {
                    if (chkHex.Checked == true)
                        printLog(string.Format("[{0:D" + strCount.Length + "}] {1:X2}", i, by)); // show as hexcode
                    else
                        printLog(string.Format("[{0:D" + strCount.Length + "}] {1}", i, by)); // show decimal

                    i++;
                }
            }catch(Exception ex)
            {
                txtCodePage.Clear();
                MessageBox.Show(ex.ToString());
            }
        }



        private void printLog(string msg)
        {
            txtLog.Text += msg + "\r\n";
        }




    }
}
