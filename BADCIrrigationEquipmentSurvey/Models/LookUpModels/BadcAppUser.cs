using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace BADCIrrigationEquipmentSurvey.Models
{
    // Add profile data for application users by adding properties to the BadcAppUser class
    public class BadcAppUser : IdentityUser
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        ////[DataType(DataType.Text)]
        //[Column(Order = , TypeName = "int", Order = 1)]
        ////[Display(Name = "Id")]
        //public int uId { get; set; }
        
        //[Required]
        //[Column(Order = 1, TypeName = "nvarchar(100)")]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        //[DataType(DataType.Text)]
        //[Display(Name = "User Type")]
        //public string UserType { get; set; }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Column(Order = 0, TypeName = "nvarchar(20)")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [Display(Name = "Initial/User Id")]
        public string UserId { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(100)")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }


        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Column(Order = 2, TypeName = "nvarchar(250)")]
        [StringLength(250, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [Display(Name = "User Name")]
        public string Name { get; set; }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Column(Order = 3, TypeName = "nvarchar(250)")]
        [StringLength(150)]
        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [PersonalData]
        [Required]
        [EmailAddress]
        [Column(Order = 4, TypeName = "nvarchar(50)")]
        [Display(Name = "E-mail")]
        public override string Email { get; set; }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Column(Order = 5, TypeName = "nvarchar(50)")]
        [Display(Name = "Mobile No.")]
        public string MobileNo { get; set; }

        [PersonalData]
        [Column(Order = 6, TypeName = "nvarchar(150)")]
        [StringLength(150)]
        [DataType(DataType.Text)]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }



        public virtual ICollection<UserRole> UserRoles { get; } = new List<UserRole>();

        public virtual ICollection<UserClaim> UserClaims { get; } = new List<UserClaim>();

        public virtual ICollection<UserLogin> UserLogins { get; } = new List<UserLogin>();

    }

    //public class MyBadcAppUser : BadcAppUser
    //{
    //    public virtual BadcAppUser BadcAppUser { get; set; }
    //}


    public class UserLogin : IdentityUserLogin<string>
    {
        public virtual BadcAppUser BadcAppUser { get; set; }
    }

    public class UserRole : IdentityUserRole<string>
    {
        public virtual BadcAppUser BadcAppUser { get; set; }
    }

    public class UserClaim : IdentityUserClaim<string>
    {
        public virtual BadcAppUser BadcAppUser { get; set; }
    }


    //public class UserManager : UserManager<BadcAppUser>
    //{
    //    public UserManager() : base(new UserStore<MyBadcAppUser>(new UserDbContext()))
    //    {
    //    }
    //}
}
