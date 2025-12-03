using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin_c__pro
{
    public static class AlertHelp
    {
        public static string Text { get; set; }
        public static string Message  { get; set; }
        public static MessageBoxButtons Button { get; set; }
        public static MessageBoxIcon Icon { get; set; }
        public static void Alert()
        {
            MessageBox.Show(Message,Text, Button,Icon);
        }

    }
}
