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

        public static DataTable SearchRecipes(string searchText, int timeFrom, int timeTo, int numPortions)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = new DataTable();
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (timeFrom == -1 && timeTo == -1 && numPortions == -1 && string.IsNullOrEmpty(searchText))
                    {
                        cmd.CommandText = "SELECT * FROM Recepti";
                    }
                    else
                    {
                        string cmdText = "SELECT * FROM Recepti WHERE ";
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            cmdText = cmdText + "(Naziv LIKE @SearchText) AND ";
                            cmd.Parameters.AddWithValue("SearchText", "%" + searchText + "%");
                        }

                        if (timeFrom != -1)
                        {
                            cmdText = cmdText + "UkupnoVrijeme > @TimeFrom AND ";
                            cmd.Parameters.AddWithValue("TimeFrom", timeFrom);
                        }

                        if (timeTo != -1)
                        {
                            cmdText = cmdText + "UkupnoVrijeme < @TimeTo AND ";
                            cmd.Parameters.AddWithValue("TimeTo", timeTo);
                        }

                        if (numPortions != -1)
                        {
                            cmdText = cmdText + "BrojPorcija = @NumPortions AND ";
                            cmd.Parameters.AddWithValue("NumPortions", numPortions);
                        }

                        cmdText = cmdText.Substring(0, cmdText.Length - 4); // uklanja poslednji " AND"
                        cmd.CommandText = cmdText;
                    }

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
                    if ((reader != null && !reader.IsClosed)) reader.Close();
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
                    MessageBox.Show("Greška pri čitanju podataka o receptu! Detalji: " + ex.Message);
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

                    //prvo obrišemo povezane redove iz tabele ReceptMeni
                    cmd.CommandText = "DELETE FROM ReceptMeni WHERE ReceptID = @ReceptID";
                    cmd.Parameters.AddWithValue("@ReceptID", recipeID);
                    cmd.ExecuteNonQuery();

                    //zatim obrišemo red iz tabele Recepti
                    cmd.CommandText = "DELETE FROM Recepti WHERE ReceptID = @ReceptID";
                    cmd.Parameters.Clear(); //očistimo parametre prije ponovnog dodavanja
                    cmd.Parameters.AddWithValue("@ReceptID", recipeID);

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

        public static bool AddIngredientToRecipe(int ingredientID, int recipeID, decimal amount, string measurement)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO ReceptSastojci(ReceptID, SastojakID, Kolicina, MjernaJedinica)" +
                                        " VALUES (@ReceptID, @SastojakID, @Kolicina, @MjernaJedinica)";
                    cmd.Parameters.AddWithValue("ReceptID", recipeID);
                    cmd.Parameters.AddWithValue("SastojakID", ingredientID);
                    cmd.Parameters.AddWithValue("Kolicina", amount);
                    cmd.Parameters.AddWithValue("MjernaJedinica", measurement);

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

        //prvo provjerimo da li je sastojak već u receptu, jer ako jeste, ažuriramo ga, a ne da se duplira
        public static bool IngredientExistsInRecipe(int ingredientID, int recipeID)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                string query = "SELECT COUNT(*) FROM ReceptSastojci WHERE SastojakID = @SastojakID AND ReceptID = @ReceptID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SastojakID", ingredientID);
                cmd.Parameters.AddWithValue("@ReceptID", recipeID);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        //vršimo ažuriranje sastojka u receptu, ako već postoji
        public static bool UpdateIngredientInRecipe(int ingredientID, int recipeID, decimal amount, string measurement)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                string query = "UPDATE ReceptSastojci SET Kolicina = @Kolicina, MjernaJedinica = @MjernaJedinica WHERE SastojakID = @SastojakID AND ReceptID = @ReceptID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Kolicina", amount);
                cmd.Parameters.AddWithValue("@MjernaJedinica", measurement);
                cmd.Parameters.AddWithValue("@SastojakID", ingredientID);
                cmd.Parameters.AddWithValue("@ReceptID", recipeID);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
