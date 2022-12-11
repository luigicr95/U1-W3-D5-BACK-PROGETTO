using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_BACK_PROGETTO
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Prodotti> giochiOnDisplay = new List<Prodotti>();
                giochiOnDisplay = Prodotti.GetList();

                Repeater1.DataSource= giochiOnDisplay;
                Repeater1.DataBind();


            }
        }

        protected void AggiungiCarrello_Click(object sender, EventArgs e)
        {
            Button CartButton = (Button)sender;
            int giocoAcquistato = Convert.ToInt32(CartButton.CommandArgument);

            foreach(Prodotti gioco in Prodotti.GetList())
            {
                if(gioco.IdProdotto == giocoAcquistato)
                {
                    Prodotti giocoCarrello = new Prodotti()
                    {
                        IdProdotto = gioco.IdProdotto,
                        NomeProdotto = gioco.NomeProdotto,
                        ImmagineProdotto = gioco.ImmagineProdotto,
                        DescrizioneProdotto = gioco.DescrizioneProdotto,
                        PrezzoProdotto = gioco.PrezzoProdotto
                    };
                    Prodotti.Carrello.Add(giocoCarrello);
                }
            }
        }

        protected void CarrelloButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Carrello.aspx");
        }
    }
    public class Prodotti
        {
            public int IdProdotto { get; set; }
            public string NomeProdotto { get; set; }
            public string ImmagineProdotto { get; set; }

            public string DescrizioneProdotto { get; set; }
            public decimal PrezzoProdotto { get; set; }
            public static List<Prodotti> Carrello = new List<Prodotti>();
            public static List<Prodotti> GetList()
            {
                List<Prodotti> ListaProdotti = new List<Prodotti>();

                Prodotti p1 = new Prodotti { IdProdotto = 1, NomeProdotto = "God of War Ragnarok", PrezzoProdotto = 79.99m, DescrizioneProdotto = "Story driven action-adventure", ImmagineProdotto = "./img/god-of-war-ragnarok-v21-42049-320x450.jpg" };
                Prodotti p2 = new Prodotti { IdProdotto = 2, NomeProdotto = "Persona 5", PrezzoProdotto = 49.99m, DescrizioneProdotto = "Stylish turn-based JRPG", ImmagineProdotto = "./img/persona-5-button-2021-1640029221968.jpg" };
                Prodotti p3 = new Prodotti { IdProdotto = 3, NomeProdotto = "Outer Wilds", PrezzoProdotto = 29.99m, DescrizioneProdotto = "Stunning space adventure with a twist", ImmagineProdotto = "./img/EGS_OuterWildsArchaeologistEdition_MobiusDigital_Editions_S2_1200x1600-cbee3eb8c11e928652161c949c28cab4.jfif" };
                Prodotti p4 = new Prodotti { IdProdotto = 4, NomeProdotto = "The Last of Us Part II", PrezzoProdotto = 30.00m, DescrizioneProdotto = "Gut-wrenching story and awesome graphics", ImmagineProdotto = "./img/TLOU2_featu-1.jpg" };
                Prodotti p5 = new Prodotti { IdProdotto = 5, NomeProdotto = "Hades", PrezzoProdotto = 19.99m, DescrizioneProdotto = "Mythical rouge-lite", ImmagineProdotto = "./img/1200x1600-1200x1600-e92fa6b99bb20c9edee19c361b8853b9.jpg" };
                Prodotti p6 = new Prodotti { IdProdotto = 6, NomeProdotto = "Elden Ring", PrezzoProdotto = 59.99m, DescrizioneProdotto = "Dark Souls gone open world!", ImmagineProdotto = "./img/images.jfif" };

                ListaProdotti.Add(p1);
                ListaProdotti.Add(p2);
                ListaProdotti.Add(p3);
                ListaProdotti.Add(p4);
                ListaProdotti.Add(p5);
                ListaProdotti.Add(p6);

                return ListaProdotti;
            }
        }
}