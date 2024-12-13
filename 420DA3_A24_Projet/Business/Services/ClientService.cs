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
internal class ClientService {

    private WsysApplication parentApp;
    private ClientDAO clientDAO;
    private ClientView clientWindow;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public ClientService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.clientDAO = new ClientDAO(context);
        this.clientWindow = new ClientView(parentApp);
    }


    #region METHODS

    public List<Client> GetAllClients(bool includeDeleted = false) {
        return this.clientDAO.GetAll(includeDeleted);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <returns></returns>
    public Client? OpenClientManagementWindowForCreation() {
        Client newEmptyClient = (Client) FormatterServices.GetUninitializedObject(typeof(Client));
        DialogResult result = this.clientWindow.OpenForCreation(newEmptyClient);
        return result == DialogResult.OK
            ? this.clientWindow.CurrentEntityInstance
            : null;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="clientToEdit"></param>
    /// <returns></returns>
    public Client OpenClientManagementWindowForEdition(Client clientToEdit) {
        _ = this.clientWindow.OpenForModification(clientToEdit);
        return clientToEdit;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="clientToView"></param>
    /// <returns></returns>
    public Client OpenClientManagementWindowForVisualization(Client clientToView) {
        _ = this.clientWindow.OpenForDetailsView(clientToView);
        return clientToView;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="clientToDelete"></param>
    /// <returns></returns>
    public Client OpenClientManagementWindowForDeletion(Client clientToDelete) {
        _ = this.clientWindow.OpenForDeletion(clientToDelete);
        return clientToDelete;
    }


    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Client? GetClientById(int id) {
        return this.clientDAO.GetById(id);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="clientName"></param>
    /// <returns></returns>
    public Client? GetClientByUsername(string clientName) {
        return this.clientDAO.GetByClientName(clientName);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<Client> SearchClients(string criterion) {
        return this.clientDAO.Search(criterion);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client CreateClientInDatabase(Client client) {
        return this.clientDAO.Create(client);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client UpdateClientInDatabase(Client client) {
        return this.clientDAO.Update(client);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client DeleteClientFromDatabase(Client client) {
        return this.clientDAO.Delete(client);
    }

    #endregion

}

