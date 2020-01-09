namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.area_result = new System.Windows.Forms.TextBox();
            this.input_one = new System.Windows.Forms.Button();
            this.input_two = new System.Windows.Forms.Button();
            this.input_thr = new System.Windows.Forms.Button();
            this.input_six = new System.Windows.Forms.Button();
            this.input_five = new System.Windows.Forms.Button();
            this.input_four = new System.Windows.Forms.Button();
            this.input_nine = new System.Windows.Forms.Button();
            this.input_eight = new System.Windows.Forms.Button();
            this.input_seven = new System.Windows.Forms.Button();
            this.input_end = new System.Windows.Forms.Button();
            this.input_zero = new System.Windows.Forms.Button();
            this.input_hundred = new System.Windows.Forms.Button();
            this.input_plus = new System.Windows.Forms.Button();
            this.input_minus = new System.Windows.Forms.Button();
            this.input_multipli = new System.Windows.Forms.Button();
            this.input_Division = new System.Windows.Forms.Button();
            this.area_process = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(151, 29);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Calculator";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // area_result
            // 
            this.area_result.CausesValidation = false;
            this.area_result.Font = new System.Drawing.Font("굴림", 12F);
            this.area_result.Location = new System.Drawing.Point(17, 84);
            this.area_result.Name = "area_result";
            this.area_result.ReadOnly = true;
            this.area_result.Size = new System.Drawing.Size(356, 26);
            this.area_result.TabIndex = 1;
            // 
            // input_one
            // 
            this.input_one.Location = new System.Drawing.Point(17, 116);
            this.input_one.Name = "input_one";
            this.input_one.Size = new System.Drawing.Size(99, 29);
            this.input_one.TabIndex = 2;
            this.input_one.Text = "1";
            this.input_one.UseVisualStyleBackColor = true;
            this.input_one.Click += new System.EventHandler(this.input_one_Click);
            // 
            // input_two
            // 
            this.input_two.Location = new System.Drawing.Point(122, 116);
            this.input_two.Name = "input_two";
            this.input_two.Size = new System.Drawing.Size(99, 29);
            this.input_two.TabIndex = 3;
            this.input_two.Text = "2";
            this.input_two.UseVisualStyleBackColor = true;
            this.input_two.Click += new System.EventHandler(this.input_two_Click);
            // 
            // input_thr
            // 
            this.input_thr.Location = new System.Drawing.Point(227, 116);
            this.input_thr.Name = "input_thr";
            this.input_thr.Size = new System.Drawing.Size(99, 29);
            this.input_thr.TabIndex = 4;
            this.input_thr.Text = "3";
            this.input_thr.UseVisualStyleBackColor = true;
            this.input_thr.Click += new System.EventHandler(this.input_thr_Click);
            // 
            // input_six
            // 
            this.input_six.Location = new System.Drawing.Point(227, 151);
            this.input_six.Name = "input_six";
            this.input_six.Size = new System.Drawing.Size(99, 29);
            this.input_six.TabIndex = 7;
            this.input_six.Text = "6";
            this.input_six.UseVisualStyleBackColor = true;
            this.input_six.Click += new System.EventHandler(this.input_six_Click);
            // 
            // input_five
            // 
            this.input_five.Location = new System.Drawing.Point(122, 151);
            this.input_five.Name = "input_five";
            this.input_five.Size = new System.Drawing.Size(99, 29);
            this.input_five.TabIndex = 6;
            this.input_five.Text = "5";
            this.input_five.UseVisualStyleBackColor = true;
            this.input_five.Click += new System.EventHandler(this.input_five_Click);
            // 
            // input_four
            // 
            this.input_four.Location = new System.Drawing.Point(17, 151);
            this.input_four.Name = "input_four";
            this.input_four.Size = new System.Drawing.Size(99, 29);
            this.input_four.TabIndex = 5;
            this.input_four.Text = "4";
            this.input_four.UseVisualStyleBackColor = true;
            this.input_four.Click += new System.EventHandler(this.input_four_Click);
            // 
            // input_nine
            // 
            this.input_nine.Location = new System.Drawing.Point(227, 186);
            this.input_nine.Name = "input_nine";
            this.input_nine.Size = new System.Drawing.Size(99, 29);
            this.input_nine.TabIndex = 10;
            this.input_nine.Text = "9";
            this.input_nine.UseVisualStyleBackColor = true;
            this.input_nine.Click += new System.EventHandler(this.input_nine_Click);
            // 
            // input_eight
            // 
            this.input_eight.Location = new System.Drawing.Point(122, 186);
            this.input_eight.Name = "input_eight";
            this.input_eight.Size = new System.Drawing.Size(99, 29);
            this.input_eight.TabIndex = 9;
            this.input_eight.Text = "8";
            this.input_eight.UseVisualStyleBackColor = true;
            this.input_eight.Click += new System.EventHandler(this.input_eight_Click);
            // 
            // input_seven
            // 
            this.input_seven.Location = new System.Drawing.Point(17, 186);
            this.input_seven.Name = "input_seven";
            this.input_seven.Size = new System.Drawing.Size(99, 29);
            this.input_seven.TabIndex = 8;
            this.input_seven.Text = "7";
            this.input_seven.UseVisualStyleBackColor = true;
            this.input_seven.Click += new System.EventHandler(this.input_seven_Click);
            // 
            // input_end
            // 
            this.input_end.Location = new System.Drawing.Point(227, 221);
            this.input_end.Name = "input_end";
            this.input_end.Size = new System.Drawing.Size(99, 29);
            this.input_end.TabIndex = 13;
            this.input_end.Text = "=";
            this.input_end.UseVisualStyleBackColor = true;
            // 
            // input_zero
            // 
            this.input_zero.Location = new System.Drawing.Point(122, 221);
            this.input_zero.Name = "input_zero";
            this.input_zero.Size = new System.Drawing.Size(99, 29);
            this.input_zero.TabIndex = 12;
            this.input_zero.Text = "0";
            this.input_zero.UseVisualStyleBackColor = true;
            this.input_zero.Click += new System.EventHandler(this.input_zero_Click);
            // 
            // input_hundred
            // 
            this.input_hundred.Location = new System.Drawing.Point(17, 221);
            this.input_hundred.Name = "input_hundred";
            this.input_hundred.Size = new System.Drawing.Size(99, 29);
            this.input_hundred.TabIndex = 11;
            this.input_hundred.Text = "00";
            this.input_hundred.UseVisualStyleBackColor = true;
            this.input_hundred.Click += new System.EventHandler(this.input_hundred_Click);
            // 
            // input_plus
            // 
            this.input_plus.Font = new System.Drawing.Font("굴림", 12F);
            this.input_plus.Location = new System.Drawing.Point(333, 116);
            this.input_plus.Name = "input_plus";
            this.input_plus.Size = new System.Drawing.Size(40, 29);
            this.input_plus.TabIndex = 14;
            this.input_plus.Text = "+";
            this.input_plus.UseVisualStyleBackColor = true;
            this.input_plus.Click += new System.EventHandler(this.input_plus_Click);
            // 
            // input_minus
            // 
            this.input_minus.Font = new System.Drawing.Font("굴림", 12F);
            this.input_minus.Location = new System.Drawing.Point(333, 151);
            this.input_minus.Name = "input_minus";
            this.input_minus.Size = new System.Drawing.Size(40, 29);
            this.input_minus.TabIndex = 15;
            this.input_minus.Text = "-";
            this.input_minus.UseVisualStyleBackColor = true;
            // 
            // input_multipli
            // 
            this.input_multipli.Font = new System.Drawing.Font("굴림", 12F);
            this.input_multipli.Location = new System.Drawing.Point(333, 186);
            this.input_multipli.Name = "input_multipli";
            this.input_multipli.Size = new System.Drawing.Size(40, 29);
            this.input_multipli.TabIndex = 16;
            this.input_multipli.Text = "×";
            this.input_multipli.UseVisualStyleBackColor = true;
            // 
            // input_Division
            // 
            this.input_Division.Font = new System.Drawing.Font("굴림", 12F);
            this.input_Division.Location = new System.Drawing.Point(333, 221);
            this.input_Division.Name = "input_Division";
            this.input_Division.Size = new System.Drawing.Size(40, 29);
            this.input_Division.TabIndex = 17;
            this.input_Division.Text = "÷";
            this.input_Division.UseVisualStyleBackColor = true;
            // 
            // area_process
            // 
            this.area_process.Location = new System.Drawing.Point(17, 57);
            this.area_process.Name = "area_process";
            this.area_process.ReadOnly = true;
            this.area_process.Size = new System.Drawing.Size(356, 21);
            this.area_process.TabIndex = 18;
            this.area_process.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 274);
            this.Controls.Add(this.area_process);
            this.Controls.Add(this.input_Division);
            this.Controls.Add(this.input_multipli);
            this.Controls.Add(this.input_minus);
            this.Controls.Add(this.input_plus);
            this.Controls.Add(this.input_end);
            this.Controls.Add(this.input_zero);
            this.Controls.Add(this.input_hundred);
            this.Controls.Add(this.input_nine);
            this.Controls.Add(this.input_eight);
            this.Controls.Add(this.input_seven);
            this.Controls.Add(this.input_six);
            this.Controls.Add(this.input_five);
            this.Controls.Add(this.input_four);
            this.Controls.Add(this.input_thr);
            this.Controls.Add(this.input_two);
            this.Controls.Add(this.input_one);
            this.Controls.Add(this.area_result);
            this.Controls.Add(this.label_name);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox area_result;
        private System.Windows.Forms.Button input_one;
        private System.Windows.Forms.Button input_two;
        private System.Windows.Forms.Button input_thr;
        private System.Windows.Forms.Button input_six;
        private System.Windows.Forms.Button input_five;
        private System.Windows.Forms.Button input_four;
        private System.Windows.Forms.Button input_nine;
        private System.Windows.Forms.Button input_eight;
        private System.Windows.Forms.Button input_seven;
        private System.Windows.Forms.Button input_end;
        private System.Windows.Forms.Button input_zero;
        private System.Windows.Forms.Button input_hundred;
        private System.Windows.Forms.Button input_plus;
        private System.Windows.Forms.Button input_minus;
        private System.Windows.Forms.Button input_multipli;
        private System.Windows.Forms.Button input_Division;
        private System.Windows.Forms.TextBox area_process;
    }
}

