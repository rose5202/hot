<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="admin_index" %>

<%@ Register Src="~/admin/ascx/admin_menu.ascx" TagName="admin_menu" TagPrefix="uc1" %>
<%@ Register Src="~/admin/ascx/admin_top.ascx" TagName="admin_top" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>欧莱雅培训后台管理平台</title>

    <script language="javascript" src="jquery-1.2.3.pack.js"></script>

    <link href="css/admin_style.css" rel="stylesheet" type="text/css" />

    <script src="js/jquery-1.4.1.min.js" type="text/javascript"></script>

    <script src="js/jquery.messager.js" type="text/javascript"></script>

    <script src="js/help.js" type="text/javascript"></script>

    <style type="text/css">
        #message_content a
        {
            color: #333;
        }
        #winpop
        {
            width: 200px;
            height: 0px;
            position: absolute;
            right: 0;
            bottom: 0;
            border: 1px solid #666;
            margin: 0;
            padding: 1px;
            overflow: hidden;
            display: none;
        }
        #winpop .title
        {
            width: 100%;
            height: 22px;
            line-height: 20px;
            background: #3C3C3C;
            font-weight: bold;
            text-align: left;
            font-size: 12px;
        }
        #winpop .con
        {
            width: 100%;
            height: 30px;
            line-height: 30px;
            font-weight: bold;
            font-size: 12px;
            color: #FF0000;
            text-decoration: none;
            text-align: left;
        }
        #silu
        {
            font-size: 12px;
            color: #666;
            position: absolute;
            right: 0;
            text-align: right;
            text-decoration: underline;
            line-height: 22px;
        }
        .close
        {
            position: absolute;
            right: 4px;
            top: -1px;
            color: #FFF;
            cursor: pointer;
        }
        .con a{ text-decoration:none!important; color:#333;}
    </style>

    <script type="text/javascript">
        //    window.onload = getNewHelp();
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="wrap01">
        <uc2:admin_top ID="admin_top1" runat="server" />
        <div id="center">
            <uc1:admin_menu ID="admin_menu1" runat="server" />
            <div id="right">
                <iframe name="a" width="100%" height="100%" src="right.aspx"></iframe>
                <div class="clr">
                </div>
            </div>
        </div>
        <div class="clr">
        </div>
    </div>
    <div id="winpop">
        <div class="title">
            您有新的短消息！<span class="close" onclick="tips_pop()">关闭</span></div>
        <div class="con">
           
        </div>
    </div>

    <script language="javascript">
        function slideToggle(obj) {
           $("#" + obj + ">ul li:not(.tit)").slideToggle(0);
        }
    </script>

    </form>
</body>
</html>
