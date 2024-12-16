using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Classe d'objet d'cccès de données pour l'entité <see cref="Address"/>
/// </summary>
internal class AddressDAO {

    private readonly AppDbContext context;

    /// <summary>
    /// Constructeur pour <see cref="AddressDAO"/>
    /// </summary>
    /// <param name="context"></param>
    public AddressDAO(AppDbContext context) {
        this.context = context;
    }

    public List<Address> GetAll(bool includeDeleted = false) {
        try {
            return this.context.Addresses
                .Where(address => includeDeleted || address.DateDeleted == null)
                .ToList();
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all addresses from database.", ex);
        }
    }

    /// <summary>
    /// Retourne une adresse selon l'id fourni dans <param name="id"></param>
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Address? GetById(int id, bool includeDeleted = false) {

        try {
            return this.context.Addresses
            .Where(address => address.Id == id && (includeDeleted || address.DateDeleted == null))
            .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve address Id #{id} from database.", ex);
        }
    }

    /// <summary>
    /// Crée une nouvelle addresse avec les informations de <param name="address"></param>
    /// </summary>
    /// <returns></returns>
    public Address? Create(Address address) {
        try {
            _ = this.context.Addresses.Add(address);
            _ = this.context.SaveChanges();
            return address;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create address in database.", ex);
        }
    }




    /// <summary>
    /// Met à jour l'adresse avec les informations fournies dans <param name="address"></param>
    /// </summary>
    /// <returns></returns>
    public Address Update(Address address) {
        DateTime? originalDateModified = address.DateModified;
        try {
            address.DateModified = DateTime.Now;
            _ = this.context.Addresses.Update(address);
            _ = this.context.SaveChanges();
            return address;

        } catch (Exception ex) {
            // revert date modified
            address.DateModified = originalDateModified;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update address in database.", ex);
        }
    }


    /// <summary>
    /// Supprime en douceur (soft delete) si <param name="softDeletes"></param> est vrai, sinon efface de manière permanente l'addresse et sauvegarde les changements.
    /// </summary>
    /// <param name="address"></param>
    /// 
    /// <returns></returns>
    public Address Delete(Address address, bool softDeletes = true) {
        DateTime? originalDateDelated = address.DateDeleted;
        try {
            if (softDeletes) {
                address.DateDeleted = DateTime.Now;
                _ = this.context.Addresses.Update(address);

            } else {
                _ = this.context.Addresses.Remove(address);
            }
            _ = this.context.SaveChanges();
            return address;

        } catch (Exception ex) {
            // revert date deleted
            address.DateModified = originalDateDelated;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete address from database.", ex);
        }
    }

    /// <summary>
    /// Recherche une adresse à partir du destinataire, numéro civique, rue, ville, province, pays et code postal. <br/>
    /// Retourne la liste des Adresses dont le destinataire, numéro civique, rue, ville, province, pays ou le code postal contient la valeur de <param name="criterion"></param>
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Address> Search(string criterion, bool includeDeleted = false) {
        try {
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

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search address in database.", ex);
        }
    }

    /// <summary>
    /// Retourne l'addresse selon le warehouse (optionnel???)
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    /// 
    /*
    public Address? GetByWarehouse(Warehouse warehouse) {
        try {
            return this.context.Addresses
            .Where(address => address.DateDeleted == null &&
                   address.Warehouses.Contains(warehouse))
            .SingleOrDefault();
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search address using the warehouse Id in the database.", ex);
        }
    }
    */


    /// <summary>
    /// Retourne l'addresse selon le shipping order (optionnel???)
    /// </summary>
    /// <param name="shippingOrder"></param>
    /// <returns></returns>
    /// 
    /*
    public Address? GetByShipOrder(ShipmentOrders shippingOrder) {
        try {
            return this.context.Addresses
            .Where(address => address.DateDeleted == null &&
                   address.ShippingOrders.Contains(shippingOrder))
            .SingleOrDefault();
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search address using the shipping order Id in the database.", ex);
        }
    }
    */

}
