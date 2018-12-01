using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Model
{
    public class KategoriBarang
    {
        [Key]
        public int IdKategori { get; set; }

        public string NamaKategori { get; set; }


    }
}
