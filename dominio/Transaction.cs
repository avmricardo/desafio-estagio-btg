namespace dominio
{
    public class Transaction
    {
        public Account? AccountTransaction { get; set; }
        public int IdTransaction { get; set; }
        public int Value { get; set; }
        public DateTime? Date { get; set; }
        public string? TypeTransaction { get; set; }
    }
}
