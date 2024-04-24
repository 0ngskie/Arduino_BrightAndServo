namespace RoboticsTest_24Apr24_
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
            this.angleApplyButton = new System.Windows.Forms.Button();
            this.angleTextBoxInput = new System.Windows.Forms.TextBox();
            this.redConfirmButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.brightnessTracker = new System.Windows.Forms.TrackBar();
            this.yellowConfirmButton = new System.Windows.Forms.Button();
            this.yellowBrightnessTracker = new System.Windows.Forms.TrackBar();
            this.angleResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBrightnessTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // angleApplyButton
            // 
            this.angleApplyButton.Location = new System.Drawing.Point(196, 75);
            this.angleApplyButton.Name = "angleApplyButton";
            this.angleApplyButton.Size = new System.Drawing.Size(95, 54);
            this.angleApplyButton.TabIndex = 1;
            this.angleApplyButton.Text = "Apply";
            this.angleApplyButton.UseVisualStyleBackColor = true;
            this.angleApplyButton.Click += new System.EventHandler(this.angleApplyButton_Click);
            // 
            // angleTextBoxInput
            // 
            this.angleTextBoxInput.Location = new System.Drawing.Point(311, 89);
            this.angleTextBoxInput.Name = "angleTextBoxInput";
            this.angleTextBoxInput.Size = new System.Drawing.Size(340, 26);
            this.angleTextBoxInput.TabIndex = 2;
            this.angleTextBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.angleTextBoxInput.TextChanged += new System.EventHandler(this.angleTextBoxInput_TextChanged);
            // 
            // redConfirmButton
            // 
            this.redConfirmButton.Location = new System.Drawing.Point(196, 192);
            this.redConfirmButton.Name = "redConfirmButton";
            this.redConfirmButton.Size = new System.Drawing.Size(95, 54);
            this.redConfirmButton.TabIndex = 4;
            this.redConfirmButton.Text = "red";
            this.redConfirmButton.UseVisualStyleBackColor = true;
            this.redConfirmButton.Click += new System.EventHandler(this.ledConfirmButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // brightnessTracker
            // 
            this.brightnessTracker.Location = new System.Drawing.Point(311, 192);
            this.brightnessTracker.Maximum = 255;
            this.brightnessTracker.Name = "brightnessTracker";
            this.brightnessTracker.Size = new System.Drawing.Size(340, 69);
            this.brightnessTracker.TabIndex = 3;
            this.brightnessTracker.TickFrequency = 10;
            this.brightnessTracker.Scroll += new System.EventHandler(this.brightnessTracker_Scroll);
            // 
            // yellowConfirmButton
            // 
            this.yellowConfirmButton.Location = new System.Drawing.Point(196, 293);
            this.yellowConfirmButton.Name = "yellowConfirmButton";
            this.yellowConfirmButton.Size = new System.Drawing.Size(95, 54);
            this.yellowConfirmButton.TabIndex = 7;
            this.yellowConfirmButton.Text = "yellow";
            this.yellowConfirmButton.UseVisualStyleBackColor = true;
            this.yellowConfirmButton.Click += new System.EventHandler(this.yellowConfirmButton_Click);
            // 
            // yellowBrightnessTracker
            // 
            this.yellowBrightnessTracker.Location = new System.Drawing.Point(311, 293);
            this.yellowBrightnessTracker.Maximum = 255;
            this.yellowBrightnessTracker.Name = "yellowBrightnessTracker";
            this.yellowBrightnessTracker.Size = new System.Drawing.Size(340, 69);
            this.yellowBrightnessTracker.TabIndex = 8;
            this.yellowBrightnessTracker.TickFrequency = 10;
            this.yellowBrightnessTracker.Scroll += new System.EventHandler(this.yellowBrightnessTracker_Scroll);
            // 
            // angleResetButton
            // 
            this.angleResetButton.Location = new System.Drawing.Point(83, 75);
            this.angleResetButton.Name = "angleResetButton";
            this.angleResetButton.Size = new System.Drawing.Size(95, 54);
            this.angleResetButton.TabIndex = 9;
            this.angleResetButton.Text = "Reset";
            this.angleResetButton.UseVisualStyleBackColor = true;
            this.angleResetButton.Click += new System.EventHandler(this.angleResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.angleResetButton);
            this.Controls.Add(this.yellowBrightnessTracker);
            this.Controls.Add(this.yellowConfirmButton);
            this.Controls.Add(this.redConfirmButton);
            this.Controls.Add(this.brightnessTracker);
            this.Controls.Add(this.angleTextBoxInput);
            this.Controls.Add(this.angleApplyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBrightnessTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button angleApplyButton;
        private System.Windows.Forms.TextBox angleTextBoxInput;
        private System.Windows.Forms.Button redConfirmButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar brightnessTracker;
        private System.Windows.Forms.Button yellowConfirmButton;
        private System.Windows.Forms.TrackBar yellowBrightnessTracker;
        private System.Windows.Forms.Button angleResetButton;
    }
}

