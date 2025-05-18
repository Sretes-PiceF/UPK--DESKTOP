using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Perpustakaan
{
    internal class Koneksi
    {
        public static string conn = "" +
        "Data Source = DESKTOP-26BJV6N\\SQLEXPRESS; " +
        "Initial Catalog = desktop_pgri; " +
        "Integrated Security = True; " + 
        "TrustServerCertificate = True; ";
    }
    public class Model
    {
        public static string name { get; set; }
    }
}
