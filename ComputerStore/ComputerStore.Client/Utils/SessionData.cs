﻿using ComputerStore.Client.Models;
using ComputerStore.DTO.Types;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
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
        public List<Kategoria> Kosar { get; set; }
        public int KategoriaID { get; set; }

        public bool ShowCategories { get; set; }

        public int ListingPageSize { get; set; }

        public ApplicationUser CurrentUser
        {
            get
            {
                return System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            }
        }

        public SessionData()
        {
            ShowCategories = true;
            ListingPageSize = 6;
            Kosar = new List<Kategoria>();

            using (var bl = new BusinessLogic.LogicClient())
            {
                this.MemList = bl.MemoriaFoglalat_GetKaegoriak().ToList();
                this.ProcList = bl.ProcFoglalat_GetKategoriak().ToList();
                this.UsbList = bl.UsbTipus_GetKaegoriak().ToList();
                this.HattertarList = bl.HattertatTipus_GetKaegoriak().ToList();
                this.HattertarCsatoloList = bl.HattertatCsatoloTipus_GetKaegoriak().ToList();
                this.MonitorFelbontasList = bl.MonitorFelbontasTipus_GetKaegoriak().ToList();
                this.MonitorMeretList = bl.MonitorMeretTipus_GetKaegoriak().ToList();

            }
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