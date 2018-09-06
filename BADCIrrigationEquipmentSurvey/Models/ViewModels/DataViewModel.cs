using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BADCIrrigationEquipmentSurvey.Models.ViewModels
{
    public class ViewCategoryInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CategoryId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "CategoryId")]
        public int CategoryId { get; set; }

        [Column("Category", Order = 1, TypeName = "varchar(200)")]
        [Display(Name = "Category")]
        public string Category { get; set; }
    }

    public class ViewSubCategoryInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SubCategoryId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Sub Category Id")]
        public int SubCategoryId { get; set; }

        [Column("CategoryId", Order = 0, TypeName = "int")]
        [DataType(DataType.Text)]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ViewCategoryInfo Category { get; set; }

        [Column("SubCategory", Order = 1, TypeName = "varchar(200)")]
        [Display(Name = "Sub Category")]
        public string SubCategory { get; set; }

    }

    public class ViewSubSubCategoryInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SubSubCategoryId", Order = 3, TypeName = "int")]
        [Display(Name = "SubSubCategoryId")]
        public int SubSubCategoryId { get; set; }
        
        //[Required(ErrorMessage = "Survey District is required !")]
        [Column("SubCategoryId", Order = 2, TypeName = "int")]
        [Display(Name = "Sub-Category")]
        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual ViewSubCategoryInfo SubCategory { get; set; }

        [Column("SubSubCategory", Order = 5, TypeName = "varchar(200)")]
        [Display(Name = "Sub Sub Category")]
        public string SubSubCategory { get; set; }
    }


}
