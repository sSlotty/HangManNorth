using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hangman.Constants
{
    public static class Variable
    {
        public static string ConnectionString
        {
            get
            {
                string execPath = Path.GetDirectoryName(Application.ExecutablePath);
                string dataSourcePath = Path.Combine(execPath, "db_user.mdb");
                return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dataSourcePath};";
            }
        }
    }
}
