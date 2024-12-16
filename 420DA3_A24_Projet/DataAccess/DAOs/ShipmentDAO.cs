using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.DataAccess.DAOs;


/// <summary>
/// Classe d'objet d'accès de données pour l'entité <see cref="Shipment"/>
/// </summary>
internal class ShipmentDAO {

    private readonly AppDbContext context;

    /// <summary>
    /// Constructeur pour <see cref="ShipmentDAO"/>
    /// </summary>
    /// <param name="context"></param>
    public ShipmentDAO(AppDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Retourne toutes les expéditions
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public List<Shipment> GetAll(bool includeDeleted = false) {
        try {
            return this.context.Shipments
                .Where(shipment => includeDeleted || shipment.DateDeleted == null)
                .ToList();
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all shipments from database.", ex);
        }
    }

    /// <summary>
    /// Crée une nouvelle expédition avec les informations du paramètre <param name="shipment"></param>
    /// </summary>
    /// <returns></returns>
    public Shipment? Create(Shipment shipment) { 
        try {
            _ = this.context.Shipments.Add(shipment);
            _ = this.context.SaveChanges();
            return shipment;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create shipment in database.", ex);
        }
    }

    /// <summary>
    /// Retourne l'expéddition selon le id fourni <param name="id"></param>
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Shipment? GetById(int id, bool includeDeleted = false) {

        try {
            return this.context.Shipments
            .Where(shipment => shipment.Id == id && (includeDeleted || shipment.DateDeleted == null))
            .SingleOrDefault();
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve shipment Id #{id} from database.", ex);
        }
    }

    /// <summary>
    /// Met à jour l'expédition avec les nouvelles informations grâce au paramètre <param name="shipment"></param>
    /// </summary>
    /// <returns></returns>
    public Shipment? Update(Shipment shipment) {
        DateTime? originalDateModified = shipment.DateModified;
        try {
            shipment.DateModified = DateTime.Now;
            _ = this.context.Shipments.Update(shipment);
            _ = this.context.SaveChanges();
            return shipment;
        } catch (Exception ex) {
            // revert date modified
            shipment.DateModified = originalDateModified;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update shipment in database.", ex);
        }
    }

    /// <summary>
    ///  Supprime en douceur (soft delete) si <param name="softDeletes"></param> est vrai, sinon efface de manière permanente l'expédition et sauvegarde les changements.
    /// </summary>
    /// <param name="shipment"></param>
    /// <returns></returns>
    public Shipment? Delete(Shipment shipment, bool softDeletes = true) {
        DateTime? originalDateDelated = shipment.DateDeleted;
        try {
            if (softDeletes) {
                shipment.DateDeleted = DateTime.Now;
                _ = this.context.Shipments.Update(shipment);

            } else {
                _ = this.context.Shipments.Remove(shipment);
            }
            _ = this.context.SaveChanges();
            return shipment;
        } catch (Exception ex) {
            // revert date deleted
            shipment.DateModified = originalDateDelated;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete shipment from database.", ex);
        }
    }

    /// <summary>
    /// Recherche une expédition dont le id, tracking ou status correspond
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Shipment> Search(string criterion, bool includeDeleted = false) {
        try {
            return this.context.Shipments
            .Where(shipment =>
                (includeDeleted || shipment.DateDeleted == null) &&
                (shipment.Id.ToString().Contains(criterion) ||
                 shipment.TrackingNumber.Contains(criterion) ||
                 shipment.Status.ToString().Contains(criterion)))
            .ToList();
        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search shipment in database.", ex);
        }
    }


}
