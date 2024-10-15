using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _420DA3_A24_Exemple_Enseignant.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medecins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    NumLicenseMedicale = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medecins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    NumAssMaladie = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RendezVous",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRendezVous = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    MedecinId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DateModified = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2(6)", precision: 6, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendezVous", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RendezVous_Medecins_MedecinId",
                        column: x => x.MedecinId,
                        principalTable: "Medecins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RendezVous_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medecins",
                columns: new[] { "Id", "DateDeleted", "DateModified", "Nom", "NumLicenseMedicale", "Prenom" },
                values: new object[] { 1, null, null, "Jones", "1234567", "Indianna" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DateDeleted", "DateModified", "Nom", "NumAssMaladie", "Prenom" },
                values: new object[,]
                {
                    { 1, null, null, "Doe", "DOEJ12345678", "John" },
                    { 2, null, null, "Doe", "DOEJ87654321", "Jane" }
                });

            migrationBuilder.InsertData(
                table: "RendezVous",
                columns: new[] { "Id", "DateDeleted", "DateModified", "DateRendezVous", "MedecinId", "PatientId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 10, 14, 16, 59, 5, 926, DateTimeKind.Utc).AddTicks(9540), 1, 1 },
                    { 2, null, null, new DateTime(2024, 10, 14, 16, 59, 5, 926, DateTimeKind.Utc).AddTicks(9570), 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_MedecinId",
                table: "RendezVous",
                column: "MedecinId");

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_PatientId",
                table: "RendezVous",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RendezVous");

            migrationBuilder.DropTable(
                name: "Medecins");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
