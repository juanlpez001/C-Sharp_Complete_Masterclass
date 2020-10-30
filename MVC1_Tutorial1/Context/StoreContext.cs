using MVC1_Tutorial1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1_Tutorial1.Context
{
    public class StoreContext : DbContext //Hereda de DBContext
    {
        //Product va a representar todos los productos de la BD
        public  DbSet<Product> Products { get; set; } //BD

        
    //    internal object Entry(object product)
    //    {
    //        throw new NotImplementedException();
    //    }
       
    }
}
