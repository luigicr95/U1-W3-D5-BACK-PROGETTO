using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_BACK_PROGETTO
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = Prodotti.Carrello;
            Repeater1.DataBind();
            int totaleSpesa = 0;
            foreach(Prodotti giochiAcquistati in Prodotti.Carrello)
            {
                totaleSpesa += Convert.ToInt32(giochiAcquistati.PrezzoProdotto);
            }
            LabelTotale.Text= "Totale:" + totaleSpesa.ToString("c2");
        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Prodotti.Carrello.Clear();
            Repeater1.DataSource = Prodotti.Carrello;
            Repeater1.DataBind();
            int totaleSpesa = 0;
            foreach (Prodotti giochiAcquistati in Prodotti.Carrello)
            {
                totaleSpesa += Convert.ToInt32(giochiAcquistati.PrezzoProdotto);
            }
            LabelTotale.Text = "Totale:" + totaleSpesa.ToString("c2");
        }
    }
}