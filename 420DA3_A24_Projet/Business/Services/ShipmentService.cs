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

/* Auteur de la classe ShipmentService.cs : Pierre-Sylvestre Cypré */

internal class ShipmentService {

    private WsysApplication parentApp;
    private ShipmentDAO shipmentDAO;
    private ShipmentView shipmentWindow;

    public ShipmentService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.shipmentDAO = new ShipmentDAO(context);
        this.shipmentWindow = new ShipmentView(parentApp);
    }

    #region METHODS

    // Finir OpenViewFor....

    public Shipment? OpenManagementWindowForCreation() {
        try {
            Shipment newShipment = (Shipment) FormatterServices.GetUninitializedObject(typeof(User));
            DialogResult result = this.shipmentWindow.OpenForCreation(newShipment);
            return result == DialogResult.OK
                ? newShipment
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipment management window in shipment creation mode.", ex);
        }
    }


    public Shipment? CreateShipmentInDatabase(Shipment shipment) {
        return this.shipmentDAO.Create(shipment);
    }

    public Shipment? GetShipmentById(int id) {
        return this.shipmentDAO.GetById(id);
    }

    public List<Shipment> SearchShipments(string criterion) { 
        return this.shipmentDAO.Search(criterion);
    }

    public Shipment? UpdateShipmentInDatabase(Shipment shipment) {
        return this.shipmentDAO.Update(shipment);
    }

    public Shipment? DeleteShipmentFromDatabase(Shipment shipment) {
        return shipmentDAO.Delete(shipment);
    }
        

    #endregion
}
