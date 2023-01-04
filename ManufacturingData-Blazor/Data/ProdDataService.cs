using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManufacturingData_Blazor.Data
{
    public class ProdDataService
    {
        List<ProdData> prodData = new List<ProdData>()
        {
            new ProdData(){SFCID=1, SFC="91234", Date=Convert.ToDateTime("2022-01-11"), OrderType="Production", Status="DONE", Quantity=2749},
            new ProdData(){SFCID=2, SFC="91235", Date=Convert.ToDateTime("2022-02-18"), OrderType="Production", Status="DONE", Quantity=1388},
            new ProdData(){SFCID=3, SFC="91236", Date=Convert.ToDateTime("2022-03-02"), OrderType="Production", Status="DONE", Quantity=3109},
            new ProdData(){SFCID=4, SFC="91237", Date=Convert.ToDateTime("2022-04-10"), OrderType="Production", Status="DONE", Quantity=1987},
            new ProdData(){SFCID=5, SFC="91238", Date=Convert.ToDateTime("2022-05-08"), OrderType="Production", Status="DONE", Quantity=2208},
            new ProdData(){SFCID=6, SFC="91239", Date=Convert.ToDateTime("2022-06-26"), OrderType="Production", Status="DONE", Quantity=1142}
        };
        public async Task<List<ProdData>> ProdDataList() 
        {
            return await Task.FromResult(prodData);
        }
    }
}
