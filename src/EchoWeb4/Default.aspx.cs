using System;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace EchoWeb4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var labelHtml = new StringBuilder();

            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "AcceptType", Request.AcceptTypes.Aggregate(string.Empty, (s, s1) => s + s1)));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "ContentType", Request.ContentType));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "ContentEncoding", Request.ContentEncoding));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "HttpMethod", Request.HttpMethod));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "UserHostName", Request.UserHostName));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "UserHostAddress", Request.UserHostAddress));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "Url", Request.Url));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "IsSecureConnection", Request.IsSecureConnection));
            
            RequestMiscLabel.Text = labelHtml.ToString();

            labelHtml.Clear();

            foreach (var key in Request.Headers.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, Request.Headers[key]));

            HeadersLabel.Text = labelHtml.ToString();

            labelHtml.Clear();

            foreach (var key in Request.Form.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, Request.Form[key]));

            FormValuesLabel.Text = labelHtml.ToString();

            labelHtml.Clear();

            foreach (var key in Request.ServerVariables.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, Request.ServerVariables[key]));

            ServerVariablesLabel.Text = labelHtml.ToString();

            HostLabel.Text = Server.MachineName;
        }
    }
}