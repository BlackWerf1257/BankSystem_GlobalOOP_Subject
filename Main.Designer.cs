namespace Banking_System
{
    partial class Main
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
            Login_Button = new Button();
            Find_Button = new Button();
            Register_Button = new Button();
            ID_TextBox = new TextBox();
            PW_TextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Login_Button
            // 
            Login_Button.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Login_Button.Location = new Point(89, 349);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(162, 51);
            Login_Button.TabIndex = 0;
            Login_Button.Text = "로그인";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Find_Button
            // 
            Find_Button.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Find_Button.Location = new Point(288, 349);
            Find_Button.Name = "Find_Button";
            Find_Button.Size = new Size(162, 51);
            Find_Button.TabIndex = 1;
            Find_Button.Text = "정보 찾기";
            Find_Button.UseVisualStyleBackColor = true;
            Find_Button.Click += Find_Button_Click;
            // 
            // Register_Button
            // 
            Register_Button.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Register_Button.Location = new Point(496, 349);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(162, 51);
            Register_Button.TabIndex = 2;
            Register_Button.Text = "가입하기";
            Register_Button.UseVisualStyleBackColor = true;
            Register_Button.Click += Register_Button_Click;
            // 
            // ID_TextBox
            // 
            ID_TextBox.Location = new Point(186, 140);
            ID_TextBox.Name = "ID_TextBox";
            ID_TextBox.Size = new Size(472, 23);
            ID_TextBox.TabIndex = 3;
            // 
            // PW_TextBox
            // 
            PW_TextBox.Location = new Point(186, 224);
            PW_TextBox.Name = "PW_TextBox";
            PW_TextBox.Size = new Size(472, 23);
            PW_TextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 135);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 219);
            label2.Name = "label2";
            label2.Size = new Size(42, 28);
            label2.TabIndex = 6;
            label2.Text = "PW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(337, 60);
            label3.Name = "label3";
            label3.Size = new Size(98, 37);
            label3.TabIndex = 7;
            label3.Text = "로그인";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PW_TextBox);
            Controls.Add(ID_TextBox);
            Controls.Add(Register_Button);
            Controls.Add(Find_Button);
            Controls.Add(Login_Button);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Button;
        private Button Find_Button;
        private Button Register_Button;
        private TextBox ID_TextBox;
        private TextBox PW_TextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}