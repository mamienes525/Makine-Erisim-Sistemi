using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MES
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config1.xml");

            Config.AuthDomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText.Trim();
            Config.ApiKey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText.Trim();
            Config.FBDomain = config.DocumentElement.SelectSingleNode("/FireBase/FBDomain").InnerText.Trim();
            Config.FSDomain = config.DocumentElement.SelectSingleNode("/FireBase/FSDomain").InnerText.Trim();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Ana_Sayfa());
            Application.Run(new Giris_Ekrani(Config.AuthDomain, Config.ApiKey));
            
        }
    }
}
