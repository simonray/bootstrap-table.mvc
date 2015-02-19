using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace System.Web.Mvc
{
    public static class Helpers
    {
        public static MvcHtmlString DisplayWithIdFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression, string wrapperTag = "div")
        {
            var id = helper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(ExpressionHelper.GetExpressionText(expression));
            return MvcHtmlString.Create(string.Format("<{0} id=\"{1}\">{2}</{0}>", wrapperTag, id, helper.DisplayFor(expression)));
        }

        public static MvcHtmlString ActionLinkMenu(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues = null, object htmlAttributes = null)
        {
            var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            var builder = new TagBuilder("li")
            {
                InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName, routeValues, htmlAttributes).ToHtmlString()
            };

            if (controllerName == currentController && actionName == currentAction)
                builder.AddCssClass("active");

            return new MvcHtmlString(builder.ToString());
        }
    }
}
