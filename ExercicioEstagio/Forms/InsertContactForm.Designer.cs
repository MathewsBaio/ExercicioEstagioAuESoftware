namespace ExercicioEstagio.Forms
{
    partial class InsertContactForm
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
            this.txt_operationTitle = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cbox_gender = new System.Windows.Forms.ComboBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_operationTitle
            // 
            this.txt_operationTitle.AutoSize = true;
            this.txt_operationTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operationTitle.Location = new System.Drawing.Point(138, 61);
            this.txt_operationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_operationTitle.Name = "txt_operationTitle";
            this.txt_operationTitle.Size = new System.Drawing.Size(245, 36);
            this.txt_operationTitle.TabIndex = 17;
            this.txt_operationTitle.Text = "Novo Contato";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(266, 437);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(153, 57);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(104, 437);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(153, 57);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cbox_gender
            // 
            this.cbox_gender.FormattingEnabled = true;
            this.cbox_gender.Location = new System.Drawing.Point(180, 264);
            this.cbox_gender.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_gender.Name = "cbox_gender";
            this.cbox_gender.Size = new System.Drawing.Size(160, 24);
            this.cbox_gender.TabIndex = 14;
            this.cbox_gender.SelectedIndexChanged += new System.EventHandler(this.cbox_gender_SelectedIndexChanged);
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(180, 339);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(160, 22);
            this.txt_city.TabIndex = 13;
            this.txt_city.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(180, 183);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 22);
            this.txt_name.TabIndex = 12;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // InsertContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 554);
            this.Controls.Add(this.txt_operationTitle);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cbox_gender);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertContactForm";
            this.Text = "Cadastrar Novo Contato";
            this.Load += new System.EventHandler(this.InsertContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_operationTitle;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cbox_gender;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}