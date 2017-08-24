using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    class WebBrowserProxy : System.Windows.Forms.WebBrowser
    {
        private const int k_BrowserVersion = 11001;

        public WebBrowserProxy()
        {
            this.ScriptErrorsSuppressed = true;
            setRegistryDword(k_BrowserVersion);
        }

        private void setRegistryDword(int i_Version)
        {
            const string key64bit =
                @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\" +
                @"MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
            string appName = System.AppDomain.CurrentDomain.FriendlyName;
            Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key64bit, true);
            if (key == null)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(key64bit, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            key.SetValue(appName, i_Version, Microsoft.Win32.RegistryValueKind.DWord);
            key.Close();
        }

    }
}
