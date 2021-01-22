using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormPris
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormJournal();
            f.ShowDialog();
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormBook();
            f.ShowDialog();
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormStudent();
            f.ShowDialog();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormGroup();
            f.ShowDialog();
        }

        private void направленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormDirection();
            f.ShowDialog();
        }

        private void институтыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormInstitute();
            f.ShowDialog();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormAuthors();
            f.ShowDialog();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormPublishers();
            f.ShowDialog();
        }

        private void библиотекарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormLibrarians();
            f.ShowDialog();
        }
    }
}
