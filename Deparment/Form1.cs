using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deparment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbDefaultPrice_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Visible = ckbDefaultPrice.Checked;
            txtDefaultPrice.Visible = ckbDefaultPrice.Checked;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;
                string command = string.Empty;

                ecr.Open("Port=" + numLogicPort.Value.ToString());
                if (ckbDefaultPrice.Checked)
                    command = "SETDPT NR=" + numDepartmentNumber.Value.ToString() + ", DES='" + "ΠΕΡΙΒΑΛ. ΤΕΛΟΣ', LIS=1, VAT=" + numVatCode.Value.ToString() + ", PRICE=" + txtDefaultPrice.Text;
                else
                    command = "SETDPT NR=" + numDepartmentNumber.Value.ToString() + ", DES='" + "ΠΕΡΙΒΑΛ. ΤΕΛΟΣ', LIS=1, VAT=" + numVatCode.Value.ToString() + ", PRICE=0.00";
                ecr.EcrCmd("STARTSET", ref result);
                ecr.EcrCmd(command, ref result);

                if (ckbSetKeyboard.Checked)
                {
                    int func = Convert.ToInt32(74 + numDepartmentNumber.Value);
                    string keyCommand = "SETKEYB POS=" + numKeyPosition.Value.ToString() + ", FUNC=" + func.ToString();
                    ecr.EcrCmd(keyCommand, ref result);
                }

                ecr.EcrCmd("ENDSET", ref result);
                ecr.EcrCmd("KEY REG", ref result);
                ecr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ckbSetKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            lblKeyPosition.Visible = ckbSetKeyboard.Checked;
            numKeyPosition.Visible = ckbSetKeyboard.Checked;
        }
    }
}
