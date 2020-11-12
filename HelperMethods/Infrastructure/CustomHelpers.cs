using System;
using System.Web.Mvc;

namespace HelperMethods.Infrastructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html, string[] list)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach(string str in list)
            {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }


        //My model message is This is my html element<input> - msg returned by helper is enoded
        public static string DisplayMessage(this HtmlHelper html, string msg)
        {
            return String.Format("This is the message <p>{0}</p>", msg);
        }

        public static MvcHtmlString DisplayMessageEncoded(this HtmlHelper html, string msg)
        {
            //selectively encoded msg
            string encodedMessage = html.Encode(msg);
            string result = String.Format("This is the message <p>{0}</p>", encodedMessage);
            return new MvcHtmlString(result);
        }
    }
}