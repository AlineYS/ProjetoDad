
namespace ProjetoDad
{
    partial class Form4
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
            this.mtxtCpfEx = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtCpfEx
            // 
            this.mtxtCpfEx.Location = new System.Drawing.Point(48, 37);
            this.mtxtCpfEx.Mask = "999.999.999-99";
            this.mtxtCpfEx.Name = "mtxtCpfEx";
            this.mtxtCpfEx.Size = new System.Drawing.Size(132, 20);
            this.mtxtCpfEx.TabIndex = 0;
            this.mtxtCpfEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCpfEx_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(12, 40);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 275);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.mtxtCpfEx);
            this.Name = "Form4";
            this.Text = "Excluir Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtCpfEx;
        private System.Windows.Forms.Label lblCpf;
    }
}