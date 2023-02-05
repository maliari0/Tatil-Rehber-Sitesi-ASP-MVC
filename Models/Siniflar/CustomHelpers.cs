using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProje2.Models.Siniflar
{
    public class CustomHelpers
    {
        public static MvcHtmlString Image(string Imagesource,string classTxt /*string imagewidth, string imageheight*/)
        {
            var ImageTag = new TagBuilder("img");
            ImageTag.MergeAttribute("src", Imagesource);
            ImageTag.MergeAttribute("class", classTxt);
            //ImageTag.MergeAttribute("width", imagewidth);
            //ImageTag.MergeAttribute("height", imageheight);
            return MvcHtmlString.Create(ImageTag.ToString
               (TagRenderMode.SelfClosing));
        }
    }
}