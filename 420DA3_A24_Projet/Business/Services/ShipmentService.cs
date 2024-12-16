using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Classe de service pour gérer l'entité <see cref="Shipment"/>
/// </summary>

internal class ShipmentService {

    private WsysApplication parentApp;
    private ShipmentDAO dao;
    private ShipmentView view;

    public ShipmentService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.dao = new ShipmentDAO(context);
        this.view = new ShipmentView(parentApp);
    }

    #region METHODS

    public Shipment? OpenManagementWindowForCreation() {
        try {
            Shipment newShipment = (Shipment) FormatterServices.GetUninitializedObject(typeof(User));
            DialogResult result = this.view.OpenForCreation(newShipment);
            return result == DialogResult.OK
                ? newShipment
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipment management window in shipment creation mode.", ex);
        }
    }

    public bool OpenManagementWindowForEdition(Shipment shipment) {
        try {
            DialogResult result = this.view.OpenForModification(shipment);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipment management window in shipment edition mode.", ex);
        }
    }

    public Shipment OpenManagementWindowForVisualization(Shipment shipment) {
        try {
            _ = this.view.OpenForDetailsView(shipment);
            return shipment;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipment management window in shipment visualization mode.", ex);
        }
    }

    public bool OpenManagementWindowForDeletion(Shipment shipment) {
        try {
            DialogResult result = this.view.OpenForDeletion(shipment);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipment management window in shipment deletion mode.", ex);
        }
    }

    public List<Shipment> GetAllShipments(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing shipments.", ex);
        }
    }
    public Shipment? GetShipmentById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve an shipment by its Id.", ex);
        }
    }

    public Shipment? CreateShipment(Shipment shipment) {
        try {
            return this.dao.Create(shipment);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new shipment in the database.", ex);
        }
    }

    public List<Shipment> SearchShipment(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search existing shipments.", ex);
        }
    }

    public Shipment UpdateShipment(Shipment shipment) {
        try {
            return this.dao.Update(shipment);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a shipment in the database.", ex);
        }
    }

    public Shipment DeleteShipment(Shipment shipment, bool softDeletes = true) {
        try {
            return this.dao.Delete(shipment, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete an shipment from the database.", ex);
        }
    }


    #endregion
}
