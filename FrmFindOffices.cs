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
    public partial class FrmFindOffices : Form
    {
        private readonly IOffice _repository;
        public FrmFindOffices()
        {
            _repository = new RepositoryOffice();
            InitializeComponent();
        }

        private void FrmOffices_Load(object sender, EventArgs e)
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
        private List<OfficeVM> GetOffices(string officeName)
        {
            LblMenssage.Visible = false;
            LblMenssage.Text = "";

            var officesVM = new List<OfficeVM>();

            try
            {
              var  officesEntity = _repository.GetOffices(officeName);
                              
                foreach (var office in officesEntity)
                {
                    officesVM.Add(
                        new OfficeVM { 
                          OfficeId = office.OfficeId
                        , Address = office.Address
                        , OfficeName= office.OfficeName
                        });
                }


                return officesVM;
            }
            catch (Exception)
            {
                LblMenssage.Visible = true;
                LblMenssage.Text = "* Ocurrió un error, comuniquese con el administrador";
            }

            return officesVM;

        }


        #endregion

        private void DgOffices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SessionHelper.OfficeId = Convert.ToInt32(DgOffices[0, e.RowIndex].Value.ToString());
            SessionHelper.OfficeName = (string?)DgOffices[1, e.RowIndex].Value;

            this.Hide();
        }
    }
}
