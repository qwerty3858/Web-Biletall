#pragma checksum "C:\Users\Celal\Desktop\celal\Biletall\Biletall\Biletall.Web\Views\Rezervasyon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e12827ab835b60795ec2126755d3e0aefb17d50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rezervasyon_Index), @"mvc.1.0.view", @"/Views/Rezervasyon/Index.cshtml")]
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
#line 1 "C:\Users\Celal\Desktop\celal\Biletall\Biletall\Biletall.Web\Views\_ViewImports.cshtml"
using Biletall.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Celal\Desktop\celal\Biletall\Biletall\Biletall.Web\Views\_ViewImports.cshtml"
using Biletall.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e12827ab835b60795ec2126755d3e0aefb17d50", @"/Views/Rezervasyon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57e80c88574e66c0b97fcc1dd6da7b0371c95d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Rezervasyon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/biletall.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("postForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e12827ab835b60795ec2126755d3e0aefb17d505522", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e12827ab835b60795ec2126755d3e0aefb17d505784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e12827ab835b60795ec2126755d3e0aefb17d506962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!--Import Google Icon Font-->
    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
    <!--Import materialize.css-->
    <link type=""text/css"" rel=""stylesheet"" href=""css/materialize.min.css"" media=""screen,projection"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css"">
    <!--Let browser know website is optimized for mobile-->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <style>
        /* label color */
        .input-field label {
            color: #000;
        }
        /* label focus color */
        .input-field input[type=text]:focus + label {
            color: #000;
        }
        /* label underline focus color */
        .input-field input[type=text]:focus {
            border-bottom: 1px solid #000;
            box-shadow: 0 1px 0 0 #000;
        }
        /* valid color */
        .input-field input[type=text].valid {
       ");
                WriteLiteral(@"     border-bottom: 1px solid #000;
            box-shadow: 0 1px 0 0 #000;
        }
        /* invalid color */
        .input-field input[type=text].invalid {
            border-bottom: 1px solid #000;
            box-shadow: 0 1px 0 0 #000;
        }
        /* icon prefix focus color */
        .input-field .prefix.active {
            color: #000;
        }

        .iletisim-back {
            background-color: #F5F5F5;
        }

        .up {
            margin-top: 10px;
        }

        .master {
            border: 1px solid black;
        }
        /*Firefox*/
        input[type=number] {
            -moz-appearance: textfield;
        }
        /*Chrome*/
        input::-webkit-outer-spin-button,
        input::-webkit-inner-spin-button {
            -webkit-appearance: none;
            margin: 0;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 68 "C:\Users\Celal\Desktop\celal\Biletall\Biletall\Biletall.Web\Views\Rezervasyon\Index.cshtml"
  
    List<Sefer> list = (List<Sefer>)ViewData["Seferler"];
    List<MusteriViewModel> list2 = (List<MusteriViewModel>)TempData["values2"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e12827ab835b60795ec2126755d3e0aefb17d5011125", async() => {
                WriteLiteral("\r\n\r\n    <h6><i class=\"material-icons prefix\">directions_subway </i><i> Sefer Bilgileri</i></h6>\r\n");
                WriteLiteral("\r\n    <h6><i class=\"material-icons prefix\">transfer_within_a_station </i><i> Yolcu Bilgileri</i></h6>\r\n\r\n    <div class=\"master\">\r\n        <div class=\"row\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e12827ab835b60795ec2126755d3e0aefb17d5011706", async() => {
                    WriteLiteral(@"
                <div class=""row up"">
                    <div class=""input-field col s3"">
                        
                            <h6>Yolcu()</h6>
                            <div class=""input-field col s3"">
                                <input placeholder=""Adınız"" id=""first_name"" type=""text"" class=""validate"" required>
                                <label for=""first_name"">Ad</label>
                            </div>
                            <div class=""input-field col s3"">
                                <input placeholder=""Soyadınız"" id=""last_name"" type=""text"" class=""validate"" required>
                                <label for=""last_name"">Soyad</label>
                            </div>
                            <div class=""input-field col s3"">
                                <input type=""text"" onkeypress=""return isNumberKey(event)"" name=""tc"" id=""tc"" class=""validate"" placeholder=""TC Kimlik No"" maxlength=""11"" required>
                                <label for=""tc"">TC");
                    WriteLiteral(@" Kimlik Numarası</label>
                                <i class=""tc-group"" style=""font-size: 12px;"">(Karayolu Taşıma Yönetmeliğince Gereklidir.)</i>
                                <span class=""helper-text"" data-error=""Lütfen TC Kimlik No alanını doğru giriniz."" data-success=""Başarılı""></span>
                            </div>
                        

                    </div>

                </div>
                <div class=""iletisim-back"">
                    <div class=""row "">
                        <div class=""input-field col s4"">
                            <i class=""material-icons prefix"" style=""margin-left:10px;"">contact_phone</i>
                            <label for=""icon_telephone"" style=""margin-left:50px; font-size:20px;""><i>İletişim Bilgileri</i></label>
                        </div>
                        <div class=""input-field col s4"">
                            <input placeholder=""E-mail"" id=""email"" type=""email"" class=""validate"" required>
                          ");
                    WriteLiteral(@"  <label for=""email"">Email</label>
                            <span class=""helper-text"" data-error=""Lütfen E-mail alanını doğru giriniz."" data-success=""Başarılı""></span>
                        </div>
                        <div class=""input-field col s4"">
                            <input type=""tel"" class=""validate"" id=""phone_number"" onkeypress=""return isNumberKey(event)"" placeholder=""5xx-xxx-xxxx"" pattern=""^\(?[0]?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"" maxlength=""12"" required>
                            <label for=""phone"">Telefon Numarası</label>
                            <span class=""helper-text"" data-error=""Lütfen Cep Telefonu alanını doğru giriniz."" data-success=""Başarılı""></span>
                        </div>
                    </div>
                </div>
                <div class=""form-group col-md-6"">
                    <button id=""btnSave"" type=""submit"" class=""btn btn-primary"">Gönder</button>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <script type=\"text/javascript\" src=\"js/materialize.min.js\"></script>\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e12827ab835b60795ec2126755d3e0aefb17d5016637", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>

        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }

        $(""#postForm"").submit(function (e) {
            e.preventDefault();
            console.log(e);
            var rezervasyon = {

                Name: $('#first_name').val(),
                Surname: $('#last_name').val(),
                Mail: $('#email').val(),
                PhoneNumber: $('#phone_number').val(),
                Tc: $('#tc').val()
            }
            console.log(rezervasyon);
            var myJSON = JSON.stringify(rezervasyon);
            $.ajax({
                url: 'https://localhost:44326/api/Rezervasyons',
                type: 'POST',
                contentType: ""application/json; charset=utf-8"",
                data: myJSON,
                success: function (gelenveri) {
              ");
                WriteLiteral(@"      alertify.success('Rezervasyonunuz başarıyla eklendi.');
                    $('input').val("""");
                },
                error: function (hata) {
                    alertify.error('Erişim Sağlanamadı.');
                }
            });
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
