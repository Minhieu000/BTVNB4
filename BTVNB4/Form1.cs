using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVNB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormNV form = new FormNV();
            if (form.ShowDialog() == DialogResult.OK)
            {

                var item = new ListViewItem(form.MSNV);
                item.SubItems.Add(form.TenNhanVien);
                item.SubItems.Add(form.Luong);
                listView1.Items.Add(item);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                FormNV form = new FormNV

                {
                    MSNV = selectedItem.Text,
                    TenNhanVien = selectedItem.SubItems[1].Text,
                    Luong = selectedItem.SubItems[2].Text
                };

                if (form.ShowDialog() == DialogResult.OK)
                {

                    selectedItem.Text = form.MSNV;
                    selectedItem.SubItems[1].Text = form.TenNhanVien;
                    selectedItem.SubItems[2].Text = form.Luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
