namespace ExercicioEstagio.Forms
{
    partial class EditContactForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_operationTitle = new System.Windows.Forms.Label();
            this.cb_masculino = new System.Windows.Forms.CheckBox();
            this.cb_feminino = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(143, 178);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(217, 22);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(143, 334);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(217, 22);
            this.txt_city.TabIndex = 4;
            this.txt_city.TextChanged += new System.EventHandler(this.txt_city_TextChanged);
            this.txt_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_city_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(89, 434);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(153, 57);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(251, 434);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(153, 57);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_operationTitle
            // 
            this.txt_operationTitle.AutoSize = true;
            this.txt_operationTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operationTitle.ForeColor = System.Drawing.Color.White;
            this.txt_operationTitle.Location = new System.Drawing.Point(123, 58);
            this.txt_operationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_operationTitle.Name = "txt_operationTitle";
            this.txt_operationTitle.Size = new System.Drawing.Size(259, 36);
            this.txt_operationTitle.TabIndex = 8;
            this.txt_operationTitle.Text = "Editar Contato";
            // 
            // cb_masculino
            // 
            this.cb_masculino.AutoSize = true;
            this.cb_masculino.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_masculino.ForeColor = System.Drawing.Color.White;
            this.cb_masculino.Location = new System.Drawing.Point(143, 259);
            this.cb_masculino.Name = "cb_masculino";
            this.cb_masculino.Size = new System.Drawing.Size(109, 27);
            this.cb_masculino.TabIndex = 9;
            this.cb_masculino.Text = "Masculino";
            this.cb_masculino.UseVisualStyleBackColor = true;
            this.cb_masculino.CheckedChanged += new System.EventHandler(this.cb_masculino_CheckedChanged);
            // 
            // cb_feminino
            // 
            this.cb_feminino.AutoSize = true;
            this.cb_feminino.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_feminino.ForeColor = System.Drawing.Color.White;
            this.cb_feminino.Location = new System.Drawing.Point(258, 259);
            this.cb_feminino.Name = "cb_feminino";
            this.cb_feminino.Size = new System.Drawing.Size(102, 27);
            this.cb_feminino.TabIndex = 10;
            this.cb_feminino.Text = "Feminino";
            this.cb_feminino.UseVisualStyleBackColor = true;
            this.cb_feminino.CheckedChanged += new System.EventHandler(this.cb_feminino_CheckedChanged);
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(523, 554);
            this.Controls.Add(this.cb_feminino);
            this.Controls.Add(this.cb_masculino);
            this.Controls.Add(this.txt_operationTitle);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Contato";
            this.Load += new System.EventHandler(this.EditContactForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label txt_operationTitle;
        private System.Windows.Forms.CheckBox cb_masculino;
        private System.Windows.Forms.CheckBox cb_feminino;
    }
}