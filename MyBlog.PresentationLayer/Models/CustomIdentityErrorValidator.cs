﻿using Microsoft.AspNetCore.Identity;

namespace MyBlog.PresentationLayer.Models
{
    public class CustomIdentityErrorValidator:IdentityErrorDescriber
    {


        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = "DublicatedEmail",
                Description = "Bu Email adresi zaten sistemde kayıtlı"
            };
        }


        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 rakam giriniz."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Lütfen en az 1 tane küçük harf giriniz."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf giriniz."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az 1 tane sembol giriniz."
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Lütfen en az 6 karakter girişi yapınız."
            };
        }
    }
}
