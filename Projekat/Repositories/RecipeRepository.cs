using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat.Models;

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

        public static Recipe GetRecipeByID(int recipeID) //ovo nam je neophodno za brisanje i editovanje, da dobijemo recept koji selektujemo, tj. njegov ID
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                Recipe result = null;
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Recepti WHERE ReceptID = @ReceptID";
                    cmd.Parameters.AddWithValue("ReceptID", recipeID);

                    reader = cmd.ExecuteReader();
                    reader.Read();

                    result = new Recipe();
                    result.ReceptID = reader.GetInt32(0);
                    result.Naziv = reader.GetString(1);
                    result.Opis = reader.GetString(2);
                    result.VrijemePripreme = reader.GetInt32(3);
                    result.VrijemeKuvanja = reader.GetInt32(4);
                    result.UkupnoVrijeme = reader.GetInt32(5);
                    result.BrojPorcija = reader.GetInt32(6);

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri citanju podataka o receptu! Detalji: " + ex.Message);
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool InsertRecipe(Recipe rec)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Recepti(Naziv, Opis, VrijemePripreme, VrijemeKuvanja, UkupnoVrijeme, BrojPorcija) " +
                                      "VALUES (@Naziv, @Opis, @VrijemePripreme, @VrijemeKuvanja, @UkupnoVrijeme, @BrojPorcija)";

                    cmd.Parameters.AddWithValue("Naziv", rec.Naziv);
                    cmd.Parameters.AddWithValue("Opis", rec.Opis);
                    cmd.Parameters.AddWithValue("VrijemePripreme", rec.VrijemePripreme);
                    cmd.Parameters.AddWithValue("VrijemeKuvanja", rec.VrijemeKuvanja);
                    cmd.Parameters.AddWithValue("UkupnoVrijeme", rec.UkupnoVrijeme);
                    cmd.Parameters.AddWithValue("BrojPorcija", rec.BrojPorcija);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0) //ako se nešto promijenilo, promijenimo recept
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool UpdateRecipe(Recipe rec)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Recepti SET Naziv = @Naziv, Opis = @Opis, " +
                                      "VrijemePripreme = @VrijemePripreme, VrijemeKuvanja = @VrijemeKuvanja, UkupnoVrijeme = @UkupnoVrijeme, " +
                                      "BrojPorcija = @BrojPorcija WHERE ReceptID = @ReceptID";

                    cmd.Parameters.AddWithValue("Naziv", rec.Naziv);
                    cmd.Parameters.AddWithValue("Opis", rec.Opis);
                    cmd.Parameters.AddWithValue("VrijemePripreme", rec.VrijemePripreme);
                    cmd.Parameters.AddWithValue("VrijemeKuvanja", rec.VrijemeKuvanja);
                    cmd.Parameters.AddWithValue("UkupnoVrijeme", rec.UkupnoVrijeme);
                    cmd.Parameters.AddWithValue("BrojPorcija", rec.BrojPorcija);
                    cmd.Parameters.AddWithValue("ReceptID", rec.ReceptID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool DeleteRecipe(int recipeID)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Recepti WHERE ReceptID = @ReceptID";
                    cmd.Parameters.AddWithValue("ReceptID", recipeID);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
