var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.FantasyFootballApi_Service>("fantasyfootballapi-service");

builder.Build().Run();
