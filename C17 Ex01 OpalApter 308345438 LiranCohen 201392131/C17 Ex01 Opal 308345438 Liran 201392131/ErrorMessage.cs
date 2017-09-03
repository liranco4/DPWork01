using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class ErrorMessage : MessageNotification
    {
        public ErrorMessage(string i_Message): base(i_Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        {  }
        
        public override void ShowMessageNotificationOnForm()
        {
            MessageBox.Show(m_Message, "ERROR", m_Buttons, m_Icon);
        }
    }
}
