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
        public bool ApplicationTheme = true;
        public bool Accented = true;
        public int AccentColor;

        MainWin MW;

        public Settings(MainWin mw)
        {
            this.DoubleBuffered = true;
            MW = mw;
            InitializeComponent();
            RndBdr();
            ApplicationTheme = mw.APP_THEME;
            Accented = mw.ACCENTED;
            AccentColor = mw.APP_ACCENT_COLOR;
            ChngTheme();
        }

        private void ChngTheme()
        {
            if (ApplicationTheme)
            {
                ChngThemeBtn.Text = "Тёмная";
            }
            else
            {
                ChngThemeBtn.Text = "Светлая";
            }
            if (Accented)
            {
                accentColChngBtn.Text = "Выключить";
                label2.Text = "Выключить акцентный цвет";
            }
            else
            {
                accentColChngBtn.Text = "Включить";
                label2.Text = "Включить акцентный цвет";

            }

            ThemeColorData th = new(ApplicationTheme, Accented, AccentColor);
            th.SetForeColor(MainPanel);
            th.SetForeColor(panel3);
            th.SetForeColor(panel4);
            th.SetForeColor(panel2);
            th.SetLabelColor(label1);
            th.SetLabelColor(label2);
            th.SetLabelColor(label4);
            th.SetLabelColor(TasksLbl);
            th.SetScndForeColor(ColorSchemePanel);
            th.SetBtnColor(ChngThemeBtn, false);
            th.SetBtnColor(accentColChngBtn, false);

            btnsColors(th);

        }
        private void btnsColors(ThemeColorData th)
        {
            if (ApplicationTheme)
            {
                button1.BackColor = th.color_light_blue;
                button2.BackColor = th.color_light_green;
                button3.BackColor = th.color_light_red;
                button4.BackColor = th.color_light_orange;
                button5.BackColor = th.color_light_yellow;
            }
            else
            {
                button1.BackColor = th.color_dark_blue;
                button2.BackColor = th.color_dark_green;
                button3.BackColor = th.color_dark_red;
                button4.BackColor = th.color_dark_orange;
                button5.BackColor = th.color_dark_yellow;

            }
        }


        private void Settings_SizeChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            RndBdr();
            ResumeLayout();
        }


        private void RndBdr()
        {
            SuspendLayout();   
            formRnd(MainPanel, 25);
            formRnd(ColorSchemePanel, 25);
            formRnd(panel3, 15);
            formRnd(panel4, 15);
            formRnd(panel2, 15);

            int btns_rad = 18;

            formRnd(button1, btns_rad);
            formRnd(button2, btns_rad);
            formRnd(button3, btns_rad);
            formRnd(button4, btns_rad);
            formRnd(button5, btns_rad);

            formRnd(ChngThemeBtn, 15);
            formRnd(accentColChngBtn, 15);
            ResumeLayout();
        }

        private void accentColChngBtn_Click(object sender, EventArgs e)
        {
            Accented = !Accented;
            if (Accented)
            {
                MW.ACCENTED = Accented;
                MW.SetAppTheme();
            }
            else
            {
                MW.ACCENTED = Accented;
                MW.SetAppTheme();
            }
            ChngTheme();
        }

        private void ChngThemeBtn_Click(object sender, EventArgs e)
        {
            ApplicationTheme = !ApplicationTheme;

            MW.APP_THEME = ApplicationTheme;

            MW.SetAppTheme();
            ChngTheme();

        }

        private void blue_clck(object sender, EventArgs e)
        {
            MW.APP_ACCENT_COLOR = 0;
            AccentColor = 0;
            MW.SetAppTheme();
            ChngTheme();
        }

        private void green_clck(object sender, EventArgs e)
        {
            MW.APP_ACCENT_COLOR = 1;
            AccentColor = 1;
            MW.SetAppTheme();
            ChngTheme();

        }

        private void red_clck(object sender, EventArgs e)
        {
            MW.APP_ACCENT_COLOR = 2;
            AccentColor = 2;
            MW.SetAppTheme();
            ChngTheme();

        }

        private void orang_clck(object sender, EventArgs e)
        {
            MW.APP_ACCENT_COLOR = 3;
            AccentColor = 3;
            MW.SetAppTheme();
            ChngTheme();

        }

        private void yellow_clck(object sender, EventArgs e)
        {
            MW.APP_ACCENT_COLOR = 4;
            AccentColor = 4;
            MW.SetAppTheme();
            ChngTheme();

        }
    }
}
