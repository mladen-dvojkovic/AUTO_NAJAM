using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNajam.Klase
{
    public class cOsoba
    {
        public static bool OsobaPostoji(string Ime, string Prezime)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Osoba WHERE Ime = @Ime AND Prezime = @Prezime"))
            {
                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);

                return Convert.ToInt32(SqlDb.Scalar(cmd)) > 0;
            }
        }

        public static void DodajOsobu(string Ime, string Prezime, string Adresa, string Email, string Napomena)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Osoba (Ime, Prezime, Adresa, Email, Napomena) VALUES (@Ime, @Prezime, @Adresa, @Email, @Napomena)"))
            {
                cmd.Parameters.AddWithValue("@Ime", Ime);
                cmd.Parameters.AddWithValue("@Prezime", Prezime);
                cmd.Parameters.AddWithValue("@Adresa", Adresa);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Napomena", Napomena);

                SqlDb.Execute(cmd);
            }
        }

        public static DataTable GetOsobe()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Osoba ORDER BY Ime ASC, Prezime ASC"))
            {
                return SqlDb.FillTable(cmd);
            }
        }

        public static DataTable GetOsobeForDropdown()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT IdOsoba, Ime + ' ' + Prezime AS ImePrezime FROM Osoba ORDER BY Ime ASC, Prezime ASC"))
            {
                return SqlDb.FillTable(cmd);
            }
        }
    }
}
