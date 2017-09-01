using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class WarningMessage : MessageNotification
    {
        public WarningMessage(string i_Message) : base(i_Message)
        {
            MessageBox.Show(i_Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
