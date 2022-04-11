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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationInterface
{
    public partial class FrmPatient : Form
    {
        private readonly IPacient _repository;
        public FrmPatient()
        {
            _repository = new RepositoryPacient();
            InitializeComponent();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            GetListsCbo();

        }

        //Carga las listas de los combo box
        private void GetListsCbo()
        {
            GetTypesId();
            GetGenders();
            GetCivilState();
            GetOccupations();
            GetLevelSchooling();
            GetEps();
            GetRegime();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LblMenssage.Text = "";
            LblMenssage.Visible = false;

            bool isOk = isValidFiels(this.Controls);
            if (!isOk)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ingrese todos los campos";
                return;
            }


            try
            {
                Pacient pacient = new()
                {
                    Name = TxtName.Text,
                    TypeId = (int)CboTypeId.SelectedValue,
                    Id = TxtId.Text,
                    GenderId = (int)CboGender.SelectedValue,
                    DateBorn = DpBorn.Value,
                    Age = TxtAge.Text,
                    CivilStateId = (int)CboCivilState.SelectedValue,
                    Address = TxtAddress.Text,
                    NeiborHood = TxtNeiborHood.Text,
                    PhoneContact = TxtPhoneContact.Text,
                    EpsId = (int)CboEps.SelectedValue,
                    RegimeId = (int)CboRegime.SelectedValue,
                    LevelSchoolingId = (int)CboLevelSchooling.SelectedValue,
                    Email = TxtEmail.Text,
                    EmergencyContact = TxtEmergencyContact.Text,
                    MedicalHistory = TxtMedicalHistory.Text,
                };


                bool isSaved = _repository.AddPacient(pacient);

                if (isSaved)
                {
                    LblMenssage.ForeColor = Color.Green;
                    LblMenssage.Visible = true;
                    LblMenssage.Text = "* Ok!, guardado correcto.";
                }

            }
            catch (Exception)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ocurrió un error, comuniquese con el administrador";
            }
        }

        private bool isValidFiels(Control.ControlCollection ctrlCollection)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text.Trim()))
            {
                errorName.SetError(TxtName, "Campo requerido.");
                return false;
            }
            else
            {
                errorName.SetError(TxtName, "");
            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtId.Text.Trim()))
            {
                errorId.SetError(TxtId, "Campo requerido.");
                return false;
            }
            else
            {
                Regex regex = new("[0-9]");
                if (!regex.IsMatch(TxtId.Text.Trim()))
                {
                    errorId.SetError(TxtId, "Solo se permiten números, sin caracteres especiales (. o ,).");
                    return false;
                }
                else
                {
                    errorId.SetError(TxtId, "");
                }

            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtAge.Text.Trim()))
            {
                errorAge.SetError(TxtAge, "Campo requerido.");
                return false;
            }
            else
            {
                //Expresión regular
                Regex regex = new("[0-9]");
                if (!regex.IsMatch(TxtAge.Text.Trim()))
                {
                    errorAge.SetError(TxtAge, "El valor debe de ser númerico.");
                    return false;
                }
                else
                {
                    int age = int.Parse(TxtAge.Text.Trim());

                    if (age > 120 || age < 0)
                    {
                        errorAge.SetError(TxtAge, "Verifique la edad.");
                        return false;
                    }
                    else
                    {
                        errorAge.SetError(TxtAge, "");
                    }
                }

            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtAddress.Text.Trim()))
            {
                errorAddress.SetError(TxtAddress, "Campo requerido.");
                return false;
            }
            else
            {
                errorAddress.SetError(TxtAddress, "");
            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtNeiborHood.Text.Trim()))
            {
                errorNeiborHood.SetError(TxtNeiborHood, "Campo requerido.");
                return false;
            }
            else
            {
                errorNeiborHood.SetError(TxtNeiborHood, "");
            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtPhoneContact.Text.Trim()))
            {
                errorPhoneContact.SetError(TxtPhoneContact, "Campo requerido.");
                return false;
            }
            else
            {
                errorPhoneContact.SetError(TxtPhoneContact, "");
            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtEmail.Text.Trim()))
            {
                errorEmail.SetError(TxtEmail, "Campo requerido.");
                return false;
            }
            else
            {
                errorEmail.SetError(TxtEmail, "");
            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtEmergencyContact.Text.Trim()))
            {
                errorEmergencyContact.SetError(TxtEmergencyContact, "Campo requerido.");
                return false;
            }
            else
            {
                errorEmergencyContact.SetError(TxtEmergencyContact, "");
            }

            //////////////////////////////////////////////////////

            if (string.IsNullOrWhiteSpace(TxtMedicalHistory.Text.Trim()))
            {
                errorMedicalHistory.SetError(TxtMedicalHistory, "Campo requerido.");
                return false;
            }
            else
            {
                errorMedicalHistory.SetError(TxtMedicalHistory, "");
            }

            //////////////////////////////////////////////////////

            if ((int)CboTypeId.SelectedValue == 0)
            {
                errorTypeId.SetError(CboTypeId, "Campo requerido.");
                return false;
            }
            else
            {
                errorTypeId.SetError(CboTypeId, "");
            }

            //////////////////////////////////////////////////////

            if ((int)CboGender.SelectedValue == 0)
            {
                errorTypeId.SetError(CboTypeId, "Campo requerido.");
                return false;

            }
            else
            {
                errorTypeId.SetError(CboTypeId, "");
            }

            //////////////////////////////////////////////////////

            if ((int)CboCivilState.SelectedValue == 0)
            {
                errorCivilState.SetError(CboCivilState, "Campo requerido.");
                return false;
            }
            else
            {
                errorCivilState.SetError(CboCivilState, "");
            }

            //////////////////////////////////////////////////////

            if ((int)CboEps.SelectedValue == 0)
            {
                errorEps.SetError(CboEps, "Campo requerido.");
                return false;
            }
            else
            {
                errorEps.SetError(CboEps, "");
            }

            //////////////////////////////////////////////////////

            if ((int)CboRegime.SelectedValue == 0)
            {
                errorRegime.SetError(CboRegime, "Campo requerido.");
                return false;
            }
            else
            {
                errorRegime.SetError(CboRegime, "");
            }

            //////////////////////////////////////////////////////
            if ((int)CboLevelSchooling.SelectedValue == 0)
            {
                errorLevelSchooling.SetError(CboLevelSchooling, "Campo requerido.");
                return false;
            }
            else
            {
                errorLevelSchooling.SetError(CboLevelSchooling, "");
            }






            return true;
        }

        private void BtnNewPatient_Click(object sender, EventArgs e)
        {
            //Borra el contenido de todos los text box
            ClearTextBoxes(this.Controls);

            CboTypeId.SelectedValue = 0;
            CboGender.SelectedValue = 0;
            CboCivilState.SelectedValue = 0;
            CboEps.SelectedValue = 0;
            CboLevelSchooling.SelectedValue = 0;
            CboOc.SelectedValue = 0;
            CboRegime.SelectedValue = 0;

            DpBorn.Value = System.DateTime.Now;

            TxtName.Focus();
        }
        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        #region Metodos
        private void GetTypesId()
        {
            List<TypeId> typeIds = new()
            {
                new TypeId { Id = 0, Name = "-- Seleccione --" },
                new TypeId { Id = 1, Name = "Cedula" },
                new TypeId { Id = 2, Name = "Pasaporte" },
                new TypeId { Id = 3, Name = "Extrangería" },
                new TypeId { Id = 4, Name = "Nit" }
            };

            CboTypeId.DataSource = typeIds.OrderBy(t => t.Id).ToList();
            CboTypeId.DisplayMember = "Name";
            CboTypeId.ValueMember = "Id";
        }
        private void GetGenders()
        {
            List<Gend> genders = new()
            {
                new Gend { Id = 0, Name = "-- Seleccione --" },
                new Gend { Id = 1, Name = "Masculino" },
                new Gend { Id = 2, Name = "Femenino" },
                new Gend { Id = 2, Name = "Otro" },
            };

            CboGender.DataSource = genders.OrderBy(t => t.Id).ToList();
            CboGender.DisplayMember = "Name";
            CboGender.ValueMember = "Id";
        }
        private void GetCivilState()
        {
            List<CivilState> civilStates = new()
            {
                new CivilState { Id = 0, Name = "-- Seleccione --" },
                new CivilState { Id = 1, Name = "Soltero" },
                new CivilState { Id = 2, Name = "Casado" },
                new CivilState { Id = 2, Name = "Unión libre" },
                new CivilState { Id = 2, Name = "Viudo" },
            };

            CboCivilState.DataSource = civilStates.OrderBy(t => t.Id).ToList();
            CboCivilState.DisplayMember = "Name";
            CboCivilState.ValueMember = "Id";
        }
        private void GetOccupations()
        {
            List<Occupation> occupations = new()
            {
                new Occupation { Id = 0, Name = "-- Seleccione --" },
                new Occupation { Id = 1, Name = "Ama de casa" },
                new Occupation { Id = 2, Name = "Trabajador independiente" },
                new Occupation { Id = 2, Name = "Asalariado" },
                new Occupation { Id = 2, Name = "Pensionado" },
            };

            CboOc.DataSource = occupations.OrderBy(t => t.Id).ToList();
            CboOc.DisplayMember = "Name";
            CboOc.ValueMember = "Id";
        }
        private void GetLevelSchooling()
        {
            List<LevelSchooling> levelSchoolings = new()
            {
                new LevelSchooling { Id = 0, Name = "-- Seleccione --" },
                new LevelSchooling { Id = 1, Name = "Primaria" },
                new LevelSchooling { Id = 2, Name = "Secundaria" },
                new LevelSchooling { Id = 2, Name = "Superior" },
            };

            CboLevelSchooling.DataSource = levelSchoolings.OrderBy(t => t.Id).ToList();
            CboLevelSchooling.DisplayMember = "Name";
            CboLevelSchooling.ValueMember = "Id";
        }
        private void GetEps()
        {
            List<Eps> eps = new()
            {
                new Eps { Id = 0, Name = "-- Seleccione --" },
                new Eps { Id = 1, Name = "Salud Colmena" },
                new Eps { Id = 2, Name = "Nueva EPS" },
                new Eps { Id = 2, Name = "Salud Total" },
                new Eps { Id = 2, Name = "Cafesalud" },
                new Eps { Id = 2, Name = "Sanitas" },
                new Eps { Id = 2, Name = "Compensar" },
                new Eps { Id = 2, Name = "Sura" },
                new Eps { Id = 2, Name = "Humana Vivir" },
                new Eps { Id = 2, Name = "Servicios Medicos Colpatria" },


            };

            CboEps.DataSource = eps.OrderBy(t => t.Id).ToList();
            CboEps.DisplayMember = "Name";
            CboEps.ValueMember = "Id";
        }
        private void GetRegime()
        {
            List<Regime> regimes = new()
            {
                new Regime { Id = 0, Name = "-- Seleccione --" },
                new Regime { Id = 1, Name = "Contributivo" },
                new Regime { Id = 2, Name = "Subsidiado" },
                new Regime { Id = 2, Name = "Beneficiario" },
            };

            CboRegime.DataSource = regimes.OrderBy(t => t.Id).ToList();
            CboRegime.DisplayMember = "Name";
            CboRegime.ValueMember = "Id";
        }


        #endregion

        private void BtnNewText_Click(object sender, EventArgs e)
        {
            FrmInfoTest frmInfoTest = new FrmInfoTest();
            frmInfoTest.ShowDialog();

            this.Close();
        }
    }
}
