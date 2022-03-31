using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для начала оценивания мимимишности альпак нужно нажать на кнопку Начать все заново, после оценивания выйдет рейтинг альпак, удачи!");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            evaluationForm a = new evaluationForm(this);
            a.Show();
        }

    }
}
