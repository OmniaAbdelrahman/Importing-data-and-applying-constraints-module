namespace File_Project1
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.default_value_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_radiobtn = new System.Windows.Forms.RadioButton();
            this.uniqe_radiobtn = new System.Windows.Forms.RadioButton();
            this.defaul_radiobtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.not_null_radiobtn = new System.Windows.Forms.RadioButton();
            this.columns_names_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sign_cmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.value_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.apply_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(866, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // default_value_txt
            // 
            this.default_value_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.default_value_txt.Location = new System.Drawing.Point(454, 246);
            this.default_value_txt.Name = "default_value_txt";
            this.default_value_txt.Size = new System.Drawing.Size(198, 20);
            this.default_value_txt.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(263, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Choose Default Value";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // check_radiobtn
            // 
            this.check_radiobtn.AutoSize = true;
            this.check_radiobtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_radiobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.check_radiobtn.Location = new System.Drawing.Point(630, 188);
            this.check_radiobtn.Name = "check_radiobtn";
            this.check_radiobtn.Size = new System.Drawing.Size(65, 24);
            this.check_radiobtn.TabIndex = 33;
            this.check_radiobtn.TabStop = true;
            this.check_radiobtn.Text = "Check";
            this.check_radiobtn.UseVisualStyleBackColor = true;
            // 
            // uniqe_radiobtn
            // 
            this.uniqe_radiobtn.AutoSize = true;
            this.uniqe_radiobtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqe_radiobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.uniqe_radiobtn.Location = new System.Drawing.Point(524, 188);
            this.uniqe_radiobtn.Name = "uniqe_radiobtn";
            this.uniqe_radiobtn.Size = new System.Drawing.Size(63, 24);
            this.uniqe_radiobtn.TabIndex = 32;
            this.uniqe_radiobtn.TabStop = true;
            this.uniqe_radiobtn.Text = "Uniqe";
            this.uniqe_radiobtn.UseVisualStyleBackColor = true;
            this.uniqe_radiobtn.CheckedChanged += new System.EventHandler(this.uniqe_radiobtn_CheckedChanged);
            // 
            // defaul_radiobtn
            // 
            this.defaul_radiobtn.AutoSize = true;
            this.defaul_radiobtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaul_radiobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.defaul_radiobtn.Location = new System.Drawing.Point(388, 188);
            this.defaul_radiobtn.Name = "defaul_radiobtn";
            this.defaul_radiobtn.Size = new System.Drawing.Size(109, 24);
            this.defaul_radiobtn.TabIndex = 31;
            this.defaul_radiobtn.TabStop = true;
            this.defaul_radiobtn.Text = "Default Value";
            this.defaul_radiobtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(263, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Constrains";
            // 
            // not_null_radiobtn
            // 
            this.not_null_radiobtn.AutoSize = true;
            this.not_null_radiobtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_null_radiobtn.ForeColor = System.Drawing.SystemColors.Control;
            this.not_null_radiobtn.Location = new System.Drawing.Point(267, 188);
            this.not_null_radiobtn.Name = "not_null_radiobtn";
            this.not_null_radiobtn.Size = new System.Drawing.Size(77, 24);
            this.not_null_radiobtn.TabIndex = 30;
            this.not_null_radiobtn.TabStop = true;
            this.not_null_radiobtn.Text = "Not Null";
            this.not_null_radiobtn.UseVisualStyleBackColor = true;
            // 
            // columns_names_cmb
            // 
            this.columns_names_cmb.FormattingEnabled = true;
            this.columns_names_cmb.Location = new System.Drawing.Point(416, 39);
            this.columns_names_cmb.Name = "columns_names_cmb";
            this.columns_names_cmb.Size = new System.Drawing.Size(198, 21);
            this.columns_names_cmb.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(263, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Choose Column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(263, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Enter Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(263, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Choose sign";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sign_cmb
            // 
            this.sign_cmb.FormattingEnabled = true;
            this.sign_cmb.Items.AddRange(new object[] {
            "<",
            ">",
            "=",
            "!="});
            this.sign_cmb.Location = new System.Drawing.Point(454, 280);
            this.sign_cmb.Name = "sign_cmb";
            this.sign_cmb.Size = new System.Drawing.Size(198, 21);
            this.sign_cmb.TabIndex = 40;
            this.sign_cmb.SelectedIndexChanged += new System.EventHandler(this.sign_cmb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(849, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // value_txt
            // 
            this.value_txt.Location = new System.Drawing.Point(454, 317);
            this.value_txt.Name = "value_txt";
            this.value_txt.Size = new System.Drawing.Size(198, 20);
            this.value_txt.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.Image = global::File_Project1.Properties.Resources.n4;
            this.button2.Location = new System.Drawing.Point(630, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 75);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackgroundImage = global::File_Project1.Properties.Resources.icons8_save_button_64;
            this.save_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.save_btn.Location = new System.Drawing.Point(524, 358);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(60, 70);
            this.save_btn.TabIndex = 12;
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // apply_btn
            // 
            this.apply_btn.BackgroundImage = global::File_Project1.Properties.Resources.icons8_checkmark_64;
            this.apply_btn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.apply_btn.Location = new System.Drawing.Point(362, 358);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(62, 70);
            this.apply_btn.TabIndex = 11;
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(926, 440);
            this.Controls.Add(this.value_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sign_cmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.default_value_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.check_radiobtn);
            this.Controls.Add(this.uniqe_radiobtn);
            this.Controls.Add(this.defaul_radiobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.not_null_radiobtn);
            this.Controls.Add(this.columns_names_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.apply_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox default_value_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton check_radiobtn;
        private System.Windows.Forms.RadioButton uniqe_radiobtn;
        private System.Windows.Forms.RadioButton defaul_radiobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton not_null_radiobtn;
        private System.Windows.Forms.ComboBox columns_names_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sign_cmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox value_txt;
    }
}