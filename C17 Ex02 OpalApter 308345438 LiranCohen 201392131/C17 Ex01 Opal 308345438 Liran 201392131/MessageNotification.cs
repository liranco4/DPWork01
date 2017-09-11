using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public abstract class MessageNotification
    {
        protected string m_Message;
        protected MessageBoxButtons m_Buttons;
        protected MessageBoxIcon m_Icon;

        public MessageNotification(string i_Message, MessageBoxButtons i_Button, MessageBoxIcon i_Icon)
        {
            m_Message = i_Message;
            m_Buttons = i_Button;
            m_Icon = i_Icon;
        }

        public abstract void ShowMessageNotificationOnForm();
    }
}
