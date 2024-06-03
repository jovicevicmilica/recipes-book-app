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
    internal class IngredientRepository
    {
        public static DataTable GetIngredientsDataTable()
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = new DataTable();
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Sastojci";
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

        public static Ingredient GetIngredientByID(int ingredientID) //ovo nam je neophodno za brisanje i editovanje, da dobijemo sastojak koji selektujemo, tj. njegov ID
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                Ingredient result = null;
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Sastojci WHERE SastojakID = @SastojakID";
                    cmd.Parameters.AddWithValue("SastojakID", ingredientID);

                    reader = cmd.ExecuteReader();
                    reader.Read();

                    result = new Ingredient();
                    result.SastojakID = reader.GetInt32(0);
                    result.Naziv = reader.GetString(1);

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri citanju podataka o sastojku! Detalji: " + ex.Message);
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool InsertIngredient(Ingredient ingr)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Sastojci(Naziv) " +
                                      "VALUES (@Naziv)";

                    cmd.Parameters.AddWithValue("Naziv", ingr.Naziv);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0) //ako se nešto promijenilo, promijenimo sastojak
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

        public static bool UpdateIngredient(Ingredient ingr)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Sastojci SET Naziv = @Naziv WHERE SastojakID = @SastojakID";

                    cmd.Parameters.AddWithValue("Naziv", ingr.Naziv);
                    cmd.Parameters.AddWithValue("SastojakID", ingr.SastojakID);

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

        public static bool DeleteIngredient(int ingredientID)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Sastojci WHERE SastojakID = @SastojakID";
                    cmd.Parameters.AddWithValue("SastojakID", ingredientID);

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

        public static DataTable SearchIngredients(string searchText)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = null;
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (string.IsNullOrEmpty(searchText)) //ako je search bar prazan
                    {
                        cmd.CommandText = "SELECT * FROM Sastojci";
                    }
                    else
                    {
                        string cmdText = "SELECT * FROM Sastojci WHERE ";
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            cmdText = cmdText + "(Naziv LIKE @SearchText) AND ";
                            cmd.Parameters.AddWithValue("SearchText", "%" + searchText + "%");
                        }


                        cmdText = cmdText.Substring(0, cmdText.Length - 4);
                        cmd.CommandText = cmdText;
                    }

                    reader = cmd.ExecuteReader();
                    result = new DataTable();
                    result.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri konekciji sa bazom! Detalji: " + ex.Message);
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }
    }
}
