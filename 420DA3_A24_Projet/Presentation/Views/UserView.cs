using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal partial class UserView : Form {
    private bool isInitialized = false;
    private WsysApplication app;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public User CurrentEntityInstance { get; private set; }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="application"></param>
    public UserView(WsysApplication application) {
        this.app = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un utilisateur", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un utilisateur", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un utilisateur", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(User instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.btnAction.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
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
    /// TODO @PROF : documenter
    /// </summary>
    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadSelectors();
            this.isInitialized = true;
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void ReloadSelectors() {
        this.userRolesValues.Items.Clear();
        foreach (Role role in this.app.RoleService.GetAllRoles()) {
            _ = this.userRolesValues.Items.Add(role);
        }
        this.whEmpWarehouseValue.Items.Clear();
        // TODO @PROF: fix this quand le service entrepot sera créé
        foreach (Entrepot entrepot in this.app.EntrepotService.GetAllEntrepots()) {
            _ = this.whEmpWarehouseValue.Items.Add(entrepot);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    private User LoadDataInControls(User user) {
        this.idValue.Value = user.Id;
        this.usernameValue.Text = user.Username;
        this.passwordHashValue.Text = user.PasswordHash;
        this.whEmpWarehouseValue.SelectedItem = user.EmployeeWarehouse is not null
            ? user.EmployeeWarehouse
            : null;
        this.dateCreatedValue.Value = user.DateCreated;
        this.dateModifiedValue.Value = user.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = user.DateDeleted ?? DateTime.Now;
        this.userRolesValues.SelectedItems.Clear();
        foreach (Role role in user.Roles) {
            this.userRolesValues.SelectedItems.Add(role);
        }
        return user;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    private User GetDataFromControls(User user) {
        user.Username = this.usernameValue.Text;
        // TODO: get clear password, encrypt it, and set as user's passwordHash
        user.EmployeeWarehouse = this.whEmpWarehouseValue.SelectedItem as Entrepot;
        user.Roles = new List<Role>();
        foreach (Role role in this.userRolesValues.SelectedItems) {
            user.Roles.Add(role);
        }
        return user;
    }

    private void ActivateControls() {
        this.usernameValue.Enabled = true;
        this.passwordValue.Enabled = true;
        this.whEmpWarehouseValue.Enabled = true;
        this.userRolesValues.Enabled = true;
    }

    private void DeactivateControls() {
        this.usernameValue.Enabled = false;
        this.passwordValue.Enabled = false;
        this.whEmpWarehouseValue.Enabled = false;
        this.userRolesValues.Enabled = false;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAction_Click(object sender, EventArgs e) {
        // TODO @PROF: implémenter processus des actions selon l'action courante
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
