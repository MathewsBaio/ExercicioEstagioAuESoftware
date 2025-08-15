namespace ExercicioEstagio
{
    partial class ListContactsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_contacts = new System.Windows.Forms.ListView();
            this.txt_report = new System.Windows.Forms.TextBox();
            this.btn_report = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 451);
            this.panel1.TabIndex = 1;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 191);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(98, 75);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Adicionar";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 272);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(98, 75);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 353);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 75);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Deletar";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Contatos";
            // 
            // list_contacts
            // 
            this.list_contacts.HideSelection = false;
            this.list_contacts.Location = new System.Drawing.Point(128, 59);
            this.list_contacts.Name = "list_contacts";
            this.list_contacts.Size = new System.Drawing.Size(695, 207);
            this.list_contacts.TabIndex = 3;
            this.list_contacts.UseCompatibleStateImageBehavior = false;
            // 
            // txt_report
            // 
            this.txt_report.Location = new System.Drawing.Point(128, 353);
            this.txt_report.Name = "txt_report";
            this.txt_report.Size = new System.Drawing.Size(695, 20);
            this.txt_report.TabIndex = 4;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(128, 320);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(165, 26);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "Gerar Relatório";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // ListContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(835, 451);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.txt_report);
            this.Controls.Add(this.list_contacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListContactsForm";
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.ListContactsForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_contacts;
        private System.Windows.Forms.TextBox txt_report;
        private System.Windows.Forms.Button btn_report;
    }
}

