using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeowWalletCallback.Models
{
    public class MeowWalletCallbackModel
    {
        public float amount { get; set; }
        public DateTime Create_date { get; set; }
        public string Currency { get; set; }
        public string Event { get; set; }
        public string Ext_customerid { get; set; }
        public string Ext_email { get; set; }
        private string Ext_invoiceid { get; set; }
        public string Method { get; set; }
        public DateTime Modified_date { get; set; }
        public string Operation_id { get; set; }
        public string Operation_status { get; set; }
        public string User { get; set; }
    }
}