using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class RegisterKey
    {
        public static void SetWebBrowserVersion(int i_Version)
        {
            const string key64bit =
                @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\" +
                @"MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";

            string app_name = System.AppDomain.CurrentDomain.FriendlyName;

            SetRegistryDword(key64bit, app_name, i_Version);
        }

        public static void SetRegistryDword(string i_KeyName, string i_ValueName, int i_Value)
        {
            Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(i_KeyName, true);
            if (key == null)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(i_KeyName, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
            }

            key.SetValue(i_ValueName, i_Value, Microsoft.Win32.RegistryValueKind.DWord);

            key.Close();
        }
    }
}
