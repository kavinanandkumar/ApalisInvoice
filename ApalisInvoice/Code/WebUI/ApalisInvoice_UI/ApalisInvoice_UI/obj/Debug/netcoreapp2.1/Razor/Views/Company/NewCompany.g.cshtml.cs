#pragma checksum "E:\Kavin\Project\ApalisInvoice\Code\WebUI\ApalisInvoice_UI\ApalisInvoice_UI\Views\Company\NewCompany.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71f576760f36f148bd2f30f4973005052c3395b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_NewCompany), @"mvc.1.0.view", @"/Views/Company/NewCompany.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/NewCompany.cshtml", typeof(AspNetCore.Views_Company_NewCompany))]
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
#line 1 "E:\Kavin\Project\ApalisInvoice\Code\WebUI\ApalisInvoice_UI\ApalisInvoice_UI\Views\_ViewImports.cshtml"
using ApalisInvoice_UI;

#line default
#line hidden
#line 2 "E:\Kavin\Project\ApalisInvoice\Code\WebUI\ApalisInvoice_UI\ApalisInvoice_UI\Views\_ViewImports.cshtml"
using ApalisInvoice_UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71f576760f36f148bd2f30f4973005052c3395b9", @"/Views/Company/NewCompany.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe10a7732798d76b22fe30e4cc253fdcde98eb2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_NewCompany : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dropify/js/dropify.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dropify.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-content\">\r\n");
            EndContext();
#line 4 "E:\Kavin\Project\ApalisInvoice\Code\WebUI\ApalisInvoice_UI\ApalisInvoice_UI\Views\Company\NewCompany.cshtml"
     using (Html.BeginForm("SaveCompany", "Company", FormMethod.Post, new { enctype = "multipart/form-data", onsubmit = "return fnValidate();" }))
	{
		

#line default
#line hidden
            BeginContext(185, 28, false);
#line 6 "E:\Kavin\Project\ApalisInvoice\Code\WebUI\ApalisInvoice_UI\ApalisInvoice_UI\Views\Company\NewCompany.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(215, 271, true);
            WriteLiteral(@"		<div class=""modal-header "">
			<input type=""hidden"" id=""hdn_CompanyID"" value=""0"" name=""CompanyID"" />
			<strong>New Company</strong>
			<a href=""javascript:void(0)"" data-dismiss=""modal"" class=""btn btn-danger modal-btn-emr""><i class=""fa fa-close""></i></a>
		</div>
");
            EndContext();
            BeginContext(488, 3986, true);
            WriteLiteral(@"		<div class=""card-body"" style=""padding-bottom:0px !important;"">
			<div class=""row "">
				<div class=""col-md-4"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Company Name"" name=""CompanyName"" />
					</div>
				</div>
				<div class=""col-md-2"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Company Code"" name=""CompanyCode"" />
					</div>
				</div>
				<div class=""col-md-6"">
					<div class=""form-group"">
						<textarea rows=""1"" class=""form-control"" name=""Address"" placeholder=""Address""></textarea>
					</div>
				</div>
			</div>
			<div class=""row "">
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""City"" name=""City"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""State"" name=""State"" />
					</div>
				</div>
				<div class=""col-md-3"">
	");
            WriteLiteral(@"				<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Zipcode"" name=""Zipcode"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Work Phone(Landline)"" name=""Workphone"" />
					</div>
				</div>
			</div>
			<div class=""row "">
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Mobile 1"" name=""Mobile1"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Mobile 2"" name=""Mobile2"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Mobile 3"" name=""Mobile3"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Mobile 4"" name=""Mobile4"" />
            WriteLiteral(@"
					</div>
				</div>
			</div>
			<div class=""row "">
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""Govt. Regd No"" name=""Govtregdno"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""ESI No"" name=""Esi_no"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""EPF No"" name=""Epf_no"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""TN Police L.No"" name=""Tnpolicelno"" />
					</div>
				</div>
			</div>
			<div class=""row "">
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""ISO"" name=""Iso"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<i");
            WriteLiteral(@"nput type=""text"" class=""form-control"" placeholder=""Website"" name=""Website"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""PAN No"" name=""Pan_no"" />
					</div>
				</div>
				<div class=""col-md-3"">
					<div class=""form-group"">
						<input type=""text"" class=""form-control"" placeholder=""GSTIN"" name=""Gstn"" />
					</div>
				</div>
			</div>
			<div class=""row  p-12 m-b-10"">
				<div class=""col-lg-12"">
					<div class=""form-group"">
						<input type=""file"" id=""dropify_Logo"" class=""dropify"" name=""file"" data-allowed-file-extensions=""png"" data-max-file-size=""100K"">
					</div>
				</div>
			</div>
		</div>
		<div class=""modal-footer"">
			<button type=""submit"" class=""btn btn-primary"">Save</button>
			<button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
		</div>
");
            EndContext();
#line 131 "E:\Kavin\Project\ApalisInvoice\Code\WebUI\ApalisInvoice_UI\ApalisInvoice_UI\Views\Company\NewCompany.cshtml"
	}

#line default
#line hidden
            BeginContext(4478, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(4486, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "973afb4215934f249ab71148694cd451", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4541, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4543, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73240dca6d534ae583c250cc04382e46", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4582, 92, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\tfunction fnValidate() {\r\n\t\treturn true;\r\n\t}\r\n</script>\r\n");
            EndContext();
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