using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public class WarningMessage : MessageNotification
    {
        public WarningMessage(string i_Message) : base(i_Message, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        {            
        }

        public override void ShowMessageNotificationOnForm()
        {
            MessageBox.Show(m_Message, "WARNING", m_Buttons, m_Icon);
        }
    }
}
