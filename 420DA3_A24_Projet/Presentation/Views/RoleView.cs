using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// Management window for <see cref="Role"/> entities.
/// </summary>
internal partial class RoleView : Form {

    private readonly WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="Role"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Role CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// <see cref="RoleView"/> constructor.
    /// </summary>
    /// <param name="application"></param>
    public RoleView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
        this.nameValue.MaxLength = Role.NAME_MAX_LENGTH;
        this.descriptionValue.MaxLength = Role.DESCRIPTION_MAX_LENGTH;
    }


    /// <summary>
    /// Opens a <see cref="RoleView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un rôle", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="RoleView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un rôle", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="RoleView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un rôle", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="RoleView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un rôle", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="RoleView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Role instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.actionButton.Text = actionButtonText;
        // display the current action in the top bar
        this.openedModeValue.Text = Enum.GetName(action);
        // load data from the current instance in the controls
        _ = this.LoadDataInControls(instance);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    /// <summary>
    /// Enables the <see cref="RoleView"/> window's controls for creation and edition modes.
    /// </summary>
    private void ActivateControls() {
        this.nameValue.Enabled = true;
        this.descriptionValue.Enabled = true;
    }

    /// <summary>
    /// Disables the <see cref="RoleView"/> window's controls for visualization and deletion modes.
    /// </summary>
    private void DeactivateControls() {
        this.nameValue.Enabled = false;
        this.descriptionValue.Enabled = false;
    }

    /// <summary>
    /// Loads the data of a given <paramref name="role"/> in the <see cref="RoleView"/>
    /// window's controls.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    private Role LoadDataInControls(Role role) {
        this.idValue.Text = role.Id.ToString();
        this.nameValue.Text = role.Name;
        this.descriptionValue.Text = role.Description;
        this.dateCreatedValue.Text = role.DateCreated.ToString();
        return role;
    }

    /// <summary>
    /// Takes data from the basic <see cref="RoleView"/>'s controls and assigns
    /// it to the given <paramref name="role"/>.
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    private Role SaveDataFromControls(Role role) {
        role.Name = this.nameValue.Text.Trim();
        role.Description = this.descriptionValue.Text.Trim();
        return role;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.RoleService.CreateRole(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.RoleService.UpdateRole(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.RoleService.DeleteRole(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Visualization:
                    // nothing to do
                    break;
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) { 
            this.parentApp.HandleException(ex);
        }
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
