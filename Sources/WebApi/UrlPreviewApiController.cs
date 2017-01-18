// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UrlPreviewApiController.cs" company="Colours B.V.">
//   © Colours B.V. 2015
// </copyright>
// <summary>
//   Defines the UrlPreviewApiController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Our.Umbraco.UrlPreview.WebApi
{
    using System.Collections.Generic;

    using global::Umbraco.Web.Editors;
    using global::Umbraco.Web.Mvc;

    /// <summary>
    /// The url preview api controller.
    /// </summary>
    [PluginController("OurUmbracoUrlPreview")]
    public class UrlPreviewApiController : UmbracoAuthorizedJsonController
    {
        /// <summary>
        /// The get urls.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<string> GetUrls(int id)
        {
            var urls = new List<string>();

            if (id > 0)
            {
                urls.Add(this.UmbracoContext.UrlProvider.GetUrl(id));
                urls.AddRange(this.UmbracoContext.UrlProvider.GetOtherUrls(id));
            }

            return urls;
        }
    }
}