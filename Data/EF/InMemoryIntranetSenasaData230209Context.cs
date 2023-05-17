//using login4.Models.EF;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Caching.Memory;
//using System;
//using System.Collections.Generic;
//namespace login4.Data.EF
//{
//    public class InMemoryIntranetSenasaData230209Context : InMemoryDataContext<ext_adm_CL_Search>
//    {
//        IntranetSenasaData230209Context _context;
        

//            public InMemoryIntranetSenasaData230209Context(IntranetSenasaData230209Context context, IHttpContextAccessor contextAccessor, IMemoryCache memoryCache)
//                : base(contextAccessor, memoryCache)
//            {
//                _context = context;
//            }
//            public ICollection<ext_adm_CL_Search> ext_adm_CL_Searchs => ItemsInternal;

//            public DbSet<Customer> Customers => _nwind.Customers;

//            public DbSet<Order_Detail> Order_Details => _nwind.Order_Details;

//            public DbSet<Shipper> Shippers => _nwind.Shippers;


//            protected override IEnumerable<Order> Source => _nwind.Orders;

//            protected override int GetKey(Order item) => item.OrderID;

//            protected override void SetKey(Order item, int key) => item.OrderID = key;
//        }
//    }

//}
//}
