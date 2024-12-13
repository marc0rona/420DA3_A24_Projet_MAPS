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
internal class ClientService {

    private WsysApplication parentApp;
    private ClientDAO clientDAO;
    private ClientView clientWindow;

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public ClientService(WsysApplication parentApp, AppDbContext context) {
        this.parentApp = parentApp;
        this.clientDAO = new ClientDAO(context);
        this.clientWindow = new ClientView(parentApp);
    }


    #region METHODS

    /// <summary>
    /// Opens the <see cref="ClientView">user management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    public Client? OpenManagementWindowForCreation() {
        try {
            Client newClient = (Client) FormatterServices.GetUninitializedObject(typeof(Client));
            DialogResult result = this.clientWindow.OpenForCreation(newClient);
            return result == DialogResult.OK
                ? newClient
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the client management window in client creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="ClientView">user management window</see> in edition mode
    /// for the given <paramref name="client"/>.
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForEdition(Client client) {
        try {
            DialogResult result = this.clientWindow.OpenForModification(client);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the client management window in client edition mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="ClientView">user management window</see> in visualization mode
    /// for the given <paramref name="client"/>.
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client OpenManagementWindowForVisualization(Client client) {
        try {
            _ = this.clientWindow.OpenForDetailsView(client);
            return client;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the client management window in client visualization mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="ClientView">user management window</see> in deletion mode
    /// for the given <paramref name="client"/>.
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForDeletion(Client client) {
        try {
            DialogResult result = this.clientWindow.OpenForDeletion(client);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the client management window in client deletion mode.", ex);
        }
    }

    public List<Client> GetAllClients(bool includeDeleted = false) {
        return this.clientDAO.GetAll(includeDeleted);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
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
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="clientToEdit"></param>
    /// <returns></returns>
    public Client OpenClientManagementWindowForEdition(Client clientToEdit) {
        _ = this.clientWindow.OpenForModification(clientToEdit);
        return clientToEdit;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="clientToView"></param>
    /// <returns></returns>
    public Client OpenClientManagementWindowForVisualization(Client clientToView) {
        _ = this.clientWindow.OpenForDetailsView(clientToView);
        return clientToView;
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="clientToDelete"></param>
    /// <returns></returns>
    public Client OpenClientManagementWindowForDeletion(Client clientToDelete) {
        _ = this.clientWindow.OpenForDeletion(clientToDelete);
        return clientToDelete;
    }


    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Client? GetClientById(int id) {
        return this.clientDAO.GetById(id);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="clientName"></param>
    /// <returns></returns>
    public Client? GetClientByUsername(string clientName) {
        return this.clientDAO.GetByClientName(clientName);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<Client> SearchClients(string criterion) {
        return this.clientDAO.Search(criterion);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client CreateClientInDatabase(Client client) {
        return this.clientDAO.Create(client);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client UpdateClientInDatabase(Client client) {
        return this.clientDAO.Update(client);
    }

    /// <summary>
    /// TODO @SERGIO : documenter
    /// </summary>
    /// <param name="client"></param>
    /// <returns></returns>
    public Client DeleteClientFromDatabase(Client client) {
        return this.clientDAO.Delete(client);
    }

    #endregion

}

