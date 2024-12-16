using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Class de service pour gérer l'entité <see cref="Address"/>
/// </summary>

internal class AddressService {

    private WsysApplication parentApp;
    private AddressDAO dao;
    private AddressView view;

    /// <summary>
    /// <see cref="RoleService"/> constructeur
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public AddressService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.dao = new AddressDAO(context);
        this.view = new AddressView(parentApp);
    }

    #region METHODS

    /// <summary>
    /// Opens the <see cref="AddressView">address management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    public Address? OpenAddressManagementWindowForCreation() {
        Address newAddress = (Address) FormatterServices.GetUninitializedObject(typeof(Address));
        DialogResult result = this.view.OpenForCreation(newAddress); // finir view
        return result == DialogResult.OK
            ? this.view.CurrentEntityInstance
            : null;
    }

    /// <summary>
    /// Opens the <see cref="AddressView">address management window</see> in edition mode
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public bool OpenManagementWindowForEdition(Address address) {
        try {
            DialogResult result = this.view.OpenForModification(address);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the address management window in address edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="AddressView">address management window</see> in visualization mode
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Address OpenManagementWindowForVisualization(Address address) {
        try {
            _ = this.view.OpenForDetailsView(address);
            return address;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the address management window in address visualization mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="AddressView">role management window</see> in deletion mode
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public bool OpenManagementWindowForDeletion(Role address) {
        try {
            DialogResult result = this.view.OpenForDeletion(address);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the address management window in address deletion mode.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="Address"/> that exist in the data source.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public List<Address> GetAllAddresses(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing addresses.", ex);
        }
    }

    public Address? GetById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve an address by its Id.", ex);
        }
    }

    /// <summary>
    /// Renvoie la liste de tous les <see cref="Address"/> qui correspondent au <paramref name="criterion"/> donné dans la source de données.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public List<Address> SearchAddress(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search existing addresses.", ex);
        }
    }

    /// <summary>
    /// Insère un <see cref="Role"/> dans la source de données.
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Address? CreateAddress(Address address) {
        try {
            return this.dao.Create(address);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new address in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="Role"/> dans la source de données.
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Address UpdateAddress(Address address) {
        try {
            return this.dao.Update(address);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update an address in the database.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="Address"/> in the data source.
    /// </summary>
    /// <param name="address"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public Address DeleteAddress(Address address, bool softDeletes = true) {
        try {
            return this.dao.Delete(address, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete an address from the database.", ex);
        }
    }


    #endregion
}
