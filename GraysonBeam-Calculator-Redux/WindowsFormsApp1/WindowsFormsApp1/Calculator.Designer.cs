namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NumOneButton = new System.Windows.Forms.Button();
            this.NumTwoButton = new System.Windows.Forms.Button();
            this.NumThreeButton = new System.Windows.Forms.Button();
            this.NumFourButton = new System.Windows.Forms.Button();
            this.SqareRootButton = new System.Windows.Forms.Button();
            this.NumNineButton = new System.Windows.Forms.Button();
            this.NumFiveButton = new System.Windows.Forms.Button();
            this.NumSixButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.OneOverXButton = new System.Windows.Forms.Button();
            this.NumSevenButton = new System.Windows.Forms.Button();
            this.NumEightButton = new System.Windows.Forms.Button();
            this.DivisonButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.NumZeroButton = new System.Windows.Forms.Button();
            this.NegativePositiveButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.MemoryClearButton = new System.Windows.Forms.Button();
            this.MemoryRecallButton = new System.Windows.Forms.Button();
            this.MemoryAddButton = new System.Windows.Forms.Button();
            this.MemoryStoreButton = new System.Windows.Forms.Button();
            this.MemoryStoredTextBox = new System.Windows.Forms.TextBox();
            this.ValueInMemoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Enabled = false;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OutputTextBox.Location = new System.Drawing.Point(12, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(274, 33);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BackButton.ForeColor = System.Drawing.Color.Red;
            this.BackButton.Location = new System.Drawing.Point(104, 55);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 34);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ClearButton.ForeColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(198, 55);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 34);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NumOneButton
            // 
            this.NumOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumOneButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumOneButton.Location = new System.Drawing.Point(57, 96);
            this.NumOneButton.Name = "NumOneButton";
            this.NumOneButton.Size = new System.Drawing.Size(41, 42);
            this.NumOneButton.TabIndex = 3;
            this.NumOneButton.Text = "1";
            this.NumOneButton.UseVisualStyleBackColor = true;
            this.NumOneButton.Click += new System.EventHandler(this.NumOneButton_Click);
            // 
            // NumTwoButton
            // 
            this.NumTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumTwoButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumTwoButton.Location = new System.Drawing.Point(104, 96);
            this.NumTwoButton.Name = "NumTwoButton";
            this.NumTwoButton.Size = new System.Drawing.Size(41, 42);
            this.NumTwoButton.TabIndex = 4;
            this.NumTwoButton.Text = "2";
            this.NumTwoButton.UseVisualStyleBackColor = true;
            this.NumTwoButton.Click += new System.EventHandler(this.NumTwoButton_Click);
            // 
            // NumThreeButton
            // 
            this.NumThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumThreeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumThreeButton.Location = new System.Drawing.Point(151, 96);
            this.NumThreeButton.Name = "NumThreeButton";
            this.NumThreeButton.Size = new System.Drawing.Size(41, 42);
            this.NumThreeButton.TabIndex = 5;
            this.NumThreeButton.Text = "3";
            this.NumThreeButton.UseVisualStyleBackColor = true;
            this.NumThreeButton.Click += new System.EventHandler(this.NumThreeButton_Click);
            // 
            // NumFourButton
            // 
            this.NumFourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumFourButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumFourButton.Location = new System.Drawing.Point(57, 142);
            this.NumFourButton.Name = "NumFourButton";
            this.NumFourButton.Size = new System.Drawing.Size(41, 42);
            this.NumFourButton.TabIndex = 6;
            this.NumFourButton.Text = "4";
            this.NumFourButton.UseVisualStyleBackColor = true;
            this.NumFourButton.Click += new System.EventHandler(this.NumFourButton_Click);
            // 
            // SqareRootButton
            // 
            this.SqareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.SqareRootButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SqareRootButton.Location = new System.Drawing.Point(245, 95);
            this.SqareRootButton.Name = "SqareRootButton";
            this.SqareRootButton.Size = new System.Drawing.Size(41, 42);
            this.SqareRootButton.TabIndex = 7;
            this.SqareRootButton.Text = "Sqrt";
            this.SqareRootButton.UseVisualStyleBackColor = true;
            this.SqareRootButton.Click += new System.EventHandler(this.SqareRootButton_Click);
            // 
            // NumNineButton
            // 
            this.NumNineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumNineButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumNineButton.Location = new System.Drawing.Point(151, 189);
            this.NumNineButton.Name = "NumNineButton";
            this.NumNineButton.Size = new System.Drawing.Size(41, 42);
            this.NumNineButton.TabIndex = 8;
            this.NumNineButton.Text = "9";
            this.NumNineButton.UseVisualStyleBackColor = true;
            this.NumNineButton.Click += new System.EventHandler(this.NumNineButton_Click);
            // 
            // NumFiveButton
            // 
            this.NumFiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumFiveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumFiveButton.Location = new System.Drawing.Point(104, 142);
            this.NumFiveButton.Name = "NumFiveButton";
            this.NumFiveButton.Size = new System.Drawing.Size(41, 42);
            this.NumFiveButton.TabIndex = 9;
            this.NumFiveButton.Text = "5";
            this.NumFiveButton.UseVisualStyleBackColor = true;
            this.NumFiveButton.Click += new System.EventHandler(this.NumFiveButton_Click);
            // 
            // NumSixButton
            // 
            this.NumSixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSixButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumSixButton.Location = new System.Drawing.Point(151, 142);
            this.NumSixButton.Name = "NumSixButton";
            this.NumSixButton.Size = new System.Drawing.Size(41, 42);
            this.NumSixButton.TabIndex = 10;
            this.NumSixButton.Text = "6";
            this.NumSixButton.UseVisualStyleBackColor = true;
            this.NumSixButton.Click += new System.EventHandler(this.NumSixButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MultiplyButton.ForeColor = System.Drawing.Color.Red;
            this.MultiplyButton.Location = new System.Drawing.Point(198, 141);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(41, 42);
            this.MultiplyButton.TabIndex = 11;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // OneOverXButton
            // 
            this.OneOverXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.OneOverXButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OneOverXButton.Location = new System.Drawing.Point(246, 141);
            this.OneOverXButton.Name = "OneOverXButton";
            this.OneOverXButton.Size = new System.Drawing.Size(41, 42);
            this.OneOverXButton.TabIndex = 12;
            this.OneOverXButton.Text = "1/X";
            this.OneOverXButton.UseVisualStyleBackColor = true;
            this.OneOverXButton.Click += new System.EventHandler(this.OneOverXButton_Click);
            // 
            // NumSevenButton
            // 
            this.NumSevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumSevenButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumSevenButton.Location = new System.Drawing.Point(57, 189);
            this.NumSevenButton.Name = "NumSevenButton";
            this.NumSevenButton.Size = new System.Drawing.Size(41, 42);
            this.NumSevenButton.TabIndex = 13;
            this.NumSevenButton.Text = "7";
            this.NumSevenButton.UseVisualStyleBackColor = true;
            this.NumSevenButton.Click += new System.EventHandler(this.NumSevenButton_Click);
            // 
            // NumEightButton
            // 
            this.NumEightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEightButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumEightButton.Location = new System.Drawing.Point(104, 189);
            this.NumEightButton.Name = "NumEightButton";
            this.NumEightButton.Size = new System.Drawing.Size(41, 42);
            this.NumEightButton.TabIndex = 14;
            this.NumEightButton.Text = "8";
            this.NumEightButton.UseVisualStyleBackColor = true;
            this.NumEightButton.Click += new System.EventHandler(this.NumEightButton_Click);
            // 
            // DivisonButton
            // 
            this.DivisonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DivisonButton.ForeColor = System.Drawing.Color.Red;
            this.DivisonButton.Location = new System.Drawing.Point(198, 95);
            this.DivisonButton.Name = "DivisonButton";
            this.DivisonButton.Size = new System.Drawing.Size(41, 42);
            this.DivisonButton.TabIndex = 15;
            this.DivisonButton.Text = "/";
            this.DivisonButton.UseVisualStyleBackColor = true;
            this.DivisonButton.Click += new System.EventHandler(this.DivisonButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.SubtractionButton.ForeColor = System.Drawing.Color.Red;
            this.SubtractionButton.Location = new System.Drawing.Point(198, 189);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(41, 42);
            this.SubtractionButton.TabIndex = 16;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // NumZeroButton
            // 
            this.NumZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NumZeroButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumZeroButton.Location = new System.Drawing.Point(57, 237);
            this.NumZeroButton.Name = "NumZeroButton";
            this.NumZeroButton.Size = new System.Drawing.Size(41, 42);
            this.NumZeroButton.TabIndex = 17;
            this.NumZeroButton.Text = "0";
            this.NumZeroButton.UseVisualStyleBackColor = true;
            this.NumZeroButton.Click += new System.EventHandler(this.NumZeroButton_Click);
            // 
            // NegativePositiveButton
            // 
            this.NegativePositiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegativePositiveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NegativePositiveButton.Location = new System.Drawing.Point(104, 237);
            this.NegativePositiveButton.Name = "NegativePositiveButton";
            this.NegativePositiveButton.Size = new System.Drawing.Size(41, 42);
            this.NegativePositiveButton.TabIndex = 18;
            this.NegativePositiveButton.Text = "+/-";
            this.NegativePositiveButton.UseVisualStyleBackColor = true;
            this.NegativePositiveButton.Click += new System.EventHandler(this.NegativePositiveButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.DecimalButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DecimalButton.Location = new System.Drawing.Point(151, 237);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(41, 42);
            this.DecimalButton.TabIndex = 19;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.ForeColor = System.Drawing.Color.Red;
            this.AdditionButton.Location = new System.Drawing.Point(199, 237);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(41, 42);
            this.AdditionButton.TabIndex = 20;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.ForeColor = System.Drawing.Color.Red;
            this.EqualsButton.Location = new System.Drawing.Point(245, 189);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(42, 90);
            this.EqualsButton.TabIndex = 21;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // MemoryClearButton
            // 
            this.MemoryClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MemoryClearButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryClearButton.Location = new System.Drawing.Point(10, 96);
            this.MemoryClearButton.Name = "MemoryClearButton";
            this.MemoryClearButton.Size = new System.Drawing.Size(41, 42);
            this.MemoryClearButton.TabIndex = 22;
            this.MemoryClearButton.Text = "MC";
            this.MemoryClearButton.UseVisualStyleBackColor = true;
            this.MemoryClearButton.Click += new System.EventHandler(this.MemoryClearButton_Click);
            // 
            // MemoryRecallButton
            // 
            this.MemoryRecallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MemoryRecallButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryRecallButton.Location = new System.Drawing.Point(10, 142);
            this.MemoryRecallButton.Name = "MemoryRecallButton";
            this.MemoryRecallButton.Size = new System.Drawing.Size(41, 42);
            this.MemoryRecallButton.TabIndex = 23;
            this.MemoryRecallButton.Text = "MR";
            this.MemoryRecallButton.UseVisualStyleBackColor = true;
            this.MemoryRecallButton.Click += new System.EventHandler(this.MemoryRecallButton_Click);
            // 
            // MemoryAddButton
            // 
            this.MemoryAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MemoryAddButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryAddButton.Location = new System.Drawing.Point(10, 236);
            this.MemoryAddButton.Name = "MemoryAddButton";
            this.MemoryAddButton.Size = new System.Drawing.Size(41, 42);
            this.MemoryAddButton.TabIndex = 24;
            this.MemoryAddButton.Text = "M+";
            this.MemoryAddButton.UseVisualStyleBackColor = true;
            this.MemoryAddButton.Click += new System.EventHandler(this.MemoryAddButton_Click);
            // 
            // MemoryStoreButton
            // 
            this.MemoryStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.MemoryStoreButton.ForeColor = System.Drawing.Color.Red;
            this.MemoryStoreButton.Location = new System.Drawing.Point(10, 190);
            this.MemoryStoreButton.Name = "MemoryStoreButton";
            this.MemoryStoreButton.Size = new System.Drawing.Size(41, 42);
            this.MemoryStoreButton.TabIndex = 25;
            this.MemoryStoreButton.Text = "MS";
            this.MemoryStoreButton.UseVisualStyleBackColor = true;
            this.MemoryStoreButton.Click += new System.EventHandler(this.MemoryStoreButton_Click);
            // 
            // MemoryStoredTextBox
            // 
            this.MemoryStoredTextBox.Enabled = false;
            this.MemoryStoredTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryStoredTextBox.Location = new System.Drawing.Point(13, 56);
            this.MemoryStoredTextBox.Multiline = true;
            this.MemoryStoredTextBox.Name = "MemoryStoredTextBox";
            this.MemoryStoredTextBox.Size = new System.Drawing.Size(38, 34);
            this.MemoryStoredTextBox.TabIndex = 26;
            // 
            // ValueInMemoryTextBox
            // 
            this.ValueInMemoryTextBox.Enabled = false;
            this.ValueInMemoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueInMemoryTextBox.Location = new System.Drawing.Point(60, 56);
            this.ValueInMemoryTextBox.Multiline = true;
            this.ValueInMemoryTextBox.Name = "ValueInMemoryTextBox";
            this.ValueInMemoryTextBox.Size = new System.Drawing.Size(38, 34);
            this.ValueInMemoryTextBox.TabIndex = 27;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 290);
            this.Controls.Add(this.ValueInMemoryTextBox);
            this.Controls.Add(this.MemoryStoredTextBox);
            this.Controls.Add(this.MemoryStoreButton);
            this.Controls.Add(this.MemoryAddButton);
            this.Controls.Add(this.MemoryRecallButton);
            this.Controls.Add(this.MemoryClearButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.NegativePositiveButton);
            this.Controls.Add(this.NumZeroButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.DivisonButton);
            this.Controls.Add(this.NumEightButton);
            this.Controls.Add(this.NumSevenButton);
            this.Controls.Add(this.OneOverXButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.NumSixButton);
            this.Controls.Add(this.NumFiveButton);
            this.Controls.Add(this.NumNineButton);
            this.Controls.Add(this.SqareRootButton);
            this.Controls.Add(this.NumFourButton);
            this.Controls.Add(this.NumThreeButton);
            this.Controls.Add(this.NumTwoButton);
            this.Controls.Add(this.NumOneButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OutputTextBox);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NumOneButton;
        private System.Windows.Forms.Button NumTwoButton;
        private System.Windows.Forms.Button NumThreeButton;
        private System.Windows.Forms.Button NumFourButton;
        private System.Windows.Forms.Button SqareRootButton;
        private System.Windows.Forms.Button NumNineButton;
        private System.Windows.Forms.Button NumFiveButton;
        private System.Windows.Forms.Button NumSixButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button OneOverXButton;
        private System.Windows.Forms.Button NumSevenButton;
        private System.Windows.Forms.Button NumEightButton;
        private System.Windows.Forms.Button DivisonButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button NumZeroButton;
        private System.Windows.Forms.Button NegativePositiveButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button MemoryClearButton;
        private System.Windows.Forms.Button MemoryRecallButton;
        private System.Windows.Forms.Button MemoryAddButton;
        private System.Windows.Forms.Button MemoryStoreButton;
        private System.Windows.Forms.TextBox MemoryStoredTextBox;
        private System.Windows.Forms.TextBox ValueInMemoryTextBox;
    }
}

