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

            string AuthDomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText.Trim();
            string ApiKey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText.Trim();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Ana_Sayfa());
            Application.Run(new Giris_Ekrani(AuthDomain, ApiKey));
            
        }
    }
}
