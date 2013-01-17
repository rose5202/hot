<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>欧莱雅培训后台管理平台</title>
    <link href="css/admin_style.css" rel="stylesheet" type="text/css" />
</head>
<body style="background: #FFF; color: #000; font: 75% Arial, Helvetica, sans-serif;">
    <div style="position: absolute; left: 50%; top: 50%; width: 500px; height: 230px;
        margin-left: -250px; margin-top: -115px;">
        <div style="border: 1px solid #CCC; background: #EEE; padding: 5px;">
            <form id="Form1" runat="server" method="post" name="login" style="background: #FFF url(images/Logo.jpg) no-repeat 40px 50%;
            margin: 0; padding: 20px 0 20px 180px;">
            <asp:MultiView runat="server" ID="MainView">
                <asp:View runat="server" ID="LoginView">
                    <fieldset style="border: none; border-left: 1px solid #EEE; padding-left: 3em;">
                        <p style="margin: 0.5em 0;">
                            账 号：<input type="text" id="uname" name="uname" style="width: 10em; border: 1px solid #CCC;
                                padding: 4px 2px;" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uname"
                                ErrorMessage="*填写帐号"></asp:RequiredFieldValidator></p>
                        <p style="margin: 0.5em 0;">
                            密 码：<input type="password" id="upass" name="upass" style="width: 10em; border: 1px solid #CCC;
                                padding: 4px 2px;" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="upass"
                                ErrorMessage="*填写密码"></asp:RequiredFieldValidator></p>
                        <p style="margin: 0.5em 0; align: center">
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                            <input type="submit" class="button" name="btnLogin" value="登录管理平台" style="background: #DDD;
                                border-top: 1px solid #EEE; border-right: 1px solid #BBB; border-bottom: 1px solid #BBB;
                                border-left: 1px solid #EEE; padding: 3px; cursor: pointer;" id="btnLogin" onserverclick="btnLogin_ServerClick"
                                runat="server" /></p>
                        <p style="margin: 0.5em 0;">
                            <font color="red">
                                <asp:Literal runat="server" ID="lblMessage" Visible="False"></asp:Literal></font></p>
                    </fieldset>

                    <script language="JavaScript" type="text/javascript">
                                    document.getElementById('txtPassword').focus();
                    </script>

                </asp:View>
                <asp:View runat="server" ID="SuccessView">
                    <fieldset style="border: none; border-left: 1px solid #EEE; padding-left: 3em;">
                        <p style="margin: 0.5em 0;">
                            <asp:Literal runat="server" ID="lblWelcome"></asp:Literal></p>
                    </fieldset>
                </asp:View>
            </asp:MultiView>
            </form>
        </div>
        <p style="margin: 0.5em 0; text-align: center; font-size: 10px;">
            &copy; 2010 Showone Inc.</p>
    </div>
</body>
</html>
