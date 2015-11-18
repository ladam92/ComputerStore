using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ComputerStore.DTO.Types
{
    [DataContract]
    [KnownType(typeof(Alaplap))]
    public class PageableList <T>
    {
        [DataMember]
        public List<T> Items { get; set; }
        [DataMember]
        public int CurrentPage { get; set; }
        [DataMember]
        public int MaxPages { get; set; }

        public PageableList(List<T> items, int currentPage, int maxPages)
        {
            Items = items;
            CurrentPage = currentPage;
            MaxPages = maxPages;
        }
    }
}