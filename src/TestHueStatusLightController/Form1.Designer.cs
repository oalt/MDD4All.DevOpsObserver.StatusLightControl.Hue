namespace TestHueStatusLightController
{
    partial class Form1
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
            onButton = new Button();
            OffButton = new Button();
            RedButton = new Button();
            YellowButton = new Button();
            greenButton = new Button();
            UnknownButton = new Button();
            AlertButton = new Button();
            SuspendLayout();
            // 
            // onButton
            // 
            onButton.Location = new Point(58, 37);
            onButton.Name = "onButton";
            onButton.Size = new Size(75, 23);
            onButton.TabIndex = 0;
            onButton.Text = "On";
            onButton.UseVisualStyleBackColor = true;
            onButton.Click += onButton_Click;
            // 
            // OffButton
            // 
            OffButton.Location = new Point(58, 87);
            OffButton.Name = "OffButton";
            OffButton.Size = new Size(75, 23);
            OffButton.TabIndex = 1;
            OffButton.Text = "Off";
            OffButton.UseVisualStyleBackColor = true;
            OffButton.Click += OffButton_Click;
            // 
            // RedButton
            // 
            RedButton.Location = new Point(237, 37);
            RedButton.Name = "RedButton";
            RedButton.Size = new Size(75, 23);
            RedButton.TabIndex = 2;
            RedButton.Text = "Fail";
            RedButton.UseVisualStyleBackColor = true;
            RedButton.Click += RedButton_Click;
            // 
            // YellowButton
            // 
            YellowButton.Location = new Point(235, 85);
            YellowButton.Name = "YellowButton";
            YellowButton.Size = new Size(75, 23);
            YellowButton.TabIndex = 3;
            YellowButton.Text = "Warning";
            YellowButton.UseVisualStyleBackColor = true;
            YellowButton.Click += YellowButton_Click;
            // 
            // greenButton
            // 
            greenButton.Location = new Point(237, 124);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(75, 23);
            greenButton.TabIndex = 4;
            greenButton.Text = "Success";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.Click += greenButton_Click;
            // 
            // UnknownButton
            // 
            UnknownButton.Location = new Point(240, 186);
            UnknownButton.Name = "UnknownButton";
            UnknownButton.Size = new Size(75, 23);
            UnknownButton.TabIndex = 5;
            UnknownButton.Text = "Unknown";
            UnknownButton.UseVisualStyleBackColor = true;
            UnknownButton.Click += UnknownButton_Click;
            // 
            // AlertButton
            // 
            AlertButton.BackColor = Color.Red;
            AlertButton.Location = new Point(404, 51);
            AlertButton.Name = "AlertButton";
            AlertButton.Size = new Size(75, 23);
            AlertButton.TabIndex = 6;
            AlertButton.Text = "Alert";
            AlertButton.UseVisualStyleBackColor = false;
            AlertButton.Click += AlertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AlertButton);
            Controls.Add(UnknownButton);
            Controls.Add(greenButton);
            Controls.Add(YellowButton);
            Controls.Add(RedButton);
            Controls.Add(OffButton);
            Controls.Add(onButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button onButton;
        private Button OffButton;
        private Button RedButton;
        private Button YellowButton;
        private Button greenButton;
        private Button UnknownButton;
        private Button AlertButton;
    }
}
