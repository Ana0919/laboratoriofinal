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
    public partial class FrmInfoTest : Form
    {
        private readonly IPacient _patientRepository;
        public FrmInfoTest()
        {
            _patientRepository = new RepositoryPacient();
            InitializeComponent();
        }

        private void BtnFindOffice_Click(object sender, EventArgs e)
        {
            FrmFindOffices frmOffices = new();
            frmOffices.ShowDialog();

            LblOfficeName.Text = (string?)SessionHelper.OfficeName;

            LblMenssage.Visible = false;
            LblMenssage.Text = "";
            errorOfficeName.SetError(LblOfficeName, "");

        }


        private List<Gend> GetGenders()
        {
            List<Gend> genders = new()
            {
                new Gend { Id = 0, Name = "-- Seleccione --" },
                new Gend { Id = 1, Name = "Masculino" },
                new Gend { Id = 2, Name = "Femenino" },
                new Gend { Id = 2, Name = "Otro" },
            };

            return genders;
        }
        private void BtnFindUser_Click(object sender, EventArgs e)
        {
            FrmFindPatients frmFindPatients = new();
            frmFindPatients.ShowDialog();

            TxtPatientId.Text = (string?)SessionHelper.PatientId;

            var patientEntity = _patientRepository.GetPatientById(TxtPatientId.Text);
            if (patientEntity != null)
            {
                LblAge.Text = patientEntity.Age;
                LblName.Text = patientEntity.Name;

                var gender = GetGenders().Where(g => g.Id == patientEntity.GenderId).FirstOrDefault();

                lblGender.Text = gender.Name;



            }


            LblMenssage.Visible = false;
            LblMenssage.Text = "";
            errorPatientId.SetError(TxtPatientId, "");

            //LblMenssage.Visible = false;
            //LblMenssage.Text = "";
            //errorPatientId.SetError(TxtPatientId, "");

            //if (String.IsNullOrEmpty(TxtPatientId.Text))
            //{
            //    LblMenssage.Visible = true;
            //    LblMenssage.Text = "* Seleccione el usuario.";
            //    TxtPatientId.Text = "";

            //    errorPatientId.SetError(TxtPatientId, "Campo requerido.");
            //    TxtPatientId.Focus();
            //    return;
            //}



            //try
            //{
            //    var patientEntity = _patientRepository.GetPatientById(TxtPatientId.Text.Trim());

            //    if (patientEntity == null)
            //    {
            //        LblMenssage.Visible = true;
            //        LblMenssage.Text = "* Paciente no encontrado.";
            //        TxtPatientId.Text = "";
            //        TxtPatientId.Focus();

            //        return;
            //    }

            //    LblName.Text = patientEntity.Name;
            //    LblAge.Text = patientEntity.Age;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isOk = FielsValid(LblOfficeName.Text, TxtPatientId.Text);


        }

        private bool FielsValid(string OfficeName, string PatientId)
        {
            if (string.IsNullOrWhiteSpace(OfficeName))
            {

                errorOfficeName.SetError(LblOfficeName, "Campo requerido.");
                return false;
            }
            else
            {
                errorOfficeName.SetError(LblOfficeName, "");
            }

            if (string.IsNullOrWhiteSpace(PatientId))
            {
                TxtPatientId.Focus();
                errorPatientId.SetError(TxtPatientId, "Campo requerido.");
                return false;
            }
            else
            {
                errorPatientId.SetError(TxtPatientId, "");
            }

            return true;
        }


        #region Validaciones



        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
