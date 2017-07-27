using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex01_Opal_308345438_Liran_201392131.Model
{
    class FacebookOperation
    {
        private User m_User;
        private String m_AppID;
        public FacebookOperation(String i_AppID, int i_CollectionLimit, float i_FbApiVersion)
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = i_CollectionLimit;
            FacebookWrapper.FacebookService.s_FbApiVersion = i_FbApiVersion;
            m_AppID = i_AppID;
        }

        public User LoginToFaceBook(params string[] i_RequestPermissions)
        {
            User user = null;
            try
            {
                LoginResult result = FacebookService.Login(m_AppID, i_RequestPermissions);
                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    user = result.LoggedInUser;
                }
            }
            catch (Exception exception)
            {
                ///TODO inform with delegate to error message
                ///result.ErrorMessage
                
            }
            return user;
        }
    }
}
