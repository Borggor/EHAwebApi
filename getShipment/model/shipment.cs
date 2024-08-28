using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace getShipment;
[Table("Shipment")]
public class shipmentReq
{
        [Key]
        [Column("shipment_ID")]
        public int shipmentID { get; set; }
        [Column("order_ID")]
        public int orderID {get;set;}
        [Column("shipment_Address")]
        public string {get;set;}
        
}