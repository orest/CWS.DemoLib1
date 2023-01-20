namespace CWS.DemoLib1
{
    public class Account
    {
        public int AccountId { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal AvailableCredit { get; set; }
        public string CardHolderName { get; set; } = "";
        public string? MiscFlag { get; set; }


    }
}