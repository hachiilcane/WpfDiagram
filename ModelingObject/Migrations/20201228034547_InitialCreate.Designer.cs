﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelingObject;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModelingObject.Migrations
{
    [DbContext(typeof(ModelingObjectContext))]
    [Migration("20201228034547_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ModelingObject.Models.ConnectorPath", b =>
                {
                    b.Property<int>("ConnectorPathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("ConnectorPathId");

                    b.ToTable("ConnectorPaths");
                });

            modelBuilder.Entity("ModelingObject.Models.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("MappingLocationId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ShapeColorId")
                        .HasColumnType("integer");

                    b.HasKey("EquipmentId");

                    b.HasIndex("MappingLocationId");

                    b.HasIndex("ShapeColorId");

                    b.ToTable("Equipments");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Equipment");
                });

            modelBuilder.Entity("ModelingObject.Models.EquipmentConnector", b =>
                {
                    b.Property<int>("EquipmentConnectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ConnectorPathId")
                        .HasColumnType("integer");

                    b.Property<int>("DownstreamConnectionPosition")
                        .HasColumnType("integer");

                    b.Property<int>("DownstreamEquipmentId")
                        .HasColumnType("integer");

                    b.Property<int?>("ShapeColorId")
                        .HasColumnType("integer");

                    b.Property<int>("UpstreamConnectionPosition")
                        .HasColumnType("integer");

                    b.Property<int>("UpstreamEquipmentId")
                        .HasColumnType("integer");

                    b.HasKey("EquipmentConnectorId");

                    b.HasIndex("ConnectorPathId");

                    b.HasIndex("DownstreamEquipmentId");

                    b.HasIndex("ShapeColorId");

                    b.HasIndex("UpstreamEquipmentId");

                    b.ToTable("EquipmentConnectors");
                });

            modelBuilder.Entity("ModelingObject.Models.MappingLocation", b =>
                {
                    b.Property<int>("MappingLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Angle")
                        .HasColumnType("double precision");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.Property<double>("X")
                        .HasColumnType("double precision");

                    b.Property<double>("Y")
                        .HasColumnType("double precision");

                    b.HasKey("MappingLocationId");

                    b.ToTable("MappingLocations");
                });

            modelBuilder.Entity("ModelingObject.Models.PointXY", b =>
                {
                    b.Property<int>("PointXYId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ConnectorPathId")
                        .HasColumnType("integer");

                    b.Property<double>("X")
                        .HasColumnType("double precision");

                    b.Property<double>("Y")
                        .HasColumnType("double precision");

                    b.HasKey("PointXYId");

                    b.HasIndex("ConnectorPathId");

                    b.ToTable("PointXYs");
                });

            modelBuilder.Entity("ModelingObject.Models.ShapeColor", b =>
                {
                    b.Property<int>("ShapeColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Fill")
                        .HasColumnType("text");

                    b.Property<string>("Stroke")
                        .HasColumnType("text");

                    b.Property<double>("StrokeThickness")
                        .HasColumnType("double precision");

                    b.HasKey("ShapeColorId");

                    b.ToTable("ShapeColors");
                });

            modelBuilder.Entity("ModelingObject.Models.Inlet", b =>
                {
                    b.HasBaseType("ModelingObject.Models.Equipment");

                    b.HasDiscriminator().HasValue("Inlet");
                });

            modelBuilder.Entity("ModelingObject.Models.Outlet", b =>
                {
                    b.HasBaseType("ModelingObject.Models.Equipment");

                    b.HasDiscriminator().HasValue("Outlet");
                });

            modelBuilder.Entity("ModelingObject.Models.Pipe", b =>
                {
                    b.HasBaseType("ModelingObject.Models.Equipment");

                    b.Property<double>("InsideDiameter")
                        .HasColumnType("double precision");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.HasDiscriminator().HasValue("Pipe");
                });

            modelBuilder.Entity("ModelingObject.Models.Valve", b =>
                {
                    b.HasBaseType("ModelingObject.Models.Equipment");

                    b.HasDiscriminator().HasValue("Valve");
                });

            modelBuilder.Entity("ModelingObject.Models.Equipment", b =>
                {
                    b.HasOne("ModelingObject.Models.MappingLocation", "MappingLocation")
                        .WithMany()
                        .HasForeignKey("MappingLocationId");

                    b.HasOne("ModelingObject.Models.ShapeColor", "ShapeColor")
                        .WithMany()
                        .HasForeignKey("ShapeColorId");
                });

            modelBuilder.Entity("ModelingObject.Models.EquipmentConnector", b =>
                {
                    b.HasOne("ModelingObject.Models.ConnectorPath", "ConnectorPath")
                        .WithMany()
                        .HasForeignKey("ConnectorPathId");

                    b.HasOne("ModelingObject.Models.Equipment", "DownstreamEquipment")
                        .WithMany("UpstreamEquipmentConnectors")
                        .HasForeignKey("DownstreamEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModelingObject.Models.ShapeColor", "ShapeColor")
                        .WithMany()
                        .HasForeignKey("ShapeColorId");

                    b.HasOne("ModelingObject.Models.Equipment", "UpstreamEquipment")
                        .WithMany("DownstreamEquipmentConnectors")
                        .HasForeignKey("UpstreamEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModelingObject.Models.PointXY", b =>
                {
                    b.HasOne("ModelingObject.Models.ConnectorPath", null)
                        .WithMany("Points")
                        .HasForeignKey("ConnectorPathId");
                });
#pragma warning restore 612, 618
        }
    }
}