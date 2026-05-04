namespace BackupPG
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TxtServidor = new TextBox();
            BtnProcurarBKP = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtPorta = new TextBox();
            TxtSenha = new TextBox();
            TxtUsuario = new TextBox();
            TxtBaseDados = new TextBox();
            TxtCaminhoBKP = new TextBox();
            OpenFileDlg = new OpenFileDialog();
            TxtPgDump = new TextBox();
            LblPgDump = new Label();
            BtnProcuraPgDump = new Button();
            TxtPgRestore = new TextBox();
            LblPgRestore = new Label();
            BtnProcuraPgRestore = new Button();
            TxtConsole = new TextBox();
            TxtPastaBkp = new TextBox();
            label7 = new Label();
            BtnProcurarPastaBkp = new Button();
            BarraMenus = new MenuStrip();
            MenuArquivo = new ToolStripMenuItem();
            MenuArquivoNovo = new ToolStripMenuItem();
            MenuArquivoAbrir = new ToolStripMenuItem();
            MenuArquivoSalvar = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuArquivoSair = new ToolStripMenuItem();
            MenuBackup = new ToolStripMenuItem();
            MenuIniciarBackup = new ToolStripMenuItem();
            MenuBackupRestaurar = new ToolStripMenuItem();
            MenuAjuda = new ToolStripMenuItem();
            MenuAjudaSobre = new ToolStripMenuItem();
            SaveFileDlg = new SaveFileDialog();
            LblNomeArquivo = new Label();
            BarraMenus.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 63);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // TxtServidor
            // 
            TxtServidor.Location = new Point(131, 59);
            TxtServidor.Name = "TxtServidor";
            TxtServidor.Size = new Size(135, 25);
            TxtServidor.TabIndex = 1;
            // 
            // BtnProcurarBKP
            // 
            BtnProcurarBKP.Location = new Point(574, 189);
            BtnProcurarBKP.Name = "BtnProcurarBKP";
            BtnProcurarBKP.Size = new Size(75, 26);
            BtnProcurarBKP.TabIndex = 9;
            BtnProcurarBKP.Text = "Procurar";
            BtnProcurarBKP.UseVisualStyleBackColor = true;
            BtnProcurarBKP.Click += BtnProcurarBKP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 3;
            label2.Text = "Porta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 94);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 4;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 94);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 125);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 6;
            label5.Text = "Base de dados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 192);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 7;
            label6.Text = "Caminho Backup";
            // 
            // TxtPorta
            // 
            TxtPorta.Location = new Point(329, 59);
            TxtPorta.Name = "TxtPorta";
            TxtPorta.Size = new Size(100, 25);
            TxtPorta.TabIndex = 2;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(329, 91);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(135, 25);
            TxtSenha.TabIndex = 4;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(131, 90);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(135, 25);
            TxtUsuario.TabIndex = 3;
            // 
            // TxtBaseDados
            // 
            TxtBaseDados.Location = new Point(131, 122);
            TxtBaseDados.Name = "TxtBaseDados";
            TxtBaseDados.Size = new Size(205, 25);
            TxtBaseDados.TabIndex = 5;
            // 
            // TxtCaminhoBKP
            // 
            TxtCaminhoBKP.Location = new Point(131, 188);
            TxtCaminhoBKP.Name = "TxtCaminhoBKP";
            TxtCaminhoBKP.Size = new Size(437, 25);
            TxtCaminhoBKP.TabIndex = 8;
            // 
            // OpenFileDlg
            // 
            OpenFileDlg.FileName = "openFileDialog1";
            // 
            // TxtPgDump
            // 
            TxtPgDump.Location = new Point(131, 221);
            TxtPgDump.Name = "TxtPgDump";
            TxtPgDump.Size = new Size(437, 25);
            TxtPgDump.TabIndex = 10;
            // 
            // LblPgDump
            // 
            LblPgDump.AutoSize = true;
            LblPgDump.Location = new Point(67, 224);
            LblPgDump.Name = "LblPgDump";
            LblPgDump.Size = new Size(58, 17);
            LblPgDump.TabIndex = 17;
            LblPgDump.Text = "PgDump";
            // 
            // BtnProcuraPgDump
            // 
            BtnProcuraPgDump.Location = new Point(574, 221);
            BtnProcuraPgDump.Name = "BtnProcuraPgDump";
            BtnProcuraPgDump.Size = new Size(75, 26);
            BtnProcuraPgDump.TabIndex = 11;
            BtnProcuraPgDump.Text = "Procurar";
            BtnProcuraPgDump.UseVisualStyleBackColor = true;
            BtnProcuraPgDump.Click += BtnProcuraPgDump_Click;
            // 
            // TxtPgRestore
            // 
            TxtPgRestore.Location = new Point(131, 254);
            TxtPgRestore.Name = "TxtPgRestore";
            TxtPgRestore.Size = new Size(437, 25);
            TxtPgRestore.TabIndex = 12;
            // 
            // LblPgRestore
            // 
            LblPgRestore.AutoSize = true;
            LblPgRestore.Location = new Point(57, 257);
            LblPgRestore.Name = "LblPgRestore";
            LblPgRestore.Size = new Size(68, 17);
            LblPgRestore.TabIndex = 20;
            LblPgRestore.Text = "PgRestore";
            // 
            // BtnProcuraPgRestore
            // 
            BtnProcuraPgRestore.Location = new Point(574, 254);
            BtnProcuraPgRestore.Name = "BtnProcuraPgRestore";
            BtnProcuraPgRestore.Size = new Size(75, 26);
            BtnProcuraPgRestore.TabIndex = 13;
            BtnProcuraPgRestore.Text = "Procurar";
            BtnProcuraPgRestore.UseVisualStyleBackColor = true;
            BtnProcuraPgRestore.Click += BtnProcuraPgRestore_Click;
            // 
            // TxtConsole
            // 
            TxtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtConsole.BackColor = Color.White;
            TxtConsole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtConsole.Location = new Point(12, 286);
            TxtConsole.Multiline = true;
            TxtConsole.Name = "TxtConsole";
            TxtConsole.ReadOnly = true;
            TxtConsole.ScrollBars = ScrollBars.Both;
            TxtConsole.Size = new Size(659, 196);
            TxtConsole.TabIndex = 14;
            // 
            // TxtPastaBkp
            // 
            TxtPastaBkp.Location = new Point(131, 155);
            TxtPastaBkp.Name = "TxtPastaBkp";
            TxtPastaBkp.Size = new Size(437, 25);
            TxtPastaBkp.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 159);
            label7.Name = "label7";
            label7.Size = new Size(103, 17);
            label7.TabIndex = 24;
            label7.Text = "Pasta de Backup";
            // 
            // BtnProcurarPastaBkp
            // 
            BtnProcurarPastaBkp.Location = new Point(574, 155);
            BtnProcurarPastaBkp.Name = "BtnProcurarPastaBkp";
            BtnProcurarPastaBkp.Size = new Size(75, 26);
            BtnProcurarPastaBkp.TabIndex = 7;
            BtnProcurarPastaBkp.Text = "Procurar";
            BtnProcurarPastaBkp.UseVisualStyleBackColor = true;
            BtnProcurarPastaBkp.Click += BtnProcurarPastaBkp_Click;
            // 
            // BarraMenus
            // 
            BarraMenus.Items.AddRange(new ToolStripItem[] { MenuArquivo, MenuBackup, MenuAjuda });
            BarraMenus.Location = new Point(0, 0);
            BarraMenus.Name = "BarraMenus";
            BarraMenus.Padding = new Padding(6, 3, 0, 3);
            BarraMenus.Size = new Size(683, 25);
            BarraMenus.TabIndex = 0;
            BarraMenus.Text = "menuStrip1";
            // 
            // MenuArquivo
            // 
            MenuArquivo.DropDownItems.AddRange(new ToolStripItem[] { MenuArquivoNovo, MenuArquivoAbrir, MenuArquivoSalvar, toolStripSeparator1, MenuArquivoSair });
            MenuArquivo.Name = "MenuArquivo";
            MenuArquivo.Size = new Size(61, 19);
            MenuArquivo.Text = "Arquivo";
            // 
            // MenuArquivoNovo
            // 
            MenuArquivoNovo.Name = "MenuArquivoNovo";
            MenuArquivoNovo.Size = new Size(180, 22);
            MenuArquivoNovo.Text = "Novo";
            MenuArquivoNovo.Click += MenuArquivoNovo_Click;
            // 
            // MenuArquivoAbrir
            // 
            MenuArquivoAbrir.Name = "MenuArquivoAbrir";
            MenuArquivoAbrir.Size = new Size(180, 22);
            MenuArquivoAbrir.Text = "Abrir";
            MenuArquivoAbrir.Click += MenuArquivoAbrir_Click;
            // 
            // MenuArquivoSalvar
            // 
            MenuArquivoSalvar.Name = "MenuArquivoSalvar";
            MenuArquivoSalvar.Size = new Size(180, 22);
            MenuArquivoSalvar.Text = "Salvar";
            MenuArquivoSalvar.Click += MenuArquivoSalvar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // MenuArquivoSair
            // 
            MenuArquivoSair.Name = "MenuArquivoSair";
            MenuArquivoSair.Size = new Size(180, 22);
            MenuArquivoSair.Text = "Sair";
            MenuArquivoSair.Click += MenuArquivoSair_Click;
            // 
            // MenuBackup
            // 
            MenuBackup.DropDownItems.AddRange(new ToolStripItem[] { MenuIniciarBackup, MenuBackupRestaurar });
            MenuBackup.Name = "MenuBackup";
            MenuBackup.Size = new Size(58, 19);
            MenuBackup.Text = "Backup";
            // 
            // MenuIniciarBackup
            // 
            MenuIniciarBackup.Name = "MenuIniciarBackup";
            MenuIniciarBackup.Size = new Size(143, 22);
            MenuIniciarBackup.Text = "Fazer Backup";
            MenuIniciarBackup.Click += MenuIniciarBackup_Click;
            // 
            // MenuBackupRestaurar
            // 
            MenuBackupRestaurar.Name = "MenuBackupRestaurar";
            MenuBackupRestaurar.Size = new Size(143, 22);
            MenuBackupRestaurar.Text = "Restaurar";
            MenuBackupRestaurar.Click += MenuBackupRestaurar_Click;
            // 
            // MenuAjuda
            // 
            MenuAjuda.DropDownItems.AddRange(new ToolStripItem[] { MenuAjudaSobre });
            MenuAjuda.Name = "MenuAjuda";
            MenuAjuda.Size = new Size(50, 19);
            MenuAjuda.Text = "Ajuda";
            // 
            // MenuAjudaSobre
            // 
            MenuAjudaSobre.Name = "MenuAjudaSobre";
            MenuAjudaSobre.Size = new Size(104, 22);
            MenuAjudaSobre.Text = "Sobre";
            MenuAjudaSobre.Click += MenuAjudaSobre_Click;
            // 
            // LblNomeArquivo
            // 
            LblNomeArquivo.AutoSize = true;
            LblNomeArquivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNomeArquivo.Location = new Point(8, 35);
            LblNomeArquivo.Name = "LblNomeArquivo";
            LblNomeArquivo.Size = new Size(32, 17);
            LblNomeArquivo.TabIndex = 25;
            LblNomeArquivo.Text = "</>";
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 493);
            Controls.Add(LblNomeArquivo);
            Controls.Add(BarraMenus);
            Controls.Add(TxtPastaBkp);
            Controls.Add(label7);
            Controls.Add(BtnProcurarPastaBkp);
            Controls.Add(TxtConsole);
            Controls.Add(TxtPgRestore);
            Controls.Add(LblPgRestore);
            Controls.Add(BtnProcuraPgRestore);
            Controls.Add(TxtPgDump);
            Controls.Add(LblPgDump);
            Controls.Add(BtnProcuraPgDump);
            Controls.Add(TxtCaminhoBKP);
            Controls.Add(TxtBaseDados);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUsuario);
            Controls.Add(TxtPorta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnProcurarBKP);
            Controls.Add(TxtServidor);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup PostgreSQL";
            BarraMenus.ResumeLayout(false);
            BarraMenus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtServidor;
        private Button BtnProcurarBKP;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtPorta;
        private TextBox TxtSenha;
        private TextBox TxtUsuario;
        private TextBox TxtBaseDados;
        private TextBox TxtCaminhoBKP;
        private OpenFileDialog OpenFileDlg;
        private TextBox TxtPgDump;
        private Label LblPgDump;
        private Button BtnProcuraPgDump;
        private TextBox TxtPgRestore;
        private Label LblPgRestore;
        private Button BtnProcuraPgRestore;
        private TextBox TxtConsole;
        private TextBox TxtPastaBkp;
        private Label label7;
        private Button BtnProcurarPastaBkp;
        private MenuStrip BarraMenus;
        private ToolStripMenuItem MenuArquivo;
        private ToolStripMenuItem MenuArquivoNovo;
        private ToolStripMenuItem MenuArquivoAbrir;
        private ToolStripMenuItem MenuArquivoSalvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuArquivoSair;
        private ToolStripMenuItem MenuBackup;
        private ToolStripMenuItem MenuIniciarBackup;
        private ToolStripMenuItem MenuBackupRestaurar;
        private ToolStripMenuItem MenuAjuda;
        private ToolStripMenuItem MenuAjudaSobre;
        private SaveFileDialog SaveFileDlg;
        private Label LblNomeArquivo;
    }
}
