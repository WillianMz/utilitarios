namespace ListaImpressoras
{
    partial class ImpressorasForm
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
            this.ListBoxImpressoras = new System.Windows.Forms.ListBox();
            this.BtnAtualizarLista = new System.Windows.Forms.Button();
            this.BtnBuscarImpressoraPadrao = new System.Windows.Forms.Button();
            this.BtnDefinirComoPadrao = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxImpressoras
            // 
            this.ListBoxImpressoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxImpressoras.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxImpressoras.FormattingEnabled = true;
            this.ListBoxImpressoras.ItemHeight = 30;
            this.ListBoxImpressoras.Location = new System.Drawing.Point(13, 12);
            this.ListBoxImpressoras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBoxImpressoras.Name = "ListBoxImpressoras";
            this.ListBoxImpressoras.Size = new System.Drawing.Size(361, 274);
            this.ListBoxImpressoras.TabIndex = 0;
            // 
            // BtnAtualizarLista
            // 
            this.BtnAtualizarLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtualizarLista.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizarLista.Location = new System.Drawing.Point(13, 292);
            this.BtnAtualizarLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAtualizarLista.Name = "BtnAtualizarLista";
            this.BtnAtualizarLista.Size = new System.Drawing.Size(361, 30);
            this.BtnAtualizarLista.TabIndex = 1;
            this.BtnAtualizarLista.Text = "Atualizar lista";
            this.BtnAtualizarLista.UseVisualStyleBackColor = true;
            this.BtnAtualizarLista.Click += new System.EventHandler(this.BtnAtualizarLista_Click);
            // 
            // BtnBuscarImpressoraPadrao
            // 
            this.BtnBuscarImpressoraPadrao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscarImpressoraPadrao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarImpressoraPadrao.Location = new System.Drawing.Point(13, 328);
            this.BtnBuscarImpressoraPadrao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBuscarImpressoraPadrao.Name = "BtnBuscarImpressoraPadrao";
            this.BtnBuscarImpressoraPadrao.Size = new System.Drawing.Size(361, 30);
            this.BtnBuscarImpressoraPadrao.TabIndex = 2;
            this.BtnBuscarImpressoraPadrao.Text = "Obter impressora padrão";
            this.BtnBuscarImpressoraPadrao.UseVisualStyleBackColor = true;
            this.BtnBuscarImpressoraPadrao.Click += new System.EventHandler(this.BtnBuscarImpressoraPadrao_Click);
            // 
            // BtnDefinirComoPadrao
            // 
            this.BtnDefinirComoPadrao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDefinirComoPadrao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefinirComoPadrao.Location = new System.Drawing.Point(13, 364);
            this.BtnDefinirComoPadrao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDefinirComoPadrao.Name = "BtnDefinirComoPadrao";
            this.BtnDefinirComoPadrao.Size = new System.Drawing.Size(361, 30);
            this.BtnDefinirComoPadrao.TabIndex = 3;
            this.BtnDefinirComoPadrao.Text = "Definir como padrão";
            this.BtnDefinirComoPadrao.UseVisualStyleBackColor = true;
            this.BtnDefinirComoPadrao.Click += new System.EventHandler(this.BtnDefinirComoPadrao_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(13, 400);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(361, 30);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "Selecionar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ImpressorasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 438);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnDefinirComoPadrao);
            this.Controls.Add(this.BtnBuscarImpressoraPadrao);
            this.Controls.Add(this.BtnAtualizarLista);
            this.Controls.Add(this.ListBoxImpressoras);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImpressorasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressoas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImpressorasForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxImpressoras;
        public System.Windows.Forms.Button BtnAtualizarLista;
        public System.Windows.Forms.Button BtnBuscarImpressoraPadrao;
        public System.Windows.Forms.Button BtnDefinirComoPadrao;
        public System.Windows.Forms.Button BtnConfirmar;
    }
}

