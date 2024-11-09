
namespace Rock_Paper_Scissors
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
            this.ControlBox = new System.Windows.Forms.Panel();
            this.minimize_btn = new WindowsFormsApp1.RoundBtn();
            this.exit_btn = new WindowsFormsApp1.RoundBtn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.game_panel = new System.Windows.Forms.Panel();
            this.roundBtn1 = new WindowsFormsApp1.RoundBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.bot_box = new System.Windows.Forms.PictureBox();
            this.player_box = new System.Windows.Forms.PictureBox();
            this.scissors_btn = new WindowsFormsApp1.RoundBtn();
            this.paper_btn = new WindowsFormsApp1.RoundBtn();
            this.rock_btn = new WindowsFormsApp1.RoundBtn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.play_btn = new WindowsFormsApp1.RoundBtn();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.game_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.Black;
            this.ControlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlBox.Controls.Add(this.minimize_btn);
            this.ControlBox.Controls.Add(this.exit_btn);
            this.ControlBox.Controls.Add(this.pictureBox1);
            this.ControlBox.Controls.Add(this.label1);
            this.ControlBox.Location = new System.Drawing.Point(0, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(800, 25);
            this.ControlBox.TabIndex = 9;
            this.ControlBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlBox_Paint);
            this.ControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseDown);
            this.ControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseMove);
            this.ControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(749, 3);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Radius = 20;
            this.minimize_btn.Size = new System.Drawing.Size(20, 20);
            this.minimize_btn.TabIndex = 11;
            this.minimize_btn.Text = "-";
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            this.minimize_btn.MouseEnter += new System.EventHandler(this.minimize_btn_MouseEnter);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.minimize_btn_MouseLeave);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(775, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Radius = 20;
            this.exit_btn.Size = new System.Drawing.Size(20, 20);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new System.EventHandler(this.exit_btn_MouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rock_Paper_Scissors.Properties.Resources.ico;
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rock-paper-scissors";
            // 
            // game_panel
            // 
            this.game_panel.Controls.Add(this.roundBtn1);
            this.game_panel.Controls.Add(this.label2);
            this.game_panel.Controls.Add(this.bot_box);
            this.game_panel.Controls.Add(this.player_box);
            this.game_panel.Controls.Add(this.scissors_btn);
            this.game_panel.Controls.Add(this.paper_btn);
            this.game_panel.Controls.Add(this.rock_btn);
            this.game_panel.Location = new System.Drawing.Point(800, 25);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(800, 426);
            this.game_panel.TabIndex = 13;
            // 
            // roundBtn1
            // 
            this.roundBtn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundBtn1.ForeColor = System.Drawing.Color.White;
            this.roundBtn1.Location = new System.Drawing.Point(12, 7);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Radius = 45;
            this.roundBtn1.Size = new System.Drawing.Size(152, 37);
            this.roundBtn1.TabIndex = 14;
            this.roundBtn1.Text = "←";
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "           ";
            // 
            // bot_box
            // 
            this.bot_box.Location = new System.Drawing.Point(534, 47);
            this.bot_box.Name = "bot_box";
            this.bot_box.Size = new System.Drawing.Size(236, 236);
            this.bot_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bot_box.TabIndex = 12;
            this.bot_box.TabStop = false;
            // 
            // player_box
            // 
            this.player_box.Location = new System.Drawing.Point(48, 47);
            this.player_box.Name = "player_box";
            this.player_box.Size = new System.Drawing.Size(236, 236);
            this.player_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_box.TabIndex = 12;
            this.player_box.TabStop = false;
            // 
            // scissors_btn
            // 
            this.scissors_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scissors_btn.ForeColor = System.Drawing.Color.White;
            this.scissors_btn.Location = new System.Drawing.Point(565, 302);
            this.scissors_btn.Name = "scissors_btn";
            this.scissors_btn.Radius = 45;
            this.scissors_btn.Size = new System.Drawing.Size(205, 89);
            this.scissors_btn.TabIndex = 11;
            this.scissors_btn.Text = "Scissors";
            this.scissors_btn.Click += new System.EventHandler(this.scissors_btn_Click);
            // 
            // paper_btn
            // 
            this.paper_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paper_btn.ForeColor = System.Drawing.Color.White;
            this.paper_btn.Location = new System.Drawing.Point(309, 302);
            this.paper_btn.Name = "paper_btn";
            this.paper_btn.Radius = 45;
            this.paper_btn.Size = new System.Drawing.Size(205, 89);
            this.paper_btn.TabIndex = 11;
            this.paper_btn.Text = "Paper";
            this.paper_btn.Click += new System.EventHandler(this.paper_btn_Click);
            // 
            // rock_btn
            // 
            this.rock_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rock_btn.ForeColor = System.Drawing.Color.White;
            this.rock_btn.Location = new System.Drawing.Point(48, 302);
            this.rock_btn.Name = "rock_btn";
            this.rock_btn.Radius = 45;
            this.rock_btn.Size = new System.Drawing.Size(205, 89);
            this.rock_btn.TabIndex = 11;
            this.rock_btn.Text = "Rock";
            this.rock_btn.Click += new System.EventHandler(this.rock_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rock_Paper_Scissors.Properties.Resources._4144475__1_;
            this.pictureBox2.Location = new System.Drawing.Point(242, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // play_btn
            // 
            this.play_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_btn.ForeColor = System.Drawing.Color.White;
            this.play_btn.Location = new System.Drawing.Point(279, 340);
            this.play_btn.Name = "play_btn";
            this.play_btn.Radius = 45;
            this.play_btn.Size = new System.Drawing.Size(226, 80);
            this.play_btn.TabIndex = 12;
            this.play_btn.Text = "Play";
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.game_panel.ResumeLayout(false);
            this.game_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bot_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp1.RoundBtn minimize_btn;
        private WindowsFormsApp1.RoundBtn exit_btn;
        private WindowsFormsApp1.RoundBtn play_btn;
        private System.Windows.Forms.Panel game_panel;
        private WindowsFormsApp1.RoundBtn scissors_btn;
        private WindowsFormsApp1.RoundBtn paper_btn;
        private WindowsFormsApp1.RoundBtn rock_btn;
        private System.Windows.Forms.PictureBox bot_box;
        private System.Windows.Forms.PictureBox player_box;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApp1.RoundBtn roundBtn1;
    }
}

