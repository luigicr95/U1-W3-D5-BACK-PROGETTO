<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="U1_W3_D5_BACK_PROGETTO.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:Repeater ID="Repeater1" runat="server" ItemType="U1_W3_D5_BACK_PROGETTO.Prodotti">
        <ItemTemplate>
            <div class="card col-md-4 mx-2 my-2" style="width: 18rem;">
                <img src="<%#Item.ImmagineProdotto %>" class="card-img-top mt-2" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%# Item.NomeProdotto %></h5>
                    <p class="card-text"><%# Item.DescrizioneProdotto %>.</p>
                    <p class="card-text"><%# Item.PrezzoProdotto.ToString("c2") %></p>
                    <a href="DettaglioProdotto.aspx?idprodotto=<%#Item.IdProdotto %>" class="btn btn-primary">Dettagli</a>
                    <asp:Button CssClass="btn btn-success" ID="AggiungiCarrello" runat="server" Text="Aggiungi" OnClick="AggiungiCarrello_Click" CommandArgument=<%#Item.IdProdotto %> />
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>
    <asp:Button ID="CarrelloButton" CssClass="btn btn-warning" runat="server" Text="Vai al Carrello" OnClick="CarrelloButton_Click" />
</asp:Content>