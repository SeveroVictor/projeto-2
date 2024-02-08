
namespace WindowsFormsApp1
{
    partial class txtSistemaCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcCadastroCliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbcPesquisaCliente = new System.Windows.Forms.TabPage();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblNomeCompletoCliente = new System.Windows.Forms.Label();
            this.lblNomeSocialCliente = new System.Windows.Forms.Label();
            this.lblCepCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbcCadastroCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.lblCadastroCliente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 449);
            this.panel1.TabIndex = 0;
            // 
            // tbcCadastroCliente
            // 
            this.tbcCadastroCliente.Controls.Add(this.tabPage1);
            this.tbcCadastroCliente.Controls.Add(this.tbcPesquisaCliente);
            this.tbcCadastroCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCadastroCliente.Location = new System.Drawing.Point(228, 1);
            this.tbcCadastroCliente.Name = "tbcCadastroCliente";
            this.tbcCadastroCliente.SelectedIndex = 0;
            this.tbcCadastroCliente.Size = new System.Drawing.Size(573, 448);
            this.tbcCadastroCliente.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.maskedTextBox2);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblCepCliente);
            this.tabPage1.Controls.Add(this.lblNomeSocialCliente);
            this.tabPage1.Controls.Add(this.lblNomeCompletoCliente);
            this.tabPage1.Controls.Add(this.lblCPFCliente);
            this.tabPage1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro Cliente";
            // 
            // tbcPesquisaCliente
            // 
            this.tbcPesquisaCliente.BackColor = System.Drawing.Color.Ivory;
            this.tbcPesquisaCliente.Location = new System.Drawing.Point(4, 31);
            this.tbcPesquisaCliente.Name = "tbcPesquisaCliente";
            this.tbcPesquisaCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbcPesquisaCliente.Size = new System.Drawing.Size(565, 413);
            this.tbcPesquisaCliente.TabIndex = 1;
            this.tbcPesquisaCliente.Text = "Pesquisar Cliente";
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.Location = new System.Drawing.Point(105, 75);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(41, 23);
            this.lblCPFCliente.TabIndex = 0;
            this.lblCPFCliente.Text = "CPF";
            // 
            // lblNomeCompletoCliente
            // 
            this.lblNomeCompletoCliente.AutoSize = true;
            this.lblNomeCompletoCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompletoCliente.Location = new System.Drawing.Point(28, 115);
            this.lblNomeCompletoCliente.Name = "lblNomeCompletoCliente";
            this.lblNomeCompletoCliente.Size = new System.Drawing.Size(122, 23);
            this.lblNomeCompletoCliente.TabIndex = 1;
            this.lblNomeCompletoCliente.Text = "Nome Completo";
            // 
            // lblNomeSocialCliente
            // 
            this.lblNomeSocialCliente.AutoSize = true;
            this.lblNomeSocialCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSocialCliente.Location = new System.Drawing.Point(51, 153);
            this.lblNomeSocialCliente.Name = "lblNomeSocialCliente";
            this.lblNomeSocialCliente.Size = new System.Drawing.Size(102, 23);
            this.lblNomeSocialCliente.TabIndex = 2;
            this.lblNomeSocialCliente.Text = "Nome Social ";
            // 
            // lblCepCliente
            // 
            this.lblCepCliente.AutoSize = true;
            this.lblCepCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCliente.Location = new System.Drawing.Point(105, 199);
            this.lblCepCliente.Name = "lblCepCliente";
            this.lblCepCliente.Size = new System.Drawing.Size(39, 23);
            this.lblCepCliente.TabIndex = 3;
            this.lblCepCliente.Text = "Cep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Complemento";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 29);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 29);
            this.textBox3.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(153, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 29);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(152, 285);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 29);
            this.textBox6.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(153, 75);
            this.maskedTextBox1.Mask = "###,###,###-##";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(141, 29);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(153, 201);
            this.maskedTextBox2.Mask = "#####-###";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(97, 29);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.AutoSize = true;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(25, 208);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(180, 24);
            this.lblCadastroCliente.TabIndex = 0;
            this.lblCadastroCliente.Text = "Cadastro Cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(152, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtSistemaCliente
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcCadastroCliente);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "txtSistemaCliente";
            this.Text = "Sistema Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcCadastroCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcCadastroCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbcPesquisaCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCepCliente;
        private System.Windows.Forms.Label lblNomeSocialCliente;
        private System.Windows.Forms.Label lblNomeCompletoCliente;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

