namespace dominio
{
    public class Account
    {
        public Client? ClientAccount { get; set; }
        public int IdAccount { get; set; }
        public string? Number { get; set; }
        public int Balance { get; set; }
        public string? TypeAccount { get; set; }
    }
}
