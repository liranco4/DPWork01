using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public class CheckInServices
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private SingletonFacebookAppService m_FacebookAppService;
        private List<string> m_UsertDetails;

        public CheckInServices() 
        {
            m_FacebookAppService = SingletonFacebookAppService.GetInstanceFacebookServices();
            m_UsertDetails = m_FacebookAppService.FetchUserBasicDetails();
        }

        public void ShowCheckIns(ListBox i_ListBoxCheckIn, BindingSource i_CheckinBindingSource)
        {
            i_ListBoxCheckIn.Invoke(new Action(() => i_CheckinBindingSource.DataSource = m_FacebookAppService.FetchCheckIn()));

            if (m_FacebookAppService.FetchCheckInCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no Checkins", k_Warning).ShowMessageNotificationOnForm();
            }
        }
    }
}
