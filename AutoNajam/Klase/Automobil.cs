using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNajam.Klase
{
    public class cAutomobil
    {
        public static DataTable GetAutomobili()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT IdAutomobil, Naziv, CijenaPoSatu FROM Automobil WHERE Izbrisano = 0"))
            {
                return SqlDb.FillTable(cmd);
            }
        }

        public static void DodajAutomobil(string Naziv, decimal CijenaPoSatu)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Automobil(Naziv, CijenaPoSatu) VALUES (@Naziv, @CijenaPoSatu)"))
            {
                cmd.Parameters.AddWithValue("@Naziv", Naziv);
                cmd.Parameters.AddWithValue("@CijenaPoSatu", CijenaPoSatu);
                SqlDb.Execute(cmd);
            }
        }

        public static bool AutomobilPostoji(string Naziv)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Automobil WHERE Naziv = @Naziv"))
            {
                cmd.Parameters.AddWithValue("@Naziv", Naziv);
                return Convert.ToInt32(SqlDb.Scalar(cmd)) > 0;
            }
        }

        public static decimal GetCijena(int IdAutomobil, DateTime DatumOd, DateTime DatumDo)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT ceiling(cast(datediff(minute, @DatumOd, @DatumDo) as decimal(10, 2)) / 60.00) * CijenaPoSatu FROM Automobil WHERE IdAutomobil = @IdAutomobil"))
            {
                cmd.Parameters.AddWithValue("@IdAutomobil", IdAutomobil);
                cmd.Parameters.AddWithValue("@DatumOd", DatumOd);
                cmd.Parameters.AddWithValue("@DatumDo", DatumDo);

                return Convert.ToDecimal(SqlDb.Scalar(cmd));
            }
        }

        public static DataTable GetZaPovrat()
        {
            string sql = @"
                select
                    IdNajam,
	                o.Ime + ' ' + o.Prezime + ' -- ' + a.Naziv as Najam
                from
                    Najam n
                    inner join Automobil a on a.IdAutomobil = n.IdAutomobil
                    inner join Osoba o on o.IdOsoba = n.IdOsoba
                where
	                n.IsAutomobilVracen = 0
                and
                    n.Izbrisano = 0
            ";

            using (SqlCommand cmd = new SqlCommand(sql))
            {
                return SqlDb.FillTable(cmd);
            }
        }

        public static DataTable GetZaIzbrisati()
        {
            string sql = @"
                select
                    IdNajam,
	                o.Ime + ' ' + o.Prezime + ' -- ' + a.Naziv as Najam
                from
                    Najam n
                    inner join Automobil a on a.IdAutomobil = n.IdAutomobil
                    inner join Osoba o on o.IdOsoba = n.IdOsoba
                where
                    n.Izbrisano = 0
            ";

            using (SqlCommand cmd = new SqlCommand(sql))
            {
                return SqlDb.FillTable(cmd);
            }
        }

        public static DataTable GetAutomobilZaIzbrisati()
        {
            string sql = @"
                select
                    Idautomobil,
	                Naziv
                from
                    Automobil
                where
                    Izbrisano = 0
            ";

            using (SqlCommand cmd = new SqlCommand(sql))
            {
                return SqlDb.FillTable(cmd);
            }
        }

        public static void IzbrisiAutomobil(int IdAutomobil)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Automobil SET Izbrisano = 1 WHERE IdAutomobil = @IdAutomobil"))
            {
                cmd.Parameters.AddWithValue("@IdAutomobil", IdAutomobil);
                SqlDb.Execute(cmd);
            }
        }
    }
}
