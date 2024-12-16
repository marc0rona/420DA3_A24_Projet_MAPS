using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//ajout des variables exterieures necessaires
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ProductDAO 
{
    private readonly AppDbContext context;

    ///Constructeur (param name = 'context')
    public ProductDAO(AppDbContext Context) 
    {   this.context = Context;   }

    ///METHODES - FONCTIONS 
    //Sert a créer le DAO dans les Services [CRUD : Create]
    public Product Create(Product product) 
    {   _ = this.context.Products.Add(product); //rajoute Entity du Produit
        _ = this.context.SaveChanges();
        return product;
    }

    //Pogne le ID + enities connecter en fonction du AppContext (peut etre nullable) [CRUD : Read]
    public Product? GetById(int id_input, bool includeDeleted = false /* default false = n'inclu pas les Produits qui ont été supprimés */) 
    {   return this.context.Products
            .Where(prod => prod.Id == id_input && (includeDeleted || prod.DateDeleted == null))  //verification de la suppression, si faite
            .Include(prod => prod.OwnerClient)      //lié a Client
            .Include(prod => prod.Supplier)         //lié au Supplier
            .Include(prod => prod.OrderPurchases)
            .Include(prod => prod.ShippingOrderProducts)
            .SingleOrDefault(); //Retourne 1 seul element 
    }
    //Mis-a-jour d'une donnée de l'Entity [CRUD : Update]
    public Product Update(Product chosenProd) 
    {   chosenProd.DateModified = DateTime.Now; //Premierement, change le dateModified (logic)
        _ = this.context.Products.Update(chosenProd);
        _ = this.context.SaveChanges();
        return chosenProd;
    }
    //Suppression [CRUD : Delete]
    public string Delete(Product chosenProd, bool softDeletes = true /* default delete totally = */) 
    {   if(softDeletes) /*is true*/
        {   chosenProd.DateDeleted = DateTime.Now;
            _ = this.context.Products.Update(chosenProd); //'Soft Delete' guarde les infos du produits supprimer
        } else 
          { _ = this.context.Products.Remove(chosenProd); }
        _ = this.context.SaveChanges();
        return chosenProd.Name; //RETOURNE le nom pour CONFIRMATION
    }
    //Recherche par input TextBox
    public List<Product> Search(string searchBar, bool incDeleted = false)  //default = false
    {   return this.context.Products.Where(prod => 
        (    prod.Id.ToString()
            .Contains(searchBar) || prod.Name.ToLower().Contains(searchBar.ToLower())
        ) && (incDeleted || prod.DateDeleted == null)) //si le DateDeleted =! null (a été supprimer), peut rajouter un TRUE pour include le produit supprimer
        .Include(prod => prod.OwnerClient)
        .Include(prod => prod.Supplier)
        .ToList();
    }
    public List<Product> GetAll(bool includeDeleted = false) 
    {
        return this.context.Products
            .Where(prod => includeDeleted || prod.DateDeleted == null)
            .ToList();
    }
    //GetBy - Relations a autres Tables
    public List<Product> GetBySupplier(Supplier supplier, bool incDeleted = false) 
    {   return this.context.Products
               .Where(prod => prod.Supplier == supplier && (incDeleted || prod.DateDeleted == null))
               .Include(prod => prod.OwnerClient)
               .ToList(); //Unlike 'SingleOrDefault', retourne pluseirus elements
    }

    public List<Product>? GetByClient(Client client, bool incDeleted = false) 
    {   return this.context.Products
               .Where(prod => prod.OwnerClient == client && (incDeleted || prod.DateDeleted == null))
               .Include(prod => prod.Supplier)
               .ToList();
    }
}
