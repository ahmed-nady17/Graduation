#pragma checksum "E:\PROJECT\Bills Project\Bills_Project\Bills_Project\Views\Admin\CompanyData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ef77514b85b1a2aa5452d12be51e1233e53063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CompanyData), @"mvc.1.0.view", @"/Views/Admin/CompanyData.cshtml")]
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
#line 1 "E:\PROJECT\Bills Project\Bills_Project\Bills_Project\Views\_ViewImports.cshtml"
using Bills_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\Bills Project\Bills_Project\Bills_Project\Views\_ViewImports.cshtml"
using Bills_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ef77514b85b1a2aa5452d12be51e1233e53063", @"/Views/Admin/CompanyData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f0c01533b917663e3738a8117ba4820469a16a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CompanyData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"         <div class=""main-panel"">
            <div class=""main-content"">
               <div class=""content-wrapper"">
                  <div class=""container-fluid"">
           
                    <section id=""horizontal-form-layouts"">
                   
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""card"">
                                    <div class=""card-header"">
                                        <div class=""card-title-wrap bar-success"">
                                            <h4 class=""card-title"" id=""horz-layout-basic"">Company Data Form</h4>
                                        </div>
                                        <p class=""mb-0"">This is the basic horizontal form with labels on left and cost estimation form is the default position.</p>
                                    </div>
                                    <div class=""card-body"">
                                  ");
            WriteLiteral("      <div class=\"px-3\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ef77514b85b1a2aa5452d12be51e1233e530634809", async() => {
                WriteLiteral(@"
                                            
                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9"">Company Name : </label>
                                                        <div class=""col-md-9"">
                                                            <input type=""text"" id=""projectinput9"" class=""form-control"" name=""Type"">
                                                        </div>
                                                    </div>
                                 
                                   
                                                        
                                                      
                    
                                                    <div class=""form-group row"">
                                                        <label class=""col-md-3 label-control"" for=""projectinput9"">Notes: </label>
             ");
                WriteLiteral(@"                                           <div class=""col-md-9"">
                                                            <textarea id=""projectinput9"" rows=""5"" class=""form-control"" name=""comment""></textarea>
                                                        </div>
                                                    </div>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                    
                                                <div class=""form-actions"">
                                                    <button type=""button"" class=""btn btn-danger mr-1"">
                                                        <i class=""icon-trash""></i> Cancel
                                                    </button>
                                                    <button type=""button"" class=""btn btn-success"">
                                                        <i class=""icon-note""></i> Save
                                                    </button>
                                                </div>
                                            
                                        </div>
                                    
                                </div>
                            </div>
                            </div>
                        </section>
                  </div>
               </div>
            </div>
    ");
            WriteLiteral("        </div>");
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
