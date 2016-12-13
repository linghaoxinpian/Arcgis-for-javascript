<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ArcgisWebUI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="easyui/jquery-1.8.0.min.js"></script>
    <script src="easyui/jquery.easyui.min.js"></script>
    <link href="easyui/icon.css" rel="stylesheet" />
    <link href="easyui/black/easyui.css" rel="stylesheet" />
</head>
<body class="easyui-layout claro map">
    <div data-options="region:'north',title:'基于Asp.net的Arcgis地图开发',split:true" style="height: 100px;"></div>
    <div data-options="region:'south',title:'关于我们',split:true" style="height: 100px;">15级数计一班Arcgis小组</div>
    <div data-options="region:'west',title:'------------'" style="width: 330px;">

        <form id="form1" runat="server" style="width: 300px; height: 772px;">
            <div id="aa" class="easyui-accordion" style="width: 300px; height: 772px;">
                <div title="查找地点" data-options="iconCls:'icon-save'" style="overflow: auto; padding: 10px; width: 300px;">
                    <div style="background-color: chartreuse; padding-left: 20px;">
                        <asp:Label ID="Label4" runat="server" Text="地点"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label5" runat="server" Text="经度"></asp:Label>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label6" runat="server" Text="纬度"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="高程"></asp:Label>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <br />
                        <hr />
                        <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" Width="196px" />
                    </div>
                </div>
                <div title="录入地点" data-options="iconCls:'icon-reload',selected:true" style="padding: 10px; width: 300px;">
                    <div style="background-color: aquamarine; padding-left: 20px;">
                        <asp:TextBox ID="txtAddress" runat="server">上海海洋大学</asp:TextBox>
                        <asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" Width="173px" />
                        <br />
                        <hr />
                        <asp:Label ID="Label1" runat="server" Text="经度"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="纬度"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="高程"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </form>
    </div>
    <div data-options="region:'center',title:'天地图'" style="padding: 5px; background: #eee;">
        <!--Arcgis主面板-->
        <iframe src="arcgishtml.html" height="100%" width="100%"></iframe>
    </div>
</body>
</html>
