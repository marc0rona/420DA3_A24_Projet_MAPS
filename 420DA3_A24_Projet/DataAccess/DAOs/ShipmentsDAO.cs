using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
/// <summary>
/// TODO @Pierre : documenter
/// </summary>
internal class ShipmentsDAO {

    private readonly AppDbContext context;


    /// <summary>
    /// TODO @Pierre : documenter
    /// </summary>
    /// <param name="context"></param>
    public ShipmentsDAO(AppDbContext context) {
        this.context = context;
    }

    public Shipments? GetById(int id, bool includeDeleted = false) {
        return this.context.Shipments
            .Where(shipment => shipment.Id == id && (includeDeleted || shipment.DateDeleted == null))
            .SingleOrDefault();
    }
}
