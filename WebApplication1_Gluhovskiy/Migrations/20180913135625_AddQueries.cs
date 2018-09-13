using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1_Gluhovskiy.Migrations
{
    public partial class AddQueries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE VIEW View_FullWorkData AS
                  SELECT Title, ReleaseDate,
                  GenreName, GenreDescription,
                  SeriesName, Description
                  FROM Work w 
                  JOIN Genres g ON w.GenreID=g.GenreID
                  JOIN Series s ON s.SeriesID=w.SeriesID;"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"DROP VIEW View_FullWorkData;"
                );
        }
    }
}
