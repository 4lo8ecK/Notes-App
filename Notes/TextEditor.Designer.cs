namespace TaskSaver
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            NamePanel = new Panel();
            NameTextPanel = new Panel();
            NameBox = new TextBox();
            label1 = new Label();
            BodyPanel = new Panel();
            BodyTextPanel = new Panel();
            BodyBox = new RichTextBox();
            label2 = new Label();
            SaveBtn = new Button();
            CancelBtn = new Button();
            NamePanel.SuspendLayout();
            NameTextPanel.SuspendLayout();
            BodyPanel.SuspendLayout();
            BodyTextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NamePanel
            // 
            NamePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NamePanel.BackColor = Color.White;
            NamePanel.Controls.Add(NameTextPanel);
            NamePanel.Controls.Add(label1);
            NamePanel.Location = new Point(34, 8);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(686, 78);
            NamePanel.TabIndex = 0;
            NamePanel.SizeChanged += SizeChng;
            // 
            // NameTextPanel
            // 
            NameTextPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextPanel.BackColor = SystemColors.Control;
            NameTextPanel.Controls.Add(NameBox);
            NameTextPanel.Location = new Point(24, 34);
            NameTextPanel.Name = "NameTextPanel";
            NameTextPanel.Size = new Size(639, 34);
            NameTextPanel.TabIndex = 0;
            NameTextPanel.TabStop = true;
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.BackColor = SystemColors.Control;
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameBox.Location = new Point(10, 6);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(619, 22);
            NameBox.TabIndex = 1;
            NameBox.TextChanged += NameTextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 5);
            label1.Name = "label1";
            label1.Size = new Size(182, 26);
            label1.TabIndex = 0;
            label1.Text = "Название заметки";
            // 
            // BodyPanel
            // 
            BodyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BodyPanel.BackColor = Color.White;
            BodyPanel.Controls.Add(BodyTextPanel);
            BodyPanel.Controls.Add(label2);
            BodyPanel.Location = new Point(34, 92);
            BodyPanel.Name = "BodyPanel";
            BodyPanel.Size = new Size(686, 311);
            BodyPanel.TabIndex = 0;
            BodyPanel.Resize += SizeChng;
            // 
            // BodyTextPanel
            // 
            BodyTextPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BodyTextPanel.BackColor = SystemColors.Control;
            BodyTextPanel.Controls.Add(BodyBox);
            BodyTextPanel.Location = new Point(24, 31);
            BodyTextPanel.Name = "BodyTextPanel";
            BodyTextPanel.Size = new Size(639, 268);
            BodyTextPanel.TabIndex = 1;
            // 
            // BodyBox
            // 
            BodyBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BodyBox.BackColor = SystemColors.Control;
            BodyBox.BorderStyle = BorderStyle.None;
            BodyBox.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BodyBox.Location = new Point(12, 8);
            BodyBox.Name = "BodyBox";
            BodyBox.Size = new Size(616, 257);
            BodyBox.TabIndex = 0;
            BodyBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 2);
            label2.Name = "label2";
            label2.Size = new Size(163, 26);
            label2.TabIndex = 0;
            label2.Text = "Дополнительно";
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveBtn.BackColor = Color.FromArgb(35, 75, 230);
            SaveBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Segoe UI Variable Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SaveBtn.ForeColor = SystemColors.ControlLightLight;
            SaveBtn.ImageAlign = ContentAlignment.TopCenter;
            SaveBtn.Location = new Point(547, 412);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(115, 41);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveClick;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = SystemColors.Menu;
            CancelBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI Variable Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            CancelBtn.ImageAlign = ContentAlignment.TopCenter;
            CancelBtn.Location = new Point(426, 412);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(115, 41);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelClick;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(754, 461);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(BodyPanel);
            Controls.Add(NamePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(770, 500);
            Name = "TextEditor";
            Text = "Расширенный редактор";
            TopMost = true;
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            NameTextPanel.ResumeLayout(false);
            NameTextPanel.PerformLayout();
            BodyPanel.ResumeLayout(false);
            BodyPanel.PerformLayout();
            BodyTextPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NamePanel;
        private Label label1;
        private Panel BodyPanel;
        private TextBox NameBox;
        private Panel NameTextPanel;
        private RichTextBox BodyBox;
        private Panel BodyTextPanel;
        private Label label2;
        private Button SaveBtn;
        private Button CancelBtn;
    }
}