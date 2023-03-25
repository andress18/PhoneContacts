﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PhoneContacts.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class PhoneContactsDbContextFactory : IDesignTimeDbContextFactory<PhoneContactsDbContext>
{
    public PhoneContactsDbContext CreateDbContext(string[] args)
    {
        PhoneContactsEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PhoneContactsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new PhoneContactsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../PhoneContacts.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
