namespace EmpresaVerduras
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
            this.btnDados = new System.Windows.Forms.Button();
            this.lboNormal = new System.Windows.Forms.ListBox();
            this.lboCNPJ = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboMediaCNPJ = new System.Windows.Forms.ListBox();
            this.lboMediaEstoque = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDados
            // 
            this.btnDados.Location = new System.Drawing.Point(92, 282);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(98, 37);
            this.btnDados.TabIndex = 0;
            this.btnDados.Text = "Inserir Dados";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // lboNormal
            // 
            this.lboNormal.FormattingEnabled = true;
            this.lboNormal.Location = new System.Drawing.Point(12, 38);
            this.lboNormal.Name = "lboNormal";
            this.lboNormal.Size = new System.Drawing.Size(120, 238);
            this.lboNormal.TabIndex = 1;
            this.lboNormal.SelectedIndexChanged += new System.EventHandler(this.lboNormal_SelectedIndexChanged);
            // 
            // lboCNPJ
            // 
            this.lboCNPJ.FormattingEnabled = true;
            this.lboCNPJ.Location = new System.Drawing.Point(151, 38);
            this.lboCNPJ.Name = "lboCNPJ";
            this.lboCNPJ.Size = new System.Drawing.Size(120, 238);
            this.lboCNPJ.TabIndex = 2;
            this.lboCNPJ.SelectedIndexChanged += new System.EventHandler(this.lboCNPJ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
            // 
            // lboMediaCNPJ
            // 
            this.lboMediaCNPJ.FormattingEnabled = true;
            this.lboMediaCNPJ.Location = new System.Drawing.Point(482, 38);
            this.lboMediaCNPJ.Name = "lboMediaCNPJ";
            this.lboMediaCNPJ.Size = new System.Drawing.Size(120, 238);
            this.lboMediaCNPJ.TabIndex = 5;
            this.lboMediaCNPJ.SelectedIndexChanged += new System.EventHandler(this.lboMediaCNPJ_SelectedIndexChanged);
            // 
            // lboMediaEstoque
            // 
            this.lboMediaEstoque.FormattingEnabled = true;
            this.lboMediaEstoque.Location = new System.Drawing.Point(638, 38);
            this.lboMediaEstoque.Name = "lboMediaEstoque";
            this.lboMediaEstoque.Size = new System.Drawing.Size(120, 238);
            this.lboMediaEstoque.TabIndex = 6;
            this.lboMediaEstoque.SelectedIndexChanged += new System.EventHandler(this.lboMediaEstoque_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Media CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Media Estoque";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboMediaEstoque);
            this.Controls.Add(this.lboMediaCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboCNPJ);
            this.Controls.Add(this.lboNormal);
            this.Controls.Add(this.btnDados);
            this.Name = "Form1";
            this.Text = "Leguminhos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.ListBox lboNormal;
        private System.Windows.Forms.ListBox lboCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboMediaCNPJ;
        private System.Windows.Forms.ListBox lboMediaEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

