using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/* Auteur de la classe ShipmentDAO.cs : Pierre-Sylvestre Cypré */

internal class ShipmentDAO {

    private readonly AppDbContext context;

    public ShipmentDAO(AppDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Crée une nouvelle expédition avec les informations du paramètre <param name="shipment"></param>
    /// </summary>
    /// <returns></returns>
    public Shipment? Create(Shipment shipment) { 
        _ = this.context.Shipments.Add(shipment);
        _ = this.context.SaveChanges();
        return shipment;
    }

    /// <summary>
    /// Retourne l'expéddition selon le id fourni <param name="id"></param>
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Shipment? GetById(int id, bool includeDeleted = false) {
        return this.context.Shipments
            .Where(shipment => shipment.Id == id && (includeDeleted || shipment.DateDeleted == null))
            .SingleOrDefault();
    }

    /// <summary>
    /// Met à jour l'expédition avec les nouvelles informations grâce au paramètre <param name="shipment"></param>
    /// </summary>
    /// <returns></returns>
    public Shipment? Update(Shipment shipment) { 
        shipment.DateModified = DateTime.Now;
        _ = this.context.Shipments.Update(shipment);
        _ = this.context.SaveChanges();
        return shipment;
    }

    /// <summary>
    ///  Supprime en douceur (soft delete) si <param name="softDeletes"></param> est vrai, sinon efface de manière permanente l'expédition et sauvegarde les changements.
    /// </summary>
    /// <param name="shipment"></param>
    /// <returns></returns>
    public Shipment? Delete(Shipment shipment, bool softDeletes = true) {
        if (softDeletes) {
            shipment.DateDeleted = DateTime.Now;
            _ = this.context.Shipments.Update(shipment);

        } else {
            _ = this.context.Shipments.Remove(shipment);
        }
        _ = this.context.SaveChanges();
        return shipment;
    }

    /// <summary>
    /// *À finir....
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Shipment> Search(string criterion, bool includeDeleted = false) {
        return this.context.Shipments
            .Where(shipment =>
                (includeDeleted || shipment.DateDeleted == null) &&
                (shipment.Id.ToString().Contains(criterion) ||
                 shipment.TrackingNumber.Contains(criterion) ||
                 shipment.Status.ToString().Contains(criterion)))
            .ToList();
    }


}
