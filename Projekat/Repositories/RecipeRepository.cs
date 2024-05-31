using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat.Repositories
{
    internal class RecipeRepository
    {
        public static DataTable GetRecipesDataTable()
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = new DataTable();
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Recepti";
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    result.Load(reader);

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri konekciji sa bazom! Detalji: " + ex.Message);
                }
                finally
                {
                    if (reader != null && !reader.IsClosed) reader.Close();
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static DataTable GetIngredientsByRecipeId(int recipeId)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("SELECT s.Naziv, rs.Kolicina, rs.MjernaJedinica FROM ReceptSastojci rs JOIN Sastojci s ON rs.SastojakID = s.SastojakID WHERE rs.ReceptID = @ReceptID", connection);
                cmd.Parameters.AddWithValue("@ReceptID", recipeId);
                DataTable result = new DataTable();
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    result.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri konekciji sa bazom! Detalji: " + ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }
                return result;
            }
        }
    }
}
