using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getOrder;
[Table("Order")]
public class orderReq
{
        [Key]
        [Column("order_ID")]
        public int orderID {get;set;}
        [Column("cart_ID")]
        public int cartID {get;set;}
}