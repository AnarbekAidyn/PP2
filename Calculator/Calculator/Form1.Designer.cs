namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClearLast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClearE = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ZnakChange = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.PointFloat = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Inverse = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.MemoryMinus = new System.Windows.Forms.Button();
            this.MemoryPlus = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.MemoryReader = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearLast
            // 
            this.ClearLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearLast.FlatAppearance.BorderSize = 0;
            this.ClearLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearLast.Location = new System.Drawing.Point(12, 148);
            this.ClearLast.Name = "ClearLast";
            this.ClearLast.Size = new System.Drawing.Size(37, 27);
            this.ClearLast.TabIndex = 0;
            this.ClearLast.Text = "←";
            this.ClearLast.UseVisualStyleBackColor = false;
            this.ClearLast.Click += new System.EventHandler(this.ClearLast_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClearE
            // 
            this.ClearE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearE.FlatAppearance.BorderSize = 0;
            this.ClearE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearE.Location = new System.Drawing.Point(55, 148);
            this.ClearE.Name = "ClearE";
            this.ClearE.Size = new System.Drawing.Size(37, 27);
            this.ClearE.TabIndex = 2;
            this.ClearE.Text = "CE";
            this.ClearE.UseVisualStyleBackColor = false;
            this.ClearE.Click += new System.EventHandler(this.ClearE_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(98, 148);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(37, 27);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ZnakChange
            // 
            this.ZnakChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ZnakChange.FlatAppearance.BorderSize = 0;
            this.ZnakChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZnakChange.Location = new System.Drawing.Point(141, 148);
            this.ZnakChange.Name = "ZnakChange";
            this.ZnakChange.Size = new System.Drawing.Size(37, 27);
            this.ZnakChange.TabIndex = 4;
            this.ZnakChange.Text = "±";
            this.ZnakChange.UseVisualStyleBackColor = false;
            this.ZnakChange.Click += new System.EventHandler(this.ZnakChange_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sqrt.FlatAppearance.BorderSize = 0;
            this.Sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sqrt.Location = new System.Drawing.Point(184, 148);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(37, 27);
            this.Sqrt.TabIndex = 5;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = false;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Location = new System.Drawing.Point(141, 280);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(37, 27);
            this.Plus.TabIndex = 9;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.button17_Click);
            // 
            // PointFloat
            // 
            this.PointFloat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PointFloat.FlatAppearance.BorderSize = 0;
            this.PointFloat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointFloat.Location = new System.Drawing.Point(98, 280);
            this.PointFloat.Name = "PointFloat";
            this.PointFloat.Size = new System.Drawing.Size(37, 27);
            this.PointFloat.TabIndex = 8;
            this.PointFloat.Text = ",";
            this.PointFloat.UseVisualStyleBackColor = false;
            this.PointFloat.Click += new System.EventHandler(this.PointFloat_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.DarkGray;
            this.Zero.FlatAppearance.BorderSize = 0;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Location = new System.Drawing.Point(12, 280);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(80, 27);
            this.Zero.TabIndex = 6;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Result.FlatAppearance.BorderSize = 0;
            this.Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Result.Location = new System.Drawing.Point(184, 247);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 60);
            this.Result.TabIndex = 15;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Location = new System.Drawing.Point(141, 247);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(37, 27);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.button17_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.DarkGray;
            this.Three.FlatAppearance.BorderSize = 0;
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Location = new System.Drawing.Point(98, 247);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(37, 27);
            this.Three.TabIndex = 13;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.DarkGray;
            this.Two.FlatAppearance.BorderSize = 0;
            this.Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Two.Location = new System.Drawing.Point(55, 247);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(37, 27);
            this.Two.TabIndex = 12;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Digits_Click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.DarkGray;
            this.One.FlatAppearance.BorderSize = 0;
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Location = new System.Drawing.Point(12, 247);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(37, 27);
            this.One.TabIndex = 11;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Inverse
            // 
            this.Inverse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inverse.FlatAppearance.BorderSize = 0;
            this.Inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inverse.Location = new System.Drawing.Point(184, 214);
            this.Inverse.Name = "Inverse";
            this.Inverse.Size = new System.Drawing.Size(37, 27);
            this.Inverse.TabIndex = 20;
            this.Inverse.Text = "1/x";
            this.Inverse.UseVisualStyleBackColor = false;
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiply.FlatAppearance.BorderSize = 0;
            this.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiply.Location = new System.Drawing.Point(141, 214);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(37, 27);
            this.Multiply.TabIndex = 19;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.button17_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.DarkGray;
            this.Six.FlatAppearance.BorderSize = 0;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Location = new System.Drawing.Point(98, 214);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(37, 27);
            this.Six.TabIndex = 18;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.DarkGray;
            this.Five.FlatAppearance.BorderSize = 0;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Location = new System.Drawing.Point(55, 214);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(37, 27);
            this.Five.TabIndex = 17;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.DarkGray;
            this.Four.FlatAppearance.BorderSize = 0;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Four.Location = new System.Drawing.Point(12, 214);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(37, 27);
            this.Four.TabIndex = 16;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Percentage
            // 
            this.Percentage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Percentage.FlatAppearance.BorderSize = 0;
            this.Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percentage.Location = new System.Drawing.Point(184, 181);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(37, 27);
            this.Percentage.TabIndex = 25;
            this.Percentage.Text = "%";
            this.Percentage.UseVisualStyleBackColor = false;
            this.Percentage.Click += new System.EventHandler(this.button17_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Divide.FlatAppearance.BorderSize = 0;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Location = new System.Drawing.Point(141, 181);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(37, 27);
            this.Divide.TabIndex = 24;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.button17_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.DarkGray;
            this.Nine.FlatAppearance.BorderSize = 0;
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Location = new System.Drawing.Point(98, 181);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(37, 27);
            this.Nine.TabIndex = 23;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.DarkGray;
            this.Eight.FlatAppearance.BorderSize = 0;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Location = new System.Drawing.Point(55, 181);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(37, 27);
            this.Eight.TabIndex = 22;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Digits_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.DarkGray;
            this.Seven.FlatAppearance.BorderSize = 0;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Location = new System.Drawing.Point(12, 181);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(37, 27);
            this.Seven.TabIndex = 21;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Digits_Click);
            // 
            // MemoryMinus
            // 
            this.MemoryMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoryMinus.FlatAppearance.BorderSize = 0;
            this.MemoryMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemoryMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryMinus.Location = new System.Drawing.Point(184, 115);
            this.MemoryMinus.Name = "MemoryMinus";
            this.MemoryMinus.Size = new System.Drawing.Size(37, 27);
            this.MemoryMinus.TabIndex = 30;
            this.MemoryMinus.Text = "M-";
            this.MemoryMinus.UseVisualStyleBackColor = false;
            this.MemoryMinus.Click += new System.EventHandler(this.MemoryMinus_Click);
            // 
            // MemoryPlus
            // 
            this.MemoryPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoryPlus.FlatAppearance.BorderSize = 0;
            this.MemoryPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemoryPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryPlus.Location = new System.Drawing.Point(141, 115);
            this.MemoryPlus.Name = "MemoryPlus";
            this.MemoryPlus.Size = new System.Drawing.Size(37, 27);
            this.MemoryPlus.TabIndex = 29;
            this.MemoryPlus.Text = "M+";
            this.MemoryPlus.UseVisualStyleBackColor = false;
            this.MemoryPlus.Click += new System.EventHandler(this.MemoryPlus_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemorySave.FlatAppearance.BorderSize = 0;
            this.MemorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemorySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemorySave.Location = new System.Drawing.Point(98, 115);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(37, 27);
            this.MemorySave.TabIndex = 28;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = false;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // MemoryReader
            // 
            this.MemoryReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoryReader.FlatAppearance.BorderSize = 0;
            this.MemoryReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemoryReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryReader.Location = new System.Drawing.Point(55, 115);
            this.MemoryReader.Name = "MemoryReader";
            this.MemoryReader.Size = new System.Drawing.Size(37, 27);
            this.MemoryReader.TabIndex = 27;
            this.MemoryReader.Text = "MR";
            this.MemoryReader.UseVisualStyleBackColor = false;
            this.MemoryReader.Click += new System.EventHandler(this.MemoryReader_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoryClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.MemoryClear.FlatAppearance.BorderSize = 0;
            this.MemoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryClear.Location = new System.Drawing.Point(12, 115);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(37, 27);
            this.MemoryClear.TabIndex = 26;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = false;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Вид";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Правка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Справка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemoryMinus);
            this.Controls.Add(this.MemoryPlus);
            this.Controls.Add(this.MemorySave);
            this.Controls.Add(this.MemoryReader);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Inverse);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.PointFloat);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.ZnakChange);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClearLast);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Инжинерный калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearLast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ClearE;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ZnakChange;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button PointFloat;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Inverse;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Percentage;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button MemoryMinus;
        private System.Windows.Forms.Button MemoryPlus;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.Button MemoryReader;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

