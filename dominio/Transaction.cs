using dominio

namespace dominio
{
    public class Transaction
    {
        public Account account { get; set; }
        public int IdTransaction { get; set; }
        public int Value { get; set; }
        public string Date { get; set; }
        public string TypeTransaction { get; set; }
    }
}