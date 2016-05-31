using System;
using System.Collections.Generic;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Publishing;
using Umbraco.Core.Services;

namespace Strona_RESET_Umbraco.Core
{
    public class OutputCacheResolverOnAfterItemPublished : ApplicationEventHandler
    {
        private static readonly Dictionary<ResetUmbracoContentTypesEnum, string[]> CacheKeys = new Dictionary
            <ResetUmbracoContentTypesEnum, string[]>
        {
            {ResetUmbracoContentTypesEnum.aktualnosciSzczegoly, new[] {"/home"}},
            {ResetUmbracoContentTypesEnum.galeria, new[] {"/galeria"}},
            {ResetUmbracoContentTypesEnum.galeriaSzczegoly, new[] {"/galeria"}},
            {ResetUmbracoContentTypesEnum.kontakt, new[] {"/kontakt"}},
            {ResetUmbracoContentTypesEnum.home, new[] {"/home"}},
            {ResetUmbracoContentTypesEnum.layout, new[] {"/layout"}},
            {ResetUmbracoContentTypesEnum.projekty, new[] {"/projekty"}},
            {ResetUmbracoContentTypesEnum.projektySzczegoly, new[] {"/projekty"}},
            {ResetUmbracoContentTypesEnum.ofertyPracy, new[] {"/oferty-pracy"}},
            {ResetUmbracoContentTypesEnum.kontaktNode, new[] {"/kontakt"}},
            {ResetUmbracoContentTypesEnum.ofertyPracyNode, new[] {"/oferty-pracy"}}
         };

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            ContentService.Published += ContentServicePublished;
            ContentService.UnPublished += ContentServiceUnPublished;
        }

        private static void ContentServicePublished(IPublishingStrategy sender, PublishEventArgs<IContent> args)
        {
            foreach (var node in args.PublishedEntities)
            {
                var publishedContentEnum = (ResetUmbracoContentTypesEnum)Enum.Parse(typeof (ResetUmbracoContentTypesEnum), node.ContentType.Alias);
                switch (publishedContentEnum)
                {
                    case ResetUmbracoContentTypesEnum.aktualnosciSzczegoly:
                        ClearRelatedCache(publishedContentEnum, umbraco.library.NiceUrl(node.Id));
                        ClearLazyNewsCache();
                        break;
                    case ResetUmbracoContentTypesEnum.galeriaSzczegoly:
                    case ResetUmbracoContentTypesEnum.projektySzczegoly:
                    case ResetUmbracoContentTypesEnum.kontaktNode:
                    case ResetUmbracoContentTypesEnum.ofertyPracyNode:
                        ClearRelatedCache(publishedContentEnum, umbraco.library.NiceUrl(node.Id));
                        break;
                    case ResetUmbracoContentTypesEnum.galeria:
                    case ResetUmbracoContentTypesEnum.home:
                    case ResetUmbracoContentTypesEnum.kontakt:
                    case ResetUmbracoContentTypesEnum.layout:
                    case ResetUmbracoContentTypesEnum.ofertyPracy:
                    case ResetUmbracoContentTypesEnum.projekty:
                        ClearRelatedCache(publishedContentEnum);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void ContentServiceUnPublished(IPublishingStrategy sender, PublishEventArgs<IContent> args)
        {
            foreach (var node in args.PublishedEntities)
            {
                var publishedContentEnum = (ResetUmbracoContentTypesEnum)Enum.Parse(typeof(ResetUmbracoContentTypesEnum), node.ContentType.Alias);
                switch (publishedContentEnum)
                {
                    case ResetUmbracoContentTypesEnum.aktualnosciSzczegoly:
                        ClearRelatedCache(publishedContentEnum);
                        ClearLazyNewsCache();
                        break;
                    case ResetUmbracoContentTypesEnum.galeriaSzczegoly:
                    case ResetUmbracoContentTypesEnum.projektySzczegoly:
                    case ResetUmbracoContentTypesEnum.kontaktNode:
                    case ResetUmbracoContentTypesEnum.ofertyPracyNode:
                        ClearRelatedCache(publishedContentEnum);
                        break;
                    case ResetUmbracoContentTypesEnum.galeria:
                    case ResetUmbracoContentTypesEnum.home:
                    case ResetUmbracoContentTypesEnum.kontakt:
                    case ResetUmbracoContentTypesEnum.layout:
                    case ResetUmbracoContentTypesEnum.ofertyPracy:
                    case ResetUmbracoContentTypesEnum.projekty:
                        ClearRelatedCache(publishedContentEnum);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private const string UmbraceLazyNewsControllerBaseUrl = "/umbraco/surface/Lazy/GetNews";


        private static void ClearRelatedCache(ResetUmbracoContentTypesEnum publishedContent, string childArg = null)
        {
            foreach (var key in CacheKeys[publishedContent])
            {
                HttpResponse.RemoveOutputCacheItem(key);
            }
            if (childArg != null && childArg != "#")
            {
                HttpResponse.RemoveOutputCacheItem(childArg);
            }
        }

        private static void ClearLazyNewsCache()
        {
            HttpResponse.RemoveOutputCacheItem(UmbraceLazyNewsControllerBaseUrl);
        }

        public enum ResetUmbracoContentTypesEnum
        {
            aktualnosciSzczegoly,
            galeria,
            galeriaSzczegoly,
            home,
            kontakt,
            layout,
            ofertyPracy,
            projekty,
            projektySzczegoly,
            kontaktNode,
            ofertyPracyNode
        }
    }
}
