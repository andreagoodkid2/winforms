namespace BaiThucHanhChuong1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkDelete()
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkDelete();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkDelete();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo", MessageBoxButtons.OK);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                textBox2.Focus();
            }
            else
            {
                if(textBox1.Text=="ngonguyenhuyanh"&&textBox2.Text=="111200022")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo");
                }
            }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
                button2.PerformClick();
                button3.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                button1_Click(sender, e);
            }
        }
    }

}