﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test;

namespace ClassLibrary1.Migrations
{
    [DbContext(typeof(MedicalContext))]
    [Migration("20201116001344_BuildingDatabase")]
    partial class BuildingDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClassLibrary1.Entities.A_State", b =>
                {
                    b.Property<int>("State_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("State_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("State_ID");

                    b.ToTable("StateTB");
                });
#pragma warning restore 612, 618
        }
    }
}
