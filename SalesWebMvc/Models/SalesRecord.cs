using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; } 
        public SalesStatus status { get; set; }
        public Seller Seller { get; set; }
    
        public SalesRecord() { }

        public SalesRecord( DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
