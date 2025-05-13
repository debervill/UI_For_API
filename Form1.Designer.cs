using System.Net.Http;
using System.Net.Http.Json;

namespace UI_For_API
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
            label1 = new Label();
            label2 = new Label();
            userAdd = new Button();
            userEdit = new Button();
            booksAdd = new Button();
            booksEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Пользователи";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(557, 56);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Книги";
            label2.Click += label2_Click;
            // 
            // UserAdd
            // 
            userAdd.Location = new Point(111, 111);
            userAdd.Name = "UserAdd";
            userAdd.Size = new Size(94, 29);
            userAdd.TabIndex = 2;
            userAdd.Text = "Добавить";
            userAdd.UseVisualStyleBackColor = true;
            userAdd.Click += button1_Click_1;
            // 
            // userEdit
            // 
            userEdit.Location = new Point(96, 176);
            userEdit.Name = "userEdit";
            userEdit.Size = new Size(122, 29);
            userEdit.TabIndex = 3;
            userEdit.Text = "Редактировать";
            userEdit.UseVisualStyleBackColor = true;
            // 
            // booksAdd
            // 
            booksAdd.Location = new Point(543, 111);
            booksAdd.Name = "booksAdd";
            booksAdd.Size = new Size(94, 29);
            booksAdd.TabIndex = 4;
            booksAdd.Text = "Добавить";
            booksAdd.UseVisualStyleBackColor = true;
            // 
            // BooksEdit
            // 
            booksEdit.Location = new Point(531, 176);
            booksEdit.Name = "BooksEdit";
            booksEdit.RightToLeft = RightToLeft.Yes;
            booksEdit.Size = new Size(128, 29);
            booksEdit.TabIndex = 5;
            booksEdit.Text = "Редактировать";
            booksEdit.UseVisualStyleBackColor = true;
            booksEdit.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(booksEdit);
            Controls.Add(booksAdd);
            Controls.Add(userEdit);
            Controls.Add(userAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button userAdd;
        private Button userEdit;
        private Button booksAdd;
        private Button booksEdit;
    }
}
