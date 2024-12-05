using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class WarehouseDAO {

    private readonly AppDbContext context;

    /// <param name="context"></param>
    public WarehouseDAO(AppDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Warehouse? GetById(int id, bool includeDeleted = false) {
        return this.context.Warehouses
            .Where(warehouse => warehouse.Id == id && (includeDeleted || warehouse.DateDeleted == null))
            .Include(warehouse => warehouse.Clients)
            .Include(warehouse => warehouse.AssignedAddress)
            //.Include(warehouse => warehouse.RestockOrders)
            .Include(warehouse => warehouse.WarehouseEmployees)

            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="clientName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Warehouse? GetByWarehouseName(string warehouseName, bool includeDeleted = false) {
        return this.context.Warehouses
            .Where(warehouse => warehouse.WarehouseName == warehouseName && (includeDeleted || warehouse.DateDeleted == null))
            .Include(warehouse => warehouse.Clients)
            .Include(warehouse => warehouse.AssignedAddress)
            //.Include(warehouse => warehouse.RestockOrders)
            .Include(warehouse => warehouse.WarehouseEmployees)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Warehouse> Search(string criterion, bool includeDeleted = false) {
        return this.context.Warehouses
            .Where(warehouse => (
                warehouse.Id.ToString().Contains(criterion)
                || warehouse.WarehouseName.ToLower().Contains(criterion.ToLower())
            ) && (includeDeleted || warehouse.DateDeleted == null))
            .Include(warehouse => warehouse.Clients)
            .Include(warehouse => warehouse.AssignedAddress)
            //.Include(warehouse => warehouse.RestockOrders)
            .Include(warehouse => warehouse.WarehouseEmployees)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Warehouse Create(Warehouse warehouse) {
        _ = this.context.Warehouses.Add(warehouse);
        _ = this.context.SaveChanges();
        return warehouse;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public Warehouse Update(Warehouse warehouse) {
        warehouse.DateModified = DateTime.Now;
        _ = this.context.Warehouses.Update(warehouse);
        _ = this.context.SaveChanges();
        return warehouse;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Warehouse Delete(Warehouse warehouse, bool softDeletes = true) {
        if (softDeletes) {
            warehouse.DateDeleted = DateTime.Now;
            _ = this.context.Warehouses.Update(warehouse);

        } else {
            _ = this.context.Warehouses.Remove(warehouse);
        }
        _ = this.context.SaveChanges();
        return warehouse;
    }


}
