namespace CarRaceApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.road = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.mycar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_startrace = new System.Windows.Forms.Button();
            this.crash = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crash)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.crash);
            this.panel1.Controls.Add(this.mycar);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.road);
            this.panel1.Location = new System.Drawing.Point(13, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // road
            // 
            this.road.Image = global::CarRaceApplication.Properties.Resources.yol;
            this.road.Location = new System.Drawing.Point(-7, -252);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(513, 775);
            this.road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road.TabIndex = 0;
            this.road.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::CarRaceApplication.Properties.Resources.araba4;
            this.car1.Location = new System.Drawing.Point(102, 101);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(69, 134);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::CarRaceApplication.Properties.Resources.araba6;
            this.car2.Location = new System.Drawing.Point(336, 101);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(69, 134);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            // 
            // mycar
            // 
            this.mycar.Image = global::CarRaceApplication.Properties.Resources.araba5;
            this.mycar.Location = new System.Drawing.Point(221, 360);
            this.mycar.Name = "mycar";
            this.mycar.Size = new System.Drawing.Size(69, 134);
            this.mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mycar.TabIndex = 3;
            this.mycar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(494, 594);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(25, 27);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "0";
            // 
            // btn_startrace
            // 
            this.btn_startrace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_startrace.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startrace.Location = new System.Drawing.Point(13, 624);
            this.btn_startrace.Name = "btn_startrace";
            this.btn_startrace.Size = new System.Drawing.Size(506, 41);
            this.btn_startrace.TabIndex = 3;
            this.btn_startrace.Text = "Start Race";
            this.btn_startrace.UseVisualStyleBackColor = false;
            this.btn_startrace.Click += new System.EventHandler(this.btn_startrace_Click);
            // 
            // crash
            // 
            this.crash.Image = global::CarRaceApplication.Properties.Resources.explosion;
            this.crash.Location = new System.Drawing.Point(273, 322);
            this.crash.Name = "crash";
            this.crash.Size = new System.Drawing.Size(60, 50);
            this.crash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crash.TabIndex = 4;
            this.crash.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highscore.Location = new System.Drawing.Point(159, 594);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(25, 27);
            this.lbl_highscore.TabIndex = 5;
            this.lbl_highscore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "High Score :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 677);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_startrace);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mycar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox road;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox mycar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_startrace;
        private System.Windows.Forms.PictureBox crash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.Label label3;
    }
}

