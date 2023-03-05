<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="yyazokulu.Dersle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>
            <strong>
                <asp:Label ID="Label1" runat="server" Text="Ders Seçin " Style="font-size: x-large"></asp:Label>
            </strong>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <strong>
                <asp:Label ID="Label2" runat="server" Text="Öğrenci ID  " Style="font-size: x-large"></asp:Label>
            </strong>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Ders Talebi Oluştur" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>
