﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Domain.Apps.Core.Apps;

namespace Squidex.Pipeline
{
    public sealed class MustBeAppReaderAttribute : AppPermissionAttribute
    {
        public MustBeAppReaderAttribute()
            : base(AppPermission.Reader)
        {
        }
    }
}
