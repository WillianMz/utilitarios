namespace BackupPG
{
    public class ConfigModel
    {
        public string Servidor { get; set; } = "";
        public int Porta { get; set; } = 0;
        public string Usuario { get; set; } = "";
        public string Senha { get; set; } = "";
        public string BaseDeDados { get; set; } = "";
        public string PastaBackup { get; set; } = "";
        public string ArquivoBackup { get; set; } = "";
        public string PgDump { get; set; } = "";
        public string PgRestore { get; set; } = "";
    }
}
