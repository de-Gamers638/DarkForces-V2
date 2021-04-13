
namespace Client
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
            this.AirWalk = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AirJump = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Flight = new System.Windows.Forms.Button();
            this.Glide = new System.Windows.Forms.Button();
            this.Movement = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlayerCat = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TriggerBot = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AirWalk
            // 
            this.AirWalk.BackColor = System.Drawing.Color.Red;
            this.AirWalk.Location = new System.Drawing.Point(17, 47);
            this.AirWalk.Name = "AirWalk";
            this.AirWalk.Size = new System.Drawing.Size(115, 51);
            this.AirWalk.TabIndex = 0;
            this.AirWalk.Text = "AirWalk";
            this.AirWalk.UseVisualStyleBackColor = false;
            this.AirWalk.Click += new System.EventHandler(this.AirWalk_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AirJump
            // 
            this.AirJump.BackColor = System.Drawing.Color.Red;
            this.AirJump.Location = new System.Drawing.Point(17, 104);
            this.AirJump.Name = "AirJump";
            this.AirJump.Size = new System.Drawing.Size(115, 51);
            this.AirJump.TabIndex = 1;
            this.AirJump.Text = "AirJump";
            this.AirJump.UseVisualStyleBackColor = false;
            this.AirJump.Click += new System.EventHandler(this.AirJump_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Flight);
            this.panel1.Controls.Add(this.Glide);
            this.panel1.Controls.Add(this.Movement);
            this.panel1.Controls.Add(this.AirWalk);
            this.panel1.Controls.Add(this.AirJump);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 286);
            this.panel1.TabIndex = 2;
            // 
            // Flight
            // 
            this.Flight.BackColor = System.Drawing.Color.Red;
            this.Flight.Location = new System.Drawing.Point(17, 218);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(115, 51);
            this.Flight.TabIndex = 4;
            this.Flight.Text = "Flight";
            this.Flight.UseVisualStyleBackColor = false;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // Glide
            // 
            this.Glide.BackColor = System.Drawing.Color.Red;
            this.Glide.Location = new System.Drawing.Point(17, 161);
            this.Glide.Name = "Glide";
            this.Glide.Size = new System.Drawing.Size(115, 51);
            this.Glide.TabIndex = 3;
            this.Glide.Text = "Glide";
            this.Glide.UseVisualStyleBackColor = false;
            this.Glide.Click += new System.EventHandler(this.Glide_Click);
            // 
            // Movement
            // 
            this.Movement.AutoSize = true;
            this.Movement.Location = new System.Drawing.Point(35, 16);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(73, 17);
            this.Movement.TabIndex = 2;
            this.Movement.Text = "Movement";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.PlayerCat);
            this.panel2.Controls.Add(this.Step);
            this.panel2.Location = new System.Drawing.Point(196, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 111);
            this.panel2.TabIndex = 5;
            // 
            // PlayerCat
            // 
            this.PlayerCat.AutoSize = true;
            this.PlayerCat.Location = new System.Drawing.Point(50, 16);
            this.PlayerCat.Name = "PlayerCat";
            this.PlayerCat.Size = new System.Drawing.Size(48, 17);
            this.PlayerCat.TabIndex = 2;
            this.PlayerCat.Text = "Player";
            // 
            // Step
            // 
            this.Step.BackColor = System.Drawing.Color.Red;
            this.Step.Location = new System.Drawing.Point(17, 47);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(115, 51);
            this.Step.TabIndex = 0;
            this.Step.Text = "Step";
            this.Step.UseVisualStyleBackColor = false;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TriggerBot);
            this.panel3.Location = new System.Drawing.Point(381, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 111);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Combat";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TriggerBot
            // 
            this.TriggerBot.BackColor = System.Drawing.Color.Red;
            this.TriggerBot.Location = new System.Drawing.Point(17, 47);
            this.TriggerBot.Name = "TriggerBot";
            this.TriggerBot.Size = new System.Drawing.Size(115, 51);
            this.TriggerBot.TabIndex = 0;
            this.TriggerBot.Text = "TriggerBot";
            this.TriggerBot.UseVisualStyleBackColor = false;
            this.TriggerBot.Click += new System.EventHandler(this.TriggerBot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DarkForces";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AirWalk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button AirJump;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Movement;
        private System.Windows.Forms.Button Glide;
        private System.Windows.Forms.Button Flight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PlayerCat;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TriggerBot;
    }
}

