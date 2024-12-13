using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class WarehouseService {

    private WsysApplication parentApp;
    private WarehouseDAO warehouseDAO;
    private WarehouseView warehouseWindow;

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public WarehouseService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.warehouseDAO = new WarehouseDAO(context);
        this.warehouseWindow = new WarehouseView(parentApp);
    }


    #region METHODS

    public List<Warehouse> GetAllWarehouses(bool includeDeleted = false) {
        return this.warehouseDAO.GetAll(includeDeleted);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <returns></returns>
    public Warehouse? OpenWarehouseManagementWindowForCreation() {
        Warehouse newEmptyWarehouse = (Warehouse) FormatterServices.GetUninitializedObject(typeof(Warehouse));
        DialogResult result = this.warehouseWindow.OpenForCreation(newEmptyWarehouse);
        return result == DialogResult.OK
            ? this.warehouseWindow.CurrentEntityInstance
            : null;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouseToEdit"></param>
    /// <returns></returns>
    public Warehouse OpenWarehouseManagementWindowForEdition(Warehouse warehouseToEdit) {
        _ = this.warehouseWindow.OpenForModification(warehouseToEdit);
        return warehouseToEdit;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouseToView"></param>
    /// <returns></returns>
    public Warehouse OpenWarehouseManagementWindowForVisualization(Warehouse warehouseToView) {
        _ = this.warehouseWindow.OpenForDetailsView(warehouseToView);
        return warehouseToView;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouseToDelete"></param>
    /// <returns></returns>
    public Warehouse OpenWarehouseManagementWindowForDeletion(Warehouse warehouseToDelete) {
        _ = this.warehouseWindow.OpenForDeletion(warehouseToDelete);
        return warehouseToDelete;
    }


    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Warehouse? GetWarehouseById(int id) {
        return this.warehouseDAO.GetById(id);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouseName"></param>
    /// <returns></returns>
    public Warehouse? GetWarehouseByWarehouseName(string warehouseName) {
        return this.warehouseDAO.GetByWarehouseName(warehouseName);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<Warehouse> SearchWarehouses(string criterion) {
        return this.warehouseDAO.Search(criterion);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Warehouse CreateWarehouseInDatabase(Warehouse warehouse) {
        return this.warehouseDAO.Create(warehouse);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Warehouse UpdateWarehouseInDatabase(Warehouse warehouse) {
        return this.warehouseDAO.Update(warehouse);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Warehouse DeleteWarehouseFromDatabase(Warehouse warehouse) {
        return this.warehouseDAO.Delete(warehouse);
    }

    #endregion

}
