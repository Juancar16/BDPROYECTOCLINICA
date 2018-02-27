using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblDoctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCLINICA1DataSet);

        }

        private void tblDoctorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCLINICA1DataSet);

        }

        private void tblDoctorBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCLINICA1DataSet);

        }

        private void tblDoctorBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDoctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDCLINICA1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDCLINICA1DataSet.tblDoctor' Puede moverla o quitarla según sea necesario.
            this.tblDoctorTableAdapter.Fill(this.bDCLINICA1DataSet.tblDoctor);

        }
    }
}
