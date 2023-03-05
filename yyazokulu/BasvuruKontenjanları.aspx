<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BasvuruKontenjanları.aspx.cs" Inherits="yyazokulu.BasvuruKontenjanları" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th> BAŞVURU İD</th>
            <th> BAŞVURDUĞU DERS</th>
            <th> ÖĞRENCİ NUMARASI</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("BASVURUID") %></td>
                        <td><%# Eval("DERSAD") %></td>
                        <td><%# Eval("OGRNUMARA") %></td>
                       </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
