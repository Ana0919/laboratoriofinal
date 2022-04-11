using ApplicationInterface.Tools;
using Contracts;
using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationInterface
{
    public partial class FrmFindPatients : Form
    {

        private readonly IPacient _repository;

        public FrmFindPatients()
        {
            _repository = new RepositoryPacient();
            InitializeComponent();
        }

        private void FrmFindPatient_Load(object sender, EventArgs e)
        {
            var offices = GetPatientes("");
            DgPatients.DataSource = offices;
        }

        private List<PacientVM> GetPatientes(string name)
        {
            LblMenssage.Visible = false;
            LblMenssage.Text = "";

            var pacientsVM = new List<PacientVM>();

            try
            {
                var patientsEntity = _repository.GetPatient(name);

                foreach (var pacient in patientsEntity)
                {
                    pacientsVM.Add(
                        new PacientVM
                        {
                            Id = pacient.Id
                        ,
                            Name = pacient.Name
                        });
                }

                return pacientsVM;
            }
            catch (Exception)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ocurrió un error, comuniquese con el administrador";
            }

            return pacientsVM;

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LblMenssage.Text = "";
            LblMenssage.Visible = false;


            bool isOK = IsNullOrWhiteSpace(TxtName.Text.Trim());

            if (!isOK)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ingrese todos los campos.";
                return;
            }

            var offices = GetPatientes(TxtName.Text);
            DgPatients.DataSource = offices;
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtName.Focus();
            TxtName.Text = "";
            errorName.SetError(TxtName, "");

            var offices = GetPatientes("");
            DgPatients.DataSource = offices;
        }

        #region Validación

        private bool IsNullOrWhiteSpace(string officeName)
        {
            if (string.IsNullOrWhiteSpace(officeName))
            {
                TxtName.Focus();
                errorName.SetError(TxtName, "Campo requerido.");
                return false;
            }
            else
            {
                errorName.SetError(TxtName, "");
            }

            return true;
        }
        #endregion

        private void DgPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SessionHelper.PatientId = DgPatients[1, e.RowIndex].Value.ToString();
            this.Hide();
        }
    }
}