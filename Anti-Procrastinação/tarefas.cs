using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anti_Procrastinação
{
    public partial class tarefas : Form
    {
        int count = 0;

        public tarefas()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;

            if (check.Checked)
                count += 1;
            else
                count -= 1;

            if(count == 4)
            {
                button2.Visible = false;
                button1.Visible = true;
            }
            else
            {
                button2.Visible = true;
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Parabéns você concluiu todas as suas tarefas que eram importantes!");
            recompensa rep = new recompensa();
            Hide();
            rep.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você não concluiu todas as tarefas do seu dia!");

           consequencia cons = new consequencia();
            Hide();
            cons.Show();

        }
    }
}
