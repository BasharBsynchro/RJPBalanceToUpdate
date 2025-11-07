namespace RJPBalanceToUpdate
{
    public record NewBalance
    {
        public string customerid { get; init; }
        public decimal balance { get; init; }
    }

    public record NewAccount {
        public string customerid { get; init; } 
    }
    
}
