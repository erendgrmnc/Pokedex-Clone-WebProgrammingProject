#pragma checksum "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d60c88a09481cfbbd1e1fdfc9b6f25009cd1c09e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Index), @"mvc.1.0.view", @"/Views/Pokemon/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60c88a09481cfbbd1e1fdfc9b6f25009cd1c09e", @"/Views/Pokemon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProje.Models.Pokemon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 9 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                         Write(Html.DisplayFor(model => model.POKEMON_NAME));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <hr class=\"my-4\">\r\n        <button class=\"form-control btn btn-lg btn-primary\">");
#nullable restore
#line 11 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                                                       Write(localizer["Satın Al"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n\r\n\r\n        <div class=\"card text-white bg-primary my-3\">\r\n            <img class=\"img-fluid\" style=\"background-color:#fff;\"");
            BeginWriteAttribute("src", " src=\"", 575, "\"", 629, 1);
#nullable restore
#line 16 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 581, Html.DisplayFor(model => model.POKEMON_IMG_URL), 581, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 col-sm-3\">\r\n                        <div>");
#nullable restore
#line 20 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(localizer["Uzunluk"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div>");
#nullable restore
#line 21 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(Html.DisplayFor(model => model.POKEMON_HEIGHT));

#line default
#line hidden
#nullable disable
            WriteLiteral(" M</div>\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-3\">\r\n                        <div>");
#nullable restore
#line 24 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(localizer["Ağırlık"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div>");
#nullable restore
#line 25 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(Html.DisplayFor(model => model.POKEMON_WEIGHT));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KG</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 col-sm-3\">\r\n                        <div>");
#nullable restore
#line 30 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(localizer["Kategori"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div>");
#nullable restore
#line 31 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(Html.DisplayFor(model => model.POKEMON_CATEGORY));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-3\">\r\n                        <div>");
#nullable restore
#line 34 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                        Write(localizer["Yetenekler"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        ");
#nullable restore
#line 35 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
                   Write(await Component.InvokeAsync(typeof(WebProje.ViewComponents.Pokemon.Ability), new { id = Model.POKEMON_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                       \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n         ");
#nullable restore
#line 40 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
    Write(await Component.InvokeAsync(typeof(WebProje.ViewComponents.Pokemon.Type), new { id = Model.POKEMON_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n        ");
#nullable restore
#line 42 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
   Write(await Component.InvokeAsync(typeof(WebProje.ViewComponents.Pokemon.Stats), new { id = Model.POKEMON_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 43 "C:\Users\maftu\source\repos\WebProgramlamaOdev_2020\WebProje\WebProje\Views\Pokemon\Index.cshtml"
   Write(await Component.InvokeAsync(typeof(WebProje.ViewComponents.Pokemon.Weakness), new { id = Model.POKEMON_ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>


<script>
    $(document).ready(function () {
        showAbilityDesc();
    });

    function showAbilityDesc() {
        $('.ability-button').click(function () {
            let abilityName = $(this).attr('data-abilityname');
            let desc = $(this).attr('data-abilitydesc');


            swal(abilityName, desc);

        })
    }
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProje.Models.Pokemon> Html { get; private set; }
    }
}
#pragma warning restore 1591
