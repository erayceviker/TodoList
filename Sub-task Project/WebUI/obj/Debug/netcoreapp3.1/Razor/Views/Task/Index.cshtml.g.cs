#pragma checksum "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67340c35704564ef55b652c33d03227d62c93c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
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
#line 1 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67340c35704564ef55b652c33d03227d62c93c2d", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Görevler";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Görevler</h2>\r\n<div class=\"container\">\r\n    <div class=\"list-group\">\r\n");
#nullable restore
#line 11 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
         foreach (var task in Model.Tasks)
        {
            if (task.IsCompleted == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 305, "\"", 340, 2);
            WriteAttributeValue("", 312, "/task/detail?taskId=", 312, 20, true);
#nullable restore
#line 15 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
WriteAttributeValue("", 332, task.Id, 332, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action text-primary\">");
#nullable restore
#line 15 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
                                                                                                              Write(task.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 16 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 484, "\"", 519, 2);
            WriteAttributeValue("", 491, "/task/detail?taskId=", 491, 20, true);
#nullable restore
#line 19 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
WriteAttributeValue("", 511, task.Id, 511, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action text-decoration-line-through text-danger\">");
#nullable restore
#line 19 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
                                                                                                                                          Write(task.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 20 "C:\Users\erayc\Desktop\Code Archive\Projeler\Sub-task Project\WebUI\Views\Task\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
