﻿using System.Linq.Expressions;

namespace System.Web.Mvc.Html
{
    public static class HiddenTemplateForExtension
    {
        public static MvcHtmlString HiddenTemplateFor<TModel, TValue>(
           this HtmlHelper<TModel> htmlHelper,
           Expression<Func<TModel, TValue>> expression,
           object htmlAttributes = null,
           string customIndex = null)
        {
            var result = htmlHelper.HiddenFor(expression, htmlAttributes);
            var stringResult = TemplateForExtensions.ReplaceNameAndId(result.ToString(), htmlHelper, expression, customIndex);

            return MvcHtmlString.Create(stringResult);
        }
    }
}
