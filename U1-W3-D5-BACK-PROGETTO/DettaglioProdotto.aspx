﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DettaglioProdotto.aspx.cs" Inherits="U1_W3_D5_BACK_PROGETTO.DettaglioProdotto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="DettagliProdotto.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
          <asp:Image CssClass="col col-md-6" ID="Image1" runat="server" />
        <div class="col col-md-6 pt-5">
            <h1><asp:Label ID="LabelTitle" runat="server" Text=""></asp:Label></h1>
            <h3>
                <asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label></h3>
            <asp:Label ID="LabelPrice" runat="server" Text=""></asp:Label>
        </div>
      </div>
</asp:Content>
