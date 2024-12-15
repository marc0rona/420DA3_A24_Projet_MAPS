using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class PurchaseOrderService 
{
    private readonly PurchaseOrderView view;
    private readonly WsysApplication application;
    private readonly PurchaseOrderDAO dao;

    public PurchaseOrderService(PurchaseOrderView view, WsysApplication application, PurchaseOrderDAO dao) {
        this.view = view;
        this.application = application;
        this.dao = dao;
    }

    public PurchaseOrder? OpenViewFor(ViewActionsEnum action, PurchaseOrder? purchaseOrder = null) 
    {
        return purchaseOrder;
    }

    public PurchaseOrder Create(PurchaseOrder purchaseOrder) 
    {
        return this.dao.Create(purchaseOrder);
    }

    public PurchaseOrder? GetById(int id) 
    {
        return this.dao.GetById(id);
    }

    public List<PurchaseOrder> GetNewByWarehouse() 
    {
        Warehouse entrepot = this.application.LoginService.LoggedInUser?.EmployeeWarehouse 
            ?? throw new Exception("No warehouse in logged in user") ;
        return this.dao.GetByWH(entrepot, PurchaseOrderStatusEnum.New);
    }

    public List<PurchaseOrder> Search(string searchTerm) 
    {
        return this.dao.Search(searchTerm);
    }

    public PurchaseOrder Update(PurchaseOrder purchaseOrder) 
    {
        return this.dao.Update(purchaseOrder);
    }

    public void Delete(PurchaseOrder purchaseOrder) 
    {
        this.dao.Delete(purchaseOrder);
    }

}
