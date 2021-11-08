using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKedndaaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public Jaminan IdCustomerNavigation { get; set; }
        public Kendaraan IdPeminjaman1 { get; set; }
        public Customer IdPeminjamanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
