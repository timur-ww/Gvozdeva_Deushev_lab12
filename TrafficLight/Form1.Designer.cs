namespace TrafficLight {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.buttoSstart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.Location = new System.Drawing.Point(23, 34);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(200, 100);
            this.panelRed.TabIndex = 0;
            // 
            // panelYellow
            // 
            this.panelYellow.Location = new System.Drawing.Point(23, 140);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(200, 100);
            this.panelYellow.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.Location = new System.Drawing.Point(23, 255);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(200, 100);
            this.panelGreen.TabIndex = 1;
            // 
            // buttoSstart
            // 
            this.buttoSstart.Location = new System.Drawing.Point(78, 376);
            this.buttoSstart.Name = "buttoSstart";
            this.buttoSstart.Size = new System.Drawing.Size(93, 48);
            this.buttoSstart.TabIndex = 2;
            this.buttoSstart.Text = "Start";
            this.buttoSstart.UseVisualStyleBackColor = true;
            this.buttoSstart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 436);
            this.Controls.Add(this.buttoSstart);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Name = "Form1";
            this.Text = "TrafficLight";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Button buttoSstart;
        private System.Windows.Forms.Timer timer1;
    }
}

