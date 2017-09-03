using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class MusicServices
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private SingletonFacebookAppService m_FacebookAppService;
        private List<string> m_UsertDetails;
        private List<Page> m_MusicPages;

        public MusicServices()
        {
            m_FacebookAppService = SingletonFacebookAppService.GetInstanceFacebookServices();
            m_UsertDetails = m_FacebookAppService.FetchUserBasicDetails();
        }

        public void ShowMusicPages(ListBox i_ListBoxFetchMusics, BindingSource i_PageBindingSource)
        {
            m_MusicPages = m_FacebookAppService.FetchMusic();

            i_ListBoxFetchMusics.Invoke(new Action(() => i_PageBindingSource.DataSource = m_MusicPages));

            if (m_MusicPages.Count() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no Music Pages", k_Warning).ShowMessageNotificationOnForm();
            }
        }
    }
}
