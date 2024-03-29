﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPBackend.Models
{
    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrencyId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(5)]
        public string Symbol { get; set; }
        public virtual IEnumerable<Wallet> Wallets { get; set; }

        public Currency()
        {
            Wallets = new List<Wallet>();
        }
    }
}
