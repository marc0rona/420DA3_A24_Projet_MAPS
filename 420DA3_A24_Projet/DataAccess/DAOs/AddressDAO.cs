using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/* Auteur de la classe AddressDAO.cs : Pierre-Sylvestre Cypré */

internal class AddressDAO {

    private readonly AppDbContext context;

    public AddressDAO(AppDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Crée une nouvelle addresse avec les informations de <param name="address"></param>
    /// </summary>
    /// <returns></returns>
    public Address? Create(Address address) {
        _ = this.context.Addresses.Add(address);
        _ = this.context.SaveChanges();
        return address;
    }

    /// <summary>
    /// Retourne une adresse selon l'id fourni dans <param name="id"></param>
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Address? GetById(int id, bool includeDeleted = false) {
        return this.context.Addresses
            .Where(address => address.Id == id && (includeDeleted || address.DateDeleted == null))
            .SingleOrDefault();
    }

    /// <summary>
    /// Met à jour l'adresse avec les informations fournies dans <param name="address"></param>
    /// </summary>
    /// <returns></returns>
    public Address Update(Address address) {
        address.DateModified = DateTime.Now;
        _ = this.context.Addresses.Update(address);
        _ = this.context.SaveChanges();
        return address;
    }

    /// <summary>
    /// Supprime en douceur (soft delete) si <param name="softDeletes"></param> est vrai, sinon efface de manière permanente l'addresse et sauvegarde les changements.
    /// </summary>
    /// <param name="address"></param>
    /// 
    /// <returns></returns>
    public Address Delete(Address address, bool softDeletes = true) {
        if (softDeletes) {
            address.DateDeleted = DateTime.Now;
            _ = this.context.Addresses.Update(address);

        } else {
            _ = this.context.Addresses.Remove(address);
        }
        _ = this.context.SaveChanges();
        return address;
    }

    /// <summary>
    /// Recherche une adresse à partir du destinataire, numéro civique, rue, ville, province, pays et code postal. <br/>
    /// Retourne la liste des Adresses dont le destinataire, numéro civique, rue, ville, province, pays ou le code postal contient la valeur de <param name="criterion"></param>
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Address> Search(string criterion, bool includeDeleted = false) {
        return this.context.Addresses
            .Where(address =>
                (includeDeleted || address.DateDeleted == null) &&
                (address.Id.ToString().Contains(criterion) ||
                 address.Addressee.Contains(criterion) ||
                 address.CivicNumber.Contains(criterion) ||
                 address.Street.Contains(criterion) ||
                 address.City.Contains(criterion) ||
                 address.State.Contains(criterion) ||
                 address.Country.Contains(criterion) ||
                 address.PostalCode.Contains(criterion)))
            .ToList();
    }

    /// <summary>
    /// Retourne l'addresse selon le warehouse
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Address? GetByWarehouse(Warehouse warehouse) {
        return this.context.Addresses
            .Where(address => address.DateDeleted == null &&
                   address.Warehouses.Contains(warehouse))
            .SingleOrDefault();
    }

    /// <summary>
    /// Retourne l'addresse selon le shipping order
    /// </summary>
    /// <param name="shippingOrder"></param>
    /// <returns></returns>
    public Address? GetByShipOrder(ShipmentOrders shippingOrder) {
        return this.context.Addresses
            .Where(address => address.DateDeleted == null &&
                   address.ShippingOrders.Contains(shippingOrder))
            .SingleOrDefault();
    }

}
