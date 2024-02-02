namespace aula2
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hScrollBar1 = new HScrollBar();
            button4 = new Button();
            button7 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            butt = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(0, 624);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(1207, 17);
            hScrollBar1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Sem_título3;
            button4.Image = Properties.Resources.Sem_título4;
            button4.Location = new Point(561, 242);
            button4.Name = "button4";
            button4.Size = new Size(51, 46);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            button4.Click += subtração;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.Sem_título8;
            button7.Location = new Point(561, 329);
            button7.Name = "button7";
            button7.Size = new Size(51, 40);
            button7.TabIndex = 12;
            button7.UseVisualStyleBackColor = true;
            button7.Click += multiplicação;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 89);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 13;
            label3.Text = "digite um numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 89);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 14;
            label4.Text = "digite outro numero";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(503, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // butt
            // 
            butt.Image = Properties.Resources.Sem_título9;
            butt.Location = new Point(456, 412);
            butt.Name = "butt";
            butt.Size = new Size(51, 42);
            butt.TabIndex = 17;
            butt.UseVisualStyleBackColor = true;
            butt.Click += butt_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Sem_título10;
            button2.Location = new Point(456, 494);
            button2.Name = "button2";
            button2.Size = new Size(51, 43);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.BackgroundImage = Properties.Resources.Sem_título2;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Location = new Point(457, 245);
            button3.Name = "button3";
            button3.Size = new Size(50, 41);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = false;
            button3.Click += soma;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.Sem_título6;
            button5.Location = new Point(457, 329);
            button5.Name = "button5";
            button5.Size = new Size(50, 40);
            button5.TabIndex = 10;
            button5.UseVisualStyleBackColor = true;
            button5.Click += divisão;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources._828b9d2bf0b0edd15a415c23a3138c16;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(858, 616);
            Controls.Add(button2);
            Controls.Add(butt);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(hScrollBar1);
            Cursor = Cursors.AppStarting;
            DoubleBuffered = true;
            Name = "FrmCalculadora";
            Text = "Calculadora";
            Load += FrmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private Button button4;
        private Button button7;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button butt;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}
