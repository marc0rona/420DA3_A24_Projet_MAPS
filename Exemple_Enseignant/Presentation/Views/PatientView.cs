using _420DA3_A24_Exemple_Enseignant.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Exemple_Enseignant.Presentation.Views;
internal partial class PatientView : Form {
    private readonly ExempleApplication application;

    public PatientView(ExempleApplication app) {
        this.application = app;
        this.InitializeComponent();
    }
}
