namespace SA_OnlineMarket.Models
{
    [Table("User")]
    public class getLogin
    {
        [Column("Username")]
        public string userName { get; set; }
        [Column("password")]
        public string password { get; set; }
        [Column("contact")]
        public string userContact {  get; set; }
        [Column("address")]
        public string userAddress { get; set; }
        [Column("customerid")]
        public int customerID {  get; set; }

    }
}
