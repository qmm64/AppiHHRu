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
            panel2 = new Panel();
            panel3 = new Panel();
            TypeOfAnaliticLabel = new Label();
            ParamOfFindComboBox = new ComboBox();
            label4 = new Label();
            HardFindCheckBox = new CheckBox();
            CountOfPagesNumericUpDown = new NumericUpDown();
            label3 = new Label();
            OkButton = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountOfPagesNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // OutputListBox
            // 
            OutputListBox.FormattingEnabled = true;
            OutputListBox.Location = new Point(895, 136);
            OutputListBox.Name = "OutputListBox";
            OutputListBox.Size = new Size(929, 744);
            OutputListBox.TabIndex = 0;
            // 
            // VacantionFilterComboBox
            // 
            VacantionFilterComboBox.FormattingEnabled = true;
            VacantionFilterComboBox.Location = new Point(5, 59);
            VacantionFilterComboBox.Name = "VacantionFilterComboBox";
            VacantionFilterComboBox.Size = new Size(627, 45);
            VacantionFilterComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(895, 80);
            label1.Name = "label1";
            label1.Size = new Size(115, 37);
            label1.TabIndex = 2;
            label1.Text = "Данные";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(HardFindCheckBox);
            panel1.Controls.Add(CountOfPagesNumericUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(OkButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 950);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ParamOfFindComboBox);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 217);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(TypeOfAnaliticLabel);
            panel3.Controls.Add(VacantionFilterComboBox);
            panel3.Location = new Point(3, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 113);
            panel3.TabIndex = 9;
            // 
            // TypeOfAnaliticLabel
            // 
            TypeOfAnaliticLabel.AutoSize = true;
            TypeOfAnaliticLabel.Location = new Point(16, 11);
            TypeOfAnaliticLabel.Name = "TypeOfAnaliticLabel";
            TypeOfAnaliticLabel.Size = new Size(200, 37);
            TypeOfAnaliticLabel.TabIndex = 2;
            TypeOfAnaliticLabel.Text = "Тип аналитики";
            // 
            // ParamOfFindComboBox
            // 
            ParamOfFindComboBox.FormattingEnabled = true;
            ParamOfFindComboBox.Location = new Point(19, 58);
            ParamOfFindComboBox.Name = "ParamOfFindComboBox";
            ParamOfFindComboBox.Size = new Size(272, 45);
            ParamOfFindComboBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(234, 37);
            label4.TabIndex = 7;
            label4.Text = "Параметр поиска";
            // 
            // HardFindCheckBox
            // 
            HardFindCheckBox.AutoSize = true;
            HardFindCheckBox.Location = new Point(19, 118);
            HardFindCheckBox.Name = "HardFindCheckBox";
            HardFindCheckBox.Size = new Size(247, 41);
            HardFindCheckBox.TabIndex = 6;
            HardFindCheckBox.Text = "Сложный поиск";
            HardFindCheckBox.UseVisualStyleBackColor = true;
            HardFindCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // CountOfPagesNumericUpDown
            // 
            CountOfPagesNumericUpDown.Location = new Point(19, 49);
            CountOfPagesNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CountOfPagesNumericUpDown.Name = "CountOfPagesNumericUpDown";
            CountOfPagesNumericUpDown.Size = new Size(102, 43);
            CountOfPagesNumericUpDown.TabIndex = 5;
            CountOfPagesNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            CountOfPagesNumericUpDown.ValueChanged += CountOfPagesNumericUpDown_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 9);
            label3.Name = "label3";
            label3.Size = new Size(456, 37);
            label3.TabIndex = 4;
            label3.Text = "Количество страниц для аналитики";
            label3.Click += label3_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(12, 879);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(745, 59);
            OkButton.TabIndex = 3;
            OkButton.Text = "Выполнить аналитику";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(140, 37);
            label2.TabIndex = 9;
            label2.Text = "Параметр";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 45);
            comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1869, 950);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(OutputListBox);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountOfPagesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox OutputListBox;
        private ComboBox VacantionFilterComboBox;
        private Label label1;
        private Panel panel1;
        private Button OkButton;
        private Label TypeOfAnaliticLabel;
        private NumericUpDown CountOfPagesNumericUpDown;
        private Label label3;
        private CheckBox HardFindCheckBox;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private ComboBox ParamOfFindComboBox;
        private Label label2;
        private ComboBox comboBox1;
    }
}
