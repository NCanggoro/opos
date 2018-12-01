using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Training.Dto
{
    public class KategoriBarangDto
    {
        public int IdKategori { get; set; }
        public string NamaKategori { get; set; }
    }

    public class InputKategoriBarang
    {
        [Required]
        [StringLength(20,MinimumLength = 5,ErrorMessage = "Nama Kategori harus memiliki minimal 5 karakter dan maksimal 20")]
        public string NamaKategori { get; set; }
    }

    public class UpdateKategoriBarang
    {
        [Required]
        public int IdKategori { get; set; }
        [Required]
        public string NamaKategori { get; set; }
    }

}
