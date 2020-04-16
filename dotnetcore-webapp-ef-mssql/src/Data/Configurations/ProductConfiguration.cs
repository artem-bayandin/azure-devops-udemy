using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    //public class ProductConfiguration : IEntityTypeConfiguration<Product>
    //{
    //    public void Configure(EntityTypeBuilder<Product> builder)
    //    {
    //        builder.HasKey(x => x.Id);

    //        builder.Property(x => x.Name).IsRequired(true);
    //        builder.Property(x => x.Price).IsRequired(true);
    //    }
    //}

    //public class PersonConfiguration : IEntityTypeConfiguration<Person>
    //{
    //    public void Configure(EntityTypeBuilder<Person> builder)
    //    {
    //        builder.HasKey(x => x.Id);

    //        builder.Property(x => x.Name).IsRequired(true);
    //        builder.Property(x => x.Surname).IsRequired(true);
    //        builder.Property(x => x.Age).IsRequired(true).min;
    //    }
    //}
}
