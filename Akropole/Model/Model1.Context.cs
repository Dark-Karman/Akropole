﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akropole.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SQL_AkropoleEntities : DbContext
    {
        public SQL_AkropoleEntities()
            : base("name=SQL_AkropoleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BathType> BathType { get; set; }
        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<Flat> Flat { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoomsCount> RoomsCount { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ViewType> ViewType { get; set; }
    }
}