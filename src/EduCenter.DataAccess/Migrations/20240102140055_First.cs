using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduCenter.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sertificate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    CandidateNo = table.Column<string>(type: "text", nullable: false),
                    CertificateNo = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PlaseOfBirth = table.Column<string>(type: "text", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    ExamCenter = table.Column<string>(type: "text", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReadingScore = table.Column<float>(type: "real", nullable: false),
                    ListeningScore = table.Column<float>(type: "real", nullable: false),
                    SpeakingScore = table.Column<float>(type: "real", nullable: false),
                    WritingScore = table.Column<float>(type: "real", nullable: false),
                    TotalScore = table.Column<float>(type: "real", nullable: false),
                    Level = table.Column<string>(type: "text", nullable: false),
                    CertificateType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sertificate", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sertificate");
        }
    }
}
