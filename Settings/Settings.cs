using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static RoundBorder.Round;
using System.Windows;

namespace TaskSaver.Notes
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            RndBdr();
        }
        private void Settings_SizeChanged(object sender, EventArgs e)
        {
            RndBdr();
            

        }

        private void RndBdr()
        {
            formRnd(MainPanel, 25);
            formRnd(ColorSchemePanel, 25);
            formRnd(panel3, 15);
            formRnd(panel4, 15);


            formRnd(SaveBtn, 15);
            formRnd(CancelBtn, 15);
            formRnd(ChngThemeBtn, 15);
            formRnd(accentColChngBtn, 15);

        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void accentColChngBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
