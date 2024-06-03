using Projekat.Models;
using Projekat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Projekat.Models.Menu;

namespace Projekat
{
    public partial class FrmMenu : Form
    {
        private FrmMenus parentForm; //forma na koju se vraćemo poslije dodavanja/editovanja menija, glavna
        private int selectedMenuID; //izabrani meni, njegov ID

        public FrmMenu(FrmMenus parent, int selectedMenuID) //potreban nam je konstruktor sa dva argumenta kako bi znali koja je glavna forma, i koji je izabrani meni da bi mogli da dodamo/ažuriramo
        {
            InitializeComponent();

            this.parentForm = parent;
            this.selectedMenuID = selectedMenuID;
            this.btnSave.Click += BtnSave_Click;

            InitData();
        }

        private void InitData()
        {
            if (this.selectedMenuID != -1) //ako je izabran meni, to znači da radimo ažuriranje, a ne dodavanje
            {
                this.lblTitle.Text = "Izmijeni meni";
                this.btnSave.Text = "Izmijeni";

                Menu m = MenuRepository.GetMenuByID(this.selectedMenuID);
                if (m != null)
                {
                    this.txtName.Text = m.Naziv;
                    this.txtDesc.Text = m.Opis;
                    this.dtpMakingDate.Value = m.DatumKreiranja;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: VALIDACIJA

            Menu menu = new Menu();
            menu.Naziv = this.txtName.Text;
            menu.Opis = this.txtDesc.Text;
            menu.DatumKreiranja = this.dtpMakingDate.Value;

            bool result = false;
            if (this.selectedMenuID != -1)
            {
                //AŽURIRAMO, inače DODAMO
                menu.MeniID = this.selectedMenuID;
                result = MenuRepository.UpdateMenu(menu);
            }
            else
            {
                //DODAMO
                result = MenuRepository.InsertMenu(menu);
            }

            if (result)
            {
                this.parentForm.InitData();
                MessageBox.Show("Uspjesno sacuvan meni!");
            }
            else
            {
                MessageBox.Show("Greska pri cuvanju menija!");
            }
        }
    }
}
