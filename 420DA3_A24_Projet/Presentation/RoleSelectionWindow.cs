using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation;
internal partial class RoleSelectionWindow : Form {

    private WsysApplication parentApp;
    public Role? SelectedRole { get; private set; }

    public RoleSelectionWindow(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    public DialogResult OpenForUser(User user) {
        this.SelectedRole = null;
        this.roleSelectionListBox.Items.Clear();
        this.roleSelectionListBox.ClearSelected();
        this.roleSelectionListBox.SelectedItem = null;
        this.roleSelectionListBox.SelectedIndex = -1;
        // this.roleSelectButton.Enabled = false;
        foreach (Role role in user.Roles) {
            _ = this.roleSelectionListBox.Items.Add(role);
        }
        this.roleSelectionListBox.Refresh();
        return this.ShowDialog();
    }

    private void RoleSelectButton_Click(object sender, EventArgs e) {
        if (this.roleSelectionListBox.SelectedItem as Role is Role) {
            this.SelectedRole = (Role) this.roleSelectionListBox.SelectedItem;
            this.DialogResult = DialogResult.OK;
        } else {
            _ = MessageBox.Show("Veuillez sélectionner un rôle.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void RoleSelectionListBox_SelectedIndexChanged(object sender, EventArgs e) {
        this.roleSelectButton.Enabled = this.roleSelectionListBox.SelectedIndex >= 0;
    }
}
