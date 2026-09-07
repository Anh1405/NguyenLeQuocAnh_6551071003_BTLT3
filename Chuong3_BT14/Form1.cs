using System;
using System.Windows.Forms;

namespace Chuong3_BT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Các hàm bổ trợ xử lý dữ liệu

        private void ChuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void ChuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count > 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        private void XoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        #endregion

        #region Sự kiện các Button

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn không được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                lstLopA.Items.Add(txtTen.Text.Trim());
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    ChuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else if (lstLopA.Items.Count == 0)
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chuyển!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    ChuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else if (lstLopB.Items.Count == 0)
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chuyển!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSangPhaiTatCa_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu sang Lớp B không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    ChuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách Lớp A hiện đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSangTraiTatCa_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu sang Lớp A không?", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    ChuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách Lớp B hiện đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                {
                    XoaDuLieu(lstLopA);
                }
            }
            else if (lstLopA.Items.Count == 0)
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                {
                    XoaDuLieu(lstLopB);
                }
            }
            else if (lstLopB.Items.Count == 0)
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Có chắc bạn muốn đóng ứng dụng?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        private void lstLopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}