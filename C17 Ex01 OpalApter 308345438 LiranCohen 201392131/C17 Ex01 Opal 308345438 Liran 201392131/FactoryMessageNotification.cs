using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public static class FactoryMessageNotification
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";

        public static void CreateMessage(string i_Message, string i_Type)
        {
            switch(i_Type)
            {
                case k_Error:
                    {
                        new ErrorMessage(i_Message);                      
                        break;
                    }

                case k_Warning:
                    {
                        new WarningMessage(i_Message);
                        break;
                    }

                default:
                    {
                        throw new ArgumentException("Illegal Message");
                    }
            }
        }
    }
}
