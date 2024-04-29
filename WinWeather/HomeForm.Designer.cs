namespace WinWeather
{
    partial class HomeForm
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
            groupBox = new GroupBox();
            disclaimerLabel = new Label();
            conditionText = new Label();
            temperatureTextC = new Label();
            conditionIcon = new PictureBox();
            label2 = new Label();
            previousDayButton = new Button();
            nextDayButton = new Button();
            loadButton = new Button();
            cityInput = new TextBox();
            label1 = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)conditionIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = SystemColors.Control;
            groupBox.Controls.Add(disclaimerLabel);
            groupBox.Controls.Add(conditionText);
            groupBox.Controls.Add(temperatureTextC);
            groupBox.Controls.Add(conditionIcon);
            groupBox.Controls.Add(label2);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(776, 391);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Today? Tomorrow? Who knows!";
            // 
            // disclaimerLabel
            // 
            disclaimerLabel.AutoSize = true;
            disclaimerLabel.Location = new Point(254, 280);
            disclaimerLabel.Name = "disclaimerLabel";
            disclaimerLabel.Size = new Size(269, 20);
            disclaimerLabel.TabIndex = 4;
            disclaimerLabel.Text = "*Average temperature of the entire day";
            // 
            // conditionText
            // 
            conditionText.Font = new Font("Segoe UI", 15F);
            conditionText.Location = new Point(58, 240);
            conditionText.Name = "conditionText";
            conditionText.Size = new Size(660, 40);
            conditionText.TabIndex = 3;
            conditionText.Text = "Sunny? Rainy? I don't know...";
            conditionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // temperatureTextC
            // 
            temperatureTextC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            temperatureTextC.Font = new Font("Segoe UI", 40F);
            temperatureTextC.Location = new Point(138, 150);
            temperatureTextC.Name = "temperatureTextC";
            temperatureTextC.Size = new Size(500, 89);
            temperatureTextC.TabIndex = 2;
            temperatureTextC.Text = "??°C";
            temperatureTextC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // conditionIcon
            // 
            conditionIcon.Location = new Point(356, 83);
            conditionIcon.Name = "conditionIcon";
            conditionIcon.Size = new Size(64, 64);
            conditionIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            conditionIcon.TabIndex = 1;
            conditionIcon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(0, 368);
            label2.Name = "label2";
            label2.Size = new Size(286, 20);
            label2.TabIndex = 0;
            label2.Text = "Powered by https://www.weatherapi.com/";
            // 
            // previousDayButton
            // 
            previousDayButton.Location = new Point(12, 409);
            previousDayButton.Name = "previousDayButton";
            previousDayButton.Size = new Size(127, 29);
            previousDayButton.TabIndex = 1;
            previousDayButton.Text = "Previous day";
            previousDayButton.UseVisualStyleBackColor = true;
            previousDayButton.Click += previousDayButton_Click;
            // 
            // nextDayButton
            // 
            nextDayButton.Location = new Point(145, 409);
            nextDayButton.Name = "nextDayButton";
            nextDayButton.Size = new Size(94, 29);
            nextDayButton.TabIndex = 2;
            nextDayButton.Text = "Next day";
            nextDayButton.UseVisualStyleBackColor = true;
            nextDayButton.Click += nextDayButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(520, 409);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(268, 29);
            loadButton.TabIndex = 3;
            loadButton.Text = "Get weather";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // cityInput
            // 
            cityInput.Location = new Point(293, 411);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(221, 27);
            cityInput.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 413);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 5;
            label1.Text = "City:";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cityInput);
            Controls.Add(loadButton);
            Controls.Add(nextDayButton);
            Controls.Add(previousDayButton);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomeForm";
            Text = "WinWeather";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conditionIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private Button previousDayButton;
        private Button nextDayButton;
        private Button loadButton;
        private TextBox cityInput;
        private Label label1;
        private Label label2;
        private PictureBox conditionIcon;
        private Label temperatureTextC;
        private Label conditionText;
        private Label disclaimerLabel;
    }
}
