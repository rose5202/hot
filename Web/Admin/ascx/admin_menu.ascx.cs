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

public partial class admin_ascx_menu : System.Web.UI.UserControl
{
    string _strSql = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            InitInfo();
        }
    }

    private void InitInfo()
    {


        _strSql = "select Distinct(ManagePageType) from adm_managePage";
        RptPageType.DataSource = Cmn.DB.getDataTable(_strSql);
        RptPageType.DataBind();

    }
    protected void RptPageType_DataBound(object source, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            Repeater RptPageList = (Repeater)e.Item.FindControl("RptPageList");
            DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 


            string _strManagerID = LCmn.Func.GetManageID();
            if (string.IsNullOrEmpty(_strManagerID)) return;

            string _strRoleID = Cmn.DB.getFieldValue("select roleID from adm_manager where managerID='" + _strManagerID + "';");
            if (_strRoleID.Equals("1"))
            {
                _strSql = "select ManagePageDesc,ManagePageUrl,ManagePageType from adm_managePage where ManagePageType=" + rowv[0] + " order by SortID desc";
            }
            else
            {
                _strSql = @"select ManagePageDesc,ManagePageUrl,ManagePageType from adm_managePage mp
                                inner join adm_authority a on mp.ManagePageID=a.ManagePageID
                                where roleId='" + _strRoleID + " and  ManagePageType=" + rowv[0] + " ' " + @"
                                order by SortID desc";
            }
            RptPageList.DataSource = Cmn.DB.getDataTable(_strSql);
            RptPageList.DataBind();
        }
    }
}
