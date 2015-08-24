using System;
using System.Collections.Specialized;
using System.Text;

namespace EchoWeb2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var labelHtml = new StringBuilder();

            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "AcceptType", Aggregate(Request.AcceptTypes)));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "ContentType", Request.ContentType));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "ContentEncoding", Request.ContentEncoding));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "HttpMethod", Request.HttpMethod));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "UserHostName", Request.UserHostName));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "UserHostAddress", Request.UserHostAddress));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "Url", Request.Url));
            labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>", "IsSecureConnection", Request.IsSecureConnection));

            RequestMiscLabel.Text = labelHtml.ToString();

            labelHtml = new StringBuilder();

            foreach (var key in Request.Headers.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, Request.Headers[key]));

            HeadersLabel.Text = labelHtml.ToString();

            labelHtml = new StringBuilder();

            foreach (var key in Request.Form.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, Request.Form[key]));

            FormValuesLabel.Text = labelHtml.ToString();

            labelHtml = new StringBuilder();

            foreach (var key in Request.ServerVariables.AllKeys)
                if (Request.ServerVariables[key] != null && Request.ServerVariables[key].Length>0)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, Request.ServerVariables[key]));

            ServerVariablesLabel.Text = labelHtml.ToString();

            labelHtml = new StringBuilder();

            foreach (var key in Request.Cookies.AllKeys)
                labelHtml.Append(string.Format("<li><b>{0}</b>:{1}</li>",
                    key, string.Format("{0}|{1}|{2}|{3}|{4}",
                        Request.Cookies[key].Name,
                        Request.Cookies[key].Domain,
                        Request.Cookies[key].Expires.ToShortDateString(),
                        Request.Cookies[key].Value,
                        Aggregate( Request.Cookies[key].Values ))));

            CookiesLabel.Text = labelHtml.ToString();

            HostLabel.Text = Server.MachineName;
        }

        private string Aggregate(NameValueCollection nvc)
        {
            var stringBuilder = new StringBuilder();
            foreach (var key in nvc.AllKeys)
                stringBuilder.Append(string.Format("{0}:{1}", key, nvc[key]));

            return stringBuilder.ToString();
        }

        private string Aggregate(string[] arr)
        {
            var stringBuilder = new StringBuilder();
            foreach (var key in arr)
            {
                if (stringBuilder.Length>0)
                    stringBuilder.Append(","+key);
                else
                    stringBuilder.Append(key);
            }

            return stringBuilder.ToString();
        }
    }
}