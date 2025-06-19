namespace AppiHHRuInWinForms
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
            OutputListBox = new ListBox();
            VacantionFilterComboBox = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            TypeOfAnaliticLabel = new Label();
            panel2 = new Panel();
            ParamComboBox = new ComboBox();
            label2 = new Label();
            ParamOfFindComboBox = new ComboBox();
            label4 = new Label();
            HardFindCheckBox = new CheckBox();
            CountOfVacanciesNumericUpDown = new NumericUpDown();
            label3 = new Label();
            OkButton = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountOfVacanciesNumericUpDown).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // OutputListBox
            // 
            OutputListBox.FormattingEnabled = true;
            OutputListBox.Location = new Point(1, 31);
            OutputListBox.Margin = new Padding(1);
            OutputListBox.Name = "OutputListBox";
            OutputListBox.Size = new Size(596, 349);
            OutputListBox.TabIndex = 0;
            // 
            // VacantionFilterComboBox
            // 
            VacantionFilterComboBox.FormattingEnabled = true;
            VacantionFilterComboBox.Location = new Point(9, 24);
            VacantionFilterComboBox.Margin = new Padding(1);
            VacantionFilterComboBox.Name = "VacantionFilterComboBox";
            VacantionFilterComboBox.Size = new Size(247, 23);
            VacantionFilterComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 4);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Данные";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(HardFindCheckBox);
            panel1.Controls.Add(CountOfVacanciesNumericUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(OkButton);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 385);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(TypeOfAnaliticLabel);
            panel3.Controls.Add(VacantionFilterComboBox);
            panel3.Location = new Point(1, 161);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 54);
            panel3.TabIndex = 9;
            // 
            // TypeOfAnaliticLabel
            // 
            TypeOfAnaliticLabel.AutoSize = true;
            TypeOfAnaliticLabel.Location = new Point(8, 7);
            TypeOfAnaliticLabel.Margin = new Padding(1, 0, 1, 0);
            TypeOfAnaliticLabel.Name = "TypeOfAnaliticLabel";
            TypeOfAnaliticLabel.Size = new Size(89, 15);
            TypeOfAnaliticLabel.TabIndex = 2;
            TypeOfAnaliticLabel.Text = "Тип аналитики";
            // 
            // panel2
            // 
            panel2.Controls.Add(ParamComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ParamOfFindComboBox);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 73);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 88);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // ParamComboBox
            // 
            ParamComboBox.FormattingEnabled = true;
            ParamComboBox.Location = new Point(8, 63);
            ParamComboBox.Margin = new Padding(1);
            ParamComboBox.Name = "ParamComboBox";
            ParamComboBox.Size = new Size(247, 23);
            ParamComboBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 47);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 9;
            label2.Text = "Параметр";
            // 
            // ParamOfFindComboBox
            // 
            ParamOfFindComboBox.FormattingEnabled = true;
            ParamOfFindComboBox.Location = new Point(9, 24);
            ParamOfFindComboBox.Margin = new Padding(1);
            ParamOfFindComboBox.Name = "ParamOfFindComboBox";
            ParamOfFindComboBox.Size = new Size(247, 23);
            ParamOfFindComboBox.TabIndex = 8;
            ParamOfFindComboBox.SelectedIndexChanged += ParamOfFindComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 7);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Параметр поиска";
            // 
            // HardFindCheckBox
            // 
            HardFindCheckBox.AutoSize = true;
            HardFindCheckBox.Location = new Point(9, 48);
            HardFindCheckBox.Margin = new Padding(1);
            HardFindCheckBox.Name = "HardFindCheckBox";
            HardFindCheckBox.Size = new Size(116, 19);
            HardFindCheckBox.TabIndex = 6;
            HardFindCheckBox.Text = "Сложный поиск";
            HardFindCheckBox.UseVisualStyleBackColor = true;
            HardFindCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // CountOfPagesNumericUpDown
            // 
            CountOfVacanciesNumericUpDown.Location = new Point(9, 20);
            CountOfVacanciesNumericUpDown.Margin = new Padding(1);
            CountOfVacanciesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CountOfVacanciesNumericUpDown.Name = "CountOfPagesNumericUpDown";
            CountOfVacanciesNumericUpDown.Size = new Size(48, 23);
            CountOfVacanciesNumericUpDown.TabIndex = 5;
            CountOfVacanciesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            CountOfVacanciesNumericUpDown.ValueChanged += CountOfPagesNumericUpDown_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 4);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 15);
            label3.TabIndex = 4;
            label3.Text = "Количество страниц для аналитики";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(6, 356);
            OkButton.Margin = new Padding(1);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(249, 24);
            OkButton.TabIndex = 3;
            OkButton.Text = "Выполнить аналитику";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(OutputListBox);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(269, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(603, 385);
            panel4.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 385);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountOfVacanciesNumericUpDown).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox OutputListBox;
        private ComboBox VacantionFilterComboBox;
        private Label label1;
        private Panel panel1;
        private Button OkButton;
        private Label TypeOfAnaliticLabel;
        private NumericUpDown CountOfVacanciesNumericUpDown;
        private Label label3;
        private CheckBox HardFindCheckBox;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private ComboBox ParamOfFindComboBox;
        private Label label2;
        private ComboBox ParamComboBox;
        private Panel panel4;
    }
}
