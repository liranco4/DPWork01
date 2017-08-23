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
    }
}
