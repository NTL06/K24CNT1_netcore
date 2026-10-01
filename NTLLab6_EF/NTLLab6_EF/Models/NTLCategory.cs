using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTLLab6_EF.Models
{
    [Table("Category")]
    public class NTLCategory
    {
        [Key]
        public int NTLId { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string NTLName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        // Danh sách sản phẩm thuộc danh mục
        public ICollection<NTLProduct> NTLProducts { get; set; } = new List<NTLProduct>();
    }
}