using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    class AppSettings
    {
        public Point LastWindowLocation { set; get; }
        public Size LastWindowSize { set; get; }
        public bool RememberUser { set; get; }
        public string LastAccessToken { set; get; }
        private const string m_AppSettingsPathFile = @"C:\Temp\AppSettings.xml";
        private AppSettings()
        {
            this.LastWindowLocation = new Point(300, 300);
            this.LastWindowSize = new Size(1000, 800);
            this.RememberUser = false;
            this.LastAccessToken = string.Empty;
        }

        public void SaveAppSettingToFile()
        {
            Stream stream = null;
            using (stream = new FileStream(m_AppSettingsPathFile, FileMode.Truncate, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromAppSettingsFile()
        {
            AppSettings appSettings = null;
            Stream stream = null;
            try
            {
                stream = new FileStream(m_AppSettingsPathFile, FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                appSettings = serializer.Deserialize(stream) as AppSettings;
            }
            catch (Exception exception)
            {
                appSettings = new AppSettings();
                throw exception;
            }
            finally
            {
                stream.Dispose();
            }
            return appSettings;
        }
    }
}
