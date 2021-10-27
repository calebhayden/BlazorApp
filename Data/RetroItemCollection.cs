using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class RetroItemCollection
    {
        public string Header { get; set; }
        public string HelperText { get; set; }
        public List<RetroItem> Items { get; set; }

    }
}
