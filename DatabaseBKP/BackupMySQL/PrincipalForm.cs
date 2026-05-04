using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace BackupMySQL
{
    public partial class PrincipalForm : Form
    {
        private string _arquivoEdicao = "";

        public PrincipalForm()
        {
            InitializeComponent();

            if (_arquivoEdicao.Length == 0)
                LblNomeArquivo.Text = "Nenhum arquivo carregado!";
        }

        private void BtnProcurarPastaBkp_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDlg = new();
            folderDlg.Description = "Selecione a pasta onde estão os backups";
            folderDlg.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            folderDlg.ShowNewFolderButton = false;

            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                TxtPastaBkp.Text = folderDlg.SelectedPath;
            }
        }

        private void BtnProcurarBKP_Click(object sender, EventArgs e)
        {
            OpenFileDlg.FileName = string.Empty;
            OpenFileDlg.InitialDirectory = TxtPastaBkp.Text;
            OpenFileDlg.Filter = "Script SQL (*.sql) | *.SQL;";
            OpenFileDlg.FilterIndex = 2;
            OpenFileDlg.RestoreDirectory = true;

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                TxtArquivoBKP.Text = OpenFileDlg.FileName;
            }
        }

        private void BtnProcuraPgDump_Click(object sender, EventArgs e)
        {
            OpenFileDlg.FileName = string.Empty;
            OpenFileDlg.InitialDirectory = "c:\\";
            OpenFileDlg.Filter = "Aplicativo (*.EXE) | *.exe;";
            OpenFileDlg.FilterIndex = 2;
            OpenFileDlg.RestoreDirectory = true;

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                TxtDump.Text = OpenFileDlg.FileName;
            }
        }

        private void BtnProcuraPgRestore_Click(object sender, EventArgs e)
        {
            OpenFileDlg.FileName = string.Empty;
            OpenFileDlg.InitialDirectory = "c:\\";
            OpenFileDlg.Filter = "Aplicativo (*.EXE) | *.exe;";
            OpenFileDlg.FilterIndex = 2;
            OpenFileDlg.RestoreDirectory = true;

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                TxtMySQL.Text = OpenFileDlg.FileName;
            }
        }

        private void MenuArquivoSalvar_Click(object sender, EventArgs e)
        {
            //validar campos

            ConfigModel configModel = new()
            {
                Servidor = TxtServidor.Text,
                Porta = TxtPorta.Text.Length > 0 ? Convert.ToInt32(TxtPorta.Text) : 0,
                Usuario = TxtUsuario.Text,
                Senha = TxtSenha.Text,
                BaseDeDados = TxtBaseDados.Text,
                PastaBackup = TxtPastaBkp.Text,
                ArquivoBackup = TxtArquivoBKP.Text,
                PgDump = TxtDump.Text,
                PgRestore = TxtMySQL.Text
            };

            JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };
            JsonSerializerOptions options = jsonSerializerOptions;
            string jsonString = JsonSerializer.Serialize(configModel, options);

            if (_arquivoEdicao.Length != 0)
            {
                File.WriteAllText(_arquivoEdicao, jsonString);
                MessageBox.Show("Arquivo salvo com sucesso!");
            }
            else
            {
                SaveFileDlg.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                SaveFileDlg.Filter = "Arquivo (*.json) | *.json";
                SaveFileDlg.FilterIndex = 2;
                SaveFileDlg.RestoreDirectory = true;

                if (SaveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    _arquivoEdicao = SaveFileDlg.FileName;
                    File.WriteAllText(_arquivoEdicao, jsonString);
                    MessageBox.Show("Arquivo salvo com sucesso!");
                }
            }
        }

        private void MenuArquivoSair_Click(object sender, EventArgs e)
        {
            //verificar se existe arquivo em edicao

            Application.Exit();
        }

        private void MenuArquivoAbrir_Click(object sender, EventArgs e)
        {
            string caminhoInicial = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

            OpenFileDlg.FileName = string.Empty;
            OpenFileDlg.InitialDirectory = caminhoInicial;
            OpenFileDlg.Filter = "Arquivo Json (*.json) | *.json;";
            OpenFileDlg.FilterIndex = 2;
            OpenFileDlg.RestoreDirectory = true;

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                //guardar o nome do arquivo para poder salva-lo posteriormente
                _arquivoEdicao = OpenFileDlg.FileName;
                LblNomeArquivo.Text = _arquivoEdicao;
                TxtConsole.AppendText($"Arquivo aberto: {_arquivoEdicao}" + Environment.NewLine);

                string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _arquivoEdicao);
                // Lê o conteúdo
                string jsonContent = File.ReadAllText(jsonPath);

                // Desserializa para a classe Configuracao
                ConfigModel config = JsonSerializer.Deserialize<ConfigModel>(jsonContent)!;
                if (config != null)
                {
                    TxtServidor.Text = config.Servidor;
                    TxtPorta.Text = config.Porta.ToString();
                    TxtUsuario.Text = config.Usuario;
                    TxtSenha.Text = config.Senha;
                    TxtBaseDados.Text = config.BaseDeDados;
                    TxtPastaBkp.Text = config.PastaBackup;
                    TxtArquivoBKP.Text = config.ArquivoBackup;
                    TxtDump.Text = config.PgDump;
                    TxtMySQL.Text = config.PgRestore;
                }
            }
        }

        private void MenuArquivoNovo_Click(object sender, EventArgs e)
        {
            //limpar nome do arquivo
            _arquivoEdicao = "";

            //limpar campos
            TxtServidor.Clear();
            TxtPorta.Clear();
            TxtUsuario.Clear();
            TxtSenha.Clear();
            TxtBaseDados.Clear();
            TxtPastaBkp.Clear();
            TxtArquivoBKP.Clear();
            TxtDump.Clear();
            TxtMySQL.Clear();
            TxtConsole.Clear();
        }

        private void MenuIniciarBackup_Click(object sender, EventArgs e)
        {
            if (TxtServidor.Text.Length == 0 || TxtUsuario.Text.Length == 0 || TxtSenha.Text.Length == 0 || TxtBaseDados.Text.Length == 0)
            {
                MessageBox.Show("Verifique os dados e tente novamente!");
                return;
            }

            DateTime dataAtual = DateTime.Now;
            string nomeBkp = @$"{TxtPastaBkp.Text}\{TxtBaseDados.Text}.{dataAtual:yyyy-MM-dd}.{dataAtual:hh-mm-ss}.sql";
            string caminhoDump = TxtDump.Text;

            // Argumentos para o mysqldump
            string argumentos = $"-h {TxtServidor.Text} -u {TxtUsuario.Text} -p{TxtSenha.Text} {TxtBaseDados.Text}";

            ProcessStartInfo psi = new()
            {
                FileName = caminhoDump,
                Arguments = argumentos,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using Process process = Process.Start(psi)!;
                // Redireciona a saída padrão (o SQL) para um arquivo
                string output = process.StandardOutput.ReadToEnd();
                string erro = process.StandardError.ReadToEnd();
                process.WaitForExit();

                TxtConsole.AppendText(output + Environment.NewLine);

                if (process.ExitCode == 0)
                {
                    File.WriteAllText(nomeBkp, output);
                    TxtConsole.AppendText("Backup realizado com sucesso" + Environment.NewLine);
                }
                else
                {
                    TxtConsole.AppendText(erro + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                TxtConsole.AppendText("Erro ao executar o backup: " + ex.Message + Environment.NewLine);
                MessageBox.Show("Erro ao executar o backup: " + ex.Message);
            }
        }

        private void MenuBackupRestaurar_Click(object sender, EventArgs e)
        {
            if (TxtServidor.Text.Length == 0 || TxtUsuario.Text.Length == 0 || TxtSenha.Text.Length == 0 || TxtBaseDados.Text.Length == 0)
            {
                MessageBox.Show("Verifique os dados e tente novamente!");
                return;
            }

            string argumentos =
                $"-h {TxtServidor.Text} -P {TxtPorta.Text} --default-character-set=utf8mb4 " +
                $"-u {TxtUsuario.Text} -p{TxtSenha.Text} {TxtBaseDados.Text}";

            ProcessStartInfo psi = new()
            {
                FileName = TxtMySQL.Text,
                Arguments = argumentos,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = Process.Start(psi)!;

            // envia os bytes do arquivo diretamente, sem leitura como string
            using (FileStream fs = new(TxtArquivoBKP.Text, FileMode.Open, FileAccess.Read))
            {
                fs.CopyTo(process.StandardInput.BaseStream);
            }
            process.StandardInput.Close();

            string output = process.StandardOutput.ReadToEnd();
            string erro = process.StandardError.ReadToEnd();
            process.WaitForExit();

            TxtConsole.AppendText(output + Environment.NewLine);

            if (process.ExitCode == 0)
                TxtConsole.AppendText("Restauração concluída com sucesso.\n");
            else
                TxtConsole.AppendText("Erro: " + erro + "\n");


            //string argumentos = $"-h {TxtServidor.Text} -P {TxtPorta.Text} --default-character-set=utf8mb4 -u {TxtUsuario.Text} -p{TxtSenha.Text} {TxtBaseDados.Text}";

            //ProcessStartInfo psi = new()
            //{
            //    FileName = TxtMySQL.Text,
            //    Arguments = argumentos,
            //    RedirectStandardInput = true,
            //    RedirectStandardError = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = true
            //};

            //try
            //{
            //    using Process process = Process.Start(psi)!;
            //    using (StreamReader fileInput = new(TxtArquivoBKP.Text))
            //    {
            //        process.StandardInput.Write(fileInput.ReadToEnd());
            //    }

            //    process.StandardInput.Close();
            //    string erro = process.StandardError.ReadToEnd();
            //    process.WaitForExit();

            //    //if (process.ExitCode == 0)
            //    //{
            //    //    Console.WriteLine("Restauração concluída com sucesso.");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Erro:");
            //    //    Console.WriteLine(erro);
            //    //}

            //    //using Process process = Process.Start(psi)!;
            //    //string output = process.StandardOutput.ReadToEnd();
            //    //using (StreamReader fileInput = new(TxtArquivoBKP.Text))
            //    //{
            //    //    process.StandardInput.Write(fileInput.ReadToEnd());
            //    //}

            //    //process.StandardInput.Close();
            //    //string erro = process.StandardError.ReadToEnd();
            //    //process.WaitForExit();

            //    //TxtConsole.AppendText(output + Environment.NewLine);

            //    if (process.ExitCode == 0)
            //    {
            //        TxtConsole.AppendText("Restauração concluída com sucesso." + Environment.NewLine);
            //    }
            //    else
            //    {
            //        TxtConsole.AppendText(erro + Environment.NewLine);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    TxtConsole.AppendText($"Erro ao executar a restauração. {ex.Message}" + Environment.NewLine);
            //    MessageBox.Show("Erro ao executar o backup: " + ex.Message);
            //}
        }

        private void MenuAjudaSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0 \n\r" +
                "Desenvolvido por Willian.\n\r" +
                "WILLIAN 2025",
                "Sobre",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }
    }
}
