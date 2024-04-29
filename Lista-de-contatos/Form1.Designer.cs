namespace Lista_de_contatos
{
    partial class Form1
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
            this.labelnome = new System.Windows.Forms.Label();
            this.labelsobrenome = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.ListBoxContatos = new System.Windows.Forms.ListBox();
            this.buttoncontato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(12, 99);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(64, 25);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome";
            // 
            // labelsobrenome
            // 
            this.labelsobrenome.AutoSize = true;
            this.labelsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsobrenome.Location = new System.Drawing.Point(12, 135);
            this.labelsobrenome.Name = "labelsobrenome";
            this.labelsobrenome.Size = new System.Drawing.Size(114, 25);
            this.labelsobrenome.TabIndex = 1;
            this.labelsobrenome.Text = "Sobrenome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(156, 103);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(146, 20);
            this.Nome.TabIndex = 3;
            this.Nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(156, 140);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(146, 20);
            this.Sobrenome.TabIndex = 4;
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefone.Location = new System.Drawing.Point(12, 173);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(89, 25);
            this.labeltelefone.TabIndex = 5;
            this.labeltelefone.Text = "Telefone";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(156, 177);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(146, 20);
            this.Telefone.TabIndex = 6;
            // 
            // ListBoxContatos
            // 
            this.ListBoxContatos.FormattingEnabled = true;
            this.ListBoxContatos.Location = new System.Drawing.Point(381, 12);
            this.ListBoxContatos.Name = "ListBoxContatos";
            this.ListBoxContatos.Size = new System.Drawing.Size(246, 420);
            this.ListBoxContatos.TabIndex = 7;
            // 
            // buttoncontato
            // 
            this.buttoncontato.Location = new System.Drawing.Point(17, 307);
            this.buttoncontato.Name = "buttoncontato";
            this.buttoncontato.Size = new System.Drawing.Size(285, 107);
            this.buttoncontato.TabIndex = 8;
            this.buttoncontato.Text = "Inserir contato";
            this.buttoncontato.UseVisualStyleBackColor = true;
            this.buttoncontato.Click += new System.EventHandler(this.buttoncontato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.buttoncontato);
            this.Controls.Add(this.ListBoxContatos);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.labelsobrenome);
            this.Controls.Add(this.labelnome);
            this.Name = "Form1";
            this.Text = "Lista-de-contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelsobrenome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Sobrenome;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.ListBox ListBoxContatos;
        private System.Windows.Forms.Button buttoncontato;
    }
}

