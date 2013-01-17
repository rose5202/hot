using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DBHelper.Base;

public partial class admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MainView.ActiveViewIndex = 0;
        //if (!IsPostBack)
        //{
        //    InitControl();
        //}
    }

    private void InitControl()
    {
        if (!String.IsNullOrEmpty(LCmn.Func.GetManageID()))
        {
            Response.Redirect("index.aspx");
        }
    }
    protected void btnLogin_ServerClick(object sender, EventArgs e)
    {

        string userName = Cmn.Request.Get("uname");
        string upass = Cmn.Request.Get("upass");

        if (userName.Length > 0 && upass.Length > 0)
        {
            string _strManagerID = Cmn.DB.getFieldValue("select ManagerID from adm_manager where ManagerName='" + Cmn.Safe.sqlStr(userName) + "' and ManagerPwd='" + Cmn.Safe.sqlStr(upass) + "' and States=1");
            if (!string.IsNullOrEmpty(_strManagerID))
            {
                LCmn.Func.SetManageID(Int32.Parse(_strManagerID));
                WCommon.SetCookies("ManagerName",HttpUtility.UrlEncode(userName), DateTime.Now.Day + 1);
                Response.Redirect("index.aspx");
            }
            else 
            {
                Cmn.Js.Alert(Page, "对不起，用户名或密码错误", false);
            }
        }
        else 
        {
            Cmn.Js.Alert(Page, "用户名或密码不能为空", false);
        }        
    }
}
