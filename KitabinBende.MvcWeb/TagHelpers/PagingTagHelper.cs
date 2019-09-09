using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabinBende.MvcWeb.TagHelpers
{
    [HtmlTargetElement("book-list-pager")]
    public class PagingTagHelper:TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }

        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }      

        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }
        [HtmlAttributeName("base-url")]
        public string BaseUrl { get; set; }
        [HtmlAttributeName("current-category-id")]
        public int CurrentCategoryID { get; set; }
        [HtmlAttributeName("query-string-params")]
        public string QueryStringParam  { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";            
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<div class='page-number'>");
            stringBuilder.Append("<ul>");

            for (int i = 1; i <= PageCount; i++)
            {
                stringBuilder.AppendFormat("<li style='{0}'>", i == CurrentPage 
                    ? "border: 1px solid lightgray;"
                    : "");
                stringBuilder.AppendFormat("<a href='{0}/{1}?page={2}{3}'>{2}</a>"
                    ,BaseUrl,CurrentCategoryID,i,QueryStringParam);
                stringBuilder.Append("</li>");
            }
            stringBuilder.Append("</ul>");
            stringBuilder.Append("</div>");
            output.Content.SetHtmlContent(stringBuilder.ToString());

            base.Process(context, output);
        }
        //<div class="page-number">
        //                <ul>
        //                    <li><a href = "#" class="active">1</a></li>
        //                    <li><a href = "#" > 2 </ a ></ li >
        //                    < li >< a href="#">3</a></li>
        //                    <li><a href = "#" > 4 </ a ></ li >
        //                    < li >< a href="#" class="angle"><i class="fa fa-angle-right"></i></a></li>
        //                </ul>
        //            </div>
    }
}
