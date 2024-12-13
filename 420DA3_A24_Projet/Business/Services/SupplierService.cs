using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class SupplierService 
{
    private WsysApplication WApp;
    private SupplierDAO supplierDAO;
    //private SupplierView Window

    //Constructeur
    public SupplierService(WsysApplication parentApp, AppDbContext context) 
    {
        this.WApp = parentApp;
        this.supplierDAO = new SupplierDAO(context);
        //this.view = new RoleView(parentApp);
    }
    #region METHODES
    ///Method qui appellent au DAO directement
    public Supplier Create(Supplier supplier) 
        {  return this.supplierDAO.Create(supplier);  }
    public Supplier? GetById(int id) 
        {  return this.supplierDAO.GetById(id);  }
    public Supplier Update(Supplier supplier) 
        {  return this.supplierDAO.Update(supplier);  }
    public string Delete(Supplier supplier) 
        {  return this.supplierDAO.Delete(supplier);  }
    public List<Supplier> Search(string userInput) 
        {  return this.supplierDAO.Search(userInput); } //retourne une LISTE 

    //public void OpenViewFor(ViewActionsEnum, Supplier? = null)
    #endregion
}
