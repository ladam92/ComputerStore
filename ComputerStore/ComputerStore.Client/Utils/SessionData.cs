using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerStore.Client.Utils
{
    public class SessionData
    {
        private static string cookieName = "computer_store";
        private static bool isInitialized = false;

        public List<MemoriaTipus> MemList { get; set; }
        public List<ProcesszorFoglalatTipus> ProcList { get; set; }
        public List<UsbTipus> UsbList { get; set; }
        public List<HattertarTipus> HattertarList { get; set; }
        public List<HattertarCsatoloTipus> HattertarCsatoloList { get; set; }
        public List<MonitorMeret> MonitorMeretList { get; set; }
        public List<MonitorFelbontas> MonitorFelbontasList { get; set; }

        public bool ShowCategories { get; set; }

        public SessionData()
        {
            ShowCategories = true;
        }

        public static SessionData Instance
        {
            get
            {
                if (isInitialized)
                {
                    return (SessionData)HttpContext.Current.Session[cookieName];
                }
                else
                {
                    isInitialized = true;
                    HttpContext.Current.Session.Add(cookieName, new SessionData());
                    return (SessionData)HttpContext.Current.Session[cookieName];
                }
            }
        }
    }
}