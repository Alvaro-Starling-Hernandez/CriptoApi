using CriptoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CriptoApi.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Coins> Coins { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coins>().HasData(
                new Coins()
                {
                    ModenaId = 1,
                    Descripcion = "Bitcoin",
                    Valor = 20300.1,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bitcoin.png"
                },
                new Coins()
                {
                    ModenaId = 2,
                    Descripcion = "Ethereum",
                    Valor = 1094.9,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/ethereum.png"
                },
                new Coins()
                {
                    ModenaId = 3,
                    Descripcion = "Tether",
                    Valor = 0.9989,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/tether.png"
                },
                new Coins()
                {
                    ModenaId = 4,
                    Descripcion = "BNB",
                    Valor = 223.99,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/bnb.png"
                },
                new Coins()
                {
                    ModenaId = 5,
                    Descripcion = "Binance USD",
                    Valor = 1.0009,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/binance-usd.png"
                }
                ,
                new Coins()
                {
                    ModenaId = 6,
                    Descripcion = "Cordano",
                    Valor = 0.4684,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/cardano.png"
                },
                new Coins()
                {
                    ModenaId = 7,
                    Descripcion = "XRP",
                    Valor = 0.32617,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/xrp.png"
                },
                new Coins()
                {
                    ModenaId = 8,
                    Descripcion = "Solana",
                    Valor = 37.46,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/solana.png"
                },
                new Coins()
                {
                    ModenaId = 9,
                    Descripcion = "Dogecoin",
                    Valor = 0.062324,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/dogecoin.png"
                },
                new Coins()
                {
                    ModenaId = 10,
                    Descripcion = "Polkadot",
                    Valor = 7.529,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/polkadot-new.png"
                },
                new Coins()
                {
                    ModenaId = 11,
                    Descripcion = "Dai",
                    Valor = 0.9997,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/multi-collateral-dai.png"
                },
                new Coins()
                {
                    ModenaId = 12,
                    Descripcion = "TRON",
                    Valor = 0.062389,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/tron.png"
                },
                new Coins()
                {
                    ModenaId = 13,
                    Descripcion = "UNUS SED LEO",
                    Valor = 5.9316,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/unus-sed-leo.png"
                },
                new Coins()
                {
                    ModenaId = 14,
                    Descripcion = "Shiba Inu",
                    Valor = 0.00001,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/shiba-inu.png"
                },
                new Coins()
                {
                    ModenaId = 15,
                    Descripcion = "Wrapped Bitcoin",
                    Valor = 20263.25,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/wrapped-bitcoin.png"
                },
                new Coins()
                {
                    ModenaId = 16,
                    Descripcion = "Avalanche",
                    Valor = 17.35,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/avalanche.png"
                },
                new Coins()
                {
                    ModenaId = 17,
                    Descripcion = "Polygon",
                    Valor = 0.494,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/polygon.png"
                },
                new Coins()
                {
                    ModenaId = 18,
                    Descripcion = "Uniswap",
                    Valor = 5.24,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/uniswap.png"
                },
                new Coins()
                {
                    ModenaId = 19,
                    Descripcion = "Litecoin",
                    Valor = 54.7,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/litecoin.png"
                },
                new Coins()
                {
                    ModenaId = 20,
                    Descripcion = "FTX Token",
                    Valor = 25.3788,
                    ImageUrl = "https://i-invdn-com.investing.com/ico_flags/80x80/v32/ftx-token.png"
                }
            );
        }
    }
}
