
//获取最新的未读help内容
function getNewHelp() {
    var help = "";
    $.getJSON("PostData/PostData.ashx", { type: "getnewhelp" },
            function(Json) {
                if (Json != null) {
                    $.each(Json, function(i, item) {
                        help += item.H_NikeName+":<a href=\"Help/ReplyHelp.aspx?helpid=" + item.HelpID_PK + "\" target=\"a\">" + item.H_Title + "</a><br/>";
                    });
                   
                    $(".con").html(help);
                }

            });
}
