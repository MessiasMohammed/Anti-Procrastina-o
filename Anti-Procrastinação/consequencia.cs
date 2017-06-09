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
    public partial class consequencia : Form
    {
        public consequencia()
        {
            InitializeComponent();
        }

        private void consequencia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seu castigo será fazer todas atividades novamente amanhã");
 
             tarefas taf = new tarefas();
            Hide();
            taf.Show();
        }
    }
}
