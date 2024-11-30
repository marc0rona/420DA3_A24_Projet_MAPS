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

/* Auteur de la classe ShipmentsView.cs : Pierre-Sylvestre Cypré */

internal partial class ShipmentView : Form {
    private bool isInitalized = false;
    private WsysApplication app;

    public ViewActionsEnum CurrentAction {  get; private set; }

    public Shipment CurrentEntityInstance { get; private set; }


    public ShipmentView(WsysApplication application) {
        this.app = application;
        InitializeComponent();
    }
}
