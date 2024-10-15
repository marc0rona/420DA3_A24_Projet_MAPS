using _420DA3_A24_Exemple_Enseignant.Business;
using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.Presentation.Enums;

namespace _420DA3_A24_Exemple_Enseignant.Presentation;
internal partial class MainMenu : Form {
    private ExempleApplication app;

    public MainMenu(ExempleApplication app) {
        this.app = app;
        this.InitializeComponent();
    }

    #region Gestion des médecins

    private void MedecinSearchBox_TextChanged(object sender, EventArgs e) {
        List<Medecin> results = this.app.MedecinService.SearchMedecin(this.medecinSearchBox.Text);
        this.medecinSearchResultsListBox.Items.Clear();
        this.medecinSearchResultsListBox.SelectedItem = null;
        foreach (Medecin medecin in results) {
            this.medecinSearchResultsListBox.Items.Add(medecin);
        }
    }

    private void MedecinSearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            this.EnableMedecinActionButtons();
        } else {
            this.DisableMedecinActionButtons();
        }
    }

    private void EnableMedecinActionButtons() {
        this.btnMedecinModifier.Enabled = true;
        this.btnMedecinSupprimer.Enabled = true;
        this.btnMedecinViewDetails.Enabled = true;
    }

    private void DisableMedecinActionButtons() {
        this.btnMedecinModifier.Enabled = false;
        this.btnMedecinSupprimer.Enabled = false;
        this.btnMedecinViewDetails.Enabled = false;
    }

    private void BtnCreateMedecin_Click(object sender, EventArgs e) {
        this.app.MedecinService.OpenViewFor(ViewActionsEnum.Creation);
    }

    private void BtnMedecinViewDetails_Click(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            this.app.MedecinService.OpenViewFor(ViewActionsEnum.Visualization, medecin);
        }
    }

    private void BtnMedecinModifier_Click(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            this.app.MedecinService.OpenViewFor(ViewActionsEnum.Edition, medecin);
        }
    }

    private void BtnMedecinSupprimer_Click(object sender, EventArgs e) {
        Medecin? medecin = this.medecinSearchResultsListBox.SelectedItem as Medecin;
        if (medecin is not null) {
            this.app.MedecinService.OpenViewFor(ViewActionsEnum.Deletion, medecin);
        }
    }

    #endregion


}
