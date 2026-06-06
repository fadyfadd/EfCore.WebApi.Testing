using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class _3d9f8c621b7a4c92bd148f53cb2e6f47 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StudentDocuments",
                newName: "id");

            migrationBuilder.CreateSequence<int>(
                name: "student_document_sequence");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "StudentDocuments",
                type: "integer",
                nullable: false,
                defaultValueSql: "nextval('\"student_document_sequence\"')",
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "student_document_sequence");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "StudentDocuments",
                newName: "Id");

            migrationBuilder.CreateSequence<int>(
                name: "student_sequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StudentDocuments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "nextval('\"student_document_sequence\"')")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
