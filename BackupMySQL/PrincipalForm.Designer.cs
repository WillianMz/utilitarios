namespace BackupMySQL
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
            TxtPastaBkp = new TextBox();
            label7 = new Label();
            BtnProcurarPastaBkp = new Button();
            TxtConsole = new TextBox();
            TxtMySQL = new TextBox();
            LblPgRestore = new Label();
            BtnProcuraPgRestore = new Button();
            TxtDump = new TextBox();
            LblPgDump = new Label();
            BtnProcuraPgDump = new Button();
            TxtArquivoBKP = new TextBox();
            TxtBaseDados = new TextBox();
            TxtSenha = new TextBox();
            TxtUsuario = new TextBox();
            TxtPorta = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnProcurarBKP = new Button();
            TxtServidor = new TextBox();
            label1 = new Label();
            OpenFileDlg = new OpenFileDialog();
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
            // TxtPastaBkp
            // 
            TxtPastaBkp.Location = new Point(128, 152);
            TxtPastaBkp.Name = "TxtPastaBkp";
            TxtPastaBkp.Size = new Size(382, 25);
            TxtPastaBkp.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 156);
            label7.Name = "label7";
            label7.Size = new Size(103, 17);
            label7.TabIndex = 50;
            label7.Text = "Pasta de Backup";
            // 
            // BtnProcurarPastaBkp
            // 
            BtnProcurarPastaBkp.Location = new Point(516, 151);
            BtnProcurarPastaBkp.Name = "BtnProcurarPastaBkp";
            BtnProcurarPastaBkp.Size = new Size(75, 26);
            BtnProcurarPastaBkp.TabIndex = 6;
            BtnProcurarPastaBkp.Text = "Procurar";
            BtnProcurarPastaBkp.UseVisualStyleBackColor = true;
            BtnProcurarPastaBkp.Click += BtnProcurarPastaBkp_Click;
            // 
            // TxtConsole
            // 
            TxtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtConsole.BackColor = Color.White;
            TxtConsole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtConsole.Location = new Point(12, 281);
            TxtConsole.Multiline = true;
            TxtConsole.Name = "TxtConsole";
            TxtConsole.ReadOnly = true;
            TxtConsole.ScrollBars = ScrollBars.Both;
            TxtConsole.Size = new Size(659, 198);
            TxtConsole.TabIndex = 13;
            // 
            // TxtMySQL
            // 
            TxtMySQL.Location = new Point(128, 250);
            TxtMySQL.Name = "TxtMySQL";
            TxtMySQL.Size = new Size(382, 25);
            TxtMySQL.TabIndex = 11;
            // 
            // LblPgRestore
            // 
            LblPgRestore.AutoSize = true;
            LblPgRestore.Location = new Point(73, 255);
            LblPgRestore.Name = "LblPgRestore";
            LblPgRestore.Size = new Size(49, 17);
            LblPgRestore.TabIndex = 48;
            LblPgRestore.Text = "MySQL";
            // 
            // BtnProcuraPgRestore
            // 
            BtnProcuraPgRestore.Location = new Point(516, 249);
            BtnProcuraPgRestore.Name = "BtnProcuraPgRestore";
            BtnProcuraPgRestore.Size = new Size(75, 26);
            BtnProcuraPgRestore.TabIndex = 12;
            BtnProcuraPgRestore.Text = "Procurar";
            BtnProcuraPgRestore.UseVisualStyleBackColor = true;
            BtnProcuraPgRestore.Click += BtnProcuraPgRestore_Click;
            // 
            // TxtDump
            // 
            TxtDump.Location = new Point(128, 217);
            TxtDump.Name = "TxtDump";
            TxtDump.Size = new Size(382, 25);
            TxtDump.TabIndex = 9;
            // 
            // LblPgDump
            // 
            LblPgDump.AutoSize = true;
            LblPgDump.Location = new Point(38, 221);
            LblPgDump.Name = "LblPgDump";
            LblPgDump.Size = new Size(84, 17);
            LblPgDump.TabIndex = 47;
            LblPgDump.Text = "MySQLDump";
            // 
            // BtnProcuraPgDump
            // 
            BtnProcuraPgDump.Location = new Point(516, 216);
            BtnProcuraPgDump.Name = "BtnProcuraPgDump";
            BtnProcuraPgDump.Size = new Size(75, 26);
            BtnProcuraPgDump.TabIndex = 10;
            BtnProcuraPgDump.Text = "Procurar";
            BtnProcuraPgDump.UseVisualStyleBackColor = true;
            BtnProcuraPgDump.Click += BtnProcuraPgDump_Click;
            // 
            // TxtArquivoBKP
            // 
            TxtArquivoBKP.Location = new Point(128, 185);
            TxtArquivoBKP.Name = "TxtArquivoBKP";
            TxtArquivoBKP.Size = new Size(382, 25);
            TxtArquivoBKP.TabIndex = 7;
            // 
            // TxtBaseDados
            // 
            TxtBaseDados.Location = new Point(128, 119);
            TxtBaseDados.Name = "TxtBaseDados";
            TxtBaseDados.Size = new Size(205, 25);
            TxtBaseDados.TabIndex = 4;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(314, 88);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(135, 25);
            TxtSenha.TabIndex = 3;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(128, 88);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(135, 25);
            TxtUsuario.TabIndex = 2;
            // 
            // TxtPorta
            // 
            TxtPorta.Location = new Point(314, 57);
            TxtPorta.Name = "TxtPorta";
            TxtPorta.Size = new Size(100, 25);
            TxtPorta.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 188);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 38;
            label6.Text = "Arquivo Backup";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 122);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 35;
            label5.Text = "Base de dados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 92);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 33;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 92);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 32;
            label3.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 60);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 30;
            label2.Text = "Porta";
            // 
            // BtnProcurarBKP
            // 
            BtnProcurarBKP.Location = new Point(516, 184);
            BtnProcurarBKP.Name = "BtnProcurarBKP";
            BtnProcurarBKP.Size = new Size(75, 26);
            BtnProcurarBKP.TabIndex = 8;
            BtnProcurarBKP.Text = "Procurar";
            BtnProcurarBKP.UseVisualStyleBackColor = true;
            BtnProcurarBKP.Click += BtnProcurarBKP_Click;
            // 
            // TxtServidor
            // 
            TxtServidor.Location = new Point(128, 57);
            TxtServidor.Name = "TxtServidor";
            TxtServidor.Size = new Size(135, 25);
            TxtServidor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 60);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 25;
            label1.Text = "Servidor";
            // 
            // OpenFileDlg
            // 
            OpenFileDlg.FileName = "openFileDialog1";
            // 
            // BarraMenus
            // 
            BarraMenus.Items.AddRange(new ToolStripItem[] { MenuArquivo, MenuBackup, MenuAjuda });
            BarraMenus.Location = new Point(0, 0);
            BarraMenus.Name = "BarraMenus";
            BarraMenus.Padding = new Padding(6, 3, 0, 3);
            BarraMenus.Size = new Size(683, 25);
            BarraMenus.TabIndex = 14;
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
            MenuArquivoNovo.Size = new Size(105, 22);
            MenuArquivoNovo.Text = "Novo";
            MenuArquivoNovo.Click += MenuArquivoNovo_Click;
            // 
            // MenuArquivoAbrir
            // 
            MenuArquivoAbrir.Name = "MenuArquivoAbrir";
            MenuArquivoAbrir.Size = new Size(105, 22);
            MenuArquivoAbrir.Text = "Abrir";
            MenuArquivoAbrir.Click += MenuArquivoAbrir_Click;
            // 
            // MenuArquivoSalvar
            // 
            MenuArquivoSalvar.Name = "MenuArquivoSalvar";
            MenuArquivoSalvar.Size = new Size(105, 22);
            MenuArquivoSalvar.Text = "Salvar";
            MenuArquivoSalvar.Click += MenuArquivoSalvar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(102, 6);
            // 
            // MenuArquivoSair
            // 
            MenuArquivoSair.Name = "MenuArquivoSair";
            MenuArquivoSair.Size = new Size(105, 22);
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
            LblNomeArquivo.Location = new Point(12, 27);
            LblNomeArquivo.Name = "LblNomeArquivo";
            LblNomeArquivo.Size = new Size(32, 17);
            LblNomeArquivo.TabIndex = 51;
            LblNomeArquivo.Text = "</>";
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 493);
            Controls.Add(LblNomeArquivo);
            Controls.Add(TxtPastaBkp);
            Controls.Add(label7);
            Controls.Add(BtnProcurarPastaBkp);
            Controls.Add(TxtConsole);
            Controls.Add(TxtMySQL);
            Controls.Add(LblPgRestore);
            Controls.Add(BtnProcuraPgRestore);
            Controls.Add(TxtDump);
            Controls.Add(LblPgDump);
            Controls.Add(BtnProcuraPgDump);
            Controls.Add(TxtArquivoBKP);
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
            Controls.Add(BarraMenus);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = BarraMenus;
            MaximizeBox = false;
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup MySQL";
            BarraMenus.ResumeLayout(false);
            BarraMenus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtPastaBkp;
        private Label label7;
        private Button BtnProcurarPastaBkp;
        private TextBox TxtConsole;
        private TextBox TxtMySQL;
        private Label LblPgRestore;
        private Button BtnProcuraPgRestore;
        private TextBox TxtDump;
        private Label LblPgDump;
        private Button BtnProcuraPgDump;
        private TextBox TxtArquivoBKP;
        private TextBox TxtBaseDados;
        private TextBox TxtSenha;
        private TextBox TxtUsuario;
        private TextBox TxtPorta;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BtnProcurarBKP;
        private TextBox TxtServidor;
        private Label label1;
        private OpenFileDialog OpenFileDlg;
        private MenuStrip BarraMenus;
        private ToolStripMenuItem MenuArquivo;
        private ToolStripMenuItem MenuArquivoNovo;
        private ToolStripMenuItem MenuArquivoAbrir;
        private ToolStripMenuItem MenuArquivoSalvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuArquivoSair;
        private ToolStripMenuItem MenuBackup;
        private ToolStripMenuItem MenuAjuda;
        private ToolStripMenuItem MenuIniciarBackup;
        private ToolStripMenuItem MenuBackupRestaurar;
        private ToolStripMenuItem MenuAjudaSobre;
        private SaveFileDialog SaveFileDlg;
        private Label LblNomeArquivo;
    }
}
