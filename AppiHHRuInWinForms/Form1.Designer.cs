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
            CountOfPagesNumericUpDown = new NumericUpDown();
            label3 = new Label();
            OkButton = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
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
            VacantionFilterComboBox.Location = new Point(19, 161);
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
            panel1.Controls.Add(CountOfPagesNumericUpDown);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(OkButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(VacantionFilterComboBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 950);
            panel1.TabIndex = 3;
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
            label3.Location = new Point(30, 9);
            label3.Name = "label3";
            label3.Size = new Size(456, 37);
            label3.TabIndex = 4;
            label3.Text = "Количество страниц для аналитики";
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
            label2.Location = new Point(30, 113);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 2;
            label2.Text = "Тип аналитики";
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
        private Label label2;
        private NumericUpDown CountOfPagesNumericUpDown;
        private Label label3;
    }
}
