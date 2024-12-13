using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System.DirectoryServices;
using Project_Utilities.Presentation;

namespace _420DA3_A24_Projet.Presentation;

/// <summary>
/// Main menu window for users with the administrator <see cref="Role"/>.
/// </summary>
internal partial class AdminMainMenu : Form {

    /// <summary>
    /// Valeur générique pour indiquer qu'aucun élément n'est sélectionné dans une liste.
    /// À ajouter à vos listes pour offrir l'option "Aucun" aux utilisateurs.
    /// </summary>
    private static readonly object listNoneSelectedValue = "Aucun";

    private readonly WsysApplication parentApp;

    /// <summary>
    /// <see cref="AdminMainMenu"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public AdminMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// Opens a <see cref="AdminMainMenu"/> modal window.
    /// </summary>
    /// <returns></returns>
    public DialogResult ShowAdminMainMenu() {
        return this.ShowDialog();
    }

    private void ButtonLogout_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.None;
    }


    #region GESTION DES UTILISATEURS

    /// <summary>
    /// Empties the <see cref="User"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadUserSearchResults(List<User> searchResults) {
        try {
            this.userSearchResults.SelectedItem = null;
            this.userSearchResults.SelectedIndex = -1;
            this.userSearchResults.Items.Clear();
            _ = this.userSearchResults.Items.Add(listNoneSelectedValue);
            foreach (User user in searchResults) {
                _ = this.userSearchResults.Items.Add(user);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = true;
        this.buttonEditUser.Enabled = true;
        this.buttonViewUser.Enabled = true;
    }

    /// <summary>
    /// Disables the user action buttons.
    /// </summary>
    private void DeactivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = false;
        this.buttonEditUser.Enabled = false;
        this.buttonViewUser.Enabled = false;
    }

    private void ButtonCreateUser_Click(object sender, EventArgs e) {
        try {
            User? userCree = this.parentApp.UserService.OpenManagementWindowForCreation();
            if (userCree != null) {
                _ = this.userSearchResults.Items.Add(userCree);
                this.userSearchResults.SelectedItem = userCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string searchCriterion = this.userSearchTextBox.Text.Trim();
            List<User> results = this.parentApp.UserService.SearchUsers(searchCriterion);
            this.ReloadUserSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        User? selectedUSer = this.userSearchResults.SelectedItem as User;
        if (selectedUSer != null) {
            this.ActivateUserActionButtons();
        } else {
            this.DeactivateUserActionButtons();
        }
    }

    private void ButtonViewUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            User? createdUser = this.parentApp.UserService.OpenManagementWindowForVisualization(selectedUser);
            if (createdUser != null) {
                _ = this.userSearchResults.Items.Add(createdUser);
                this.userSearchResults.SelectedItem = createdUser;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            bool wasUpdated = this.parentApp.UserService.OpenManagementWindowForEdition(selectedUser);
            if (wasUpdated) {
                this.userSearchResults.RefreshDisplay();
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            bool wasDeleted = this.parentApp.UserService.OpenManagementWindowForDeletion(selectedUser);

            if (wasDeleted) {
                this.userSearchResults.SelectedItem = null;
                this.userSearchResults.SelectedIndex = -1;
                this.userSearchResults.Items.Remove(selectedUser);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region GESTION DES ROLES

    /// <summary>
    /// Empties the <see cref="Role"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadRoleSearchResults(List<Role> searchResults) {
        try {
            this.roleSearchResults.SelectedItem = null;
            this.roleSearchResults.SelectedIndex = -1;
            this.roleSearchResults.Items.Clear();
            foreach (Role role in searchResults) {
                _ = this.roleSearchResults.Items.Add(role);
            }
            this.roleSearchResults.Refresh();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateRoleActionButtons() {
        this.buttonDeleteRole.Enabled = true;
        this.buttonEditRole.Enabled = true;
        this.buttonViewRole.Enabled = true;
    }

    /// <summary>
    /// Disables the role action buttons.
    /// </summary>
    private void DeactivateRoleActionButtons() {
        this.buttonDeleteRole.Enabled = false;
        this.buttonEditRole.Enabled = false;
        this.buttonViewRole.Enabled = false;
    }

    private void ButtonCreateRole_Click(object sender, EventArgs e) {
        try {
            Role? createdRole = this.parentApp.RoleService.OpenManagementWindowForCreation();
            if (createdRole != null) {
                _ = this.roleSearchResults.Items.Add(createdRole);
                this.roleSearchResults.SelectedItem = createdRole;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            List<Role> results = this.parentApp.RoleService.SearchRoles(this.roleSearchTextBox.Text.Trim());
            this.ReloadRoleSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole != null) {
            this.ActivateRoleActionButtons();
        } else {
            this.DeactivateRoleActionButtons();
        }
    }

    private void ButtonViewRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                _ = this.parentApp.RoleService.OpenManagementWindowForVisualization(selectedRole);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonEditRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                bool wasUpdated = this.parentApp.RoleService.OpenManagementWindowForEdition(selectedRole);
                if (wasUpdated) {
                    this.roleSearchResults.RefreshDisplay();
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                bool wasDeleted = this.parentApp.RoleService.OpenManagementWindowForDeletion(selectedRole);
                if (wasDeleted) {
                    this.roleSearchResults.SelectedItem = null;
                    this.roleSearchResults.SelectedIndex = -1;
                    this.roleSearchResults.Items.Remove(selectedRole);
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion

    #region GESTION DES CLIENTS

    /// <summary>
    /// Empties the <see cref="Client"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadClientSearchResults(List<Client> searchResults) {
        try {
            this.clientSearchResults.SelectedItem = null;
            this.clientSearchResults.SelectedIndex = -1;
            this.clientSearchResults.Items.Clear();
            _ = this.clientSearchResults.Items.Add(listNoneSelectedValue);
            foreach (Client client in searchResults) {
                _ = this.clientSearchResults.Items.Add(client);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateClientActionButtons() {
        this.buttonDeleteClient.Enabled = true;
        this.buttonEditClient.Enabled = true;
        this.buttonViewClient.Enabled = true;
    }

    /// <summary>
    /// Disables the user action buttons.
    /// </summary>
    private void DeactivateClientActionButtons() {
        this.buttonDeleteClient.Enabled = false;
        this.buttonEditClient.Enabled = false;
        this.buttonViewClient.Enabled = false;
    }

    private void ButtonCreateClient_Click(object sender, EventArgs e) {
        try {
            Client? clientCree = this.parentApp.ClientService.OpenManagementWindowForCreation();
            if (clientCree != null) {
                _ = this.clientSearchResults.Items.Add(clientCree);
                this.clientSearchResults.SelectedItem = clientCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ClientSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string searchCriterion = this.clientSearchTextBox.Text.Trim();
            List<Client> results = this.parentApp.ClientService.SearchClients(searchCriterion);
            this.ReloadClientSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ClientSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Client? selectedClient = this.clientSearchResults.SelectedItem as Client;
        if (selectedClient != null) {
            this.ActivateClientActionButtons();
        } else {
            this.DeactivateClientActionButtons();
        }
    }

    private void ButtonViewClient_Click(object sender, EventArgs e) {
        try {
            Client selectedClient = (Client) this.clientSearchResults.SelectedItem;
            Client? createdClient = this.parentApp.ClientService.OpenManagementWindowForVisualization(selectedClient);
            if (createdClient != null) {
                _ = this.clientSearchResults.Items.Add(createdClient);
                this.clientSearchResults.SelectedItem = createdClient;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditClient_Click(object sender, EventArgs e) {
        try {
            Client selectedClient = (Client) this.clientSearchResults.SelectedItem;
            bool wasUpdated = this.parentApp.ClientService.OpenManagementWindowForEdition(selectedClient);
            if (wasUpdated) {
                this.clientSearchResults.RefreshDisplay();
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteClient_Click(object sender, EventArgs e) {
        try {
            Client selectedClient = (Client)this.clientSearchResults.SelectedItem;
            bool wasDeleted = this.parentApp.ClientService.OpenManagementWindowForDeletion(selectedClient);

            if (wasDeleted) {
                this.clientSearchResults.SelectedItem = null;
                this.clientSearchResults.SelectedIndex = -1;
                this.clientSearchResults.Items.Remove(selectedClient);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion

    #region GESTION DES ENTREPÔTS

    /// <summary>
    /// Empties the <see cref="Warehouse"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadWarehouseSearchResults(List<Warehouse> searchResults) {
        try {
            this.warehouseSearchResults.SelectedItem = null;
            this.warehouseSearchResults.SelectedIndex = -1;
            this.warehouseSearchResults.Items.Clear();
            _ = this.warehouseSearchResults.Items.Add(listNoneSelectedValue);
            foreach (Warehouse warehouse in searchResults) {
                _ = this.warehouseSearchResults.Items.Add(warehouse);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateWarehouseActionButtons() {
        this.buttonDeleteWarehouse.Enabled = true;
        this.buttonEditWarehouse.Enabled = true;
        this.buttonViewWarehouse.Enabled = true;
    }

    /// <summary>
    /// Disables the user action buttons.
    /// </summary>
    private void DeactivateWarehouseActionButtons() {
        this.buttonDeleteWarehouse.Enabled = false;
        this.buttonEditWarehouse.Enabled = false;
        this.buttonViewWarehouse.Enabled = false;
    }

    private void ButtonCreateWarehouse_Click(object sender, EventArgs e) {
        try {
            Warehouse? warehouseCree = this.parentApp.WarehouseService.OpenManagementWindowForCreation();
            if (warehouseCree != null) {
                _ = this.warehouseSearchResults.Items.Add(warehouseCree);
                this.warehouseSearchResults.SelectedItem = warehouseCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void WarehouseSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string searchCriterion = this.warehouseSearchTextBox.Text.Trim();
            List<Warehouse> results = this.parentApp.WarehouseService.SearchWarehouses(searchCriterion);
            this.ReloadWarehouseSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void WarehouseSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Warehouse? selectedWarehouse = this.warehouseSearchResults.SelectedItem as Warehouse;
        if (selectedWarehouse != null) {
            this.ActivateWarehouseActionButtons();
        } else {
            this.DeactivateWarehouseActionButtons();
        }
    }

    private void ButtonViewWarehouse_Click(object sender, EventArgs e) {
        try {
            Warehouse selectedWarehouse = (Warehouse) this.warehouseSearchResults.SelectedItem;
            Warehouse? createdWarehouse = this.parentApp.WarehouseService.OpenManagementWindowForVisualization(selectedWarehouse);
            if (createdWarehouse != null) {
                _ = this.warehouseSearchResults.Items.Add(createdWarehouse);
                this.warehouseSearchResults.SelectedItem = createdWarehouse;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditWarehouse_Click(object sender, EventArgs e) {
        try {
            Warehouse selectedWarehouse = (Warehouse) this.warehouseSearchResults.SelectedItem;
            bool wasUpdated = this.parentApp.WarehouseService.OpenManagementWindowForEdition(selectedWarehouse);
            if (wasUpdated) {
                this.warehouseSearchResults.RefreshDisplay();
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteWarehouse_Click(object sender, EventArgs e) {
        try {
            Warehouse selectedWarehouse = (Warehouse) this.warehouseSearchResults.SelectedItem;
            bool wasDeleted = this.parentApp.WarehouseService.OpenManagementWindowForDeletion(selectedWarehouse);

            if (wasDeleted) {
                this.warehouseSearchResults.SelectedItem = null;
                this.warehouseSearchResults.SelectedIndex = -1;
                this.warehouseSearchResults.Items.Remove(selectedWarehouse);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion

}
