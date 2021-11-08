using System;
using System.Collections.Generic;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengebalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public Peminjaman IdKondisiNavigation { get; set; }
        public KondisiKendaraan IdPengembalianNavigation { get; set; }
    }
}
