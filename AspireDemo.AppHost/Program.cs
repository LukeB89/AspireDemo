var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.AspireDemo_ApiService>("apiservice");

builder.AddProject<Projects.AspireDemo_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
