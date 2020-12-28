using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ModelingObject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConnectorPaths",
                columns: table => new
                {
                    ConnectorPathId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectorPaths", x => x.ConnectorPathId);
                });

            migrationBuilder.CreateTable(
                name: "MappingLocations",
                columns: table => new
                {
                    MappingLocationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Angle = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingLocations", x => x.MappingLocationId);
                });

            migrationBuilder.CreateTable(
                name: "ShapeColors",
                columns: table => new
                {
                    ShapeColorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fill = table.Column<string>(nullable: true),
                    Stroke = table.Column<string>(nullable: true),
                    StrokeThickness = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShapeColors", x => x.ShapeColorId);
                });

            migrationBuilder.CreateTable(
                name: "PointXYs",
                columns: table => new
                {
                    PointXYId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false),
                    ConnectorPathId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointXYs", x => x.PointXYId);
                    table.ForeignKey(
                        name: "FK_PointXYs_ConnectorPaths_ConnectorPathId",
                        column: x => x.ConnectorPathId,
                        principalTable: "ConnectorPaths",
                        principalColumn: "ConnectorPathId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    ShapeColorId = table.Column<int>(nullable: true),
                    MappingLocationId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Length = table.Column<double>(nullable: true),
                    InsideDiameter = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipments_MappingLocations_MappingLocationId",
                        column: x => x.MappingLocationId,
                        principalTable: "MappingLocations",
                        principalColumn: "MappingLocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_ShapeColors_ShapeColorId",
                        column: x => x.ShapeColorId,
                        principalTable: "ShapeColors",
                        principalColumn: "ShapeColorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentConnectors",
                columns: table => new
                {
                    EquipmentConnectorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UpstreamEquipmentId = table.Column<int>(nullable: false),
                    DownstreamEquipmentId = table.Column<int>(nullable: false),
                    UpstreamConnectionPosition = table.Column<int>(nullable: false),
                    DownstreamConnectionPosition = table.Column<int>(nullable: false),
                    ShapeColorId = table.Column<int>(nullable: true),
                    ConnectorPathId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentConnectors", x => x.EquipmentConnectorId);
                    table.ForeignKey(
                        name: "FK_EquipmentConnectors_ConnectorPaths_ConnectorPathId",
                        column: x => x.ConnectorPathId,
                        principalTable: "ConnectorPaths",
                        principalColumn: "ConnectorPathId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentConnectors_Equipments_DownstreamEquipmentId",
                        column: x => x.DownstreamEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentConnectors_ShapeColors_ShapeColorId",
                        column: x => x.ShapeColorId,
                        principalTable: "ShapeColors",
                        principalColumn: "ShapeColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentConnectors_Equipments_UpstreamEquipmentId",
                        column: x => x.UpstreamEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentConnectors_ConnectorPathId",
                table: "EquipmentConnectors",
                column: "ConnectorPathId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentConnectors_DownstreamEquipmentId",
                table: "EquipmentConnectors",
                column: "DownstreamEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentConnectors_ShapeColorId",
                table: "EquipmentConnectors",
                column: "ShapeColorId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentConnectors_UpstreamEquipmentId",
                table: "EquipmentConnectors",
                column: "UpstreamEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_MappingLocationId",
                table: "Equipments",
                column: "MappingLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ShapeColorId",
                table: "Equipments",
                column: "ShapeColorId");

            migrationBuilder.CreateIndex(
                name: "IX_PointXYs_ConnectorPathId",
                table: "PointXYs",
                column: "ConnectorPathId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentConnectors");

            migrationBuilder.DropTable(
                name: "PointXYs");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "ConnectorPaths");

            migrationBuilder.DropTable(
                name: "MappingLocations");

            migrationBuilder.DropTable(
                name: "ShapeColors");
        }
    }
}
