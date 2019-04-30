namespace CalculatorC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.numpan = new System.Windows.Forms.Panel();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.dtndvd = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnneg = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnper = new System.Windows.Forms.Button();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnconvert = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.cbto = new MetroFramework.Controls.MetroComboBox();
            this.cbfrom = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.numpan.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lblstatus);
            this.panel1.Controls.Add(this.txtdisplay);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 47);
            this.panel1.TabIndex = 3;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstatus.Location = new System.Drawing.Point(0, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 1;
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtdisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtdisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdisplay.Location = new System.Drawing.Point(0, 16);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.Size = new System.Drawing.Size(246, 31);
            this.txtdisplay.TabIndex = 0;
            this.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Pressed);
            this.txtdisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdisplay_KeyPress);
            // 
            // numpan
            // 
            this.numpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.numpan.Controls.Add(this.btnequal);
            this.numpan.Controls.Add(this.btnadd);
            this.numpan.Controls.Add(this.btnsub);
            this.numpan.Controls.Add(this.btnmul);
            this.numpan.Controls.Add(this.btn1x);
            this.numpan.Controls.Add(this.dtndvd);
            this.numpan.Controls.Add(this.btndot);
            this.numpan.Controls.Add(this.btn3);
            this.numpan.Controls.Add(this.btn6);
            this.numpan.Controls.Add(this.btn9);
            this.numpan.Controls.Add(this.btnpow);
            this.numpan.Controls.Add(this.btndel);
            this.numpan.Controls.Add(this.btnneg);
            this.numpan.Controls.Add(this.btn0);
            this.numpan.Controls.Add(this.btn1);
            this.numpan.Controls.Add(this.btn2);
            this.numpan.Controls.Add(this.btn4);
            this.numpan.Controls.Add(this.btn5);
            this.numpan.Controls.Add(this.btn7);
            this.numpan.Controls.Add(this.btn8);
            this.numpan.Controls.Add(this.btnsqrt);
            this.numpan.Controls.Add(this.btnce);
            this.numpan.Controls.Add(this.btnc);
            this.numpan.Controls.Add(this.btnper);
            this.numpan.Location = new System.Drawing.Point(0, 60);
            this.numpan.Name = "numpan";
            this.numpan.Size = new System.Drawing.Size(246, 306);
            this.numpan.TabIndex = 4;
            this.numpan.Paint += new System.Windows.Forms.PaintEventHandler(this.Numpan_Paint);
            // 
            // btnequal
            // 
            this.btnequal.FlatAppearance.BorderSize = 0;
            this.btnequal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnequal.ForeColor = System.Drawing.Color.White;
            this.btnequal.Image = global::CalculatorC.Properties.Resources.icons8_equal_sign_30;
            this.btnequal.Location = new System.Drawing.Point(181, 257);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(50, 43);
            this.btnequal.TabIndex = 0;
            this.btnequal.TabStop = false;
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.Btnequal_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = global::CalculatorC.Properties.Resources.icons8_plus_math_30;
            this.btnadd.Location = new System.Drawing.Point(181, 208);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(50, 43);
            this.btnadd.TabIndex = 0;
            this.btnadd.TabStop = false;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.MathOperation);
            // 
            // btnsub
            // 
            this.btnsub.FlatAppearance.BorderSize = 0;
            this.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsub.ForeColor = System.Drawing.Color.White;
            this.btnsub.Image = global::CalculatorC.Properties.Resources.icons8_subtract_30;
            this.btnsub.Location = new System.Drawing.Point(181, 159);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(50, 43);
            this.btnsub.TabIndex = 0;
            this.btnsub.TabStop = false;
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.MathOperation);
            // 
            // btnmul
            // 
            this.btnmul.FlatAppearance.BorderSize = 0;
            this.btnmul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnmul.ForeColor = System.Drawing.Color.White;
            this.btnmul.Image = global::CalculatorC.Properties.Resources.icons8_multiply_filled_30;
            this.btnmul.Location = new System.Drawing.Point(181, 110);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(50, 43);
            this.btnmul.TabIndex = 0;
            this.btnmul.TabStop = false;
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.MathOperation);
            // 
            // btn1x
            // 
            this.btn1x.FlatAppearance.BorderSize = 0;
            this.btn1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1x.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn1x.Location = new System.Drawing.Point(181, 12);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(50, 43);
            this.btn1x.TabIndex = 0;
            this.btn1x.TabStop = false;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = true;
            this.btn1x.Click += new System.EventHandler(this.btnAdvancedCalc);
            // 
            // dtndvd
            // 
            this.dtndvd.FlatAppearance.BorderSize = 0;
            this.dtndvd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtndvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtndvd.ForeColor = System.Drawing.Color.White;
            this.dtndvd.Image = global::CalculatorC.Properties.Resources.icons8_divide_filled_30;
            this.dtndvd.Location = new System.Drawing.Point(181, 61);
            this.dtndvd.Name = "dtndvd";
            this.dtndvd.Size = new System.Drawing.Size(50, 43);
            this.dtndvd.TabIndex = 0;
            this.dtndvd.TabStop = false;
            this.dtndvd.UseVisualStyleBackColor = true;
            this.dtndvd.Click += new System.EventHandler(this.MathOperation);
            // 
            // btndot
            // 
            this.btndot.FlatAppearance.BorderSize = 0;
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndot.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndot.Location = new System.Drawing.Point(125, 257);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(50, 43);
            this.btndot.TabIndex = 0;
            this.btndot.TabStop = false;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn3.Location = new System.Drawing.Point(125, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 43);
            this.btn3.TabIndex = 0;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn6.Location = new System.Drawing.Point(125, 159);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 43);
            this.btn6.TabIndex = 0;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btn9
            // 
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn9.Location = new System.Drawing.Point(125, 110);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 43);
            this.btn9.TabIndex = 0;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btnpow
            // 
            this.btnpow.FlatAppearance.BorderSize = 0;
            this.btnpow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpow.ForeColor = System.Drawing.Color.White;
            this.btnpow.Image = global::CalculatorC.Properties.Resources.icons8_x2_30;
            this.btnpow.Location = new System.Drawing.Point(125, 12);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(50, 43);
            this.btnpow.TabIndex = 0;
            this.btnpow.TabStop = false;
            this.btnpow.UseVisualStyleBackColor = true;
            this.btnpow.Click += new System.EventHandler(this.MathOperation);
            // 
            // btndel
            // 
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Image = global::CalculatorC.Properties.Resources.icons8_back_arrow_30;
            this.btndel.Location = new System.Drawing.Point(125, 61);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(50, 43);
            this.btndel.TabIndex = 0;
            this.btndel.TabStop = false;
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btn_click);
            // 
            // btnneg
            // 
            this.btnneg.FlatAppearance.BorderSize = 0;
            this.btnneg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnneg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnneg.ForeColor = System.Drawing.Color.White;
            this.btnneg.Image = global::CalculatorC.Properties.Resources.icons8_plus_minus_30;
            this.btnneg.Location = new System.Drawing.Point(13, 257);
            this.btnneg.Name = "btnneg";
            this.btnneg.Size = new System.Drawing.Size(50, 43);
            this.btnneg.TabIndex = 0;
            this.btnneg.TabStop = false;
            this.btnneg.UseVisualStyleBackColor = true;
            this.btnneg.Click += new System.EventHandler(this.btn_click);
            // 
            // btn0
            // 
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn0.Location = new System.Drawing.Point(69, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 43);
            this.btn0.TabIndex = 0;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn1.Location = new System.Drawing.Point(13, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 43);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn2.Location = new System.Drawing.Point(69, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 43);
            this.btn2.TabIndex = 0;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn4.Location = new System.Drawing.Point(13, 159);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 43);
            this.btn4.TabIndex = 0;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn5.Location = new System.Drawing.Point(69, 159);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 43);
            this.btn5.TabIndex = 0;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn7
            // 
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn7.Location = new System.Drawing.Point(13, 110);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 43);
            this.btn7.TabIndex = 0;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // btn8
            // 
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn8.Location = new System.Drawing.Point(69, 110);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 43);
            this.btn8.TabIndex = 0;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btnsqrt
            // 
            this.btnsqrt.FlatAppearance.BorderSize = 0;
            this.btnsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsqrt.ForeColor = System.Drawing.Color.White;
            this.btnsqrt.Image = global::CalculatorC.Properties.Resources.icons8_square_root_30;
            this.btnsqrt.Location = new System.Drawing.Point(69, 12);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(50, 43);
            this.btnsqrt.TabIndex = 0;
            this.btnsqrt.TabStop = false;
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.btnAdvancedCalc);
            // 
            // btnce
            // 
            this.btnce.FlatAppearance.BorderSize = 0;
            this.btnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnce.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnce.Location = new System.Drawing.Point(13, 61);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(50, 43);
            this.btnce.TabIndex = 0;
            this.btnce.TabStop = false;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btn_click);
            // 
            // btnc
            // 
            this.btnc.FlatAppearance.BorderSize = 0;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnc.ForeColor = System.Drawing.Color.White;
            this.btnc.Location = new System.Drawing.Point(69, 61);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(50, 43);
            this.btnc.TabIndex = 0;
            this.btnc.TabStop = false;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btn_click);
            // 
            // btnper
            // 
            this.btnper.FlatAppearance.BorderSize = 0;
            this.btnper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnper.Image = global::CalculatorC.Properties.Resources.icons8_percentage_30;
            this.btnper.Location = new System.Drawing.Point(13, 12);
            this.btnper.Name = "btnper";
            this.btnper.Size = new System.Drawing.Size(50, 43);
            this.btnper.TabIndex = 0;
            this.btnper.TabStop = false;
            this.btnper.UseVisualStyleBackColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(254, 408);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.TabStop = false;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage1.Controls.Add(this.numpan);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(246, 366);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage2.Controls.Add(this.btnconvert);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.txtres);
            this.metroTabPage2.Controls.Add(this.txtamount);
            this.metroTabPage2.Controls.Add(this.cbto);
            this.metroTabPage2.Controls.Add(this.cbfrom);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(246, 366);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnconvert
            // 
            this.btnconvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnconvert.FlatAppearance.BorderSize = 0;
            this.btnconvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnconvert.Location = new System.Drawing.Point(-4, 237);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(254, 48);
            this.btnconvert.TabIndex = 5;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = false;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Amount:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(18, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Convert To:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroLabel1.Location = new System.Drawing.Point(-1, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Convert From:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtres
            // 
            this.txtres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtres.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtres.Location = new System.Drawing.Point(0, 26);
            this.txtres.Multiline = true;
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(246, 35);
            this.txtres.TabIndex = 3;
            this.txtres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtamount
            // 
            this.txtamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtamount.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtamount.Location = new System.Drawing.Point(107, 188);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(121, 29);
            this.txtamount.TabIndex = 3;
            // 
            // cbto
            // 
            this.cbto.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbto.FormattingEnabled = true;
            this.cbto.ItemHeight = 23;
            this.cbto.Items.AddRange(new object[] {
            "USD",
            "KZT",
            "RUB",
            "EUR",
            "GBP",
            "AUD",
            "CAD",
            "CHF",
            "CNY",
            "SEK",
            "NZD"});
            this.cbto.Location = new System.Drawing.Point(107, 140);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(121, 29);
            this.cbto.TabIndex = 2;
            this.cbto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbto.UseSelectable = true;
            // 
            // cbfrom
            // 
            this.cbfrom.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.ItemHeight = 23;
            this.cbfrom.Items.AddRange(new object[] {
            "USD",
            "KZT",
            "RUB",
            "EUR",
            "GBP",
            "AUD",
            "CAD",
            "CHF",
            "CNY",
            "SEK",
            "NZD"});
            this.cbfrom.Location = new System.Drawing.Point(107, 94);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(121, 29);
            this.cbfrom.TabIndex = 2;
            this.cbfrom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbfrom.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 481);
            this.Controls.Add(this.metroTabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "  Calculator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btn_click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.numpan.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Panel numpan;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button dtndvd;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnneg;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnper;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Label lblstatus;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button btnconvert;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.TextBox txtamount;
        private MetroFramework.Controls.MetroComboBox cbto;
        private MetroFramework.Controls.MetroComboBox cbfrom;
    }
}

