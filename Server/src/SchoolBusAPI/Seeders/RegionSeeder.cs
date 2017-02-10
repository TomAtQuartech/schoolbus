﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SchoolBusAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SchoolBusAPI.Seeders
{
    public class RegionSeeder : Seeder<DbAppContext>
    {
        private string[] ProfileTriggers = { AllProfiles };

        public RegionSeeder(IConfiguration configuration, IHostingEnvironment env, ILoggerFactory loggerFactory) 
            : base(configuration, env, loggerFactory)
        { }

        protected override IEnumerable<string> TriggerProfiles
        {
            get { return ProfileTriggers; }
        }

        protected override void Invoke(DbAppContext context)
        {
            UpdateRegions(context);
            context.SaveChanges();
        }

        private void UpdateRegions(DbAppContext context)
        {
            List<Region> seedUsers = GetSeedRegions(context);
            foreach (Region Region in seedUsers)
            {
                context.UpdateSeedRegionInfo(Region);
            }
            AddInitialRegions(context);
            context.SaveChanges();
        }

        private void AddInitialRegions(DbAppContext context)
        {
            context.AddInitialRegionsFromFile(Configuration["RegionInitializationFile"]);
        }

        private List<Region> GetSeedRegions(DbAppContext context)
        {
            List<Region> Regions = new List<Region>(GetDefaultRegions(context));
            if (IsDevelopmentEnvironment)
                Regions.AddRange(GetDevRegions(context));
            if (IsTestEnvironment || IsStagingEnvironment)
                Regions.AddRange(GetTestRegions(context));
            if (IsProductionEnvironment)
                Regions.AddRange(GetProdRegions(context));

            return Regions;
        }

        /// <summary>
        /// Returns a list of users to be populated in all environments.
        /// </summary>
        private List<Region> GetDefaultRegions(DbAppContext context)
        {
            return new List<Region>();
        }

        /// <summary>
        /// Returns a list of users to be populated in the Development environment.
        /// </summary>
        private List<Region> GetDevRegions(DbAppContext context)
        {
            return new List<Region>();            
        }

        /// <summary>
        /// Returns a list of users to be populated in the Test environment.
        /// </summary>
        private List<Region> GetTestRegions(DbAppContext context)
        {
            return new List<Region>();
        }

        /// <summary>
        /// Returns a list of users to be populated in the Production environment.
        /// </summary>
        private List<Region> GetProdRegions(DbAppContext context)
        {
            return new List<Region>();
        }

    }
}
