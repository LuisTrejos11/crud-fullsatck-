using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FBTarjeta.Models;

namespace FBTarjeta
{
    public class AplicationDBContext: DbContext
    {
       public  DbSet<TarjetaCredito> TaretaCredito { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        { 
            
        }
    }
}
