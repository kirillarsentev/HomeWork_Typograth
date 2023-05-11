namespace Typograth_Application
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.to_do_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1155, 588);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // to_do_btn
            // 
            this.to_do_btn.Location = new System.Drawing.Point(990, 645);
            this.to_do_btn.Name = "to_do_btn";
            this.to_do_btn.Size = new System.Drawing.Size(177, 37);
            this.to_do_btn.TabIndex = 1;
            this.to_do_btn.Text = "Редактировать";
            this.to_do_btn.UseVisualStyleBackColor = true;
            this.to_do_btn.Click += new System.EventHandler(this.buttonToDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1179, 757);
            this.Controls.Add(this.to_do_btn);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Типограф";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button to_do_btn;
    }
}

