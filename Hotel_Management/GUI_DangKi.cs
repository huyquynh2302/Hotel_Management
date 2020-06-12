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
    public partial class GUI_DangKi : Form
    {
        BUS_DangKi busDK = new BUS_DangKi();
        public GUI_DangKi()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if(txtTk.Text != "" && txtMk.Text != "" && txtName.Text != "" && txtEmail.Text != "" && txtPhonenumber.Text != "" && txtDiachi.Text != "" )
            {
                DTO_DangKi dk = new DTO_DangKi( txtTk.Text, txtMk.Text, txtName.Text, txtEmail.Text, txtPhonenumber.Text, txtDiachi.Text);

                if (busDK.themDangKi(dk))
                {
                    MessageBox.Show("Đăng kí thành công!");

                }
                else
                {
                    MessageBox.Show("Đăng kí không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
