﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Yiim.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class DbEntities : DbContext
{
    public DbEntities()
        : base("name=DbEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserFunctionality> UserFunctionalities { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserToUserRole> UserToUserRoles { get; set; }

}

}
