using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {
        private int _Idventa;

        public int Idventa 
            {
                get { return _Idventa; }
                set { _Idventa = value; } 
            }

        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
           //this.spreporte_facturaTableAdapter.Fill(this.dsPrincipal.spreporte_factura,Idventa);

            this.crystalReportViewer1.RefreshReport();

        }
    }
}
