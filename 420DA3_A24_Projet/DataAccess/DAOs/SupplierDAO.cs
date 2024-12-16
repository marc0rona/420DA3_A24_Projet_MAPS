using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//ajout des variables exterieures necessaires
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class SupplierDAO 
{
    private readonly AppDbContext context;

    //Constructeur
    public SupplierDAO(AppDbContext context) 
    {   this.context = context;   }

    ///METHODES - FONCTIONS 
    //Sert a créer le DAO dans les Services [CRUD : Create]
    public Supplier Create(Supplier supplier) {
        try {
            _ = this.context.Suppliers.Add(supplier); //rajoute Entity Supplier
            _ = this.context.SaveChanges();
            return supplier;
        } 
        catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create supplier in DB.", ex);
        }
    }

    //Pogne le ID + enities connecter en fonction du AppContext (peut etre nullable) [CRUD : Read]
    public Supplier? GetById(int id_input, bool includeDeleted = false /* default false */) 
    {
        try {
            return this.context.Suppliers
                  .Where(supp => supp.Id == id_input && (includeDeleted || supp.DateDeleted == null))  //verification de la suppression, si faite
                  .Include(supp => supp.ProductList)      //lié a Produits
                  .SingleOrDefault();

        } 
        catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the supplier Id from DB.", ex);
        }
    }
    //Mis-a-jour d'une donnée de l'Entity [CRUD : Update]
    public Supplier Update(Supplier chosenSupp) {
        DateTime? originalDateModified = chosenSupp.DateModified;
        try {
            chosenSupp.DateModified = DateTime.Now;
            _ = this.context.Suppliers.Update(chosenSupp);
            _ = this.context.SaveChanges();
            return chosenSupp;
        } 
        catch (Exception ex) {
            // revert date modified
            chosenSupp.DateModified = originalDateModified;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update supplier in DB.", ex);
        }
    }
    //Suppression [CRUD : Delete]
    public string Delete(Supplier chosenSupp, bool softDeletes = true /* default true */) 
    {
        DateTime? originalDateDelated = chosenSupp.DateDeleted;
        try 
        {
            if (softDeletes) /* is true */
            {
                chosenSupp.DateDeleted = DateTime.Now;
                _ = this.context.Suppliers.Update(chosenSupp); //'Soft Delete' guarde les infos du produits supprimer
            } else { _ = this.context.Suppliers.Remove(chosenSupp); }
            _ = this.context.SaveChanges();
            return chosenSupp.Name; //RETOURNE le nom pour CONFIRMATION
        } catch (Exception ex) {
            // revert date deleted
            chosenSupp.DateModified = originalDateDelated;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete supplier from DB.", ex);
        }
    }
    public List<Supplier> GetAll(bool includeDeleted = false) 
    {   try {
            return this.context.Suppliers
                .Where(supp => includeDeleted || supp.DateDeleted == null)
                .ToList();
        } 
        catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all suppliers from database.", ex);
        }
    }
    //Recherches (SearchBar)
    public List<Supplier> Search(string searchBar, bool incDeleted = false) 
    {   return this.context.Suppliers.Where(supp =>
        (supp.Id.ToString()
            .Contains(searchBar) || supp.Name.ToLower().Contains(searchBar.ToLower())
        ) && (incDeleted || supp.DateDeleted == null)) //si le DateDeleted =! null (a été supprimer), peut rajouter un TRUE pour include le produit supprimer
        .Include(supp => supp.ProductList)
        .ToList();     
    }

    internal ShippingOrder Create(ShippingOrder order) {
        throw new NotImplementedException();
    }

    internal List<ShippingOrder> GetUnassignedInWarehouse(Warehouse warehouse) {
        throw new NotImplementedException();
    }

    internal List<ShippingOrder> GetProcessingOrdersForEmployee(User employee) {
        throw new NotImplementedException();
    }

    internal List<ShippingOrder> GetPackagedInWarehouse(Warehouse warehouse) {
        throw new NotImplementedException();
    }

    internal void Delete(ShippingOrder order, bool softDelete) {
        throw new NotImplementedException();
    }

    internal ShippingOrder Update(ShippingOrder order) {
        throw new NotImplementedException();
    }
}
