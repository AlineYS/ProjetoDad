
namespace ProjetoDad
{
    partial class Form3
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEnder = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTele = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtComple = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEnder = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComple = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(68, 55);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 16);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(68, 113);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblEnder
            // 
            this.lblEnder.AutoSize = true;
            this.lblEnder.Location = new System.Drawing.Point(44, 164);
            this.lblEnder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnder.Name = "lblEnder";
            this.lblEnder.Size = new System.Drawing.Size(69, 16);
            this.lblEnder.TabIndex = 2;
            this.lblEnder.Text = "Endereço:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCad);
            this.groupBox1.Controls.Add(this.mtxtCep);
            this.groupBox1.Controls.Add(this.mtxtTele);
            this.groupBox1.Controls.Add(this.mtxtCpf);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtComple);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtEnder);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblComple);
            this.groupBox1.Controls.Add(this.lblN);
            this.groupBox1.Controls.Add(this.lblTele);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblEnder);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Location = new System.Drawing.Point(51, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(839, 478);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Reativar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(52, 406);
            this.btnCad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(187, 28);
            this.btnCad.TabIndex = 25;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // mtxtCep
            // 
            this.mtxtCep.Location = new System.Drawing.Point(125, 260);
            this.mtxtCep.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCep.Mask = "99.999-999";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(132, 22);
            this.mtxtCep.TabIndex = 24;
            this.mtxtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // mtxtTele
            // 
            this.mtxtTele.Location = new System.Drawing.Point(125, 311);
            this.mtxtTele.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTele.Mask = "(999) 00000-0000";
            this.mtxtTele.Name = "mtxtTele";
            this.mtxtTele.Size = new System.Drawing.Size(195, 22);
            this.mtxtTele.TabIndex = 23;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(125, 52);
            this.mtxtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtCpf.Mask = "999.999.999-99";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(132, 22);
            this.mtxtCpf.TabIndex = 22;
            this.mtxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mtxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCpf_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(408, 311);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(421, 22);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(697, 255);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(132, 22);
            this.txtEstado.TabIndex = 20;
            this.txtEstado.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtComple
            // 
            this.txtComple.Location = new System.Drawing.Point(697, 208);
            this.txtComple.Margin = new System.Windows.Forms.Padding(4);
            this.txtComple.Name = "txtComple";
            this.txtComple.Size = new System.Drawing.Size(132, 22);
            this.txtComple.TabIndex = 19;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(355, 260);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(212, 22);
            this.txtCidade.TabIndex = 18;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(697, 162);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(132, 22);
            this.txtN.TabIndex = 17;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(125, 212);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(441, 22);
            this.txtBairro.TabIndex = 14;
            // 
            // txtEnder
            // 
            this.txtEnder.Location = new System.Drawing.Point(125, 160);
            this.txtEnder.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnder.Name = "txtEnder";
            this.txtEnder.Size = new System.Drawing.Size(441, 22);
            this.txtEnder.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 110);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(441, 22);
            this.txtNome.TabIndex = 12;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(351, 311);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "e-mail:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(632, 260);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 16);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(289, 263);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblComple
            // 
            this.lblComple.AutoSize = true;
            this.lblComple.Location = new System.Drawing.Point(591, 212);
            this.lblComple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComple.Name = "lblComple";
            this.lblComple.Size = new System.Drawing.Size(94, 16);
            this.lblComple.TabIndex = 7;
            this.lblComple.Text = "Complemento:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(668, 166);
            this.lblN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(17, 16);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "n:";
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Location = new System.Drawing.Point(48, 311);
            this.lblTele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(64, 16);
            this.lblTele.TabIndex = 5;
            this.lblTele.Text = "Telefone:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(68, 263);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(37, 16);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "CEP:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(68, 215);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 16);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro:";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(929, 437);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(232, 28);
            this.btnFoto.TabIndex = 4;
            this.btnFoto.Text = "Escolher foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(929, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 244);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEnder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComple;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtComple;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEnder;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.MaskedTextBox mtxtTele;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}