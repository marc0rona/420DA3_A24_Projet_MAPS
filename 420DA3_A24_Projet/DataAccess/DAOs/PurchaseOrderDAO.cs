using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class PurchaseOrderDAO 
{
    private readonly AppDbContext context;

    public PurchaseOrderDAO(AppDbContext context) {
        this.context = context;
    }

    public PurchaseOrder Create(PurchaseOrder order) {
        context.PurchaseOrders.Add(order);
        context.SaveChanges();
        return order;
    }

    public PurchaseOrder? GetById(int id) {
        return context.PurchaseOrders
            .Include(o => o.OrderedProduct)
            .Include(o => o.Warehouse)
            .FirstOrDefault(o => o.Id == id);
    }

    public PurchaseOrder Update(PurchaseOrder order) {
        context.PurchaseOrders.Update(order);
        context.SaveChanges();
        return order;
    }

    public void Delete(PurchaseOrder order) {
        context.PurchaseOrders.Remove(order);
        context.SaveChanges();
    }

    public List<PurchaseOrder> GetByWH(Warehouse warehouse, PurchaseOrderStatusEnum? status = null) {
        IQueryable<PurchaseOrder> query = context.PurchaseOrders
            .Include(o => o.OrderedProduct)
            .Where(o => o.WarehouseId == warehouse.Id);

        if (status is not null)
            query = query.Where(o => o.Status == status.Value);

        return query.ToList();
    }

    public List<PurchaseOrder> GetByProduct(Product product, PurchaseOrderStatusEnum? status = null) {
        IQueryable<PurchaseOrder> query = context.PurchaseOrders
            .Include(o => o.Warehouse)
            .Where(o => o.ProductId == product.Id);

        if (status.HasValue)
            query = query.Where(o => o.Status == status.Value);

        return query.ToList();
    }

    internal List<PurchaseOrder> Search(string searchTerm) {
        throw new NotImplementedException();
    }
}
