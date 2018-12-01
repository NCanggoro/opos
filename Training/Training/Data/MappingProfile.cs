using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.Dto;
using Training.Model;

namespace Training.Data
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<KategoriBarang,KategoriBarangDto>().ReverseMap();
        }
    }
}
