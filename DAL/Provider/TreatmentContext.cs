﻿using IPTreatmentOffering.Model;
using Microsoft.EntityFrameworkCore;

namespace IPTreatmentOffering.Provider
{
    public class TreatmentContext:DbContext
    {
        public TreatmentContext(DbContextOptions<TreatmentContext> options) : base(options)
        {

        }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<TreatmentPackage> TreatmentPackages { get; set; }
    }
}
