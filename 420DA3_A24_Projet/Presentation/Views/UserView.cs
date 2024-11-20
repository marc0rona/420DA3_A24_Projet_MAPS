using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal partial class UserView : Form {

    private WsysApplication app;

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
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAction_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnCancel_Click(object sender, EventArgs e) {

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
}
