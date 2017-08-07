using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public class RegisterKey
    {
        public static void SetWebBrowserVersion(int ie_version)
        {
            const string key64bit =
                @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\" +
                @"MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
            const string key32bit =
                @"SOFTWARE\Microsoft\Internet Explorer\MAIN\" +
                @"FeatureControl\FEATURE_BROWSER_EMULATION";
            string app_name = System.AppDomain.CurrentDomain.FriendlyName;

            // You can do both if you like.
            SetRegistryDword(key64bit, app_name, ie_version);
            //SetRegistryDword(key32bit, app_name, ie_version);
        }

        public static void SetRegistryDword(string key_name, string value_name, int value)
        {
            // Open the key.
            Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key_name, true);
            if (key == null)
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(key_name,
                    Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Set the desired value.
            key.SetValue(value_name, value, Microsoft.Win32.RegistryValueKind.DWord);

            key.Close();
        }
    }
}
