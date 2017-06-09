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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarefas taf = new tarefas();
            Hide();
            taf.Show();
        }
    }
}
