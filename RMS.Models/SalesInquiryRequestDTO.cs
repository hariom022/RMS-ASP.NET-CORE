using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Models
{
    public class SalesInquiryRequestDTO
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("EnquiryDocNo")]
        public Guid RequestNo { get; set; }

        [DisplayName("SoldToParty")]
        public string HF_Cust { get; set; }

        [DisplayName("CustRef")]
        public string? ReferenceNo { get; set; }

        [DisplayName("CustRefDate")]
        public string RefernceDate { get; set; } //Ref Date 

        [DisplayName("Item")]
        public List<SalesInquiryItemsDTO> salesInquiryItemsDTO { get; set; } = new List<SalesInquiryItemsDTO>();
    }
    public class SalesInquiryItemsDTO
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Material")]
        public string Number { get; set; }

        [DisplayName("ItemDesc")]
        public string Description { get; set; }

        public int OrderQuantity { get; set; }

        // Navigation property
        public int InquiryId { get; set; }
        //public SalesInquiry? Inquiry { get; set; }

    }
}
