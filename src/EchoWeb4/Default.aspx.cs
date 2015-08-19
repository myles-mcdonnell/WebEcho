using System;
using System.Collections.Generic;
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

            labelHtml.Clear();

            foreach (var key in Request.Cookies.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, string.Format("{0}|{1}|{2}|{3}|{4}",
                        Request.Cookies[key].Name,
                        Request.Cookies[key].Domain,
                        Request.Cookies[key].Expires.ToShortDateString(),
                        Request.Cookies[key].Value,
                        Request.Cookies[key].Values.AllKeys.Aggregate(string.Empty, (valkey, str) => key +"," + key +":" + Request.Cookies[key].Values[valkey]))));

            CookiesLabel.Text = labelHtml.ToString();
            
            HostLabel.Text = Server.MachineName;
        }
    }
}