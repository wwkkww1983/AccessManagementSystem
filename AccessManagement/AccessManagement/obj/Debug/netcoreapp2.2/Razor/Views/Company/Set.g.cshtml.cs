#pragma checksum "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\Company\Set.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f81325ffca92f18445ba2e1ae5d27a8746b65a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Set), @"mvc.1.0.view", @"/Views/Company/Set.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Set.cshtml", typeof(AspNetCore.Views_Company_Set))]
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
#line 1 "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\_ViewImports.cshtml"
using AccessManagement;

#line default
#line hidden
#line 2 "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\_ViewImports.cshtml"
using AccessManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f81325ffca92f18445ba2e1ae5d27a8746b65a3", @"/Views/Company/Set.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3826a4965545f2f0ad57e10c8f472e1ac40b4acd", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Set : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\Company\Set.cshtml"
  
    ViewData["Title"] = "设置";

#line default
#line hidden
            BeginContext(40, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(47, 16, false);
#line 6 "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\Company\Set.cshtml"
Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 50, true);
            WriteLiteral("</h1>\r\n<input style=\"display:none;\" id=\"CompanyId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 113, "\"", 136, 1);
#line 7 "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\Company\Set.cshtml"
WriteAttributeValue("", 121, ViewData["Id"], 121, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(137, 843, true);
            WriteLiteral(@">

<div id=""test1""></div>
<script>
    layui.use('tree', function () {
        var tree = layui.tree;
        var treeData;
        $.ajax({
            url: ""/Company/GetReFunctions/"" + $(""CompanyId"").val(),
            data: filter,
            dataType: ""json"",
            type: ""Get"",
            contentType: ""application/json"",
            error: function (data) {
                alert(data.message);
            },
            success: function (data) {
                treeData = data;
            }
        });
        
        //渲染
        var inst1 = tree.render({
            elem: '#test1'  //绑定元素
            , showCheckbox: true
            //, edit: ['add', 'update', 'del']
            , accordion: true
            , showLine: true
            , data: treeData
        });
    });
</script>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(998, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\项目\AccessManagementSystem\AccessManagement\AccessManagement\Views\Company\Set.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
