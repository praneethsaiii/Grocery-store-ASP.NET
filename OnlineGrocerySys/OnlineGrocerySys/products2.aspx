<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products2.aspx.cs" Inherits="OnlineGrocerySys.products2" %>


   <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    
    <style type="text/css">
        .header {
            color : white;
            font-family :'Trebuchet MS';
            font-size : 30px;
            font-weight : 200;            
        }
        .body {
            text-decoration:none;
        }
        .footer {
            color:white;
            font-family : 'Trebuchet MS';
            font-size : 12px;
        }
        .auto-style2 {
            width: 100%;
            height: 246px;
        }
        .auto-style3 {
            height: 778px;
        }
        </style>
</head>
<body style="height: 785px" >
    <form id="form1" runat="server" class="auto-style3">
    <div>
        <%-- <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>--%>
        <table  style="width:100%; background-color:lightyellow">
            <tr style="height:20%">
                <td style="width:100%">
                    <div style="text-align:left;background-color:darkslateblue" class="auto-style2">
                        <asp:Image ID="Logo" runat="server" Height="242px" ImageAlign="AbsBottom" ImageUrl="~/gs.png" Width="364px" />
                        <asp:Label ID="lblHeader" CssClass="header" runat="server" Text="PMA Grocery Store" Font-Size="XX-Large"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="53px" ImageUrl="~/images.png" Width="64px" OnClick="ImageButton1_Click" />
                        &nbsp;&nbsp;
                       &nbsp; &nbsp; &nbsp;
                    </div>
                </td>
            </tr>
            </table>
        </div>
        <p>
&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="STORE" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Text="select the category"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True">
            <asp:ListItem>products</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="FIND A PRODUCT" />
        
    
        
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="productid" Font-Bold="True"  AutoGenerateColumns="True">
            
            <Columns>
        <asp:TemplateField HeaderText="select">
            <ItemTemplate>
                <asp:CheckBox ID="CheckBox1"  runat="server" />
            </ItemTemplate>
        </asp:TemplateField></Columns>
            
            
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    
        
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ADD TO CART" CommandArgument='Eval("ProductID")' />
        
    
        
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text="ITEMS ADDED TO CART:" Font-Bold="True" Font-Size="Large"></asp:Label>
        
    
        
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   <asp:Label ID="Label4" runat="server" Text="products" Font-Bold="True" Font-Size="Large"></asp:Label>
        
    
        
        </form>
    </body>
    </html>