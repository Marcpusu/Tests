namespace Test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.extDateTimePicker3 = new Test.extDateTimePicker(this.components);
            this.extDateTimePicker2 = new Test.extDateTimePicker(this.components);
            this.extDataGridView1 = new Test.extDataGridView(this.components);
            this.extTextBoxEnters1 = new Test.Extensions.extTextBoxEnters(this.components);
            this.extDateTimePicker1 = new Test.extDateTimePicker(this.components);
            this.extMaskedTextBox1 = new Test.Extensions.extMaskedTextBox(this.components);
            this.extTextBoxDecimals1 = new Test.extTextBoxDecimals(this.components);
            this.extDateTimePicker4 = new Test.extDateTimePicker(this.components);
            this.extTextBoxDecimals2 = new Test.extTextBoxDecimals(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(342, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(100, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 191);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(138, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(630, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 14;
            // 
            // extDateTimePicker3
            // 
            this.extDateTimePicker3.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.extDateTimePicker3.Location = new System.Drawing.Point(256, 131);
            this.extDateTimePicker3.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.extDateTimePicker3.Name = "extDateTimePicker3";
            this.extDateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.extDateTimePicker3.TabIndex = 1;
            this.extDateTimePicker3.Value = new System.DateTime(2019, 12, 4, 13, 1, 49, 672);
            // 
            // extDateTimePicker2
            // 
            this.extDateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.extDateTimePicker2.Location = new System.Drawing.Point(462, 131);
            this.extDateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.extDateTimePicker2.Name = "extDateTimePicker2";
            this.extDateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.extDateTimePicker2.TabIndex = 2;
            this.extDateTimePicker2.Value = new System.DateTime(2019, 12, 4, 13, 1, 49, 679);
            // 
            // extDataGridView1
            // 
            this.extDataGridView1.AllowUserToAddRows = false;
            this.extDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.extDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.extDataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.extDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.extDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.extDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.extDataGridView1.EnableHeadersVisualStyles = false;
            this.extDataGridView1.GridColor = System.Drawing.Color.GhostWhite;
            this.extDataGridView1.Location = new System.Drawing.Point(216, 224);
            this.extDataGridView1.Name = "extDataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.extDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.extDataGridView1.Size = new System.Drawing.Size(240, 161);
            this.extDataGridView1.TabIndex = 13;
            // 
            // extTextBoxEnters1
            // 
            this.extTextBoxEnters1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.extTextBoxEnters1.Location = new System.Drawing.Point(216, 191);
            this.extTextBoxEnters1.Name = "extTextBoxEnters1";
            this.extTextBoxEnters1.PuntMilers = true;
            this.extTextBoxEnters1.Size = new System.Drawing.Size(161, 27);
            this.extTextBoxEnters1.TabIndex = 12;
            // 
            // extDateTimePicker1
            // 
            this.extDateTimePicker1.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.extDateTimePicker1.Location = new System.Drawing.Point(12, 157);
            this.extDateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.extDateTimePicker1.Name = "extDateTimePicker1";
            this.extDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.extDateTimePicker1.TabIndex = 11;
            this.extDateTimePicker1.Value = new System.DateTime(2019, 12, 4, 13, 1, 49, 722);
            // 
            // extMaskedTextBox1
            // 
            this.extMaskedTextBox1.Location = new System.Drawing.Point(12, 104);
            this.extMaskedTextBox1.Name = "extMaskedTextBox1";
            this.extMaskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.extMaskedTextBox1.TabIndex = 9;
            // 
            // extTextBoxDecimals1
            // 
            this.extTextBoxDecimals1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.extTextBoxDecimals1.Location = new System.Drawing.Point(12, 45);
            this.extTextBoxDecimals1.Name = "extTextBoxDecimals1";
            this.extTextBoxDecimals1.NumDecimals = 4;
            this.extTextBoxDecimals1.Size = new System.Drawing.Size(612, 27);
            this.extTextBoxDecimals1.TabIndex = 3;
            // 
            // extDateTimePicker4
            // 
            this.extDateTimePicker4.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extDateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.extDateTimePicker4.Location = new System.Drawing.Point(462, 171);
            this.extDateTimePicker4.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.extDateTimePicker4.Name = "extDateTimePicker4";
            this.extDateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.extDateTimePicker4.TabIndex = 15;
            // 
            // extTextBoxDecimals2
            // 
            this.extTextBoxDecimals2.Location = new System.Drawing.Point(579, 251);
            this.extTextBoxDecimals2.Name = "extTextBoxDecimals2";
            this.extTextBoxDecimals2.NumDecimals = 4;
            this.extTextBoxDecimals2.Size = new System.Drawing.Size(100, 20);
            this.extTextBoxDecimals2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 422);
            this.Controls.Add(this.extTextBoxDecimals2);
            this.Controls.Add(this.extDateTimePicker4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.extDateTimePicker3);
            this.Controls.Add(this.extDateTimePicker2);
            this.Controls.Add(this.extDataGridView1);
            this.Controls.Add(this.extTextBoxEnters1);
            this.Controls.Add(this.extDateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.extMaskedTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.extTextBoxDecimals1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Test.extTextBoxDecimals extTextBoxDecimals1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Extensions.extMaskedTextBox extMaskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private extDateTimePicker extDateTimePicker1;
        private Extensions.extTextBoxEnters extTextBoxEnters1;
        private extDataGridView extDataGridView1;
        private extDateTimePicker extDateTimePicker2;
        private extDateTimePicker extDateTimePicker3;
        private System.Windows.Forms.TextBox textBox2;
        private extDateTimePicker extDateTimePicker4;
        private extTextBoxDecimals extTextBoxDecimals2;
    }
}