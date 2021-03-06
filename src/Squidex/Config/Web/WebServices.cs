﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Microsoft.Extensions.DependencyInjection;
using Squidex.Config.Domain;
using Squidex.Pipeline;

namespace Squidex.Config.Web
{
    public static class WebServices
    {
        public static void AddMyMvc(this IServiceCollection services)
        {
            services.AddSingletonAs<FileCallbackResultExecutor>()
                .AsSelf();

            services.AddSingletonAs<AppApiFilter>()
                .AsSelf();

            services.AddSingletonAs<ApiCostsFilter>()
                .AsSelf();

            services.AddSingletonAs<EnforceHttpsMiddleware>()
                .AsSelf();

            services.AddSingletonAs<LocalCacheMiddleware>()
                .AsSelf();

            services.AddSingletonAs<RequestLogPerformanceMiddleware>()
                .AsSelf();

            services.AddMvc(options =>
            {
                options.Filters.Add<ETagFilter>();
            }).AddMySerializers();

            services.AddCors();
            services.AddRouting();
        }
    }
}
