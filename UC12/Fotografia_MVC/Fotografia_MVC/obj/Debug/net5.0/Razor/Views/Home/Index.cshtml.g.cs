#pragma checksum "C:\Users\gisla\source\repos\Fotografia_MVC\Fotografia_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab9e9d4f5115996a3a963ff5f1ed2dbdf4b1accc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gisla\source\repos\Fotografia_MVC\Fotografia_MVC\Views\_ViewImports.cshtml"
using Fotografia_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gisla\source\repos\Fotografia_MVC\Fotografia_MVC\Views\_ViewImports.cshtml"
using Fotografia_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab9e9d4f5115996a3a963ff5f1ed2dbdf4b1accc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25bd932a98aad3cdf6cffbd4646a1afbd2c8f91d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gisla\source\repos\Fotografia_MVC\Fotografia_MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <h1 class=""tituloport"">Portifólio</h1>
    <h5 class=""tituloport"">Fotos estúdio</h5>
    <section>
        <div id=""divisaoCarrosel"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#divisaoCarrosel"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#divisaoCarrosel"" data-slide-to=""1""></li>
                <li data-target=""#divisaoCarrosel"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""d-block w-100"" src=""http://lorempixel.com/1920/780/"" alt=""Primeiro Slide"">
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""http://lorempixel.com/1920/780/"" alt=""Segundo Slide"">
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""http://lorempixel.com/");
            WriteLiteral(@"1920/780/"" alt=""Terceiro Slide"">
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""http://lorempixel.com/1920/780/"" alt=""TerceibtrbSlide"">
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#divisaoCarrosel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Anterior</span>
            </a>
            <a class=""carousel-control-next"" href=""#divisaoCarrosel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Próximo</span>
            </a>
        </div>
    </section>
</div>
<!-- Divisão do Carousel de fotos do estúdio-->
<section id=""botoes"">
    <!-- Galeria com botões -->
    <div id=""carouselMultiItemExample"" class=""carousel slide carousel-dark text-center"" data-mdb-ride=");
            WriteLiteral(@"""carousel"">
        <h1 class=""tituloport"">Ensaios</h1>
        <div class=""carousel-inner py-4"" style=""font-family: 'Merienda one', cursive"">
            <!-- Primeiro Item -->
            <div class=""carousel-item active"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-4 mt-3"">
                            <div class=""card"">
                                <img src=""img/b2.jpg""
                                     class=""card-img-top""
                                     alt=""Ensaio New Born"" />
                                <div class=""card-body"" id=""arrumaTexto"">
                                    <h5 class=""card-title"">New Born</h5>
                                    <p class=""card-text"">
                                        O Ensaio Newborn é uma alternativa para quem procura registrar os primeiros dias do bebê. <br>
                                        Pode ser feito no estúdio (Newborn Clássico) ou em ca");
            WriteLiteral(@"sa (Newborn Natural/Lifestyle).
                                    </p>
                                </div>
                            </div>
                        </div>
                        <!-- Segundo Item -->
                        <div class=""col-lg-4 d-lg-block mt-3"">
                            <div class=""card"">
                                <img src=""img/g1.jpg""
                                     class=""card-img-top""
                                     alt=""Ensaio Gravidez"" />
                                <div class=""card-body"" id=""arrumaTexto"">
                                    <h5 class=""card-title"">Gravidez</h5>
                                    <p class=""card-text"">
                                        Ao passo que a gestação vai passando, a barriga cresce e queremos
                                        logo ter nossos bebês em nosso colo. E nada mais lindo do que ter as fotos da gravidez.
                                        É um momento muito esp");
            WriteLiteral(@"ecial para a maternidade.
                                    </p>
                                </div>
                            </div>
                        </div>
                        <!-- Terceiro Item -->
                        <div class=""col-lg-4 d-lg-block mt-3"">
                            <div class=""card"">
                                <img src=""img/f1.jpg""
                                     class=""card-img-top""
                                     alt=""Ensaio Feminino"" />
                                <div class=""card-body"" id=""arrumaTexto"">
                                    <h5 class=""card-title"">Feminina</h5>
                                    <p class=""card-text"">
                                        Acredito que o ensaio feminino possa ser a maneira da mulher de se apaixonar
                                        por ela mesma todas as vezes que revisitar as imagens. Você, mulher, já parou
                                        para pensar qual fase da v");
            WriteLiteral(@"ida ou momento gostaria de eternizar?
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--FIM da galeria com botões-->
<div class=""container mb-3"">
    <div class=""row"">
        <div class=""col-lg-12 text-center my-2"" style=""font-family: 'Merienda One', cursive"">
            <h4 style=""font-size: 50px"">Galeria</h4>
        </div>
    </div>
    <div class=""portfolio-item row"">
        <div class=""item selfie col-lg-3 col-md-4 col-6 col-sm mb-3"">
            <a href=""img/b1.jpg"" class=""fancylight popup-btn"" data-fancybox-group=""light"">
                <img class=""img-fluid"" src=""img/b1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5986, "\"", 5992, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"item gts col-lg-3 col-md-4 col-6 col-sm\">\r\n            <a href=\"img/fh1.jpg\" class=\"fancylight popup-btn\" data-fancybox-group=\"light\">\r\n                <img class=\"img-fluid\" src=\"img/fh1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6242, "\"", 6248, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"item selfie col-lg-3 col-md-4 col-6 col-sm\">\r\n            <a href=\"img/f1.jpg\" class=\"fancylight popup-btn\" data-fancybox-group=\"light\">\r\n                <img class=\"img-fluid\" src=\"img/f1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6499, "\"", 6505, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"item gts col-lg-3 col-md-4 col-6 col-sm\">\r\n            <a href=\"img/hg1.jpg\" class=\"fancylight popup-btn\" data-fancybox-group=\"light\">\r\n                <img class=\"img-fluid\" src=\"img/hg1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6755, "\"", 6761, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>
        <div style=""display:flex;justify-content:center;"">
            <div class=""item gts col-lg-3 col-md-4 col-6 col-sm"">
                <a href=""img/hg3.jpg"" class=""fancylight popup-btn"" data-fancybox-group=""light"">
                    <img class=""img-fluid"" src=""img/hg3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7083, "\"", 7089, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </a>
            </div>
            <div class=""item gts col-lg-3 col-md-4 col-6 col-sm"">
                <a href=""img/b2.jpg"" class=""fancylight popup-btn"" data-fancybox-group=""light"">
                    <img class=""img-fluid"" src=""img/b2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7357, "\"", 7363, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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