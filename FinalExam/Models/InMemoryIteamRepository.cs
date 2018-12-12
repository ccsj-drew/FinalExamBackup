using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Models
{
    public class InMemoryIteamRepository : IIteamRepository {
        public IQueryable<Iteam> Iteam => new List<Iteam>{
        new Iteam { Description="Antistatic wipes", UnitsOnHand=30 , Cost=0.15m, SellingPrice=0.25m},
        new Iteam { Description="CD Wallet", UnitsOnHand=12 , Cost=3.45m, SellingPrice=4.00m},
        new Iteam { Description="Desktop Holder", UnitsOnHand=4 , Cost=3.85m, SellingPrice=4.75m},
        new Iteam { Description="Disks", UnitsOnHand=175 , Cost=0.20m, SellingPrice=0.75m},
        new Iteam { Description="Disk Cases", UnitsOnHand=12 , Cost=2.20m, SellingPrice=2.75m},
        new Iteam { Description="Mouse Holder", UnitsOnHand=10 , Cost=.80m, SellingPrice=1.00m},
        new Iteam { Description="Mouse Pad", UnitsOnHand=25 , Cost=2.25m, SellingPrice=3.00m},
        new Iteam { Description="PC Tool Kit", UnitsOnHand=9 , Cost=7.80m, SellingPrice=9.00m},
        new Iteam { Description="Wrist Rest", UnitsOnHand=3 , Cost=2.90m, SellingPrice=3.25m}
    }.AsQueryable<Iteam>();
    }
}
