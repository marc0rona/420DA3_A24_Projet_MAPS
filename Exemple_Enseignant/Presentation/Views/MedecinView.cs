using _420DA3_A24_Exemple_Enseignant.Business;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.Presentation.Enums;
using System.CodeDom;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views;
internal partial class MedecinView : Form {
    private readonly ExempleApplication application;
    private ViewActionsEnum currentAction;

    public MedecinView(ExempleApplication app) {
        this.application = app;
        this.currentAction = ViewActionsEnum.Visualization; // default
        this.InitializeComponent();
    }

    public Medecin? OpenForCreation() {
        this.currentAction = ViewActionsEnum.Creation;
        this.viewModeValueLabel.Text = "Création";
        this.ResetControls();
        this.EnableEditableControls();
        this.actionButton.Text = "CRÉER";
        DialogResult result = this.ShowDialog();
        return result == DialogResult.OK
            ? this.application.MedecinService.DoCreateMedecin(
                this.nomTextBox.Text,
                this.prenomTextBox.Text,
                (int) this.licenseNumericUpDown.Value)
            :  null;
    }

    public void OpenForVisualization(Medecin medecin) {
        this.currentAction = ViewActionsEnum.Visualization;
        this.viewModeValueLabel.Text = "Visualisation";
        this.LoadDataInControls(medecin);
        this.EnableEditableControls();
        this.actionButton.Text = "OK";
        _ = this.ShowDialog();
    }

    public void OpenForEdition(Medecin medecin) {
        this.currentAction = ViewActionsEnum.Edition;
        this.viewModeValueLabel.Text = "Édition";
        this.LoadDataInControls(medecin);
        this.EnableEditableControls();
        this.actionButton.Text = "SAUVEGARDER";
        DialogResult result = this.ShowDialog();
        if (result == DialogResult.OK) {
            medecin.Nom = this.nomTextBox.Text.Trim();
            medecin.Prenom = this.prenomTextBox.Text.Trim();
            medecin.NumLicenseMedicale = (int) this.licenseNumericUpDown.Value;
            this.OpenForVisualization(this.application.MedecinService.DoUpdateMedecin(medecin));
        }
    }

    public void OpenForDeletion(Medecin medecin) {
        this.currentAction = ViewActionsEnum.Deletion;
        this.viewModeValueLabel.Text = "Suppression";
        this.LoadDataInControls(medecin);
        this.EnableEditableControls();
        this.actionButton.Text = "SUPPRIMER";
        DialogResult result = this.ShowDialog();
        if (result == DialogResult.OK) {
            this.application.MedecinService.DoDeleteMedecin(medecin);
        }
    }

    private void ResetControls() {
        this.idNumericUpDown.Value = 0;
        this.nomTextBox.Text = "";
        this.prenomTextBox.Text = "";
        this.licenseNumericUpDown.Value = 0;
        this.dateCreatedDTPicker.Value = DateTime.Now;
        this.dateModifiedDTPicker.Value = DateTime.Now;
        this.dateDeletedDTPicker.Value = DateTime.Now;
    }

    private void LoadDataInControls(Medecin medecin) {
        this.idNumericUpDown.Value = medecin.Id;
        this.nomTextBox.Text = medecin.Nom;
        this.prenomTextBox.Text = medecin.Prenom;
        this.licenseNumericUpDown.Value = medecin.NumLicenseMedicale;
        this.dateCreatedDTPicker.Value = medecin.DateCreated;
        this.dateModifiedDTPicker.Value = medecin.DateModified ?? DateTime.Now;
        this.dateDeletedDTPicker.Value = medecin.DateDeleted ?? DateTime.Now;
    }

    private void EnableEditableControls() {
        this.nomTextBox.Enabled = true;
        this.prenomTextBox.Enabled = true;
        this.licenseNumericUpDown.Enabled = true;
    }

    private void DisableEditableControls() {
        this.nomTextBox.Enabled = false;
        this.prenomTextBox.Enabled = false;
        this.licenseNumericUpDown.Enabled = false;
    }


    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        switch (this.currentAction) {
            case ViewActionsEnum.Creation:
                if (this.ValidateControlsForCreation()) {
                    this.DialogResult = DialogResult.OK;
                }
                break;
            case ViewActionsEnum.Edition:
                if (this.ValidateControlsForEdition()) {
                    this.DialogResult = DialogResult.OK;
                }
                break;
            case ViewActionsEnum.Deletion:
            case ViewActionsEnum.Visualization:
            default:
                this.DialogResult = DialogResult.OK;
                break;
        }
    }

    private bool ValidateControlsForCreation() {
        string message = String.Empty;
        if (String.IsNullOrEmpty(this.nomTextBox.Text.Trim())) {
            message += Environment.NewLine + "\t- Le nom ne peut être vide.";
        }
        if (this.nomTextBox.Text.Trim().Length > Medecin.LASTNAME_MAX_LENGTH) {
            message += Environment.NewLine + $"\t- Le nom ne peut dépasser {Medecin.LASTNAME_MAX_LENGTH} caractères.";
        }

        if (String.IsNullOrEmpty(this.prenomTextBox.Text.Trim())) {
            message += Environment.NewLine + "\t- Le prénom ne peut être vide.";
        }
        if (this.prenomTextBox.Text.Trim().Length > Medecin.FIRSTNAME_MAX_LENGTH) {
            message += Environment.NewLine + $"\t- Le prénom ne peut dépasser {Medecin.FIRSTNAME_MAX_LENGTH} caractères.";
        }

        if (this.licenseNumericUpDown.Value == 0) {
            message += Environment.NewLine + "\t- Le numéro de license médicale ne peut être vide.";
        }
        if (this.licenseNumericUpDown.Value < 0) {
            message += Environment.NewLine + "\t- Le numéro de license médicale ne peut être négatif.";
        }

        if (!String.IsNullOrEmpty(message)) {
            message = "Impossible de créer le nouveau médecin:" + message;
            _ = MessageBox.Show(message);
            return false;
        }
        return true;
    }

    private bool ValidateControlsForEdition() {
        string message = String.Empty;

        if (this.idNumericUpDown.Value == 0) {
            message += Environment.NewLine + "\t- Le numéro d'ID ne peut être vide.";
        }
        if (this.idNumericUpDown.Value < 0) {
            message += Environment.NewLine + "\t- Le numéro d'ID ne peut être négatif.";
        }

        if (String.IsNullOrEmpty(this.nomTextBox.Text.Trim())) {
            message += Environment.NewLine + "\t- Le nom ne peut être vide.";
        }
        if (this.nomTextBox.Text.Trim().Length > Medecin.LASTNAME_MAX_LENGTH) {
            message += Environment.NewLine + $"\t- Le nom ne peut dépasser {Medecin.LASTNAME_MAX_LENGTH} caractères.";
        }

        if (String.IsNullOrEmpty(this.prenomTextBox.Text.Trim())) {
            message += Environment.NewLine + "\t- Le prénom ne peut être vide.";
        }
        if (this.prenomTextBox.Text.Trim().Length > Medecin.FIRSTNAME_MAX_LENGTH) {
            message += Environment.NewLine + $"\t- Le prénom ne peut dépasser {Medecin.FIRSTNAME_MAX_LENGTH} caractères.";
        }

        if (this.licenseNumericUpDown.Value == 0) {
            message += Environment.NewLine + "\t- Le numéro de license médicale ne peut être vide.";
        }
        if (this.licenseNumericUpDown.Value < 0) {
            message += Environment.NewLine + "\t- Le numéro de license médicale ne peut être négatif.";
        }

        if (!String.IsNullOrEmpty(message)) {
            message = "Impossible de modifier le médecin:" + message;
            _ = MessageBox.Show(message);
            return false;
        }
        return true;

    }

}
