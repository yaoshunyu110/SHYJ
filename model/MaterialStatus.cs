using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZJSoft.DbHelper.DataAccess;

namespace SHYJ_App.model
{
    [DbTab("MaterialStatus", "MaterialId")]
    public class MaterialStatus
    {
        [DbBind("MaterialId")]
        public string MaterialId { get; set; }

        [DbBind("MaterialName")]
        public string MaterialName { get; set; }
        [DbBind("AllQuantity")]
        public string AllQuantity { get; set; }
        [DbBind("Checkquantity")]
        public string Checkquantity { get; set; }
        [DbBind("FCheckquantity")]
        public string FCheckquantity { get; set; }
        [DbBind("SCheckquantity")]
        public string SCheckquantity { get; set; }
        [DbBind("Inquantity")]
        public string Inquantity { get; set; }
   

    }
}
