using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Them(object sender, EventArgs e)
        {
            // Kiểm tra nếu các TextBox trống
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào cả 3 ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo một ListViewItem mới
            ListViewItem lvi = new ListViewItem(txtLastName.Text); 
            lvi.SubItems.Add(txtFirstName.Text);                  
            lvi.SubItems.Add(txtPhone.Text);                      

            
            listView1.Items.Add(lvi);

            
            
        }

        private void Xoa(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            
        }

        private void Sua(object sender, EventArgs e)
        {
            
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            ListViewItem selectedItem = listView1.SelectedItems[0];

            
            selectedItem.Text = txtLastName.Text;                
            selectedItem.SubItems[1].Text = txtFirstName.Text;   
            selectedItem.SubItems[2].Text = txtPhone.Text;       

           
            
        }
    }
}
