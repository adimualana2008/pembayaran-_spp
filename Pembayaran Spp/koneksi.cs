using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pembayaran_Spp
{
    class koneksi
    {
        public static MySqlConnection con = new MySqlConnection("Server=127.0.0.1;UID=root;PWD=;Database=pembayaran_spp_adi");
    }
}
