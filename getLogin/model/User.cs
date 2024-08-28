using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getLogin;
[Table("Customer")]
public class cusReq
{
    [Key]
    [Column("customer_ID")]
    public int customerID {get;set;}
    [Column("customer_Name")]
    public string customerName {get;set;}
    [Column("customer_Address")]
    public string customerAddress {get;set;}
    [Column("customer_Contact")]
    public string customerContact {get;set;}
    [Column("isAdmin")]
    public int isAdmin {get;set;}
}