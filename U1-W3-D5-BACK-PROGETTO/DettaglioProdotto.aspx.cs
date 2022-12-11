using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_BACK_PROGETTO
{
    public partial class DettaglioProdotto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idQuery = Request.QueryString["idProdotto"];

            foreach(Prodotti item in Prodotti.GetList())
            {
                if(idQuery == item.IdProdotto.ToString())
                {
                    Image1.ImageUrl = item.ImmagineProdotto;
                    LabelTitle.Text = item.NomeProdotto;
                    LabelPrice.Text = item.PrezzoProdotto.ToString("c2");
                    LabelDescription.Text = item.DescrizioneProdotto;
                }
            }
        }
    }
}