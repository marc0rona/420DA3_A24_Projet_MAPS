using _420DA3_A24_Exemple_Enseignant.Business;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.Presentation.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views;
internal partial class MedecinView : Form {
    private readonly ExempleApplication application;
    private ViewActionsEnum currentAction;
    private Medecin? currentInstance;

    public MedecinView(ExempleApplication app) {
        this.application = app;
        this.currentAction = ViewActionsEnum.Visualization; // default
        this.InitializeComponent();
        this.copyrightLabel.Text = this.application.GetCopyrightNotice();
    }

    public DialogResult OpenForCreation() {
        this.currentAction = ViewActionsEnum.Creation;
        this.currentInstance = null;
        this.viewModeValueLabel.Text = "Création";
        this.ResetControls();
        this.EnableEditableControls();
        this.actionButton.Text = "CRÉER";
        return this.ShowDialog();
    }

    public DialogResult OpenForVisualization(Medecin medecin) {
        this.currentAction = ViewActionsEnum.Visualization;
        this.currentInstance = medecin;
        this.viewModeValueLabel.Text = "Visualisation";
        this.LoadCurrentInstanceInControls();
        this.DisableEditableControls();
        this.actionButton.Text = "OK";
        return this.ShowDialog();
    }

    public DialogResult OpenForEdition(Medecin medecin) {
        this.currentAction = ViewActionsEnum.Edition;
        this.currentInstance = medecin;
        this.viewModeValueLabel.Text = "Édition";
        this.LoadCurrentInstanceInControls();
        this.EnableEditableControls();
        this.actionButton.Text = "SAUVEGARDER";
        return this.ShowDialog();
    }

    public DialogResult OpenForDeletion(Medecin medecin) {
        this.currentAction = ViewActionsEnum.Deletion;
        this.viewModeValueLabel.Text = "Suppression";
        this.currentInstance = medecin;
        this.LoadCurrentInstanceInControls();
        this.DisableEditableControls();
        this.actionButton.Text = "SUPPRIMER";
        return this.ShowDialog();
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

    private void LoadCurrentInstanceInControls() {
        if (this.currentInstance != null) {
            this.idNumericUpDown.Value = this.currentInstance.Id;
            this.nomTextBox.Text = this.currentInstance.Nom;
            this.prenomTextBox.Text = this.currentInstance.Prenom;
            this.licenseNumericUpDown.Value = this.currentInstance.NumLicenseMedicale;
            this.dateCreatedDTPicker.Value = this.currentInstance.DateCreated;
            this.dateModifiedDTPicker.Value = this.currentInstance.DateModified ?? DateTime.Now;
            this.dateDeletedDTPicker.Value = this.currentInstance.DateDeleted ?? DateTime.Now;
        }
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
        try {
            switch (this.currentAction) {
                case ViewActionsEnum.Creation:
                    this.ProcessCreation();
                    break;
                case ViewActionsEnum.Edition:
                    this.ProcessEdition();
                    break;
                case ViewActionsEnum.Deletion:
                    this.ProcessDeletion();
                    break;
                case ViewActionsEnum.Visualization:
                default:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.application.LogException(ex);
        }
    }

    private void ValidateControlsForCreation() {
        string message = string.Empty;
        if (string.IsNullOrEmpty(this.nomTextBox.Text.Trim())) {
            message += Environment.NewLine + "\t- Le nom ne peut être vide.";
        }
        if (this.nomTextBox.Text.Trim().Length > Medecin.LASTNAME_MAX_LENGTH) {
            message += Environment.NewLine + $"\t- Le nom ne peut dépasser {Medecin.LASTNAME_MAX_LENGTH} caractères.";
        }

        if (string.IsNullOrEmpty(this.prenomTextBox.Text.Trim())) {
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

        if (!string.IsNullOrEmpty(message)) {
            message = "Impossible de créer le nouveau médecin:" + message;
            throw new ValidationException(message);
        }
    }

    private void ValidateControlsForEdition() {
        string message = string.Empty;

        if (this.idNumericUpDown.Value == 0) {
            message += Environment.NewLine + "\t- Le numéro d'ID ne peut être vide.";
        }
        if (this.idNumericUpDown.Value < 0) {
            message += Environment.NewLine + "\t- Le numéro d'ID ne peut être négatif.";
        }

        if (string.IsNullOrEmpty(this.nomTextBox.Text.Trim())) {
            message += Environment.NewLine + "\t- Le nom ne peut être vide.";
        }
        if (this.nomTextBox.Text.Trim().Length > Medecin.LASTNAME_MAX_LENGTH) {
            message += Environment.NewLine + $"\t- Le nom ne peut dépasser {Medecin.LASTNAME_MAX_LENGTH} caractères.";
        }

        if (string.IsNullOrEmpty(this.prenomTextBox.Text.Trim())) {
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

        if (!string.IsNullOrEmpty(message)) {
            message = "Impossible de modifier le médecin:" + message;
            throw new ValidationException(message);
        }
    }

    private void ProcessCreation() {
        try {
            this.ValidateControlsForCreation();
            Medecin createdMedecin = this.application.MedecinService.DoCreateMedecin(
            this.nomTextBox.Text.Trim(),
            this.prenomTextBox.Text.Trim(),
            (int) this.licenseNumericUpDown.Value);


        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Failed to process creation of medecin entity.", ex);
        }
    }

    private void ProcessEdition() {
        try {
            if (this.currentInstance == null) {
                throw new Exception("Pas d'instance de Medecin chargé.");
            }
            this.ValidateControlsForEdition();
            this.currentInstance.Nom = this.nomTextBox.Text.Trim();
            this.currentInstance.Prenom = this.prenomTextBox.Text.Trim();
            this.currentInstance.NumLicenseMedicale = (int) this.licenseNumericUpDown.Value;
            this.application.MedecinService.DoUpdateMedecin(this.currentInstance);


        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Failed to process modification of medecin entity.", ex);
        }
    }

    private void ProcessDeletion() {
        try {
            if (this.currentInstance == null) {
                throw new Exception("Pas d'instance de Medecin chargé.");
            }
            this.application.MedecinService.DoDeleteMedecin(this.currentInstance);

        } catch (Exception ex) {
            _ = MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw new Exception("Failed to process deletion of medecin entity.", ex);
        }
    }

}
