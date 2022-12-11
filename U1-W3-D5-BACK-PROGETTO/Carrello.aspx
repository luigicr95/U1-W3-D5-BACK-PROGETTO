<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U1_W3_D5_BACK_PROGETTO.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Carrello.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Repeater ID="Repeater1" runat="server" ItemType="U1_W3_D5_BACK_PROGETTO.Prodotti">
        <ItemTemplate>
            <div class="card mb-3" style="max-width: 540px;">
                <div class="row no-gutters">
                    <div class="col-md-4 my-2">
                        <img src="<%#Item.ImmagineProdotto %>" class="card-img" alt="...">
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title"><%#Item.NomeProdotto %></h5>
                            <p class="card-text"><small class="text-muted"><%#Item.PrezzoProdotto.ToString("c2") %></small></p>
                        </div>
                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>
    <h3 style="text-align:center"><asp:Label ID="LabelTotale" runat="server" Text=""></asp:Label></h3>
    <asp:Button ID="SvuotaCarrello" CssClass="btn btn-warning" runat="server" Text="Svuota Carrello" OnClick="SvuotaCarrello_Click" />
</asp:Content>
