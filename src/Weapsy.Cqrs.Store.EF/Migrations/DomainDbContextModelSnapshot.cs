﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Weapsy.Cqrs.Store.EF.Migrations
{
    [DbContext(typeof(DomainDbContext))]
    partial class DomainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeapsyCqrs.EF.Entities.AggregateEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("DomainAggregate");
                });

            modelBuilder.Entity("WeapsyCqrs.EF.Entities.CommandEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregateId");

                    b.Property<string>("Data");

                    b.Property<string>("Source");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Type");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("DomainCommand");
                });

            modelBuilder.Entity("WeapsyCqrs.EF.Entities.EventEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregateId");

                    b.Property<Guid>("CommandId");

                    b.Property<string>("Data");

                    b.Property<int>("Sequence");

                    b.Property<string>("Source");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<string>("Type");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("DomainEvent");
                });
#pragma warning restore 612, 618
        }
    }
}
