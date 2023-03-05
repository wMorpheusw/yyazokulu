<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="yyazokulu.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form id="form1" runat="server">
        <table style="width: 100%; border: 1px solid #c0c0c0">
            <tr>
                <td style="width: 605px; height: 412px;">
                    
                    <div style="width: 600px">

                        <strong>
                            <asp:Label for="txtid" runat="server" Text="Öğrenci ID :" Width="200px" Style="font-size: medium"></asp:Label>
                        </strong>
                        <asp:TextBox ID="txtid" runat="server" CssClass="form-group" Width="380px"></asp:TextBox>
                    </div>
                    <br />
                    <div style="width: 600px">

                        <strong>
                            <asp:Label for="txtad" runat="server" Text="Öğrenci Adı :" Width="200px" Style="font-size: medium"></asp:Label>
                        </strong>
                        <asp:TextBox ID="txtad" runat="server" CssClass="form-group" Width="380px"></asp:TextBox>
                    </div>
                    <br />
                    <div style="width: 600px">
                        <strong>
                            <asp:Label for="txtsoyad" runat="server" Text="Öğrenci Soyadı :" Width="200px" Style="font-size: medium"></asp:Label>
                        </strong>
                        <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-group" Width="380px"></asp:TextBox>
                    </div>
                    <br />
                    <div style="width: 600px">
                        <strong>
                            <asp:Label for="txtnumara" runat="server" Text="Öğrenci Numarası :" Width="200px" Style="font-size: medium"></asp:Label>
                        </strong>
                        <asp:TextBox ID="txtnumara" runat="server" CssClass="form-group" Width="380px"></asp:TextBox>
                    </div>
                    <br />
                    <div style="width: 600px">
                        <strong>
                            <asp:Label for="txtsifre" runat="server" Text="Öğrenci Şifresi :" Width="200px" Style="font-size: medium"></asp:Label>
                        </strong>
                        <asp:TextBox ID="txtsifre" runat="server" CssClass="form-group" Width="380px"></asp:TextBox>
                    </div>
                    <br />
                    <div style="width: 600px">
                        <strong>
                            <asp:Label for="txtfoto" runat="server" Text="Öğrenci Fotoğrafı :" Width="200px" Style="font-size: medium"></asp:Label>
                        </strong>
                        <asp:TextBox ID="txtfoto" runat="server" CssClass="form-group" Width="380px"></asp:TextBox>
                    </div>





                    <div style="width: 600px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;   
        <asp:Button ID="Button1" runat="server" Text="GÜNCELLE" Width="250px" Height="35px" CssClass="btn-warning" OnClick="Button1_Click" />
                    </div>
                </td>
                <td class="text-right" style="height: 412px">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/anasayfa fotolar/foto.jpg" Width="500px" Height="550px" />

                </td>
            </tr>
        </table>






    </form>
</asp:Content>
