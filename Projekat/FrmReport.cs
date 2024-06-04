using Projekat.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmReport : Form
    {
        public FrmReport(ReportType rptType)
        {
            InitializeComponent();

            if (rptType == ReportType.AllRecipes)
            {
                RptAllRecipes rptAllRecipes = new RptAllRecipes();
                this.rptViewer.ReportSource = rptAllRecipes;
            }
            else if (rptType == ReportType.AllIngredients)
            {
                RptAllIngredients rptAllIngredients = new RptAllIngredients();
                this.rptViewer.ReportSource = rptAllIngredients;
            }
            else if (rptType == ReportType.AllMenus)
            {
                RptAllMenus rptAllMenus = new RptAllMenus();
                this.rptViewer.ReportSource = rptAllMenus;
            }
        }
    }
}
