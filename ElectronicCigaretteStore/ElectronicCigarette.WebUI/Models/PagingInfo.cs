using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicCigarette.WebUI.Models
{
    public class PagingInfo
    {
        // number of all items
        public int TotalItems { get; set; }

        //items per page
        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
            }
        }

    }
}