using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }
        public string NamaGender { get; set; }

        public Customer Customer { get; set; }
    }
}
