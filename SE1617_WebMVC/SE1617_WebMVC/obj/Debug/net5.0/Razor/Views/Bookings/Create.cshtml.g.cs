#pragma checksum "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325a3742ed2a1b15d470cdb0c5a981b3588d7703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Create), @"mvc.1.0.view", @"/Views/Bookings/Create.cshtml")]
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
#line 1 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\_ViewImports.cshtml"
using SE1617_WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\_ViewImports.cshtml"
using SE1617_WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325a3742ed2a1b15d470cdb0c5a981b3588d7703", @"/Views/Bookings/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d79a42b55b7bc58d10ea22ff32e42814f13ad2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bookings_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
  
    int index = -1;
    int checboxNumber = 0;
    Show s = (Show)ViewBag.Show;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
 for (var i = 0; i < 10; i++)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
     for (var j = 0; j < 10; j++)
    {

        index = j * 10 + i;
        string isBooked = Model[index];

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input");
            BeginWriteAttribute("value", " value=\"", 317, "\"", 338, 1);
#nullable restore
#line 20 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
WriteAttributeValue("", 325, j * 10 + i, 325, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", " disabled=\"", 339, "\"", 388, 1);
#nullable restore
#line 20 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
WriteAttributeValue("", 350, isBooked == "1" ? "disabled" : null, 350, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" ");
#nullable restore
#line 20 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
                                                                                                   Write(isBooked == "1" ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n");
#nullable restore
#line 21 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "325a3742ed2a1b15d470cdb0c5a981b3588d77036714", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
     if (s != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input hidden name=\"ShowId\"");
                BeginWriteAttribute("value", " value=\"", 559, "\"", 576, 1);
#nullable restore
#line 27 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
WriteAttributeValue("", 567, s.ShowId, 567, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"FilmId\"");
                BeginWriteAttribute("value", " value=\"", 617, "\"", 634, 1);
#nullable restore
#line 28 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
WriteAttributeValue("", 625, s.FilmId, 625, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 29 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""form-group"">
        <label>Name</label> <br />
        <input class=""form-group"" type=""text"" name=""Name"" />
    </div>
    <div class=""form-group"">
        <label>Amount</label> <br />
        <input value=""0"" class=""form-control text-box single-line readonly disabled amount"" name=""Amount"" />
    </div>
    <input hidden class=""form-group seat"" type=""text"" name=""SeatStatus""");
                BeginWriteAttribute("value", " value=\"", 1050, "\"", 1071, 1);
#nullable restore
#line 39 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
WriteAttributeValue("", 1058, ViewBag.seat, 1058, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "325a3742ed2a1b15d470cdb0c5a981b3588d770310463", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
                            WriteLiteral(s.ShowId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js\"></script>\r\n<script>\r\n      var price = parseInt(\'");
#nullable restore
#line 51 "C:\Users\Admin\Downloads\mas291\lithuyetmas\SE1617_WebMVC\SE1617_WebMVC\Views\Bookings\Create.cshtml"
                       Write(s.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
      var amount = document.querySelector("".amount"");
      function replaceStrAtIndex( str, index, letter ){
      let modifiedStr = [...str];
      modifiedStr[index] = letter;
      return modifiedStr.join('')
    }
    var markedCheckbox = document.querySelectorAll('input[type=""checkbox""]:not(:disabled)');
        markedCheckbox.forEach( (item) => {
          item.addEventListener(""click"", ()=>{

              var seat = document.querySelector("".seat"");
              if(item.checked == true){
               console.log(seat.value)
               seat.value = replaceStrAtIndex(seat.value, item.value, '1');
               console.log(seat.value)
               var currentPrice = parseInt(amount.value) + price;
               amount.value = currentPrice;
              }
              else {
                console.log(seat.value)
                 seat.value = replaceStrAtIndex(seat.value, item.value, '0');
                console.log(seat.value)
                var currentPrice = p");
            WriteLiteral("arseInt(amount.value) - price;\r\n               amount.value = currentPrice;\r\n              }\r\n          })\r\n      });\r\n    \r\n\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
