using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getProductReq;
[Table("Products")]
public class productReq
{
        [Key]
        [Column("product_ID")]
        public int prodID { get; set; }
        [Column("product_Name")]
        public string prodName { get; set; }
        [Column("product_Des")]
        public string prodDes { get; set; } 
        [Column("product_Stock")]
        public int prodStock{ get; set; }
        [Column("product_Price")]
        public decimal prodPrice { get; set; }
        
}