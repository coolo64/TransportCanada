#pragma checksum "C:\Users\Luc\source\repos\coolo64\TransportCanada\API1\TransportCanada\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d58f01d26137a6c8a95e529a6bd47cc1ce017e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
#line 1 "C:\Users\Luc\source\repos\coolo64\TransportCanada\API1\TransportCanada\Views\_ViewImports.cshtml"
using TransportCanada;

#line default
#line hidden
#line 2 "C:\Users\Luc\source\repos\coolo64\TransportCanada\API1\TransportCanada\Views\_ViewImports.cshtml"
using TransportCanada.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d58f01d26137a6c8a95e529a6bd47cc1ce017e6", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa5294984372d6b02db8341beadbf4addc0f502", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 5990, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3da93a135ff460f9d2299ad7fddb808", async() => {
                BeginContext(33, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>index</title>\r\n    ");
                EndContext();
                BeginContext(124, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "553cdd426ebd43a9ae400567e952be35", async() => {
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
                EndContext();
                BeginContext(199, 180, true);
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        .api{\r\n            border: 1px solid black;\r\n        }\r\n\r\n        .api > div {\r\n            padding: 10px;\r\n        }\r\n    </style>\r\n\r\n    ");
                EndContext();
                BeginContext(379, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdaeff27f08840ae91a18d309fce9327", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(430, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(436, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ab8fa478ab48dd953599a96140ea52", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(496, 5514, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var contenuFichierAPI1;

        var fichierJson = null;

        /**
         * Cache tous les DIVs sauf celle qui est nommé dans api
         * param api L'id du DIV à faire apparaitre
         */
        function show(api) {
            $(""#instruction"").hide();
            $(""#API1"").hide();
            $(""#API2"").hide();
            $(""#API3"").hide();
            $(""#"" + api).show();
        }

        /**
         * Crée un fichier JSON téléchargeable ensuite exécute le téléchargement
         * param Json Un object JSON à ajouter au fichier
         * param api Le nom du API exécuté
         */
        function telechargerJson(json, api) {
            console.log(json);
            console.log(JSON.stringify(json));
            var data = new Blob([JSON.stringify(json)], { type: ""application/json"" });

            if (fichierJson !== null) {
                window.URL.revokeObjectURL(fichierJson);
            }

            fi");
                WriteLiteral(@"chierJson = window.URL.createObjectURL(data);
            var a = document.createElement(""a"");
            a.setAttribute(""download"", ""CSCompVehicleRecall"" + api + "".json"");
            a.href = fichierJson;
            document.body.appendChild(a);

            // attendre pour que le lien soit ajouté au document
            window.requestAnimationFrame(function () {
                var event = new MouseEvent('click');
                a.dispatchEvent(event);
                document.body.removeChild(a);
            });
        }

        /**
         * Crée un tableau pour démontrer les données apparaissant dans le JSON
         * param data le JSON à démontrer
         * param api Le nom du API ou ajouter les rangées au tableau
         */
        function visionnerLeTableau(data, api) {
            //console.log(data);

            var table = $(""#"" + api).children().last().children().first();
            table.html("""");
            var propriete = [];
            for (var i = 0; i");
                WriteLiteral(@" < data.length; ++i) {
                for (var k in data[i]) {
                    if (!propriete.find(x => x == k)) {
                        propriete.push(k);
                    }
                }
            }

            var tr = document.createElement(""tr"");
            for (var j = 0; j < propriete.length; ++j) {
                var th = document.createElement(""th"");
                th.innerHTML = propriete[j];
                tr.appendChild(th);
            }
            table.append(tr);

            for (var i = 0; i < data.length; ++i) {
                tr = document.createElement(""tr"");
                for (var j = 0; j < propriete.length; ++j) {
                    var th = document.createElement(""th"");
                    th.innerHTML = data[i][propriete[j]];
                    tr.appendChild(th);
                }
                table.append(tr);
            }
        }


        /**
         * Exécute un POST au URL définit dans le champs #urlAPI1, le corps d");
                WriteLiteral(@"u post contient le contenu d'un fichier JSON ajouté au champs #fichierAPI1
         */
        function postAPI1() {
            console.log(""POST API1"");
            $(""#btnAPI1"").attr(""disabled"", ""true"");

            $(""#postResultAPI1"").text(""En cours d'exécution."");

            url = $(""#urlAPI1"").val();
            $.ajax({
                type: ""POST"",
                contentType: ""application/json"",
                url: url,
                data: contenuFichierAPI1,
                success: function () {
                    $(""#postResultAPI1"").text(""Succès"");
                }
            }).fail(function (data) {
                $(""#postResultAPI1"").text(""Erreur : "" + data);
            });
        }

        /**
         * exécute un GET au URL définit dans le champs #urlAPI1 avec un filtre définit par #filtreAPI1
         * param type Détermine la méthode qui sera exécuté après le GET
         */
        function getAPI1(type) {
            console.log(""GET API1"");

 ");
                WriteLiteral(@"           $(""#btnDownloadAPI1"").attr(""disabled"", ""true"");
            $(""#btnVisionnerAPI1"").attr(""disabled"", ""true"");

            url = $(""#urlAPI1"").val() + ""?manRecalNo="" + $(""#filtreAPI1"").val();
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (data) {
                    if (type == ""download"") {
                        telechargerJson(data, ""API1"");
                    }
                    else {
                        visionnerLeTableau(data, ""API1"");
                    }
                    $(""#btnDownloadAPI1"").removeAttr(""disabled"");
                    $(""#btnVisionnerAPI1"").removeAttr(""disabled"");
                }
            });
        }


        //Ajouter les valeurs par défaut
        $(document).ready(function () {
            show(""instruction"");
            $(""#btnAPI1"").attr(""disabled"", ""true"");

            //Lire les données du fichier entrant
            $(""#fichierAPI1"").on('change', event =");
                WriteLiteral(@"> {
                var file = event.target.files[0];
                var reader = new FileReader();
                reader.addEventListener('load', event => {
                    contenuFichierAPI1 = event.target.result;
                    $(""#btnAPI1"").removeAttr(""disabled"");
                });
                reader.readAsText(file);
            });
        });
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(6017, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(6019, 2119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86ec7371187143f1bf58e9425342b1a9", async() => {
                BeginContext(6025, 2106, true);
                WriteLiteral(@"
    <div class=""container"" style=""padding-top: 10px;"">
        <div class=""row justify-content-around"" style=""margin-bottom: 10px;"">
            <button class=""col-3 btn btn-primary"" role=""button"" onclick=""show('API1')"">API 1</button>
            <button class=""col-3 btn btn-primary"" role=""button"" onclick=""show('API2')"">API 2</button>
            <button class=""col-3 btn btn-primary"" role=""button"" onclick=""show('API3')"">API 3</button>
        </div>
        <div class=""row"" id=""instruction"">
            Veuillez cliquer sur un des API ci-haut.
        </div>



        <div class=""row api"" id=""API1"">
            <div class=""col"">
                <input type=""text"" class=""form-control"" id=""urlAPI1"" value=""API1/index"" />
            </div>
            <div class=""w-100""></div>
            <div class=""col-8"">
                <input class=""form-control"" type=""file"" id=""fichierAPI1""  accept="".json"" />
            </div>
            <div class=""col"">
                <button class=""btn btn-sec");
                WriteLiteral(@"ondary"" id=""btnAPI1"" onclick=""postAPI1()"">POST &agrave; API 1</button>
                <span id=""postResultAPI1""></span>
            </div>
            <div class=""w-100""></div>
            <div class=""col-8"">
                <input type=""text"" class=""form-control"" id=""filtreAPI1"" placeholder=""Rechercher par numéro de rappel du fabricant, laisser vide pour tous les résultats"" />
            </div>
            <div class=""col"">
                <button class=""btn btn-secondary"" id=""btnDownloadAPI1"" onclick=""getAPI1('download')"">T&eacute;l&eacute;charger le JSON</button>
                <button class=""btn btn-secondary"" id=""btnVisionnerAPI1"" onclick=""getAPI1('visionner')"">Visionner les données</button>
            </div>
            <div class=""w-100""></div>
            <div class=""col"">
                <table class=""table"">

                </table>
            </div>
        </div>



        <div class=""row api"" id=""API2"">
            2
        </div>



        <div class=""row api""");
                WriteLiteral(" id=\"API3\">\r\n            3\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(8138, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
