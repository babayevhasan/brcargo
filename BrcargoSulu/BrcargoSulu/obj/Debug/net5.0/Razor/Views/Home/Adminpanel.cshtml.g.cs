#pragma checksum "C:\Users\Hasan\Desktop\brcargo\BrcargoSulu\BrcargoSulu\Views\Home\Adminpanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c443168ee42fb8f3ac9cfd410217e7fe43ae4d95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Adminpanel), @"mvc.1.0.view", @"/Views/Home/Adminpanel.cshtml")]
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
#line 1 "C:\Users\Hasan\Desktop\brcargo\BrcargoSulu\BrcargoSulu\Views\_ViewImports.cshtml"
using BrcargoSulu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hasan\Desktop\brcargo\BrcargoSulu\BrcargoSulu\Views\_ViewImports.cshtml"
using BrcargoSulu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c443168ee42fb8f3ac9cfd410217e7fe43ae4d95", @"/Views/Home/Adminpanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c5bc46ac014e0ffb2ec0e87031c778eea20262", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Adminpanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hasan\Desktop\brcargo\BrcargoSulu\BrcargoSulu\Views\Home\Adminpanel.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c443168ee42fb8f3ac9cfd410217e7fe43ae4d953518", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""/css/site.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css""
          integrity=""sha512-iecdLmaskl7CVkqkXNQ/ZH/XLlvWZOJyj7Yy7tcenmpD1ypASozpmT/E0iPtmFIB46ZmdtAc9eNBvH0H/ZpiBw==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link href=""https://fonts.googleapis.com/css2?family=Mynerve&family=Poppins:wght@300&display=swap"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.0/slick.min.css"" />
    <link href=""https://cdn.jsdelivr.net/npm/remixicon@2.5.0/fonts/remixicon.css"" rel=""stylesheet"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />
    <title>www.brcargo..com</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c443168ee42fb8f3ac9cfd410217e7fe43ae4d955495", async() => {
                WriteLiteral(@"

    <!-- Part Of NavBar START -->
    <header>
        <div class=""container"">
            <nav class=""navbar"">
                <a href=""/home/Index"" class=""nav-branding"">BRcargo</a>
                <ul class=""nav-menu"">
                    <li class=""nav-item"">
                        <a href=""/home/Index"" class=""nav-link"">
                            Ana Səhifə
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/home/Xidmetler"" class=""nav-link"">Xidmətlər</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/home/Rates"" class=""nav-link"">Tariflər</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/home/Magazine"" class=""nav-link"">Mağazalar</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/home/About"" class=""nav-link"">Haqqımızda</a>
                ");
                WriteLiteral(@"    </li>
                    <li class=""nav-item"">
                        <a href=""/home/Login"" class=""nav-link"">Giriş</i></a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/home/Admin"" class=""nav-link"">Admin</i></a>
                    </li>
                </ul>
                <div class=""hamburger"">
                    <span class=""bar""></span>
                    <span class=""bar""></span>
                    <span class=""bar""></span>
                </div>
            </nav>
        </div>
    </header>

    <section class=""admin-panel"">

        <div class=""admin-panel-left"">
            <div class=""admin-panel-left-profil"">
                <div>
                    <img src=""https://i.pinimg.com/originals/d4/74/1c/d4741cb779ddec6509ca1ae0cb137a7d.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 2930, "\"", 2936, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div>
                    <h3>Hasan Babayev</h3>
                    <p>ID:12345678</p>
                </div>
            </div>
            <div class=""admin-panel-left-li"">
                <ul>

                    <a href=""/home/Sifariset"">
                    <li><i class=""fa-solid fa-truck""></i> Sifariş et</li>
                    </a>
                    <a href=""/home/Baglamalar"">
                    <li><i class=""fa-solid fa-truck-ramp-box""></i> Bağlamalarım</li>
                    </a>
                    <a href=""/home/Balance"">
                    <li><i class=""fa-solid fa-scale-balanced""></i> Balans</li>
                    </a>
                    <a href=""/home/Settings"">
                    <li><i class=""fa-solid fa-gear""></i> Tənzimləmələr</li>
                    </a>
                    <a href=""/home/Notifications"">
                    <li><i class=""fa-solid fa-message""></i> Bildirişlər</li>
                    </a>
       ");
                WriteLiteral(@"             <a href=""/home/Adminpanel"">
                    <li><i class=""fa-solid fa-screwdriver-wrench""></i> Admin panel</li>
                    </a>
                    <a href=""/home/Adminidare"">
                    <li><i class=""fa-solid fa-lock""></i> Admin idarə etmə</li>
                    </a>
                    <a href=""/home/Admintesdiq"">
                    <li><i class=""fa-solid fa-ticket""></i> Admin təsdiq</li>
                    </a>

                </ul>
            </div>

        </div>


        <div class=""adminpanel-container"">
            <table>
                <thead>
                    <tr>
                        <th>Ad</th>
                        <th>Soyad</th>
                        <th>Mail</th>
                        <th>Nömrə</th>
                        <th>Edit</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Miri</td>
                        <td>Tagiyev</");
                WriteLiteral(@"td>
                        <td>miri.tagiyev@gmail.com</td>
                        <td>+994507734303</td>
                        <td><button>Blok</button></td>
                    </tr>
                    <tr>
                        <td>Hesen</td>
                        <td>Babayev</td>
                        <td>hesen.babayev@gmail.com</td>
                        <td>+994502000102</td>
                        <td><button>Blok</button></td>
                    </tr>
                </tbody>
            </table>

        </div>



    </section>



    <script src=""kargo.js""></script>
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
            WriteLiteral("\r\n\r\n");
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
