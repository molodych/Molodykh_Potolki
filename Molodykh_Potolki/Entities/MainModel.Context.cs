﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Molodykh_Potolki.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MolodykhPotolkiEntities : DbContext
    {
        public MolodykhPotolkiEntities()
            : base("name=MolodykhPotolkiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Марка> Марка { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Потолок> Потолок { get; set; }
        public virtual DbSet<Производитель> Производитель { get; set; }
        public virtual DbSet<Роль_пользователя> Роль_пользователя { get; set; }
        public virtual DbSet<Фактура> Фактура { get; set; }
    }
}