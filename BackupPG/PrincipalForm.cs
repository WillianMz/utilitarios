using System.Diagnostics;
using System.Text.Json;

namespace BackupPG
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

        private void BtnProcurarBKP_Click(object sender, EventArgs e)
        {
            OpenFileDlg.FileName = string.Empty;
            OpenFileDlg.InitialDirectory = TxtPastaBkp.Text;
            OpenFileDlg.Filter = "Arquivo de Backup (*.BACKUP) | *.backup;";
            OpenFileDlg.FilterIndex = 2;
            OpenFileDlg.RestoreDirectory = true;

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                TxtCaminhoBKP.Text = OpenFileDlg.FileName;
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
                TxtPgDump.Text = OpenFileDlg.FileName;
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
                TxtPgRestore.Text = OpenFileDlg.FileName;
            }
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


        private void MenuArquivoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            TxtCaminhoBKP.Clear();
            TxtPgDump.Clear();
            TxtPgRestore.Clear();
            LblNomeArquivo.Text = "NOVO ARQUIVO";
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
                TxtConsole.Text += $"Arquivo aberto: {_arquivoEdicao}" + Environment.NewLine;


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
                    TxtCaminhoBKP.Text = config.ArquivoBackup;
                    TxtPgDump.Text = config.PgDump;
                    TxtPgRestore.Text = config.PgRestore;
                }
            }
        }

        private void MenuArquivoSalvar_Click(object sender, EventArgs e)
        {
            ConfigModel configModel = new()
            {
                Servidor = TxtServidor.Text,
                Porta = TxtPorta.Text.Length > 0 ? Convert.ToInt32(TxtPorta.Text) : 0,
                Usuario = TxtUsuario.Text,
                Senha = TxtSenha.Text,
                BaseDeDados = TxtBaseDados.Text,
                PastaBackup = TxtPastaBkp.Text,
                ArquivoBackup = TxtCaminhoBKP.Text,
                PgDump = TxtPgDump.Text,
                PgRestore = TxtPgRestore.Text
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

        private void MenuIniciarBackup_Click(object sender, EventArgs e)
        {
            if (TxtServidor.Text.Length == 0 || TxtUsuario.Text.Length == 0 || TxtSenha.Text.Length == 0 || TxtBaseDados.Text.Length == 0)
            {
                MessageBox.Show("Verifique os dados e tente novamente!");
                return;
            }

            DateTime dataAtual = DateTime.Now;
            string nomeBkp = @$"{TxtPastaBkp.Text}\{TxtBaseDados.Text}.{dataAtual:yyyy-MM-dd}.{dataAtual:hh-mm-ss}.backup";
            string caminhoDump = TxtPgDump.Text;

            /**
             * parâmetros do pg_dump
                -F c: formato custom (ideal para restauração via pg_restore)
                -b: inclui blobs
                -v: modo verboso
                -f: arquivo de saída     
             */

            // Argumentos para o pg_dump
            string argumentos = $"-h {TxtServidor.Text} -p {TxtPorta.Text} -U {TxtUsuario.Text} -F c -b -v -f \"{nomeBkp}\" {TxtBaseDados.Text}";

            // Configuração do processo
            ProcessStartInfo psi = new()
            {
                FileName = caminhoDump,
                Arguments = argumentos,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Define a variável de ambiente PGPASSWORD (evita prompt de senha)
            psi.EnvironmentVariables["PGPASSWORD"] = TxtSenha.Text;

            try
            {
                using Process process = Process.Start(psi)!;
                string output = process.StandardOutput.ReadToEnd();
                string erro = process.StandardError.ReadToEnd();
                process.WaitForExit();

                TxtConsole.AppendText(output + Environment.NewLine);

                if (process.ExitCode != 0)
                {
                    TxtConsole.AppendText(erro + Environment.NewLine);
                }
                else
                {
                    TxtConsole.AppendText("Backup realizado com sucesso" + Environment.NewLine);
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

            // Argumentos para o pg_restore
            string argumentos = $"-h {TxtServidor.Text} -p {TxtPorta.Text} -U {TxtUsuario.Text} -d {TxtBaseDados.Text} -v \"{TxtCaminhoBKP.Text}\"";

            // Configuração do processo
            ProcessStartInfo psi = new()
            {
                FileName = TxtPgRestore.Text,
                Arguments = argumentos,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Define a variável de ambiente PGPASSWORD (evita prompt de senha)
            psi.EnvironmentVariables["PGPASSWORD"] = TxtSenha.Text;

            try
            {
                using Process process = Process.Start(psi)!;
                string output = process.StandardOutput.ReadToEnd();
                string erro = process.StandardError.ReadToEnd();
                process.WaitForExit();

                TxtConsole.AppendText(output + Environment.NewLine);

                if (process.ExitCode != 0)
                {
                    TxtConsole.AppendText(erro + Environment.NewLine);
                }
                else
                {
                    TxtConsole.AppendText("Restauração concluída com sucesso." + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                TxtConsole.AppendText($"Erro ao executar a restauração. {ex.Message}" + Environment.NewLine);
                MessageBox.Show("Erro ao executar a restauração: " + ex.Message);
            }
        }

        private void MenuAjudaSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0 \n\r" +
                            "Desenvolvido por Willian.\n\r" +
                            "WILLIAN 2025", 
                            "Sobre", 
                            buttons:MessageBoxButtons.OK, 
                            icon:MessageBoxIcon.Information);
        }
    }
}
