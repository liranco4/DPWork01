using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class FacebookOperation
    {
        private bool m_isLogedIn = false;
        private User m_User;
        private String m_AppID;
        private String m_AccessToken = null;

        public FacebookOperation(String i_AppID, int i_CollectionLimit, float i_FbApiVersion)
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = i_CollectionLimit;
            FacebookWrapper.FacebookService.s_FbApiVersion = i_FbApiVersion;
            m_AppID = i_AppID;
        }

        public Boolean LoginToFaceBook(params string[] i_RequestPermissions)
        {
            Boolean o_LoginOperationSucceeded = true;
            m_isLogedIn = true;

            try
            {
                LoginResult result = FacebookService.Login(m_AppID, i_RequestPermissions);
                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    m_User = result.LoggedInUser;
                    m_AccessToken = result.AccessToken;///TODO need to think about the expired time 60 days, how to handle it
                }
                else
                {
                    o_LoginOperationSucceeded = false;
                    m_isLogedIn = false;
                    ///TODO inform with delegate to error message result.ErrorMessage
                }
            }
            catch (Facebook.FacebookOAuthException exception)
            {
                ///TODO inform with delegate to error message
                o_LoginOperationSucceeded = false;
                m_isLogedIn = false;
            }
            return o_LoginOperationSucceeded;
        }

        public List<string> FetchUserBasicDetails()
        {
            List<String> o_UserDetails;
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

        public FacebookObjectCollection<Album> FetchUserAlbum()
        {
            FacebookObjectCollection<Album> o_UserAlbums = new FacebookObjectCollection<Album>();

            if (m_User != null)
            {
                o_UserAlbums = m_User.Albums;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
            return o_UserAlbums;
        }

        public FacebookObjectCollection<Video> FetchUserVideos()
        {
            FacebookObjectCollection<Video> userVideos = new FacebookObjectCollection<Video>();

            if (m_User != null)
            {
                userVideos = m_User.Videos;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
            return userVideos;
        }

        public bool isLoggedIn()
        {
            return m_isLogedIn;
        }

        public string PostStatus(string i_StatusToPost)
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
            return m_User.Posts;
        }

        public int FetchPostsCount()
        {
            return m_User.Posts.Count;
        }
    }

}
