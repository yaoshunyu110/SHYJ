using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZJSoft.DbHelper.DataAccess;

namespace SHYJ_App.model
{
    [DbTab("ZBO", "MaterialId")]
    public   class Excel
    {
        [DbBind("MaterialId")]
        public string MaterialID { get; set; }


    }
}
