﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Events2._0.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Diagnostics.Tracing;

    public partial class EventEntities : DbContext
    {
        private static EventEntities context;

        public EventEntities()
            : base("name=EventEntities")
        {
        }

        public static EventEntities GetContext() 
        {
            if (context == null) context = new EventEntities();

            return context;
        }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Jury> Jury { get; set; }
        public virtual DbSet<Moderarors> Moderarors { get; set; }
        public virtual DbSet<players> players { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<организаторы> организаторы { get; set; }
    }
}