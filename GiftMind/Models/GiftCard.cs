using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiftMind.Models
{
    public class GiftCard
    {
        private string giftGuid = System.Guid.NewGuid().ToString();
        /// <summary>
        /// This represents a unique Id for the giftcard
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This represents a giftcard number which later to be created with unique alphanumber using GUID
        /// </summary>
        [Display(Name = "Giftcard Number")]
        [Required]
        public string GiftCardNumber { get { return giftGuid; } set { giftGuid = value; }  } 
        /// <summary>
        /// This represents the balance remaining in the giftcard
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; }
        /// <summary>
        /// This represents the date and time of the giftcard creation
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        /// <summary>
        /// This represents the date and time of the last edit of the gift card
        /// </summary>
        [Display(Name = "Last Edited")]
        [DataType(DataType.Date)]
        public DateTime LastEdited { get; set; }

    }
}
