using System;

namespace TaskSaver
{
    public class ThemeColorData
    {
        // true     = light theme
        // false    = dark theme
        public static bool ApplicationTheme;
        public bool Accented = true;

        private int ACCENT_POWER = 25;

        public int ACCENT_COLOR;

        private int CNCL_BTN_POWER_LIGHT = 10;
        private int CNCL_BTN_POWER_DARK = 35;


        public ThemeColorData(bool InputTheme, bool accented, int accentCol)
        {
            ACCENT_COLOR = accentCol;
            ApplicationTheme = InputTheme;
            Accented = accented;
            ThemeChange();
        }

        /*
            to set accent color:
                default color = 'input color' + accent/50 
        */

        // default vallues
        // blue accent color
        public Color color_light_blue = Color.FromArgb(35, 75, 235);
        public Color color_dark_blue = Color.FromArgb(75, 100, 195);

        // green accent color
        public Color color_light_green = Color.FromArgb(35, 235, 75);
        public Color color_dark_green = Color.FromArgb(75, 195, 100);

        // red accent color
        public Color color_light_red = Color.FromArgb(235, 75, 35);
        public Color color_dark_red = Color.FromArgb(195, 100, 75);

        // orange accent color
        public Color color_light_orange = Color.FromArgb(235, 150, 25);
        public Color color_dark_orange = Color.FromArgb(195, 135, 50);

        // yellow accent color
        public Color color_light_yellow = Color.FromArgb(225, 200, 25);
        public Color color_dark_yellow = Color.FromArgb(185, 175, 50);

        // Vallues what will be changed
        public Color AccentColor;
        Color accentLight;
        Color accentDark;

        private void SetAccent()
        {
            if (Accented)
            {
                switch (ACCENT_COLOR)
                {
                    case 0:
                        accentLight = color_light_blue;
                        accentDark = color_dark_blue;
                        break;

                    case 1:
                        accentLight = color_light_green;
                        accentDark = color_dark_green;
                        break;

                    case 2:
                        accentLight = color_light_red;
                        accentDark = color_dark_red;
                        break;

                    case 3:
                        accentLight = color_light_orange;
                        accentDark = color_dark_orange;
                        break;

                    case 4:
                        accentLight = color_light_yellow;
                        accentDark = color_dark_yellow;
                        break;
                }
            }
            else
            {
                accentLight = color_light_blue;
                accentDark = color_dark_blue;
            }

        }



        // Light ApplicationTheme
        private Color BackGroundLight   = Color.FromArgb(225, 225, 225);
        private Color ForegroundLight   = Color.FromArgb(255, 255, 255);
        private Color ButtonColorLight  = Color.FromArgb(35, 75, 235);
        private Color TxtBoxLight       = Color.FromArgb(240, 240, 240);
        private Color TxtColorLight     = Color.FromArgb(0,0,0);

        // DarkTheme
        private Color BackGroundDark    = Color.FromArgb(20,20,20);
        private Color ForegroundDark    = Color.FromArgb(50,50,50);
        private Color ButtonColorDark   = Color.FromArgb(75, 100, 195);
        private Color TxtBoxDark        = Color.FromArgb(35,35,35);
        private Color TxtColorDark      = Color.FromArgb(255,255,255);

        
        public Color BackGround;    
        public Color ForeGround;
        public Color ButtonColor;
        public Color ScndGrndColor;
        public Color TextColor;
        public Color BtnTxtColor;

        private Color addAccent(Color input)
        {
            if (Accented)
            {
                int Red = AccentColor.R     / ACCENT_POWER;
                int Green = AccentColor.G   / ACCENT_POWER;
                int Blue = AccentColor.B    / ACCENT_POWER;
                Color changed   = Color.FromArgb(input.R + Red, input.G + Green, input.B + Blue);
                
                return changed;
            }
            else
            {
                return input;
            }
        }

        private void SetDark()
        {
            SetAccent();
            AccentColor = accentDark;

            BackGround      = addAccent(BackGroundDark);
            ForeGround      = addAccent(ForegroundDark);
            ButtonColor     = addAccent(AccentColor);
            ScndGrndColor   = addAccent(TxtBoxDark);
            TextColor       = TxtColorDark;
            BtnTxtColor     = TxtColorLight;
            
        }

        private void SetLight()
        {
            SetAccent();
            AccentColor = accentLight;

            BackGround      = addAccent(BackGroundLight);
            ForeGround      = ForegroundLight;
            ButtonColor     = addAccent(AccentColor);
            ScndGrndColor   = addAccent(TxtBoxLight);
            TextColor       = TxtColorLight;
            BtnTxtColor     = TxtColorDark;
        }
                
        private void ThemeChange()
        {
            if (ApplicationTheme)
            {
                SetLight();
            }
            else
            {
                SetDark();
            }
        }
        

        // public functions/methods

        // BackColor
        public void SetBackColor(Form form)
        {
            ThemeChange();
            form.BackColor = BackGround;
        }
        public void SetBackColor(Control control)
        {
            ThemeChange();
            control.BackColor = BackGround;
        }
        public void SetBackColor(Panel panel)
        {
            ThemeChange();
            panel.BackColor = BackGround;
        }
        public void SetBackColor(FlowLayoutPanel panel)
        {
            ThemeChange();
            panel.BackColor = BackGround;
        }
        
        // ForeColor 
        public void SetForeColor(Form form)
        {
            ThemeChange();
            form.BackColor = ForeGround;
        }
        public void SetForeColor(Control control)
        {
            ThemeChange();
            control.BackColor = ForeGround;
        }
        public void SetForeColor(Panel panel)
        {
            ThemeChange();
            panel.BackColor = ForeGround;
        }
        public void SetForeColor(FlowLayoutPanel panel)
        {
            ThemeChange();
            panel.BackColor = ForeGround;
        }

        // SecondColor
        public void SetScndForeColor(Control control)
        {
            ThemeChange();
            control.BackColor = ScndGrndColor;
        }
        public void SetScndForeColor(Panel panel)
        {
            ThemeChange();
            panel.BackColor = ScndGrndColor;
        }
        public void SetLabelColor(Label lbl)
        {
            if (!ApplicationTheme)
            {
                lbl.ForeColor = TxtColorDark;
            }
            else
            {
                lbl.ForeColor = TxtColorLight;
            }

        }

        public void SetTxtBoxColor(TextBox txt)
        {
            ThemeChange();
            txt.BackColor = ScndGrndColor;
            txt.ForeColor = TextColor;
        }
        public void SetTxtBoxColor(RichTextBox txt)
        {
            ThemeChange();
            txt.BackColor = ScndGrndColor;
            txt.ForeColor = TextColor;
        }
        // Button
        public void SetBtnColor(Button btn, bool isCNCLbtn)
        {
            ThemeChange();

            if (!isCNCLbtn) {
                btn.BackColor = ButtonColor;
                //btn.ForeColor = TextColor;
                
            }
            else
            {
                if (ApplicationTheme)
                {
                    btn.BackColor = Color.FromArgb(BackGround.R + CNCL_BTN_POWER_LIGHT, BackGround.G + CNCL_BTN_POWER_LIGHT, BackGround.B + CNCL_BTN_POWER_LIGHT);
                    btn.ForeColor = TxtColorLight;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(BackGround.R + CNCL_BTN_POWER_DARK, BackGround.G + CNCL_BTN_POWER_DARK, BackGround.B + CNCL_BTN_POWER_DARK);
                    btn.ForeColor = TxtColorDark;
                }
            }
        }



    }
}
