using _420DA3_A24_Projet.Business;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Projet.Presentation;
internal partial class LoginWindow : Form {

    private WsysApplication parentApp;

    public LoginWindow(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    public DialogResult ShowLoginWindow() {
        this.ClearControls();
        return this.ShowDialog();
    }

    private void ButtonQuit_Click(object sender, EventArgs e) {
        this.ClearControls();
        this.DialogResult = DialogResult.Cancel;
    }

    private void ConnectButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(this.usernameTextBox.Text)) {
            _ = MessageBox.Show("Veuillez entrer un nom d'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _ = this.usernameTextBox.Focus();
            return;
        }
        if (string.IsNullOrEmpty(this.passwordTextBox.Text)) {
            _ = MessageBox.Show("Veuillez entrer un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _ = this.passwordTextBox.Focus();
            return;
        }

        try {
            this.parentApp.LoginService.TryLogin(this.usernameTextBox.Text, this.passwordTextBox.Text);
            this.ClearControls();
            this.DialogResult = DialogResult.OK;

        } catch (UserNotFoundException unfEx) {
            _ = MessageBox.Show("Nom d'utilisateur invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        } catch (InvalidPasswordException ipEx) {
            _ = MessageBox.Show("Mot de passe invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ClearControls() {
        this.usernameTextBox.Text = "";
        this.passwordTextBox.Text = "";
    }
}
