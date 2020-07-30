#pragma checksum "C:\Users\Dalila\Source\Repos\Moravia\ChessProject\Views\Chess\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f92a026830d3467005ef9ee34628b3b02300e7c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chess_Index), @"mvc.1.0.view", @"/Views/Chess/Index.cshtml")]
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
#line 1 "C:\Users\Dalila\Source\Repos\Moravia\ChessProject\Views\_ViewImports.cshtml"
using ChessProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dalila\Source\Repos\Moravia\ChessProject\Views\_ViewImports.cshtml"
using ChessProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92a026830d3467005ef9ee34628b3b02300e7c3", @"/Views/Chess/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73257267b64b6b73dd6cf50296c0638adfe15d05", @"/Views/_ViewImports.cshtml")]
    public class Views_Chess_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dalila\Source\Repos\Moravia\ChessProject\Views\Chess\Index.cshtml"
  
    ViewData["Title"] = "Chess";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Chess</h1>
<h4>Are you ready to play?</h4>
<br />

<fom id=""formChess"" method=""post"">
    <label>Player 1 (white): </label>
    <input type=""text"" id=""player1"" class=""input-group-text"" />

    <label>Player 2 (black): </label>
    <input type=""text"" id=""player2"" class=""input-group-text"" />

    <input type=""button"" value=""Go!""");
            BeginWriteAttribute("onclick", " onclick=\"", 388, "\"", 445, 3);
            WriteAttributeValue("", 398, "location.href=\'", 398, 15, true);
#nullable restore
#line 17 "C:\Users\Dalila\Source\Repos\Moravia\ChessProject\Views\Chess\Index.cshtml"
WriteAttributeValue("", 413, Url.Action("NewGame", "Chess"), 413, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 444, "\'", 444, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
</fom>

<div class=""board table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">a</th>
                <th scope=""col"">b</th>
                <th scope=""col"">c</th>
                <th scope=""col"">d</th>
                <th scope=""col"">e</th>
                <th scope=""col"">f</th>
                <th scope=""col"">g</th>
                <th scope=""col"">h</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">8</th>
                <td id=""8a"" class=""square""></td>
                <td id=""8b"" class=""squareDark""></td>
                <td id=""8c"" class=""square""></td>
                <td id=""8d"" class=""squareDark""></td>
                <td id=""8e"" class=""square""></td>
                <td id=""8f"" class=""squareDark""></td>
                <td id=""8g"" class=""square""></td>
                <td id=""8h"" class=""squareDark""></td>
            </tr>
   ");
            WriteLiteral(@"         <tr>
                <th scope=""row"">7</th>
                <td id=""7a"" class=""squareDark""></td>
                <td id=""7b"" class=""square""></td>
                <td id=""7c"" class=""squareDark""></td>
                <td id=""7d"" class=""square""></td>
                <td id=""7e"" class=""squareDark""></td>
                <td id=""7f"" class=""square""></td>
                <td id=""7g"" class=""squareDark""></td>
                <td id=""7h"" class=""square""></td>
            </tr>
            <tr>
                <th scope=""row"">6</th>
                <td id=""6a"" class=""square""></td>
                <td id=""6b"" class=""squareDark""></td>
                <td id=""6c"" class=""square""></td>
                <td id=""6d"" class=""squareDark""></td>
                <td id=""6e"" class=""square""></td>
                <td id=""6f"" class=""squareDark""></td>
                <td id=""6g"" class=""square""></td>
                <td id=""6h"" class=""squareDark""></td>
            </tr>
            <tr>
                <th sco");
            WriteLiteral(@"pe=""row"">5</th>
                <td id=""5a"" class=""squareDark""></td>
                <td id=""5b"" class=""square""></td>
                <td id=""5c"" class=""squareDark""></td>
                <td id=""5d"" class=""square""></td>
                <td id=""5e"" class=""squareDark""></td>
                <td id=""5f"" class=""square""></td>
                <td id=""5g"" class=""squareDark""></td>
                <td id=""5h"" class=""square""></td>
            </tr>
            <tr>
                <th scope=""row"">4</th>
                <td id=""4a"" class=""square""></td>
                <td id=""4b"" class=""squareDark""></td>
                <td id=""4c"" class=""square""></td>
                <td id=""4d"" class=""squareDark""></td>
                <td id=""4e"" class=""square""></td>
                <td id=""4f"" class=""squareDark""></td>
                <td id=""4g"" class=""square""></td>
                <td id=""4h"" class=""squareDark""></td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td i");
            WriteLiteral(@"d=""3a"" class=""squareDark""></td>
                <td id=""3b"" class=""square""></td>
                <td id=""3c"" class=""squareDark""></td>
                <td id=""3d"" class=""square""></td>
                <td id=""3e"" class=""squareDark""></td>
                <td id=""3f"" class=""square""></td>
                <td id=""3g"" class=""squareDark""></td>
                <td id=""3h"" class=""square""></td>
            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td id=""2a"" class=""square""></td>
                <td id=""2b"" class=""squareDark""></td>
                <td id=""2c"" class=""square""></td>
                <td id=""2d"" class=""squareDark""></td>
                <td id=""2e"" class=""square""></td>
                <td id=""2f"" class=""squareDark""></td>
                <td id=""2g"" class=""square""></td>
                <td id=""2h"" class=""squareDark""></td>
            </tr>
            <tr>
                <th scope=""row"">1</th>
                <td id=""1a"" class=""squareDark""></td>
     ");
            WriteLiteral(@"           <td id=""1b"" class=""square""></td>
                <td id=""1c"" class=""squareDark""></td>
                <td id=""1d"" class=""square""></td>
                <td id=""1e"" class=""squareDark""></td>
                <td id=""1f"" class=""square""></td>
                <td id=""1g"" class=""squareDark""></td>
                <td id=""1h"" class=""square""></td>
            </tr>
        </tbody>
    </table>

</div>

<div class=""board table-responsive"">
    <!--1 linea -->
    <div class=""row"">
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
        <div class=""square col-md-1""></div>
    </div>
    <!--2 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""sq");
            WriteLiteral(@"uare col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </div>

    <!--3 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </div>

    <!--4 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </");
            WriteLiteral(@"div>

    <!--5 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </div>

    <!--6 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </div>

    <!--7 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div cla");
            WriteLiteral(@"ss=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </div>

    <!--8 linea -->
    <div class=""row"">
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
        <div class=""square col-1""></div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
