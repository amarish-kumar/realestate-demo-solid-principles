﻿using RealEstateDemo.DataAccess.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDemo.DataAccess.EntityFramework.DbEntitiesMapping
{
    /// <summary>
    /// Provides mapping between <see cref="LocationInformation"/> and its underlying database object.
    /// </summary>
    public class LocationInformationMapping : EntityTypeConfiguration<LocationInformation>
    {
        /// <summary>
        /// Performs the mapping.
        /// </summary>
        public LocationInformationMapping()
        {
            ToTable("ViewLocationsInformation");
            HasKey(t => new
            {
                t.SuburbId
            });
        }
    }
}
