using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShippingOrderService 
{
    private readonly ShippingOrderView view;
    private readonly WsysApplication application;
    private readonly ShippingOrderDAO dao;

    public ShippingOrderService(AppDbContext context, WsysApplication application) {
        this.view = new ShippingOrderView();
        this.application = application;
        this.dao = new ShippingOrderDAO(context);
    }

    public ShippingOrder? OpenViewFor(ViewActionsEnum action, ShippingOrder? order = null)
    {
        return order;
    }

    public ShippingOrder Create(ShippingOrder order) 
    {
        return dao.Create(order);
    }

    public ShippingOrder? GetById(int id)
    {
        return this.dao.GetById(id);
    }

    public List<ShippingOrder> GetUnassignedInWarehouse(Warehouse warehouse) 
    {
        return dao.GetByWarehouse(warehouse, ShippingOrderStatusEnum.Unassigned);
    }

    public List<ShippingOrder> GetPackagedInWarehouse(Warehouse warehouse) 
    {
        return this.dao.GetByWarehouse(warehouse, ShippingOrderStatusEnum.Packaged);
    }

    public List<ShippingOrder> GetProcessingOrdersForWhEmployee() 
    {
        Warehouse entrepot = this.application.LoginService.LoggedInUser?.EmployeeWarehouse
            ?? throw new Exception("No warehouse in logged in user");
        return dao.GetByWarehouse(entrepot, ShippingOrderStatusEnum.Processing);
    }

    public List<ShippingOrder> Search(string searchTerm) 
    {
        return this.dao.Search(searchTerm);
    }

    public ShippingOrder Update(ShippingOrder order) 
    {
        return this.dao.Update(order);
    }

    public void Delete(ShippingOrder order) 
    {
        dao.Delete(order);
    }
}
