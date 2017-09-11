using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Globalization;

namespace C17_Ex02_Opal_308345438_Liran_201392131
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

        public void ShowLikedPages(ListBox i_ListBoxFetchLikedPages, BindingSource i_PageBindingSource, ComboBox i_LikedPagesCb)
        {
            i_ListBoxFetchLikedPages.Invoke(new Action(() => i_PageBindingSource.DataSource = m_FacebookAppService.FetchLikedPages()));

            if (m_FacebookAppService.FetchLikedPagesCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no liked pages", k_Warning).ShowMessageNotificationOnForm();
            }
            else
            {
                i_LikedPagesCb.Invoke(new Action(() => i_LikedPagesCb.Enabled = true));
            }
        }

        public void ShowEvents(ListBox i_ListBoxFetchEvents, BindingSource i_EventBindingSource, ComboBox i_EventsCb)
        {
            i_ListBoxFetchEvents.Invoke(new Action(() => i_EventBindingSource.DataSource = m_FacebookAppService.FetchEvents()));

            if (m_FacebookAppService.FetchEevntsCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no events", k_Warning).ShowMessageNotificationOnForm();
            }
            else
            {
                i_EventsCb.Invoke(new Action(()=>i_EventsCb.Enabled=true));
            }
        }

        public void ShowPosts(ListBox i_ListBoxFetchPost, BindingSource i_PostBindingSource)
        {
            //i_ListBoxFetchPost.Invoke(new Action(() => i_PostBindingSource.DataSource = m_FacebookAppService.FetchPosts()));

            PostsIterator postIterator = new PostsIterator();
            postIterator.Test = post => post.Message!=null;

            i_ListBoxFetchPost.Invoke(new Action(() => i_ListBoxFetchPost.DisplayMember = "Message"));

            foreach (Post post in postIterator)
            {
                i_ListBoxFetchPost.Invoke(new Action(()=>i_ListBoxFetchPost.Items.Add(post)));
            }

            if (m_FacebookAppService.FetchPostsCount() == 0)
            {
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + " has no post", k_Warning).ShowMessageNotificationOnForm();
            }
        }

        public void ShowFriends(ListBox i_ListBoxFetchFriends, BindingSource i_UserBindingSource, ComboBox i_FriendsCb)
        {
            i_ListBoxFetchFriends.Invoke(new Action(() => i_UserBindingSource.DataSource = m_FacebookAppService.FetchFriend()));

            if (m_FacebookAppService.FetchFriendCount() == 0)
            {
                m_UsertDetails = m_FacebookAppService.FetchUserBasicDetails();
                FactoryMessageNotification.CreateMessage(m_UsertDetails[0] + "has no friends", k_Warning).ShowMessageNotificationOnForm();
            }
            else
            {
                i_FriendsCb.Invoke(new Action(() => i_FriendsCb.Enabled = true));
            }
        }

        public string PostStatus(string i_Status)
        {
            return m_FacebookAppService.PostStatus(i_Status);
        }

        public void SortLikedPages(ListBox i_ListBoxFetchLikedPages, BindingSource i_PageBindingSource, string i_CompareBy)
        {
            switch (i_CompareBy)
            {
                case ("Name"):
                    {
                        SorterStrategy<Page> sorter = new SorterStrategy<Page>((page1, page2) => page1.Name.CompareTo(page2.Name) == 1 ? true : false);
                        i_PageBindingSource.DataSource = sorter.Sort(i_ListBoxFetchLikedPages.Items.Cast<Page>().ToList());
                        break;
                    }
                case ("Category"):
                    {
                        SorterStrategy<Page> sorter = new SorterStrategy<Page>((page1, page2) => page1.Category.CompareTo(page2.Category) == 1 ? true : false);
                        i_PageBindingSource.DataSource = sorter.Sort(i_ListBoxFetchLikedPages.Items.Cast<Page>().ToList());
                        break;
                    }
            }
        }

        public void SortFriends(ListBox i_ListBoxFetchFriends, BindingSource i_UserBindingSource, string i_CompareBy)
        {
            switch (i_CompareBy)
            {
                case ("First Name"):
                    {
                        SorterStrategy<User> sorter = new SorterStrategy<User>((friend1, friend2) => friend1.FirstName.CompareTo(friend2.FirstName) == 1 ? true : false);
                        i_UserBindingSource.DataSource = sorter.Sort(i_ListBoxFetchFriends.Items.Cast<User>().ToList());
                        break;
                    }
                case ("Last Name"):
                    {
                        SorterStrategy<User> sorter = new SorterStrategy<User>((friend1, friend2) => friend1.LastName.CompareTo(friend2.LastName)==1?true:false);
                        i_UserBindingSource.DataSource = sorter.Sort(i_ListBoxFetchFriends.Items.Cast<User>().ToList());
                        break;
                    }
            }
        }

        public void SortEvents(ListBox i_ListBoxFetchEvents, BindingSource i_EventBindingSource, string i_CompareBy)
        {
            switch (i_CompareBy)
            {
                case ("Name"):
                    {
                        SorterStrategy<Event> sorter = new SorterStrategy<Event>((event1, event2) => event1.Name.CompareTo(event2.Name) == 1 ? true : false);
                        i_EventBindingSource.DataSource = sorter.Sort(i_ListBoxFetchEvents.Items.Cast<Event>().ToList());
                        break;
                    }
                case ("Start Time"):
                    {
                        DateTime dt = DateTime.ParseExact("24/01/2013", "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        SorterStrategy<Event> sorter = new SorterStrategy<Event>((event1, event2) => event1.StartTime.Value > event2.StartTime.Value);
                        i_EventBindingSource.DataSource = sorter.Sort(i_ListBoxFetchEvents.Items.Cast<Event>().ToList());
                        break;
                    }
                case ("End Time"):
                    {
                        SorterStrategy<Event> sorter = new SorterStrategy<Event>((event1, event2) => event1.EndTime > event2.EndTime);
                        i_EventBindingSource.DataSource = sorter.Sort(i_ListBoxFetchEvents.Items.Cast<Event>().ToList());
                        break;
                    }
            }
        }
    }
}
