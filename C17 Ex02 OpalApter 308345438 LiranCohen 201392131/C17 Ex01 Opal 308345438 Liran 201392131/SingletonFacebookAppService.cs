﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public class SingletonFacebookAppService
    {
        private static SingletonFacebookAppService m_InstanceFacebookServices = null;
        public static string AppID = null;
        private bool m_isLogedIn = false;
        private User m_User;
        private string m_AccessToken;

        public int CollectionLimit { get; set; }

        public float FbApiVersion { get; set; }

        private SingletonFacebookAppService()
        {
            CollectionLimit = 100;
            FbApiVersion = 20.5f;
        }

        public static SingletonFacebookAppService GetInstanceFacebookServices()
        {
            if (m_InstanceFacebookServices == null)
            {
                m_InstanceFacebookServices = new SingletonFacebookAppService();
            }

            return m_InstanceFacebookServices;
        }

        public bool LoginToFaceBook(params string[] i_RequestPermissions)
        {
            if (AppID == null)
            {
                throw new ArgumentNullException("AppID not defined");
            }

            bool o_LoginOperationSucceeded = true;
            LoginResult result = FacebookService.Login(AppID, i_RequestPermissions);
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_User = result.LoggedInUser;
                m_AccessToken = result.AccessToken;
            }
            else
            {
                o_LoginOperationSucceeded = false;
            }

            return o_LoginOperationSucceeded;
        }

        public List<string> FetchUserBasicDetails()
        {
            List<string> o_UserDetails;
            if(m_User != null)
            {
                o_UserDetails = new List<string>();
                o_UserDetails.Add(m_User.FirstName);
                o_UserDetails.Add(m_User.LastName);
                o_UserDetails.Add(m_User.MiddleName);
                o_UserDetails.Add(m_User.Birthday);
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
            
            return o_UserDetails;
        }

        public string FetchUserProfilePicture()
        {
            string o_ProfilePicture;

            if(m_User != null)
            {
                o_ProfilePicture = m_User.PictureNormalURL;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }

            return o_ProfilePicture;
        }

        public bool isLoggedIn()
        {
            if(m_User == null)
            {
                m_isLogedIn = false;
            }
            else
            {
                m_isLogedIn = true;
            }

            return m_isLogedIn;
        }

        public string PostStatus(string i_StatusToPost)
        {
            if (i_StatusToPost != string.Empty)
            {
                if (m_User != null)
                {
                    Status o_PostedStatus = m_User.PostStatus(i_StatusToPost);
                    return o_PostedStatus.Id;            
                }
                else
                {
                    throw new InvalidOperationException("User does not declared in the system");
                }
            }
            else
            {
                throw new ArgumentException("Status parameter can not be empty");
            }
        }

        public FacebookObjectCollection<User> FetchFriend()
        {
            if (m_User != null)
            {
                return m_User.Friends;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public int FetchFriendCount()
        {
            if (m_User != null)
            {
                return m_User.Friends.Count;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public string FetchFriendProfilePicture(User i_User)
        {
            string o_ProfilePicture;
            if (m_User != null)
            {
                o_ProfilePicture = i_User.PictureNormalURL;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }

            return o_ProfilePicture;
        }

        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            if (m_User != null)
            {
                return m_User.LikedPages;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public int FetchLikedPagesCount()
        {
            if (m_User != null)
            {
                return m_User.LikedPages.Count;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public string FetchLikedPagePicture(Page i_Page)
        {
            string o_Picture;
            if (m_User != null)
            {
                o_Picture = i_Page.PictureNormalURL;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }

            return o_Picture;
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            if (m_User != null)
            {
                return m_User.Posts;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public int FetchPostsCount()
        {
            if (m_User != null)
            {
                return m_User.Posts.Count;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public void LogOut()
        {
            Action o_LogOut = null;

            FacebookService.Logout(o_LogOut);

            m_User = null;
        }

        public FacebookObjectCollection<Event> FetchEvents()
        {
            if (m_User != null)
            {
                return m_User.Events;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public int FetchEevntsCount()
        {
            if (m_User != null)
            {
                return m_User.Events.Count;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public List<Page> FetchCheckIn()
        {
            if (m_User != null)
            {
                List<Page> o_Places = new List<Page>();

                FacebookObjectCollection<Checkin> checkInList = m_User.Checkins;

                foreach (Checkin checkIn in checkInList)
                {
                    o_Places.Add(checkIn.Place);
                }

                return o_Places;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public int FetchCheckInCount()
        {
            if (m_User != null)
            {
                return m_User.Checkins.Count;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }

        public List<Page> FetchMusic()
        {
            if (m_User != null)
            {
                FacebookObjectCollection<Page> likedPagesList = m_User.LikedPages;
                List<Page> o_MusicPages = new List<Page>();
                foreach (Page likedPage in likedPagesList)
                {
                    if(likedPage.Category == "Musician/Band")
                    {
                        o_MusicPages.Add(likedPage);
                    }
                }

                return o_MusicPages;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
        }         
    }
}
