using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamrin_c__pro
{
    public class AlertHelp
    {
        public string Text { get; set; }
        public string Message  { get; set; }
        public MessageBoxButtons Button { get; set; }
        public MessageBoxIcon Icon { get; set; }
        public void Alert()
        {
            MessageBox.Show(Message,Text, Button,Icon);
        }

    }
}
