using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public abstract class MessageNotification
    {
        protected string m_Message;

        public MessageNotification(string i_Message)
        {
            m_Message = i_Message;
        }

        /*public static void ShowWarningMessage(string i_Message)
        {
            MessageBox.Show(i_Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowErrorMessage(string i_Message)
        {
            MessageBox.Show(i_Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/


    }
}
