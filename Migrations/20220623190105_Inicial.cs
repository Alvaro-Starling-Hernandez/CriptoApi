using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CriptoApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    ModenaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.ModenaId);
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bitcoin.png", 20300.099999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/ethereum.png", 1094.9000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Tether", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/tether.png", 0.99890000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "BNB", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bnb.png", 223.99000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "Binance USD", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/binance-usd.png", 1.0008999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "Cordano", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/cardano.png", 0.46839999999999998 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "XRP", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/xrp.png", 0.32617000000000002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "Solana", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/solana.png", 37.460000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 9, "Dogecoin", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/dogecoin.png", 0.062323999999999997 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 10, "Polkadot", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/polkadot-new.png", 7.5289999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 11, "Dai", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/multi-collateral-dai.png", 0.99970000000000003 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 12, "TRON", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/tron.png", 0.062389 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 13, "UNUS SED LEO", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/unus-sed-leo.png", 5.9316000000000004 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 14, "Shiba Inu", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/shiba-inu.png", 1.0000000000000001E-05 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 15, "Wrapped Bitcoin", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/wrapped-bitcoin.png", 20263.25 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 16, "Avalanche", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/avalanche.png", 17.350000000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 17, "Polygon", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/polygon.png", 0.49399999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 18, "Uniswap", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/uniswap.png", 5.2400000000000002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 19, "Litecoin", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/litecoin.png", 54.700000000000003 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "ModenaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 20, "FTX Token", "https://i-invdn-com.investing.com/ico_flags/80x80/v32/ftx-token.png", 25.378799999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}
