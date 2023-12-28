namespace Banking_System
{
    partial class Register_Form
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
            Register_Button = new Button();
            Register_Cancel_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ID_TextBox = new TextBox();
            PW_TextBox = new TextBox();
            Name_TextBox = new TextBox();
            Age_TextBox = new TextBox();
            HP_TextBox = new TextBox();
            SuspendLayout();
            // 
            // Register_Button
            // 
            Register_Button.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Register_Button.Location = new Point(140, 358);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(190, 67);
            Register_Button.TabIndex = 0;
            Register_Button.Text = "가입하기";
            Register_Button.UseVisualStyleBackColor = true;
            Register_Button.Click += Register_Button_Click;
            // 
            // Register_Cancel_Button
            // 
            Register_Cancel_Button.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Register_Cancel_Button.Location = new Point(452, 358);
            Register_Cancel_Button.Name = "Register_Cancel_Button";
            Register_Cancel_Button.Size = new Size(190, 67);
            Register_Cancel_Button.TabIndex = 1;
            Register_Cancel_Button.Text = "가입 취소하기";
            Register_Cancel_Button.UseVisualStyleBackColor = true;
            Register_Cancel_Button.Click += Register_Cancel_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 96);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 3;
            label2.Text = "PW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 201);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 4;
            label3.Text = "이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(94, 248);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 5;
            label4.Text = "나이";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(94, 299);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 6;
            label5.Text = "전화번호";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(331, 31);
            label6.Name = "label6";
            label6.Size = new Size(125, 37);
            label6.TabIndex = 7;
            label6.Text = "가입하기";
            // 
            // ID_TextBox
            // 
            ID_TextBox.Location = new Point(233, 101);
            ID_TextBox.Name = "ID_TextBox";
            ID_TextBox.Size = new Size(409, 23);
            ID_TextBox.TabIndex = 8;
            // 
            // PW_TextBox
            // 
            PW_TextBox.Location = new Point(233, 155);
            PW_TextBox.Name = "PW_TextBox";
            PW_TextBox.Size = new Size(409, 23);
            PW_TextBox.TabIndex = 9;
            // 
            // Name_TextBox
            // 
            Name_TextBox.Location = new Point(233, 209);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(409, 23);
            Name_TextBox.TabIndex = 10;
            // 
            // Age_TextBox
            // 
            Age_TextBox.Location = new Point(233, 256);
            Age_TextBox.Name = "Age_TextBox";
            Age_TextBox.Size = new Size(409, 23);
            Age_TextBox.TabIndex = 11;
            // 
            // HP_TextBox
            // 
            HP_TextBox.Location = new Point(233, 304);
            HP_TextBox.Name = "HP_TextBox";
            HP_TextBox.Size = new Size(409, 23);
            HP_TextBox.TabIndex = 12;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HP_TextBox);
            Controls.Add(Age_TextBox);
            Controls.Add(Name_TextBox);
            Controls.Add(PW_TextBox);
            Controls.Add(ID_TextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Register_Cancel_Button);
            Controls.Add(Register_Button);
            Name = "Register_Form";
            Text = "Register_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Register_Button;
        private Button Register_Cancel_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ID_TextBox;
        private TextBox PW_TextBox;
        private TextBox Name_TextBox;
        private TextBox Age_TextBox;
        private TextBox HP_TextBox;
    }
}