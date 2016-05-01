using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Template.Web.ViewModels
{
    public class AccountViewModels
    {
        public class ExternalLoginConfirmationViewModel
        {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; }
        }

        public class ChangePasswordViewModel
        {
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Current password")]
            public string OldPassword { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "New password")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm new password")]
            [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public class LoginViewModel
        {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public class RegisterViewModel
        {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "Confirm Email")]
            [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
            public string ConfirmEmail { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            public string Role { get; set; }
        }

        public class ManageUserViewModel
        {
            [Required]
            [Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public string Role { get; set; }
        }

        public class UserInfoViewModel
        {
            public string Email { get; set; }
            public bool HasRegistered { get; set; }
            public string LoginProvider { get; set; }
        }

        public class ExternalLoginViewModel
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public string State { get; set; }
        }

        public class ManageInfoViewModel
        {
            public string LocalLoginProvider { get; set; }
            public string Email { get; set; }
            public List<UserLoginInfoViewModel> Logins { get; set; }
            public IEnumerable<ExternalLoginViewModel> ExternalLoginProviders { get; set; }
        }

        public class LoginInfoViewModel
        {
            public string LocalLoginProvider { get; set; }
            public string ProviderKey { get; set; }
        }

        public class UserLoginInfoViewModel : LoginInfoViewModel
        {
            public string LoginProvider { get; set; }
        }
    }
}