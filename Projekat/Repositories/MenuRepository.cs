using Projekat.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Projekat.Models.Menu;

namespace Projekat.Repositories
{
    internal class MenuRepository
    {
        public static bool AddRecipeToMenu(int recipeID, int menuID, string typemeal)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO ReceptMeni(ReceptID, MeniID, TipObroka)" +
                                        " VALUES (@ReceptID, @MeniID, @TipObroka)";
                    cmd.Parameters.AddWithValue("ReceptID", recipeID);
                    cmd.Parameters.AddWithValue("MeniID", menuID);
                    cmd.Parameters.AddWithValue("TipObroka", typemeal);

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

        public static DataTable GetMenusDataTable()
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlDataReader reader = null;
                DataTable result = new DataTable();
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM Meni";
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

        public static DataTable GetRecipesByMenuID(int menuID)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("SELECT r.Naziv, r.UkupnoVrijeme, r.BrojPorcija, rm.TipObroka FROM ReceptMeni rm JOIN Recepti r ON rm.ReceptID = r.ReceptID WHERE rm.MeniID = @MeniID", connection);
                cmd.Parameters.AddWithValue("@MeniID", menuID);
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

        public static DataTable SearchMenus(string searchText)
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

                    if (string.IsNullOrEmpty(searchText))
                    {
                        cmd.CommandText = "SELECT * FROM Meni";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Meni WHERE Naziv LIKE @SearchText";
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
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


        public static Menu GetMenuByID(int menuID) //ovo nam je neophodno za brisanje i editovanje, da dobijemo meni koji selektujemo, tj. njegov ID
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                Menu result = null;
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Meni WHERE MeniID = @MeniID";
                    cmd.Parameters.AddWithValue("MeniID", menuID);

                    reader = cmd.ExecuteReader();
                    reader.Read();

                    result = new Menu();
                    result.MeniID = reader.GetInt32(0);
                    result.Naziv = reader.GetString(1);
                    result.Opis = reader.GetString(2);
                    result.DatumKreiranja = reader.GetDateTime(3);

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri citanju podataka o meniju! Detalji: " + ex.Message);
                }
                finally
                {
                    if ((reader != null && !reader.IsClosed)) reader.Close();
                    if (connection != null) { connection.Close(); }
                }

                return result;
            }
        }

        public static bool InsertMenu(Menu menu)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO Meni(Naziv, Opis, DatumKreiranja) " +
                                      "VALUES (@Naziv, @Opis, @DatumKreiranja)";

                    cmd.Parameters.AddWithValue("Naziv", menu.Naziv);
                    cmd.Parameters.AddWithValue("Opis", menu.Opis);
                    cmd.Parameters.AddWithValue("DatumKreiranja", menu.DatumKreiranja);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0) //ako se nešto promijenilo, unesemo meni, tj. insert je true
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

        public static bool UpdateMenu(Menu menu)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Meni SET Naziv = @Naziv, Opis = @Opis, " +
                                      "DatumKreiranja = @DatumKreiranja " +
                                      "WHERE MeniID = @MeniID";

                    cmd.Parameters.AddWithValue("Naziv", menu.Naziv);
                    cmd.Parameters.AddWithValue("Opis", menu.Opis);
                    cmd.Parameters.AddWithValue("DatumKreiranja", menu.DatumKreiranja);
                    cmd.Parameters.AddWithValue("MeniID", menu.MeniID);

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

        public static bool DeleteMenu(int menuID)
        {
            using (SqlConnection connection = new SqlConnection("Server=MILICA;Database=ReceptDB;Trusted_Connection=True;"))
            {
                bool result = false;
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Meni WHERE MeniID = @MeniID";
                    cmd.Parameters.AddWithValue("MeniID", menuID);

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
