using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane_yonetim_sistemi
{
    public class DoktorContext:DbContext
    {
        public DbSet<Doktor> Doktors { get; set; }
    }
}
