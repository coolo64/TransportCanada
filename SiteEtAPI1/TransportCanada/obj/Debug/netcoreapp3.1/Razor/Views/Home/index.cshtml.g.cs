#pragma checksum "C:\Users\Luc\source\repos\coolo64\TransportCanada\SiteEtAPI1\TransportCanada\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fce0eacb3ba2c704cd757b37230792bb81d12ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
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
#line 1 "C:\Users\Luc\source\repos\coolo64\TransportCanada\SiteEtAPI1\TransportCanada\Views\_ViewImports.cshtml"
using TransportCanada;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luc\source\repos\coolo64\TransportCanada\SiteEtAPI1\TransportCanada\Views\_ViewImports.cshtml"
using TransportCanada.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fce0eacb3ba2c704cd757b37230792bb81d12ff", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa5294984372d6b02db8341beadbf4addc0f502", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fce0eacb3ba2c704cd757b37230792bb81d12ff4943", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>index</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fce0eacb3ba2c704cd757b37230792bb81d12ff5298", async() => {
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
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        .api{\r\n            margin: 5px;\r\n            border: 1px solid black;\r\n        }\r\n\r\n        .api > div {\r\n            padding: 10px;\r\n        }\r\n    </style>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fce0eacb3ba2c704cd757b37230792bb81d12ff6702", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fce0eacb3ba2c704cd757b37230792bb81d12ff7801", async() => {
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
                WriteLiteral(@"
    <script type=""text/javascript"">
        var contenuFichierAPI1;
        var contenuFichierAPI3;

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
                window.URL.revokeObjectURL(fichierJson);");
                WriteLiteral(@"
            }

            fichierJson = window.URL.createObjectURL(data);
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
            var propriete = [");
                WriteLiteral(@"];
            for (var i = 0; i < data.length; ++i) {
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
         * Exécute un POST au URL définit da");
                WriteLiteral(@"ns le champs #urlAPI1, le corps du post contient le contenu d'un fichier JSON ajouté au champs #fichierAPI1
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
         * Exécute un POST au URL définit dans le champs #urlAPI3, le corps du post contient le contenu d'un fichier JSON ajouté au champs #fichierAPI3
         */
        function postAPI3() {
            console.log(""POST API3""");
                WriteLiteral(@");
            $(""#btnAPI3"").attr(""disabled"", ""true"");

            $(""#postResultAPI3"").text(""En cours d'exécution."");

            url = $(""#urlAPI3"").val();
            $.ajax({
                type: ""POST"",
                contentType: ""application/json"",
                url: url,
                data: contenuFichierAPI3,
                success: function () {
                    $(""#postResultAPI3"").text(""Succès"");
                }
            }).fail(function (data) {
                $(""#postResultAPI3"").text(""Erreur : "" + data);
            });
        }

        /**
         * exécute un GET au URL définit dans le champs #urlAPI1 avec un filtre définit par #filtreAPI1
         * param type Détermine la méthode qui sera exécuté après le GET
         */
        function getAPI1(type) {
            console.log(""GET API1"");

            $(""#btnDownloadAPI1"").attr(""disabled"", ""true"");
            $(""#btnVisionnerAPI1"").attr(""disabled"", ""true"");

            url = $(""#urlAPI1"")");
                WriteLiteral(@".val() + ""?manRecalNo="" + $(""#filtreAPI1"").val();
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


        /**
         * exécute un GET au URL définit dans le champs #urlAPI3 avec un filtre définit par #filtreAPI3
         * param type Détermine la méthode qui sera exécuté après le GET
         */
        function getAPI3(type) {
            console.log(""GET API3"");

            $(""#btnDownloadAPI3"").attr(""disabled"", ""true"");
            $(""#btnVisionnerAPI3"").attr(""disabled"", ""true"");

            url = $(""#ur");
                WriteLiteral(@"lAPI3"").val() + ""/SystemType/"" + $(""#filtreAPI3"").val();
            $.ajax({
                type: ""GET"",
                url: url,
                success: function (data) {
                    if (type == ""download"") {
                        telechargerJson(data, ""API3"");
                    }
                    else {
                        visionnerLeTableau(data, ""API3"");
                    }
                    $(""#btnDownloadAPI3"").removeAttr(""disabled"");
                    $(""#btnVisionnerAPI3"").removeAttr(""disabled"");
                }
            });
        }


        //Ajouter les valeurs par défaut
        $(document).ready(function () {
            show(""instruction"");
            $(""#btnAPI1"").attr(""disabled"", ""true"");
            $(""#btnAPI3"").attr(""disabled"", ""true"");

            //Ajouter l'url du API 1 (intégré)
            $(""#urlAPI1"").val(""");
#nullable restore
#line 217 "C:\Users\Luc\source\repos\coolo64\TransportCanada\SiteEtAPI1\TransportCanada\Views\Home\index.cshtml"
                           Write(Context.Request.PathBase);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/API1/index"");

            //Ajouter l'url du API 3 (intégré)
            $(""#urlAPI3"").val(""/API3/tc/API3"");


            //Lire les données du fichier entrant
            $(""#fichierAPI1"").on('change', event => {
                            var file = event.target.files[0];
                        var reader = new FileReader();
                        reader.addEventListener('load', event => {
                            contenuFichierAPI1 = event.target.result;
                    $(""#btnAPI1"").removeAttr(""disabled"");
                    });
                reader.readAsText(file);
            });

            $(""#fichierAPI3"").on('change', event => {
                var file = event.target.files[0];
                var reader = new FileReader();
                reader.addEventListener('load', event => {
                    contenuFichierAPI3 = event.target.result;
                    $(""#btnAPI3"").removeAttr(""disabled"");
                });
                reader.readAsText(file)");
                WriteLiteral(";\r\n            });\r\n        });\r\n    </script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fce0eacb3ba2c704cd757b37230792bb81d12ff18455", async() => {
                WriteLiteral(@"
    <div class=""container-fluid"" style=""padding-top: 10px;"">
        <div class=""row justify-content-around"" style=""margin-bottom: 10px;"">
            <button class=""col-3 btn btn-primary"" role=""button"" onclick=""show('API1')"">API 1</button>
            <button class=""col-3 btn btn-primary"" role=""button"" onclick=""show('API2')"">API 2</button>
            <button class=""col-3 btn btn-primary"" role=""button"" onclick=""show('API3')"">API 3</button>
        </div>
        <div class=""row api"" id=""instruction"">
            <div>
                Veuillez cliquer sur un des API ci-haut.
            </div>
        </div>



        <div class=""row api"" id=""API1"">
            <div class=""col"">
                <input type=""text"" class=""form-control"" id=""urlAPI1""");
                BeginWriteAttribute("value", " value=\"", 9462, "\"", 9470, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Lien au API"" />
            </div>
            <div class=""w-100""></div>
            <div class=""col-8"">
                <input class=""form-control"" type=""file"" id=""fichierAPI1""  accept="".json"" />
            </div>
            <div class=""col"">
                <button class=""btn btn-secondary"" id=""btnAPI1"" onclick=""postAPI1()"">POST &agrave; API 1</button>
                <span id=""postResultAPI1""></span>
            </div>
            <div class=""w-100""></div>
            <div class=""col-8"">
                <input type=""text"" class=""form-control"" id=""filtreAPI1"" placeholder=""Rechercher par numéro de rappel du fabricant, laisser vide pour tous les résultats"" />
            </div>
            <div class=""col"">
                <button class=""btn btn-secondary"" id=""btnDownloadAPI1"" onclick=""getAPI1('download')"">T&eacute;l&eacute;charger le JSON</button>
                <button class=""btn btn-secondary"" id=""btnVisionnerAPI1"" onclick=""getAPI1('visionner')"">Visionner les données</butto");
                WriteLiteral(@"n>
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



        <div class=""row api"" id=""API3"">
            <div class=""col"">
                <input type=""text"" class=""form-control"" id=""urlAPI3""");
                BeginWriteAttribute("value", " value=\"", 10916, "\"", 10924, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Lien au API"" />
            </div>
            <div class=""w-100""></div>
            <div class=""col-8"">
                <input class=""form-control"" type=""file"" id=""fichierAPI3"" accept="".json"" />
            </div>
            <div class=""col"">
                <button class=""btn btn-secondary"" id=""btnAPI3"" onclick=""postAPI3()"">POST &agrave; API 3</button>
                <span id=""postResultAPI3""></span>
            </div>
            <div class=""w-100""></div>
            <div class=""col-8"">
                <input type=""text"" class=""form-control"" id=""filtreAPI3"" placeholder=""Rechercher par type de système affecté, par exemple: Brakes"" />
            </div>
            <div class=""col"">
                <button class=""btn btn-secondary"" id=""btnDownloadAPI3"" onclick=""getAPI3('download')"">T&eacute;l&eacute;charger le JSON</button>
                <button class=""btn btn-secondary"" id=""btnVisionnerAPI3"" onclick=""getAPI3('visionner')"">Visionner les données</button>
            </div>
");
                WriteLiteral("            <div class=\"w-100\"></div>\r\n            <div class=\"col\">\r\n                <table class=\"table\">\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
