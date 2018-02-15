<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Ui.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Customer Crude Operations</h1>
        </div>
        <table border="3" style="border: medium groove #99FF66; padding: inherit; margin: inherit; table-layout: auto; border-collapse: inherit; border-spacing: inherit; empty-cells: inherit; caption-side: inherit; background-color: #FFFFFF; background-image: inherit;" >
            <tr>
                <td>
                <table border="2" style="border: medium dotted #00FF00">
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Employee" OnClick="Button1_Click" BackColor="#66FFFF" BorderColor="#99FF33" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Customer" BackColor="Red" BorderColor="#66FF33" OnClick="Button2_Click" />
                    </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" ForeColor="#336600">
                        </asp:GridView>
                    </td>
                </tr>
                </table>
                </td>
                <td>
        <table border="2" style="border: medium dotted #0099FF">
            <tr>
                <td>Cust ID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>CustName</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>EmpID</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="AddCustomer" BackColor="#003399" BorderColor="#66FF33" />
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label" BackColor="#996600" BorderColor="#66FF33"></asp:Label>
                </td>
            </tr>
        </table>
        <table  border="2" style="border: medium dotted #3366FF">
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DeleteCustomer" BackColor="Fuchsia" BorderColor="#99FF33" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="EditCustomer" BackColor="Aqua" BorderColor="#66FF66" />
                </td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
        <h1>Editable GridView</h1>
        <p>
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
                    <asp:BoundField DataField="CustorName" HeaderText="CustorName" SortExpression="CustorName" />
                    <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" SortExpression="EmployeeId" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ui.ServiceReference1.customer" DeleteMethod="DeleteCustomerById" InsertMethod="AddCustomerer" SelectMethod="getcustomer" TypeName="Ui.ServiceReference1.Service1Client" UpdateMethod="EditCustomerById">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#009933" BorderColor="#66FF33" NavigateUrl="~/LogOut.aspx">LogOut</asp:HyperLink>
    </form>
</body>
</html>
