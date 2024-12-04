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

namespace _420DA3_A24_Projet.Business.Services;

/* Auteur de la classe AddressService.cs : Pierre-Sylvestre Cypré */

internal class AddressService {

    /// <summary>
    /// TODO @Pierre : documenter
    /// </summary>
    private WsysApplication parentApp;
    private AddressDAO addressDAO;
    private AddressView addressWindow;
    private AppDbContext context;

    /// <summary>
    /// TODO @Pierre : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public AddressService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.context = context;
        this.addressDAO = new AddressDAO(context);
        this.addressWindow = new AddressView(parentApp);

    }

    #region METHODS

    public Address? OpenAddressManagementWindowForCreation() {
        Address newEmptyAddress = (Address) FormatterServices.GetUninitializedObject(typeof(Address));
        DialogResult result = this.addressWindow.OpenForCreation(newEmptyAddress); // finir view
        return result == DialogResult.OK
            ? this.addressWindow.CurrentEntityInstance
            : null;
    }






    public Address? CreateAddressInDatabase(Address address) {
        return this.addressDAO.Create(address);
    }

    public Address? GetAddressById(int id) {
        return this.addressDAO.GetById(id);
    }

    public List<Address> SearchAddresses(string criterion) {
        return this.addressDAO.Search(criterion);
    }

    public Address? UpdateAddressInDatabase(Address address) {
        return this.addressDAO.Update(address);
    }

    public Address? DeleteAddressFromDatabase(Address address) {
        return addressDAO.Delete(address);
    }
    

    #endregion
}
