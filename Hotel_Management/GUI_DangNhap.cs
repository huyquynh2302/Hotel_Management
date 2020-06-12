using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Hotel;
using BUS_Hotel;

namespace Hotel_Management
{
    public partial class GUI_DangNhap : Form
    {
        BUS_DangKi busdn = new BUS_DangKi();
        public GUI_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != "" && txtPass.Text != "")
            {
                DTO_DangKi dn = new DTO_DangKi(txtUser.Text, txtPass.Text);
                if(busdn.DangNhap(dn))
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("Meo cho vo!");
                }
            }
            else
            {
                MessageBox.Show("dien day du!");
            }
        }
    }
}
