using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinePushButtonsTemplateExample
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //建立Bot
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(txbToken.Text);

            //回覆動作
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon() { label = "文字回覆標題", text = "回覆文字" });
            actions.Add(new isRock.LineBot.UriActon() { label = "URL回覆標題", uri = new Uri("http://www.google.com") });

            //單一Button Template Message
            var ButtonTemplate = new isRock.LineBot.ButtonsTemplate()
            {
                text = "訊息",
                title = "標題",
                //設定圖片
                thumbnailImageUrl = new Uri("https://scontent-tpe1-1.xx.fbcdn.net/v/t31.0-8/15800635_1324407647598805_917901174271992826_o.jpg?oh=2fe14b080454b33be59cdfea8245406d&oe=591D5C94"),
                actions = actions //設定回覆動作
            };
            //發送
            bot.PushMessage(this.TxbUserId.Text, ButtonTemplate);
        }
    }
}