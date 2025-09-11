namespace CutterManagement.Web.Server
{
    /// <summary>
    /// An extension class for <see cref="WebApplication"/>
    /// </summary>
    public static class WebApplicationExtension
    {
        /// <summary>
        /// Configure all API endpoints
        /// </summary>
        /// <param name="app"></param>
        public static void ConfigureApiEndpoint(this WebApplication app)
        {
            // Configure endpoints here
            app.ConfigureUsersApiEndpoints();
            app.ConfigureCuttersApiEndpoints();
            app.ConfigureMachinesApiEndpoints();
            app.ConfigureUsersArchiveApiEndpoints();
            app.ConfigurePartsApiEndpoints();
            app.ConfigureCMMDataApiEndpoints();
            app.ConfigureInfoUpdateApiEndpoints();
            app.ConfigureProductionPartsLogApiEndpoints();
            app.ConfigureProductionPartsLogDataArchiveApiEndpoints();
        }

        public static void MapGetEndpoint<T>(this WebApplication app, string endPoint) where T : class
        {
            app.MapGet(endPoint, async (IServiceProvider serviceProvider) =>
            {
                var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
                var table = factory.GetDbTable<T>();
                return Results.Ok(await table.GetAllEntitiesAsync());
            });
        }

        public static void MapPostEndpoint<T>(this WebApplication app, string endPoint) where T : class
        {
            app.MapPost(endPoint, async (IServiceProvider serviceProvider, [FromBody] T entity) =>
            {
                var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
                var table = factory.GetDbTable<T>();
                await table.CreateNewEntityAsync(entity);
                return Results.Ok();
            });
        }

        public static void MapPutEndpoint<T>(this WebApplication app, string endPoint) where T : class
        {
            app.MapPut(endPoint, async (IServiceProvider serviceProvider, [FromBody] T entity) =>
            {
                var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
                var table = factory.GetDbTable<T>();
                await table.SaveEntityAsync(entity);
                return Results.Ok();
            });
        }

        //public static void MapDeleteEndpoint<T>(this WebApplication app, string endPoint) where T : class
        //{
        //    app.MapDelete(endPoint, async (IServiceProvider serviceProvider, [FromBody] T entity) =>
        //    {
        //        var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
        //        var table = factory.GetDbTable<T>();
        //        await table.DeleteEntityAsync(entity);
        //        return Results.Ok();
        //    });
        //}

        public static void MapDeleteEndpoint<T>(this WebApplication app, string endPoint) where T : class
        {
            app.MapDelete($"{endPoint}/{{id}}", async (IServiceProvider serviceProvider, int id) =>
            {
                var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
                var table = factory.GetDbTable<T>();
                var entity = await table.GetEntityByIdAsync(id);
                if(entity is null)
                {
                    return Results.NotFound();
                }
                await table.DeleteEntityAsync(entity);
                return Results.Ok();
            });
        }

        public static void MapGetByIdEndpoint<T>(this WebApplication app, string endPoint) where T : class
        {
            app.MapGet($"{endPoint}/{{id}}", async (IServiceProvider serviceProvider, int id) =>
            {
                var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
                var table = factory.GetDbTable<T>();
                var entity = await table.GetEntityByIdAsync(id);
                return entity is not null ? Results.Ok(entity) : Results.NotFound();
            });
        }

        //public static void MapGetWithNavPropertiesByIdEndpoint<T, TProperty>(this WebApplication app, string endPoint) where T : class where TProperty : class
        //{
        //    app.MapGet($"{endPoint}/{{id}}/with-nav", async (IServiceProvider serviceProvider, int id) =>
        //    {
        //        var factory = serviceProvider.GetRequiredService<IDataAccessServiceFactory>();
        //        var table = factory.GetDbTable<T>();
        //        var entity = await table.GetEntityWithCollectionsByIdAsync(id, e => (ICollection<TProperty>)typeof(T).GetProperty(typeof(TProperty).Name)!.GetValue(e)!);
        //        return entity is not null ? Results.Ok(entity) : Results.NotFound();
        //    });
        //}
    }
}
