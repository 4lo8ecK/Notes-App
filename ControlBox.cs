using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using TaskSaver.Properties;
using System.Net.NetworkInformation;

namespace TaskSaver
{
    public partial class ControlBox : UserControl
    {
        Form parent;
        public ControlBox(Form form)
        {
            parent = form;
            InitializeComponent();
            CurDateLblContent();
        }

        
        private void CurDateLblContent()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            label1.Text = DateTime.Now.Day + " " + monthName + " " + DateTime.Now.Year;
        }


        private Point lastLoc;
        private bool mouseDown;

        private void MsDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLoc = e.Location;
            if (flscreen)
            {
                parent.WindowState = FormWindowState.Normal;
            }
        }

        private void MsMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                parent.Location = new Point(
                    (parent.Location.X - lastLoc.X) + e.X, (parent.Location.Y - lastLoc.Y) + e.Y);
                parent.Update();
            }
        }

        private void MsUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #region Buttons Actions
        private void CloseClick()
        {
            parent.Close();
        }

        private void HideClick()
        {
            parent.WindowState = FormWindowState.Minimized;
        }

        bool flscreen = false;
        private void MaximizeClick()
        {
            if (flscreen)
            {
                parent.WindowState = FormWindowState.Normal;
                flscreen = false;
            }

            else
            {
                Rectangle workingArea = Screen.AllScreens[0].WorkingArea;
                parent.WindowState = FormWindowState.Maximized;
                flscreen = true;
            }
        }
        #endregion

        #region Buttons' image change
        private void ChngImg(Button btn, Image img)
        {
            btn.BackgroundImage = img;
        }

        // main work of control box buttons
        private void Close_btn_Click(object sender, EventArgs e)
        {
            CloseClick();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            HideClick();
        }

        private void MaxMinBtn_Click(object sender, EventArgs e)
        {
            MaximizeClick();
        }

        // change img if selected
        // close button
        private void Close_btn_MouseMove(object sender, MouseEventArgs e)
        {
            ChngImg(Close_btn, Resources.close_select);
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            ChngImg(Close_btn, Resources.close_def);
        }

        // minimize button
        private void Minimize_btn_MouseMove(object sender, MouseEventArgs e)
        {
            ChngImg(Minimize_btn, Resources.hide_select);
        }
        
        private void Minimize_btn_MouseLeave(object sender, EventArgs e)
        {
            ChngImg(Minimize_btn, Resources.hide_def);
        }

        // maximize button
        private void Maximize_btn_MouseMove(object sender, MouseEventArgs e)
        {
            ChngImg(Maximize_btn, Resources.min_select);
        }

        private void Maximize_btn_MouseLeave(object sender, EventArgs e)
        {
            ChngImg(Maximize_btn, Resources.min_def);
        }
        #endregion


    }
}
