using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    class FacebookOperation
    {
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
            Boolean loginOperationSucceeded = true;
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
                    loginOperationSucceeded = false;
                    ///TODO inform with delegate to error message result.ErrorMessage
                }
            }
            catch (Exception exception)
            {
                ///TODO inform with delegate to error message
                loginOperationSucceeded = false;
            }
            return loginOperationSucceeded;
        }

        public List<string> FetchUserBasicDetails()
        {
            List<String> userDetails;
            if(m_User != null)
            {
                userDetails = new List<string>();
                userDetails.Add(m_User.FirstName);
                userDetails.Add(m_User.LastName);
                userDetails.Add(m_User.MiddleName);
                userDetails.Add(m_User.Birthday);
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
            
            return userDetails;
        }

        public Image FetchUserProfilePicture()
        {
            Image profilePicture;
            if(m_User != null)
            {
                profilePicture = m_User.ImageNormal;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
            return profilePicture;
        }

        public FacebookObjectCollection<Album> FetchUserAlbum()
        {
            FacebookObjectCollection<Album> userAlbums = new FacebookObjectCollection<Album>();

            if (m_User != null)
            {
                userAlbums = m_User.Albums;
            }
            else
            {
                throw new InvalidOperationException("User does not declared in the system");
            }
            return userAlbums;
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
    }

}
