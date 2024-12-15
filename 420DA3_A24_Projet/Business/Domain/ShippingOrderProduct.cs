using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class ShippingOrderProduct 
{
    // Backing fields
    private int shippingOrderId;
    private int productId;
    private int quantity;

    // Properties
    public int ShippingOrderId { get { return shippingOrderId; } set { shippingOrderId = value; } }
    public int ProductId { get { return productId; } set { productId = value; } }
    public int Quantity { get { return quantity; } set { quantity = value; } }

    // Navigation properties
    public Product Product { get; set; } = null!;
    public ShippingOrder ShippingOrder { get; set; } = null!;

    // Constructor
    public ShippingOrderProduct(int shippingOrderId, int productId, int quantity) {
        this.ShippingOrderId = shippingOrderId;
        this.ProductId = productId;
        this.Quantity = quantity;
    }

    // ToString override
    public override string ToString() {
        return $"ShippingOrderProduct [ShippingOrderId={ShippingOrderId}, ProductId={ProductId}, Quantity={Quantity}]";
    }
}
