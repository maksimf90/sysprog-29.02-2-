namespace sysprog_29._02_2_
{
    partial class FormUpd
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
            this.label4 = new System.Windows.Forms.Label();
            this.numberUpd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameUpd = new System.Windows.Forms.TextBox();
            this.buttonUpdt = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Введите номер для изменения";
            // 
            // numberUpd
            // 
            this.numberUpd.Location = new System.Drawing.Point(12, 70);
            this.numberUpd.Name = "numberUpd";
            this.numberUpd.Size = new System.Drawing.Size(220, 20);
            this.numberUpd.TabIndex = 16;
            this.numberUpd.TextChanged += new System.EventHandler(this.textBoxNumberUpdt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите имя для изменения";
            // 
            // nameUpd
            // 
            this.nameUpd.Location = new System.Drawing.Point(12, 26);
            this.nameUpd.Name = "nameUpd";
            this.nameUpd.Size = new System.Drawing.Size(220, 20);
            this.nameUpd.TabIndex = 14;
            // 
            // buttonUpdt
            // 
            this.buttonUpdt.Location = new System.Drawing.Point(13, 99);
            this.buttonUpdt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdt.Name = "buttonUpdt";
            this.buttonUpdt.Size = new System.Drawing.Size(219, 28);
            this.buttonUpdt.TabIndex = 13;
            this.buttonUpdt.Text = "принять";
            this.buttonUpdt.UseVisualStyleBackColor = true;
            this.buttonUpdt.Click += new System.EventHandler(this.buttonUpdt_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(12, 134);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(220, 23);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(246, 165);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberUpd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameUpd);
            this.Controls.Add(this.buttonUpdt);
            this.Name = "FormUpd";
            this.Text = "FormUpd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberUpd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameUpd;
        private System.Windows.Forms.Button buttonUpdt;
        private System.Windows.Forms.Button buttonDel;
    }
}