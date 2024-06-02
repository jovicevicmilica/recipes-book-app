﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat.Enumerations;

namespace Projekat
{
    public static class MenuHelper
    {
        //pomoćna klasa za meni, da ne pišem posebno funkcije u svakoj komponenti, već da ih samo pozivam, jer sastojci i recepti dijele meni
        public static void PreviewIngredients(Form currentForm)
        {
            using (FrmIngredients ingredientsForm = new FrmIngredients())
            {
                ingredientsForm.ShowDialog();
            }
        }

        public static void PreviewRecipes(Form currentForm)
        {
            using (FrmRecipes recipesForm = new FrmRecipes())
            {
                recipesForm.ShowDialog();
            }
        }

        public static void AddRecipe(FrmRecipes currentForm)
        {
            FrmRecipe recipeForm = new FrmRecipe(currentForm, -1); //otvorimo formu za dodavanje novog recepta
            recipeForm.ShowDialog();
        }

        public static void AddIngredient(FrmIngredients currentForm)
        {
            FrmIngredient ingredientForm = new FrmIngredient(currentForm, -1); //otvorimo formu za dodavanje novog recepta
            ingredientForm.ShowDialog();
        }

        public static void AllRcpReportMenuItem_Click()
        {
            FrmReport frmReport = new FrmReport(Enumerations.ReportType.AllRecipes);
            frmReport.ShowDialog();
        }

        public static void AllIngrReportMenuItem_Click()
        {
            FrmReport frmReport = new FrmReport(Enumerations.ReportType.AllIngredients);
            frmReport.ShowDialog();
        }

        public static void ExitApplication()
        {
            Application.Exit();
        }
    }
}
