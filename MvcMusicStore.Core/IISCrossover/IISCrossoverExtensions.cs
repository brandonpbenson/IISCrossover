﻿using Microsoft.AspNetCore.Authentication;

namespace MvcMusicStore.Core
{
    public static class IISCrossoverExtensions
    {
        public static AuthenticationBuilder AddIISCrossoverAuthentication(this AuthenticationBuilder builder)
            => builder.AddScheme<IISCrossoverAuthenticationSchemeOptions, IISCrossoverAuthenticationHandler>(IISCrossoverAuthenticationDefaults.AuthenticationScheme, op => { });

        public static IApplicationBuilder UseIISCrossoverSession(this IApplicationBuilder app)
            => app.UseMiddleware<IISCrossoverSessionMiddleware>();
    }
}