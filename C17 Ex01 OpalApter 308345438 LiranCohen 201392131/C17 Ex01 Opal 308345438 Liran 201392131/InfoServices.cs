using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class InfoServices
    {
        private const string k_Error = "ERROR";
        private const string k_Warning = "WARNING";
        private SingletonFacebookAppService m_FacebookAppService;
        private List<string> m_UsertDetails;

        public InfoServices() 
        {
            m_FacebookAppService = SingletonFacebookAppService.GetInstanceFacebookServices();
            m_UsertDetails = m_FacebookAppService.FetchUserBasicDetails();
        }

        public void ShowLikedPages(ListBox i_ListBoxFetchLikedPages, BindingSource i_PageBindingSource)
        {
            i_ListBoxFetchLikedPages.Invoke(new Action(() => i_PageBindingSource.DataSource = m_FacebookAppService.FetchLikedPages()));

            if (m_FacebookAppService.FetchLikedPagesCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no liked pages", k_Warning);
            }
        }

        public void ShowEvents(ListBox i_ListBoxFetchEvents, BindingSource i_EventBindingSource)
        {
            i_ListBoxFetchEvents.Invoke(new Action(() => i_EventBindingSource.DataSource = m_FacebookAppService.FetchEvents()));

            if (m_FacebookAppService.FetchEevntsCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no events", k_Warning);
            }
        }

        public void ShowPosts(ListBox i_ListBoxFetchPost, BindingSource i_PostBindingSource)
        {
            i_ListBoxFetchPost.Invoke(new Action(() => i_PostBindingSource.DataSource = m_FacebookAppService.FetchPosts()));

            if (m_FacebookAppService.FetchPostsCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no post", k_Warning);
            }
        }

        public void ShowFriends(ListBox i_ListBoxFetchFriends, BindingSource i_UserBindingSource)
        {
            i_ListBoxFetchFriends.Invoke(new Action(() => i_UserBindingSource.DataSource = m_FacebookAppService.FetchFriend()));

            if (m_FacebookAppService.FetchFriendCount() == 0)
            {
                m_UsertDetails = m_FacebookAppService.FetchUserBasicDetails();
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + "has no friends", k_Warning);
            }
        }

        public string PostStatus(string i_Status)
        {
            return m_FacebookAppService.PostStatus(i_Status);
        }
    }
}
