﻿using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ProductService 
{
    private WsysApplication WApp; 
    private ProductDAO productDAO;
    private ProductView WinView;

    //Constructeur
    public ProductService(WsysApplication parentApp, AppDbContext context)             
    {
        this.WApp = parentApp;
        this.productDAO = new ProductDAO(context);
        this.WinView = new ProductView(parentApp);
    }

    #region METHODES
    public Product? OpenManagementWindowForCreation() {
        try {
            Product newUser = (Product) FormatterServices.GetUninitializedObject(typeof(Product));
            DialogResult result = this.WinView.OpenForCreation(newUser);
            return result == DialogResult.OK
                ? newUser
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user creation mode.", ex);
        }
    }

    ///Method qui appellent au DAO directement
    public Product Create(Product prodCreation) 
        {  return this.productDAO.Create(prodCreation); }

    public Product? GetById(int id) 
        {  return this.productDAO.GetById(id); }

    public Product Update(Product prodUpdated) 
        {  return this.productDAO.Update(prodUpdated); }
    public string Delete(Product prodDeleted) 
        {  return this.productDAO.Delete(prodDeleted);  }

    public List<Product> Search(string userInput) 
        {  return this.productDAO.Search(userInput);  }

    public List<Product> GetAllProducts(bool includedDeleted = false) 
        { return this.productDAO.GetAll(includedDeleted); }
    public List<Product> GetBySupplier(Supplier supplier) 
        {  return this.productDAO.GetBySupplier(supplier);  } //retourne une LISTE 

    public List<Product>? GetByClient(Client client) 
        {  return this.productDAO.GetByClient(client); } //retourne une LISTE 

    //public void OpenViewFor(ViewActionsEnum, Product? = null)
    #endregion

}
