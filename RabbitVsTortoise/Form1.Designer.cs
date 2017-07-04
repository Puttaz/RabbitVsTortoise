namespace RabbitVsTortoise
{
    partial class RabbitVsTortoiseForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.rabbitTrackBar = new System.Windows.Forms.TrackBar();
            this.tortoiseTrackBar = new System.Windows.Forms.TrackBar();
            this.rabbitLabel = new System.Windows.Forms.Label();
            this.tortoiseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rabbitTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortoiseTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(350, 511);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 42);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rabbitTrackBar
            // 
            this.rabbitTrackBar.Location = new System.Drawing.Point(176, 411);
            this.rabbitTrackBar.Maximum = 10000;
            this.rabbitTrackBar.Name = "rabbitTrackBar";
            this.rabbitTrackBar.Size = new System.Drawing.Size(151, 45);
            this.rabbitTrackBar.TabIndex = 1;
            this.rabbitTrackBar.Scroll += new System.EventHandler(this.rabbitTrackBar_Scroll);
            // 
            // tortoiseTrackBar
            // 
            this.tortoiseTrackBar.Location = new System.Drawing.Point(176, 471);
            this.tortoiseTrackBar.Maximum = 10000;
            this.tortoiseTrackBar.Name = "tortoiseTrackBar";
            this.tortoiseTrackBar.Size = new System.Drawing.Size(151, 45);
            this.tortoiseTrackBar.TabIndex = 2;
            this.tortoiseTrackBar.Scroll += new System.EventHandler(this.tortoiseTrackBar_Scroll);
            // 
            // rabbitLabel
            // 
            this.rabbitLabel.AutoSize = true;
            this.rabbitLabel.Location = new System.Drawing.Point(27, 411);
            this.rabbitLabel.Name = "rabbitLabel";
            this.rabbitLabel.Size = new System.Drawing.Size(79, 13);
            this.rabbitLabel.TabIndex = 3;
            this.rabbitLabel.Text = "Rabbit\'s Speed";
            // 
            // tortoiseLabel
            // 
            this.tortoiseLabel.AutoSize = true;
            this.tortoiseLabel.Location = new System.Drawing.Point(27, 471);
            this.tortoiseLabel.Name = "tortoiseLabel";
            this.tortoiseLabel.Size = new System.Drawing.Size(86, 13);
            this.tortoiseLabel.TabIndex = 4;
            this.tortoiseLabel.Text = "Tortoise\'s Speed";
            // 
            // RabbitVsTortoiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 565);
            this.Controls.Add(this.tortoiseLabel);
            this.Controls.Add(this.rabbitLabel);
            this.Controls.Add(this.tortoiseTrackBar);
            this.Controls.Add(this.rabbitTrackBar);
            this.Controls.Add(this.startButton);
            this.Name = "RabbitVsTortoiseForm";
            this.Text = "Rabbit Vs Tortoise";
            this.Load += new System.EventHandler(this.RabbitVsTortoiseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rabbitTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortoiseTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TrackBar rabbitTrackBar;
        private System.Windows.Forms.TrackBar tortoiseTrackBar;
        private System.Windows.Forms.Label rabbitLabel;
        private System.Windows.Forms.Label tortoiseLabel;
    }
}

