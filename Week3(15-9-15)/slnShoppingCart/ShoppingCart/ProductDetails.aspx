<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ShoppingCart.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <strong>Product Details</strong><br />
        <br />
        Please choose the product catagory&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownListProductCatagory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListProductCatagory_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        Choose the product type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListProductType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListProductType_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonShowProductDetails" runat="server" Text="Show Details" OnClick="ButtonShowProductDetails_Click" Visible="False" />
    
    </div>
        <p>
            &nbsp;</p>
        <p style="text-align: center">
            <asp:GridView ID="GridViewProductDetails" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnPageIndexChanging="GridViewProductDetails_PageIndexChanging" PageSize="5" Visible="False">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:TemplateField HeaderText="Product ID">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProductID") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProductID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="BrandName" HeaderText="Brand Name" />
                    <asp:TemplateField HeaderText="Product Details">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ProductDetails") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("ProductDetails") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Product Price">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("ProductPrice") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("ProductPrice") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ProductStock" HeaderText="Stock" />
                    <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBoxSelectProduct" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBoxSelectProduct_CheckedChanged" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="No of Items">
                        <ItemTemplate>
                            <asp:DropDownList ID="DropDownListNoOfItems" runat="server">
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </p>
        <p style="text-align: center">
            <asp:Button ID="ButtonAddToCart" runat="server" Text="Add To Cart" OnClick="ButtonAddToCart_Click" />
        </p>
        <p style="text-align: center">
            <asp:GridView ID="GridView1" runat="server" Width="586px">
            </asp:GridView>
        </p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
    </form>
</body>
</html>
