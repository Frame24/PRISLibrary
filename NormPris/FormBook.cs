using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormPris
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            groupBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            groupBox1.Visible = false;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {

            var dbo = new LibraryEntities();
            dbo.Book.Load();
            dataGridView1.DataSource = dbo.Book.Local.ToBindingList();

            dbo.Group.Load();
            comboBox1.DataSource = dbo.PublishingHouse.Local.ToBindingList();
            dbo.Group.Load();
            listBox1.DataSource = dbo.Author.Local.ToBindingList();
        }
    }
}
