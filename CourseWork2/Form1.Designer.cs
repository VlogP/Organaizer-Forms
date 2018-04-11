namespace CourseWork2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonADD = new System.Windows.Forms.Button();
            this.buttonOfWatch = new System.Windows.Forms.Button();
            this.buttonOfDelete = new System.Windows.Forms.Button();
            this.buttonOfEdit = new System.Windows.Forms.Button();
            this.buttonOfExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOfGame = new System.Windows.Forms.Button();
            this.textBoxOfHelp = new System.Windows.Forms.TextBox();
            this.richTextBoxOfShow = new System.Windows.Forms.RichTextBox();
            this.buttonOfHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("EuroRoman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 125);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("EuroRoman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(1051, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 111);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ButtonADD
            // 
            this.ButtonADD.BackColor = System.Drawing.Color.Transparent;
            this.ButtonADD.BackgroundImage = global::CourseWork2.Properties.Resources.aiq6d9qqT;
            this.ButtonADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonADD.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonADD.ForeColor = System.Drawing.Color.DarkRed;
            this.ButtonADD.Location = new System.Drawing.Point(588, 277);
            this.ButtonADD.Name = "ButtonADD";
            this.ButtonADD.Size = new System.Drawing.Size(211, 43);
            this.ButtonADD.TabIndex = 2;
            this.ButtonADD.Text = "Добавление расписания";
            this.ButtonADD.UseVisualStyleBackColor = false;
            this.ButtonADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOfWatch
            // 
            this.buttonOfWatch.BackgroundImage = global::CourseWork2.Properties.Resources.aiq6d9qqT;
            this.buttonOfWatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfWatch.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfWatch.ForeColor = System.Drawing.Color.Navy;
            this.buttonOfWatch.Location = new System.Drawing.Point(588, 352);
            this.buttonOfWatch.Name = "buttonOfWatch";
            this.buttonOfWatch.Size = new System.Drawing.Size(211, 43);
            this.buttonOfWatch.TabIndex = 3;
            this.buttonOfWatch.Text = "Просмотр расписания";
            this.buttonOfWatch.UseVisualStyleBackColor = true;
            this.buttonOfWatch.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOfDelete
            // 
            this.buttonOfDelete.BackgroundImage = global::CourseWork2.Properties.Resources.aiq6d9qqT;
            this.buttonOfDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfDelete.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfDelete.ForeColor = System.Drawing.Color.DarkMagenta;
            this.buttonOfDelete.Location = new System.Drawing.Point(588, 443);
            this.buttonOfDelete.Name = "buttonOfDelete";
            this.buttonOfDelete.Size = new System.Drawing.Size(211, 43);
            this.buttonOfDelete.TabIndex = 4;
            this.buttonOfDelete.Text = "Удаление";
            this.buttonOfDelete.UseVisualStyleBackColor = true;
            this.buttonOfDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonOfEdit
            // 
            this.buttonOfEdit.BackgroundImage = global::CourseWork2.Properties.Resources.aiq6d9qqT;
            this.buttonOfEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfEdit.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOfEdit.Location = new System.Drawing.Point(588, 525);
            this.buttonOfEdit.Name = "buttonOfEdit";
            this.buttonOfEdit.Size = new System.Drawing.Size(211, 43);
            this.buttonOfEdit.TabIndex = 5;
            this.buttonOfEdit.Text = "Редактирование";
            this.buttonOfEdit.UseVisualStyleBackColor = true;
            this.buttonOfEdit.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonOfExit
            // 
            this.buttonOfExit.BackgroundImage = global::CourseWork2.Properties.Resources.aiq6d9qqT;
            this.buttonOfExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfExit.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfExit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonOfExit.Location = new System.Drawing.Point(588, 668);
            this.buttonOfExit.Name = "buttonOfExit";
            this.buttonOfExit.Size = new System.Drawing.Size(211, 42);
            this.buttonOfExit.TabIndex = 6;
            this.buttonOfExit.Text = "Выход";
            this.buttonOfExit.UseVisualStyleBackColor = true;
            this.buttonOfExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Mistral", 72F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(345, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(804, 137);
            this.label3.TabIndex = 7;
            this.label3.Text = "BSUIR ORGANAIZER";
            // 
            // buttonOfGame
            // 
            this.buttonOfGame.BackgroundImage = global::CourseWork2.Properties.Resources.vojny_prestolov_btn;
            this.buttonOfGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfGame.Location = new System.Drawing.Point(588, 601);
            this.buttonOfGame.Name = "buttonOfGame";
            this.buttonOfGame.Size = new System.Drawing.Size(211, 42);
            this.buttonOfGame.TabIndex = 8;
            this.buttonOfGame.UseVisualStyleBackColor = true;
            this.buttonOfGame.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxOfHelp
            // 
            this.textBoxOfHelp.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxOfHelp.Location = new System.Drawing.Point(617, 326);
            this.textBoxOfHelp.Name = "textBoxOfHelp";
            this.textBoxOfHelp.Size = new System.Drawing.Size(153, 20);
            this.textBoxOfHelp.TabIndex = 9;
            this.textBoxOfHelp.Visible = false;
            this.textBoxOfHelp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            this.textBoxOfHelp.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // richTextBoxOfShow
            // 
            this.richTextBoxOfShow.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxOfShow.Location = new System.Drawing.Point(443, 159);
            this.richTextBoxOfShow.Name = "richTextBoxOfShow";
            this.richTextBoxOfShow.ReadOnly = true;
            this.richTextBoxOfShow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxOfShow.Size = new System.Drawing.Size(512, 484);
            this.richTextBoxOfShow.TabIndex = 10;
            this.richTextBoxOfShow.Text = "";
            this.richTextBoxOfShow.Visible = false;
            // 
            // buttonOfHelp
            // 
            this.buttonOfHelp.BackgroundImage = global::CourseWork2.Properties.Resources.aiq6d9qqT;
            this.buttonOfHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfHelp.Font = new System.Drawing.Font("Ravie", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfHelp.ForeColor = System.Drawing.Color.Maroon;
            this.buttonOfHelp.Location = new System.Drawing.Point(1003, 386);
            this.buttonOfHelp.Name = "buttonOfHelp";
            this.buttonOfHelp.Size = new System.Drawing.Size(220, 44);
            this.buttonOfHelp.TabIndex = 11;
            this.buttonOfHelp.Text = "Удаление";
            this.buttonOfHelp.UseVisualStyleBackColor = true;
            this.buttonOfHelp.Visible = false;
            this.buttonOfHelp.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mistral", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 570);
            this.label4.TabIndex = 12;
            this.label4.Text = "C\r\nO\r\nU\r\nR\r\nS\r\nE\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 80.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(1241, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 508);
            this.label5.TabIndex = 13;
            this.label5.Text = "W\r\nO\r\nR\r\nK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 780);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOfHelp);
            this.Controls.Add(this.textBoxOfHelp);
            this.Controls.Add(this.buttonOfGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOfExit);
            this.Controls.Add(this.buttonOfEdit);
            this.Controls.Add(this.buttonOfDelete);
            this.Controls.Add(this.buttonOfWatch);
            this.Controls.Add(this.ButtonADD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxOfShow);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonADD;
        private System.Windows.Forms.Button buttonOfWatch;
        private System.Windows.Forms.Button buttonOfDelete;
        private System.Windows.Forms.Button buttonOfEdit;
        private System.Windows.Forms.Button buttonOfExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOfGame;
        private System.Windows.Forms.TextBox textBoxOfHelp;
        private System.Windows.Forms.RichTextBox richTextBoxOfShow;
        private System.Windows.Forms.Button buttonOfHelp;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
    }
}

