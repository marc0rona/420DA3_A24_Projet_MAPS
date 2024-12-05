using _420DA3_A24_Projet.Business;
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
internal partial class WarehouseView : Form {
    private bool isInitialized = false;
    private WsysApplication app;
    public WarehouseView(WsysApplication application) {
        this.app = application;
        this.InitializeComponent();
    }
}
