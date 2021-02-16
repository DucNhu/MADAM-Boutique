﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using MADAM_Boutique.Models.ViewModels;
namespace MADAM_Boutique.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinksTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinksTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public string PageAction { get; set; }

        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> PageUrlvalues { get; set; }
        = new Dictionary<string, object>();

        public PagingInfo PageModel { get; set; }//  đã đjnh nghĩa ở paginginfo.cs

        public bool PageClassesEnabled { get; set; }

        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper UrlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                PageUrlvalues["productPage"] = i;
                tag.Attributes["href"] = UrlHelper.Action(PageAction, PageUrlvalues);
                //tag.Attributes["href"] = UrlHelper.Action(PageAction, new { productPage = i });
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            } // render ra div & a có href trang con phù hợp
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
