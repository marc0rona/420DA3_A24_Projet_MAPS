using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ShippingOrderDAO {
    private readonly AppDbContext context;

    public ShippingOrderDAO(AppDbContext context) {
        this.context = context;
    }

    public ShippingOrder Create(ShippingOrder order) {
        context.ShippingOrders.Add(order);
        context.SaveChanges();
        return order;
    }

    public ShippingOrder? GetById(int id) {
        return context.ShippingOrders
            .Include(o => o.SourceClient)
            .Include(o => o.CreatorEmployee)
            .Include(o => o.FulfillerEmployee)
            .FirstOrDefault(o => o.Id == id);
    }

    public ShippingOrder Update(ShippingOrder order) {
        context.ShippingOrders.Update(order);
        context.SaveChanges();
        return order;
    }

    public void Delete(ShippingOrder order) {
        context.ShippingOrders.Remove(order);
        context.SaveChanges();
    }

    public List<ShippingOrder> GetByFulfillerUser(User user, ShippingOrderStatusEnum? status = null) {
        IQueryable<ShippingOrder> query = context.ShippingOrders
            .Include(o => o.SourceClient)
            .Where(o => o.FulfillerEmployee.Id == user.Id);

        if (status.HasValue)
            query = query.Where(o => o.Status == status.Value);

        return query.ToList();
    }

    public List<ShippingOrder> GetByCreatorUser(User user, ShippingOrderStatusEnum? status = null) {
        IQueryable<ShippingOrder> query = context.ShippingOrders
            .Include(o => o.SourceClient)
            .Where(o => o.CreatorEmployee.Id == user.Id);

        if (status.HasValue)
            query = query.Where(o => o.Status == status.Value);

        return query.ToList();
    }

    public List<ShippingOrder> GetByClient(Client client, ShippingOrderStatusEnum? status = null) {
        IQueryable<ShippingOrder> query = context.ShippingOrders
            .Include(o => o.CreatorEmployee)
            .Include(o => o.FulfillerEmployee)
            .Where(o => o.SourceClient.Id == client.Id);

        if (status.HasValue)
            query = query.Where(o => o.Status == status.Value);

        return query.ToList();
    }

    public List<ShippingOrder> GetByWarehouse(Warehouse warehouse, ShippingOrderStatusEnum? status = null) {
        IQueryable<ShippingOrder> query = context.ShippingOrders
            .Include(o => o.SourceClient)
            .Include(o => o.CreatorEmployee)
            .Include(o => o.FulfillerEmployee)
            .Where(o => o.SourceClient.WarehouseId == warehouse.Id);

        if (status is not null)
            query = query.Where(o => o.Status == status.Value);

        return query.ToList();
    }

    public List<ShippingOrder> Search(string? clientName = null, 
                                   int? orderId = null, 
                                   ShippingOrderStatusEnum? status = null) {
    IQueryable<ShippingOrder> query = context.ShippingOrders
        .Include(o => o.SourceClient)
        .Include(o => o.CreatorEmployee)
        .Include(o => o.FulfillerEmployee)
        .Include(o => o.DestinationAddress);

    // Recherche par nom du client (assuré via la relation SourceClient)
    if (!string.IsNullOrEmpty(clientName))
        query = query.Where(o => o.SourceClient != null && o.SourceClient.ClientName.Contains(clientName));

    // Recherche par ID de commande
    if (orderId.HasValue)
        query = query.Where(o => o.Id == orderId.Value);

    // Recherche par statut
    if (status.HasValue)
        query = query.Where(o => o.Status == status.Value);

    return query.ToList();
}
}


