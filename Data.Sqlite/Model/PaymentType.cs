﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Data.Sqlite.Model
{
    [Table("PaymentTypes")]
    public class PaymentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaymentTypeID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
