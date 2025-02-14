﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web_shop.Models;

namespace web_shop.Migrations
{
    [DbContext(typeof(OrdersContext))]
    partial class OrdersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("web_shop.Models.OrdersDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("delivery")
                       .IsRequired()
                       .HasColumnType("bit");

                    b.Property<bool>("orderstatus")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("wishes")
                        .HasColumnType("text");

                    b.Property<string>("notes")                 
                        .HasColumnType("text");

                    b.Property<double>("sum")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
