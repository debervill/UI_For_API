
namespace UI_For_API
{
    partial class UserAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            InputName = new TextBox();
            InputEmail = new TextBox();
            InputDolgnost = new TextBox();
            btnAdd = new Button();
            bntClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 42);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Добавить пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 129);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 183);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 241);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Должность";
            // 
            // InputName
            // 
            InputName.Location = new Point(258, 126);
            InputName.Name = "InputName";
            InputName.Size = new Size(381, 27);
            InputName.TabIndex = 4;
            // 
            // InputEmail
            // 
            InputEmail.Location = new Point(258, 183);
            InputEmail.Name = "InputEmail";
            InputEmail.Size = new Size(381, 27);
            InputEmail.TabIndex = 5;
            // 
            // InputDolgnost
            // 
            InputDolgnost.Location = new Point(258, 243);
            InputDolgnost.Name = "InputDolgnost";
            InputDolgnost.Size = new Size(381, 27);
            InputDolgnost.TabIndex = 6;
            InputDolgnost.TextChanged += InputDolgnost_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(288, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // bntClose
            // 
            bntClose.Location = new Point(481, 317);
            bntClose.Name = "bntClose";
            bntClose.Size = new Size(94, 29);
            bntClose.TabIndex = 8;
            bntClose.Text = "Закрыть";
            bntClose.UseVisualStyleBackColor = true;
            bntClose.Click += button2_Click;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntClose);
            Controls.Add(btnAdd);
            Controls.Add(InputDolgnost);
            Controls.Add(InputEmail);
            Controls.Add(InputName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserAdd";
            Text = "UserAdd";
            Load += UserAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox InputName;
        private TextBox InputEmail;
        private TextBox InputDolgnost;
        private Button btnAdd;
        private Button bntClose;
    }
}