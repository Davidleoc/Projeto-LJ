using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneProjetoPIM
{
    public partial class Form7 : Form
    {
        public static class Sess
        {
            public static string Nome { get; set; }
            public static string TpUser { get; set; }
            public static int Id { get; set; }
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void meuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem Certeza?", "Confirmção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Sess.Nome = null;
                Sess.TpUser = null;
                Sess.Id = 0;

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();
            }
        }
        private void minhaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.png;*.jpeg;*";
                ofd.Title = "Selecione a imagem do seu Perfil";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.Tag = ofd.FileName;
                }
            }
        }
    }
}
