﻿using BUNKER.GameData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BUNKER.Pages
{
    public partial class Game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var s_name = Session["Username"].ToString();
            //add custom constructor and pass variables through it
            Player player = new Player();
            //GlobalVar.SetPlayers(player);
            //SortedDictionary<int, Player> pl = GlobalVar.GetPlayers();
            //player.name.set = Session["Name"].ToString();


        }

        
    }
}