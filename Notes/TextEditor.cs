using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSaver.Filework;
using static RoundBorder.Round;

namespace TaskSaver
{
    public partial class TextEditor : Form
    {
        
        string _name, _content;
        string new_name;

        public TextEditor(string name, string content)
        {
            _name = name;
            _content = content;
            InitializeComponent();
            RndAll();
            SetInputText();
        }
        
        private void CancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool nameChanged = false;

        private void NameTextChanged(object sender, EventArgs e)
        {
            new_name = NameBox.Text;
            nameChanged = true;
        }

        TaskWork tsk = new();

        private void SaveClick(object sender, EventArgs e)
        {
            if (nameChanged)
            {
                tsk.DeleteTask(_name);
                tsk.EditTask(new_name, BodyBox.Text);
            }
            else
            {
                tsk.EditTask(_name, BodyBox.Text);
            }

            this.Close();
        }


        private void SetInputText()
        {
            NameBox.Text = _name;
            if (isContentEqualName())
            {
                BodyBox.Text = "";
            }
            else BodyBox.Text = _content;
        }

        private bool isContentEqualName()
        {
            if (_name == _content)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RndAll()
        {
            formRnd(NamePanel, 25);
            formRnd(NameTextPanel, 20);
            formRnd(BodyPanel, 25);
            formRnd(BodyTextPanel, 20);
            formRnd(SaveBtn, 15);
            formRnd(CancelBtn, 15);

        }

        private void SizeChng(object sender, EventArgs e)
        {
            RndAll();
        }

    }
}
