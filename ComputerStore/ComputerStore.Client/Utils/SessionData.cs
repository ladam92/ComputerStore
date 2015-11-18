using ComputerStore.Client.Models;
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

        public List<MemoriaTipus> MemList { get; set; }
        public List<ProcesszorFoglalatTipus> ProcList { get; set; }
        public List<UsbTipus> UsbList { get; set; }
        public List<HattertarTipus> HattertarList { get; set; }
        public List<HattertarCsatoloTipus> HattertarCsatoloList { get; set; }
        public List<MonitorMeret> MonitorMeretList { get; set; }
        public List<MonitorFelbontas> MonitorFelbontasList { get; set; }

        public bool ShowCategories { get; set; }

        public int ListingPageSize { get; set; }

        public ApplicationUser CurrentUser { get; set; }

        public SessionData()
        {
            ShowCategories = true;
            ListingPageSize = 6;
        }

        public static SessionData Instance
        {
            get
            {
                var value = (SessionData)HttpContext.Current.Session[cookieName];

                if (value == null)
                {
                    HttpContext.Current.Session.Add(cookieName, new SessionData());
                    value = (SessionData)HttpContext.Current.Session[cookieName];
                }

                return value;
            }
        }
    }
}