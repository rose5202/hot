<%@ Control Language="C#" AutoEventWireup="true" CodeFile="admin_menu.ascx.cs" Inherits="admin_ascx_menu" %>
<div id="left">
    <asp:Repeater ID="RptPageType" runat="server" OnItemDataBound="RptPageType_DataBound">
        <ItemTemplate>
            <div class="left_navi" style="position: relative;" id="div<%#Container.ItemIndex+1%>">
                <div style="width: 16px; height: 16px; position: absolute; left: 126px; top: 4px;">
                    <a href="javascript:slideToggle('div<%#Container.ItemIndex+1%>');">
                        <img src="images/icon_jt.jpg" width="16" height="16" /></a>
                </div>
                <div class="tit" style="height:30px;line-height:30px;">
                    <%#LCmn.FCommon.ManagerType(Eval("ManagePageType"))%></div>
                <ul>
                    <asp:Repeater ID="RptPageList" runat="server">
                        <ItemTemplate>
                            <li><a href='<%#Eval("ManagePageUrl")%>' target="a">
                                <%#Eval("ManagePageDesc")%></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
