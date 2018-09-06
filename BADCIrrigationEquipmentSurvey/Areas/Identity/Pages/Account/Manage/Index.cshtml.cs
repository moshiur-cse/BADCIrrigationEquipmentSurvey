using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using BADCIrrigationEquipmentSurvey.Models;


namespace BADCIrrigationEquipmentSurvey.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<BadcAppUser> _userManager;
        private readonly SignInManager<BadcAppUser> _signInManager;
        private readonly IEmailSender _emailSender;

        public IndexModel(
            UserManager<BadcAppUser> userManager,
            SignInManager<BadcAppUser> signInManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public string Id { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [Display(Name = "Initial/User Id")]
            public string UserId { get; set; }


            [Required]
            [DataType(DataType.Text)]
            [StringLength(250, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
            [Display(Name = "User Name")]
            public string Name { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [StringLength(150)]
            [Display(Name = "Designation")]
            public string Designation { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "E-mail")]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Mobile No.")]
            public string MobileNo { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            //var userName = await _userManager.GetUserNameAsync(user);
            //var email = await _userManager.GetEmailAsync(user);
            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            var uId = await _userManager.GetUserIdAsync(user);

            Username = user.UserId;

            Input = new InputModel
            {
                Id = uId,
                UserId = user.UserId,
                Name = user.Name,
                Designation = user.Designation,
                MobileNo = user.MobileNo,
                Email = user.Email
                //    CreatedBy = "AHI"
                //Email = email
            };

            try
            {
                IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            //Username = user.UserId;

            //var UserId = _userManager.GetUserId(user);
            var uId = await _userManager.GetUserIdAsync(user);

            if (Input.Id != uId)
            {
                throw new InvalidOperationException($"Unexpected error occurred in user ID: '{uId}'.");
            }

            Username = Input.UserId = user.UserId;

            if (Input.UserId != user.UserName)
            {
                user.UserName = Input.UserId;
            }

            //if (Input.UserId != user.UserId)
            //if (Input.UserId != user.UserName)
            //{
            //    user.UserName = Input.UserId;
            //    user.UserId = Input.UserId;
            //}

            if (Input.Name != user.Name)
            {
                user.Name = Input.Name;
            }

            if (Input.Designation != user.Designation)
            {
                user.Designation = Input.Designation;
            }

            if (Input.MobileNo != user.MobileNo)
            {
                user.MobileNo = Input.MobileNo;
            }

            if (Input.Email != user.Email)
            {
                user.Email = Input.Email;
            }



            try
            {

                //var email = await _userManager.GetEmailAsync(user);
                //if (Input.Email != email)
                //{
                //    var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                //    if (!setEmailResult.Succeeded)
                //    {
                //        var userId = await _userManager.GetUserIdAsync(user);
                //        throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{userId}'.");
                //    }
                //}

                //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
                //if (Input.PhoneNumber != phoneNumber)
                //{
                //    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                //    if (!setPhoneResult.Succeeded)
                //    {
                //        var userId = await _userManager.GetUserIdAsync(user);
                //        throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                //    }
                //}

                await _userManager.UpdateAsync(user);

                await _signInManager.RefreshSignInAsync(user);
                StatusMessage = "Your profile has been updated.";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return RedirectToPage();
        }


        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }


            var uId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = uId, code = code },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(
                email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            StatusMessage = "Verification email sent. Please check your email.";

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsyncTest()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var uId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            Username = Input.UserId = user.UserId;

            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = uId, UserId = user.UserId, Username = user.UserId, code = code },
                protocol: Request.Scheme);

            await _emailSender.SendEmailAsync(
                email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            StatusMessage = "Verification email sent. Please check your email.";
            return RedirectToPage();
        }
    }
}
