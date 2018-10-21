using Project3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project4
{
    public partial class ClearMortgages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            IIOHelper iOHelper = new FileIOHelper(ServerPathHelper.GetPath("~/app_data/log.txt"));
            iOHelper.ClearAllMortgages();
        }
    }
}