﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SALONEntities : DbContext
    {
        private static SALONEntities _context;
        public static SALONEntities GetContext()
        {
            if (_context == null)
                _context = new SALONEntities();
            return _context;
        }

        public SALONEntities()
            : base("name=SALONEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Priem> Priem { get; set; }
        public virtual DbSet<Specialist> Specialist { get; set; }
    }
}