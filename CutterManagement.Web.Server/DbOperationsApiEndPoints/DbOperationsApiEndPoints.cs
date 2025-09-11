namespace CutterManagement.Web.Server
{
    /// <summary>
    /// Configures all API endpoints for database operations for all data models
    /// </summary>
    public static class DbOperationsApiEndPoints
    {
        /// <summary>
        /// User API endpoints
        /// </summary>
        public static void ConfigureUsersApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<UserDataModel>("UserDataModel");
            app.MapPostEndpoint<UserDataModel>("UserDataModel");
            app.MapPutEndpoint<UserDataModel>("UserDataModel");
            app.MapDeleteEndpoint<UserDataModel>("UserDataModel");
            app.MapGetByIdEndpoint<UserDataModel>("UserDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<UserDataModel, object>("UserDataModel");
        }

        /// <summary>
        /// Cutter API endpoints
        /// </summary>
        public static void ConfigureCuttersApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<CutterDataModel>("CutterDataModel");
            app.MapPostEndpoint<CutterDataModel>("CutterDataModel");
            app.MapPutEndpoint<CutterDataModel>("CutterDataModel");
            app.MapDeleteEndpoint<CutterDataModel>("CutterDataModel");
            app.MapGetByIdEndpoint<CutterDataModel>("CutterDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<CutterDataModel, object>("CutterDataModel");
        }

        /// <summary>
        /// Machine API endpoints
        /// </summary>
        public static void ConfigureMachinesApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<MachineDataModel>("MachineDataModel");
            app.MapPostEndpoint<MachineDataModel>("MachineDataModel");
            app.MapPutEndpoint<MachineDataModel>("MachineDataModel");
            app.MapDeleteEndpoint<MachineDataModel>("MachineDataModel");
            app.MapGetByIdEndpoint<MachineDataModel>("MachineDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<MachineDataModel, object>("MachineDataModel");
        }

        /// <summary>
        /// User data-archive API endpoints
        /// </summary>
        public static void ConfigureUsersArchiveApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<UserDataArchive>("UserDataArchive");
            app.MapPostEndpoint<UserDataArchive>("UserDataArchive");
            app.MapPutEndpoint<UserDataArchive>("UserDataArchive");
            app.MapDeleteEndpoint<UserDataArchive>("UserDataArchive");
            app.MapGetByIdEndpoint<UserDataArchive>("UserDataArchive");
            //app.MapGetWithNavPropertiesByIdEndpoint<UserDataArchive, object>("UserDataArchive");
        }

        /// <summary>
        /// Part API endpoints
        /// </summary>
        public static void ConfigurePartsApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<PartDataModel>("PartDataModel");
            app.MapPostEndpoint<PartDataModel>("PartDataModel");
            app.MapPutEndpoint<PartDataModel>("PartDataModel");
            app.MapDeleteEndpoint<PartDataModel>("PartDataModel");
            app.MapGetByIdEndpoint<PartDataModel>("PartDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<PartDataModel, object>("PartDataModel");
        }

        /// <summary>
        /// CMM-data API endpoints
        /// </summary>
        public static void ConfigureCMMDataApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<CMMDataModel>("CMMDataModel");
            app.MapPostEndpoint<CMMDataModel>("CMMDataModel");
            app.MapPutEndpoint<CMMDataModel>("CMMDataModel");
            app.MapDeleteEndpoint<CMMDataModel>("CMMDataModel");
            app.MapGetByIdEndpoint<CMMDataModel>("CMMDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<CMMDataModel, object>("CMMDataModel");
        }

        /// <summary>
        /// Information updates API endpoints
        /// </summary>
        public static void ConfigureInfoUpdateApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<InfoUpdateDataModel>("InfoUpdateDataModel");
            app.MapPostEndpoint<InfoUpdateDataModel>("InfoUpdateDataModel");
            app.MapPutEndpoint<InfoUpdateDataModel>("InfoUpdateDataModel");
            app.MapDeleteEndpoint<InfoUpdateDataModel>("InfoUpdateDataModel");
            app.MapGetByIdEndpoint<InfoUpdateDataModel>("InfoUpdateDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<InfoUpdateDataModel, object>("InfoUpdateDataModel");
        }

        /// <summary>
        /// Prod. parts-log API endpoints
        /// </summary>
        public static void ConfigureProductionPartsLogApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<ProductionPartsLogDataModel>("ProductionPartsLogDataModel");
            app.MapPostEndpoint<ProductionPartsLogDataModel>("ProductionPartsLogDataModel");
            app.MapPutEndpoint<ProductionPartsLogDataModel>("ProductionPartsLogDataModel");
            app.MapDeleteEndpoint<ProductionPartsLogDataModel>("ProductionPartsLogDataModel");
            app.MapGetByIdEndpoint<ProductionPartsLogDataModel>("ProductionPartsLogDataModel");
            //app.MapGetWithNavPropertiesByIdEndpoint<ProductionPartsLogDataModel, object>("ProductionPartsLogDataModel");
        }

        /// <summary>
        /// Prod. parts-log data-archive API endpoints
        /// </summary>
        public static void ConfigureProductionPartsLogDataArchiveApiEndpoints(this WebApplication app)
        {
            app.MapGetEndpoint<ProductionPartsLogDataArchive>("ProductionPartsLogDataArchive");
            app.MapPostEndpoint<ProductionPartsLogDataArchive>("ProductionPartsLogDataArchive");
            app.MapPutEndpoint<ProductionPartsLogDataArchive>("ProductionPartsLogDataArchive");
            app.MapDeleteEndpoint<ProductionPartsLogDataArchive>("ProductionPartsLogDataArchive");
            app.MapGetByIdEndpoint<ProductionPartsLogDataArchive>("ProductionPartsLogDataArchive");
            //app.MapGetWithNavPropertiesByIdEndpoint<ProductionPartsLogDataArchive, object>("ProductionPartsLogDataArchive");
        }

    }
}
