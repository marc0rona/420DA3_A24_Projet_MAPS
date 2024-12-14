using _420DA3_A24_Projet.Business.Domain;
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

    /// <summary>
    /// Opens the <see cref="WarehouseView">user management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    public Warehouse? OpenManagementWindowForCreation() {
        try {
            Warehouse newWarehouse = (Warehouse) FormatterServices.GetUninitializedObject(typeof(Warehouse));
            DialogResult result = this.warehouseWindow.OpenForCreation(newWarehouse);
            return result == DialogResult.OK
                ? newWarehouse
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the Warehouse management window in Warehouse creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="WarehouseView">user management window</see> in edition mode
    /// for the given <paramref name="warehouse"/>.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForEdition(Warehouse warehouse) {
        try {
            DialogResult result = this.warehouseWindow.OpenForModification(warehouse);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the Warehouse management window in Warehouse edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="WarehouseView">user management window</see> in visualization mode
    /// for the given <paramref name="warehouse"/>.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Warehouse OpenManagementWindowForVisualization(Warehouse warehouse) {
        try {
            _ = this.warehouseWindow.OpenForDetailsView(warehouse);
            return warehouse;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the Warehouse management window in Warehouse visualization mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="WarehouseView">user management window</see> in deletion mode
    /// for the given <paramref name="warehouse"/>.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForDeletion(Warehouse warehouse) {
        try {
            DialogResult result = this.warehouseWindow.OpenForDeletion(warehouse);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the Warehouse management window in Warehouse deletion mode.", ex);
        }
    }

    public List<Client> GetAllClients(bool includeDeleted = false) {
        return this.clientDAO.GetAll(includeDeleted);
    }


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
