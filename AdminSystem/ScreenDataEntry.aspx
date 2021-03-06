<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScreenDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblScreenID" runat="server" Text="Screen ID" width="116px"></asp:Label>
        <asp:TextBox ID="txtScreenID" runat="server" OnTextChanged="txtScreenID_TextChanged"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" />
        <p>
            <asp:Label ID="lblScreenName" runat="server" Text="Screen Name" width="116px"></asp:Label>
            <asp:TextBox ID="txtScreenName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCapacity" runat="server" Text="Capacity" width="116px"></asp:Label>
            <asp:TextBox ID="txtCapacity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAdsBeforeMovie" runat="server" Text="Ads Before Movie" width="116px" Height="19px"></asp:Label>
            <asp:TextBox ID="txtAdsBeforeMovie" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateBooked" runat="server" Text="Date Booked" width="116px"></asp:Label>
            <asp:TextBox ID="txtDateBooked" runat="server"></asp:TextBox>
        </p>
            <asp:CheckBox ID="chkScreenBeingUsed" runat="server" Text="Screen Being Used" />
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
