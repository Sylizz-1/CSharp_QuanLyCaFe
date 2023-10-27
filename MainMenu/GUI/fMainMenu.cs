using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class fMainMenu : Form
    {
        private Button lastClickedButton;
        private Color defaultBackColor;
        public fMainMenu()
        {
            InitializeComponent();
            lastClickedButton = null;
            defaultBackColor = Color.Tan;
        }
        private void fMainMenu_Load(object sender, EventArgs e)
        {
            pnlShow.Visible = true;
            pnlBanHang.Visible = false;
        }

        private void RestoreAndChangeButtonColor(Button newButton)
        {
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = defaultBackColor;
            }

            newButton.BackColor = Color.White; // Thay đổi màu nền của nút hiện tại
            lastClickedButton = newButton; // Cập nhật nút trước đó
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = true;
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RestoreAndChangeButtonColor(button);
            pnlBanHang.Visible = false;
        }

    }
}
