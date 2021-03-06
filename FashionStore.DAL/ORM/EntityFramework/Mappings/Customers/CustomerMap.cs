﻿using FashionStore.Entity.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FashionStore.DAL.ORM.EntityFramework.Mappings.Customers
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Müşteri Tablosu");

            HasKey(c => c.Id);
            Property(x=>x.Id)
                .HasColumnName("MüşteriId");

            Property(u => u.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50)
                .HasColumnName("Ad");
            Property(u => u.Surname)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50)
                .HasColumnName("Soyad");

            Property(u => u.Email)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            Property(x => x.PasswordResetToken)
                .IsUnicode();
                
            Property(u => u.Password)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50)
                .HasColumnName("Şifre");

            Property(u => u.Active)
                .HasColumnName("Durum");

            Property(u => u.DateOfBirth)
                .HasColumnName("Doğum Tarihi");

            Property(u => u.Deleted)
                .HasColumnName("SilindiMi");

            Property(u => u.CreatedTime)
                .HasColumnName("Oluşturulma Tarihi");

            Property(u => u.LastLoginTime)
                .IsOptional()
                .HasColumnName("Son Login Tarihi");

            Property(u => u.CustomerRoleId)
                .IsRequired()
                .HasColumnName("MüşteriYetkiId");
            

            HasRequired(x => x.CustomerRole)
                .WithMany(c => c.Customers)
                .HasForeignKey<int>(x => x.CustomerRoleId);


        }

    }
}
