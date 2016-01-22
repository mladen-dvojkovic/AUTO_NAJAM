using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNajam.Klase
{
    public class cNajam
    {
        public static void IznajmiAuto(int IdAutomobil, int IdOsoba, DateTime DatumOd, DateTime DatumDo, decimal Cijena)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Najam (IdAutomobil, IdOsoba, DatumOd, DatumDo, Cijena, IsAutomobilVracen) VALUES (@IdAutomobil, @IdOsoba, @DatumOd, @DatumDo, @Cijena, 0)"))
            {
                cmd.Parameters.AddWithValue("@IdAutomobil", IdAutomobil);
                cmd.Parameters.AddWithValue("@IdOsoba", IdOsoba);
                cmd.Parameters.AddWithValue("@DatumOd", DatumOd);
                cmd.Parameters.AddWithValue("@DatumDo", DatumDo);
                cmd.Parameters.AddWithValue("@Cijena", Cijena);

                SqlDb.Execute(cmd);
            }
        }

        public static bool IsMogucNajam(int IdAutomobil, DateTime DatumOd, DateTime DatumDo)
        {
            string sql = @"
                select
	                count(*)
                from
	                Najam n
                where
	                n.IdAutomobil = @IdAutomobil
	                and isnull(IsAutomobilVracen, 0) = 0
                    and (
		                (@DatumOd > DatumOd and @DatumOd < DatumDo)
		                or (@DatumDo > DatumOd and @DatumDo < DatumDo)
	                )
            ";

            using (SqlCommand cmd = new SqlCommand(sql))
            {
                cmd.Parameters.AddWithValue("@IdAutomobil", IdAutomobil);
                cmd.Parameters.AddWithValue("@DatumOd", DatumOd);
                cmd.Parameters.AddWithValue("@DatumDo", DatumDo);

                return Convert.ToInt32(SqlDb.Scalar(cmd)) == 0;
            }
        }

        public static void VratiAuto(int IdNajam)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Najam SET IsAutomobilVracen = 1 WHERE IdNajam = @IdNajam"))
            {
                cmd.Parameters.AddWithValue("@IdNajam", IdNajam);
                SqlDb.Execute(cmd);
            }
        }

        public static void IzbrisiNajam(int IdNajam)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Najam SET IsAutomobilVracen = 1, Izbrisano = 1 WHERE IdNajam = @IdNajam"))
            {
                cmd.Parameters.AddWithValue("@IdNajam", IdNajam);
                SqlDb.Execute(cmd);
            }
        }

        public static DataTable GetNajam()
        {
            string sql = @"
                select
	                n.IdNajam
	                , o.Ime + ' ' + o.Prezime as Osoba
	                , a.Naziv as Automobil
	                , n.DatumOd as [Najam od]
	                , n.DatumDo as [Najam do]
	                , n.Cijena as [Cijena HRK]
	                , case when isnull(IsAutomobilVracen, 0) = 0 then 'U NAJMU' else 'VRAĆEN' end as [Status najma]
                from
	                Najam n
	                inner join Automobil a on a.IdAutomobil = n.IdAutomobil
	                inner join Osoba o on o.IdOsoba = n.IdOsoba
                where
                    n.Izbrisano = 0
                order by
	                n.IdNajam desc
            ";

            using (SqlCommand cmd = new SqlCommand(sql))
            {
                return SqlDb.FillTable(cmd);
            }
        }

        public static int BrojAutomobilaUNajmu()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Najam WHERE ISNULL(IsAutomobilVracen, 0) = 0"))
            {
                return Convert.ToInt32(SqlDb.Scalar(cmd));
            }
        }
    }
}