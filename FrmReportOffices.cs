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
    public partial class FrmReportOffices : Form
    {
        private readonly IOffice _repository;
        public FrmReportOffices()
        {
            _repository = new RepositoryOffice();
            InitializeComponent();
        }

        private void FrmReportOffices_Load(object sender, EventArgs e)
        {
            var offices = GetOffices("");
            DgOffices.DataSource = offices;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LblMenssage.Text = "";
            LblMenssage.Visible = false;

            bool isOK = IsNullOrWhiteSpace(TxtOfficeName.Text.Trim());

            if (!isOK)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ingrese todos los campos.";
                return;
            }

            var offices = GetOffices(TxtOfficeName.Text);
            DgOffices.DataSource = offices;
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtOfficeName.Focus();
            TxtOfficeName.Text = "";
            errorOfficeName.SetError(TxtOfficeName, "");

            var offices = GetOffices("");
            DgOffices.DataSource = offices;
        }


        #region Validación

        private bool IsNullOrWhiteSpace(string officeName)
        {
            if (string.IsNullOrWhiteSpace(officeName))
            {
                TxtOfficeName.Focus();
                errorOfficeName.SetError(TxtOfficeName, "Campo requerido.");
                return false;
            }
            else
            {
                errorOfficeName.SetError(TxtOfficeName, "");
            }

            return true;
        }
        #endregion

        #region Metodos
        private List<Office> GetOffices(string officeName)
        {
            LblMenssage.Visible = false;
            LblMenssage.Text = "";

            var OfficeEntity = new List<Office>();

            try
            {
                OfficeEntity = _repository.GetOffices(officeName);

                return OfficeEntity;
            }
            catch (Exception)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ocurrió un error, comuniquese con el administrador";
            }

            return OfficeEntity;

        }


        #endregion

    }
}
