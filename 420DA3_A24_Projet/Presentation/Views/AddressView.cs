using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;

/* Auteur de la classe AddressView.cs : Pierre-Sylvestre Cypré */

internal partial class AddressView : Form {
    private bool isInitalized = false;
    private WsysApplication app;

    public ViewActionsEnum CurrentAction { get; private set; }

    public Address CurrentEntityInstance { get; private set; }

    public AddressView(WsysApplication application) {
        this.app = application;
        InitializeComponent();
    }

    public DialogResult OpenForCreation(Address instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'une addresse", "Créer");
        return DialogResult.OK;
    }

    private void PreOpenSetup(Address instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        //@TODO
    }

    private void Initialize() { 
        //@ TODO
    }




}
