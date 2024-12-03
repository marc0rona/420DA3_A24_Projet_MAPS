using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ShippingOrderDAO {

    private readonly AppDbContext context;

    public ShippingOrderDAO(AppDbContext context) {
        this.context = context;
    }

    public ShippingOrder? Create(ShippingOrder shippingOrder) {
        _ =this.context.ShippingOrders.Add(shippingOrder);
        _ = this.context.SaveChanges();
        return shippingOrder;
    }

}


