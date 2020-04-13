namespace SemiAGM
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
            this.btnRefill = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(18, 21);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(326, 34);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(18, 61);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(326, 96);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(18, 163);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(197, 145);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(221, 163);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(123, 145);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 327);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button btnGet;
    }
}

