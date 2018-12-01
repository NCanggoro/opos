using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Model
{
    public class Barang
    {
        public int Id { get; set; }
        public string NamaBarang { get; set; }
        public int StokBarang { get; set; }
        public int HargaBarang { get; set; }

        [ForeignKey("IdKategori")]
        public KategoriBarang KategoriBarang { get; set; }

        public int IdKategori { get; set; }
    }
}
