<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Database.aspx.vb" Inherits="Tijaabo.Database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
        .auto-style3 {
            width: 226px;
        }
        .auto-style4 {
            width: 226px;
            height: 38px;
        }
        .auto-style5 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" style="font-size: medium; font-weight: bold">Cust_Id</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txt_Id" runat="server" Height="23px" Width="131px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-size: medium; font-weight: bold">Cust_Name</td>
                <td>
                    <asp:TextBox ID="txt_Name" runat="server" Height="22px" Width="132px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-size: medium; font-weight: bold">Cust_Gender</td>
                <td>
                    <asp:TextBox ID="txt_Gender" runat="server" Height="18px" Width="131px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-size: medium; font-weight: bold">Cust_Tell</td>
                <td>
                    <asp:TextBox ID="txt_Tell" runat="server" Height="22px" Width="132px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-size: medium; font-weight: bold">Cust_Distruct</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="131px">
                        <asp:ListItem>Huruwai</asp:ListItem>
                        <asp:ListItem>Warta</asp:ListItem>
                        <asp:ListItem>Hodan</asp:ListItem>
                        <asp:ListItem>Waabari</asp:ListItem>
                        <asp:ListItem>Yaqshid</asp:ListItem>
                        <asp:ListItem>Boondheere</asp:ListItem>
                        <asp:ListItem>Shibis</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="Insert" runat="server" BackColor="#339933" BorderColor="White" BorderStyle="Groove" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" Text="Insert" Width="101px" />
                    <asp:Button ID="Update" runat="server" BackColor="#003399" BorderStyle="Groove" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="32px" Text="Update" Width="73px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Delete" runat="server" BackColor="#CC3300" BorderStyle="Groove" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Text="Delete" Width="103px" />
                    <asp:Button ID="Clear" runat="server" BackColor="#FF9933" BorderStyle="Groove" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="28px" Text="Clear" Width="97px" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="639px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </form>
</body>
</html>
