<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebStrips._Default" %>

<%@ Register Assembly="DevExpress.XtraCharts.v9.1.Web, Version=9.1.0.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v9.1, Version=9.1.0.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraCharts" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.1, Version=9.1.0.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>A Web Chart Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxe:ASPxButton ID="ASPxButton1" runat="server" OnClick="ASPxButton1_Click" Text="Create a Chart">
        </dxe:ASPxButton>
        <br />
        &nbsp;</div>
    </form>
</body>
</html>
