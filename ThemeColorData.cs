using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSaver
{
    public class ThemeColorData
    {
        bool theme;
        // true     = light theme
        // false    = dark theme

        Color BackGround;
        Color ForeGround;
        //Color ButtonColor = SystemAccentColor;
        Color TextBoxColor;
        Color TextColor;

        ThemeColorData(bool set_theme)
        {
            theme = set_theme;
        }

        public void BackGroundColor(Form form)
        {
            form.BackColor = BackGround;
        }

        public void BackGroundColor(Control form)
        {
            form.BackColor = BackGround;
        }

        
    }


}
