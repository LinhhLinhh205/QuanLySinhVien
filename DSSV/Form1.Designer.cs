namespace DSSV
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
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtHo = new TextBox();
            checkPhai = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtHocBong = new TextBox();
            txtNoiSinh = new TextBox();
            label7 = new Label();
            label4 = new Label();
            comKhoa = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            btnTruoc = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(129, 46);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(443, 27);
            txtMa.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(440, 77);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(132, 27);
            txtTen.TabIndex = 7;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(129, 77);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(297, 27);
            txtHo.TabIndex = 8;
            // 
            // checkPhai
            // 
            checkPhai.CheckAlign = ContentAlignment.MiddleRight;
            checkPhai.Location = new Point(32, 118);
            checkPhai.Name = "checkPhai";
            checkPhai.Size = new Size(111, 23);
            checkPhai.TabIndex = 5;
            checkPhai.Text = "Giới tính";
            checkPhai.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 85);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 3;
            label2.Text = "Họ tên SV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 54);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã SV";
            // 
            // txtHocBong
            // 
            txtHocBong.Location = new Point(129, 180);
            txtHocBong.Name = "txtHocBong";
            txtHocBong.Size = new Size(124, 27);
            txtHocBong.TabIndex = 11;
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.Location = new Point(129, 147);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(124, 27);
            txtNoiSinh.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 188);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 9;
            label7.Text = "Học bổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 155);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 10;
            label4.Text = "Nơi Sinh";
            // 
            // comKhoa
            // 
            comKhoa.FormattingEnabled = true;
            comKhoa.Location = new Point(392, 146);
            comKhoa.Name = "comKhoa";
            comKhoa.Size = new Size(180, 27);
            comKhoa.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 186);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 13;
            label3.Text = "Tổng điểm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 155);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 14;
            label5.Text = "Khoa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 119);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 14;
            label6.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(392, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Blue;
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(603, 43);
            label8.TabIndex = 18;
            label8.Text = "DANH SÁCH SINH VIÊN";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTruoc
            // 
            btnTruoc.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTruoc.ForeColor = Color.Maroon;
            btnTruoc.Location = new Point(37, 220);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(75, 39);
            btnTruoc.TabIndex = 19;
            btnTruoc.Text = "Trước";
            btnTruoc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(173, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 20;
            button1.Text = "Sau";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(333, 220);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 21;
            button2.Text = "Huỷ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Maroon;
            button3.Location = new Point(413, 220);
            button3.Name = "button3";
            button3.Size = new Size(75, 39);
            button3.TabIndex = 22;
            button3.Text = "Ghi";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Maroon;
            button4.Location = new Point(493, 220);
            button4.Name = "button4";
            button4.Size = new Size(75, 39);
            button4.TabIndex = 23;
            button4.Text = "Không";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Maroon;
            button5.Location = new Point(253, 220);
            button5.Name = "button5";
            button5.Size = new Size(75, 39);
            button5.TabIndex = 24;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 230);
            label9.Name = "label9";
            label9.Size = new Size(51, 19);
            label9.TabIndex = 25;
            label9.Text = "00/00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 286);
            Controls.Add(label9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTruoc);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(comKhoa);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHocBong);
            Controls.Add(txtNoiSinh);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(checkPhai);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "QLSV Access";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtHo;
        private CheckBox checkPhai;
        private Label label2;
        private Label label1;
        private TextBox txtHocBong;
        private TextBox txtNoiSinh;
        private Label label7;
        private Label label4;
        private ComboBox comKhoa;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Button btnTruoc;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label9;
    }
}
