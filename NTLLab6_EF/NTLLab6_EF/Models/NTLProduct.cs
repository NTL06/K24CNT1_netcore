using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTLLab6_EF.Models
{
    [Table("Product")]
    public class NTLProduct
    {
        [Key]
        public int NTLId { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(150, ErrorMessage = "Tên sản phẩm giới hạn 150 ký tự")]
        [Column(TypeName = "nvarchar(150)")]
        public string NTLName { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string NTLImage { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public float NTLPrice { get; set; }

        public float NTLSalePrice { get; set; }

        public byte NTLStatus { get; set; }

        [StringLength(1000, ErrorMessage = "Nội dung mô tả giới hạn 1000 ký tự")]
        [Column(TypeName = "ntext")]
        public string NTLDescriptions { get; set; }

        [Required(ErrorMessage = "Danh mục sản phẩm không được để trống")]
        public int NTLCategoryId { get; set; }

        public DateTime CreatedDate { get; set; }

        // Khóa ngoại tới Category
        [ForeignKey("NTLCategoryId")]
        public NTLCategory nTLCategory { get; set; }
    }
}