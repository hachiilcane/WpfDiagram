using Microsoft.EntityFrameworkCore;
using ModelingObject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingObject
{
    public class ModelingObjectContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Inlet> Inlets { get; set; }
        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<Pipe> Pipes { get; set; }
        public DbSet<Valve> Valves { get; set; }
        public DbSet<EquipmentConnector> EquipmentConnectors { get; set; }
        public DbSet<MappingLocation> MappingLocations { get; set; }
        public DbSet<ShapeColor> ShapeColors { get; set; }
        public DbSet<ConnectorPath> ConnectorPaths { get; set; }
        public DbSet<PointXY> PointXYs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=modelingobject;Username=wpfdiagram;Password=wpfdiagram");
        }
    }
}
