﻿using NUnit.Framework;

namespace Atata.SampleApp.AutoTests
{
    public class HomeTest : AutoTest
    {
        [Test]
        public void Home()
        {
            Go.To<HomePage>().
                PageUrl.Should.EndWith("/#!/").
                SignIn.Content.Should.Equal("Sign In").
                SignUp.Content.Should.Equal("Sign Up");
        }

        [Test]
        public void Home_SignInAndSignUpLinks()
        {
            Go.To<HomePage>().
                SignIn.Should.Exist().
                SignUp.Should.Exist().
                Menu.SignIn().
                    Email.Set(Config.Account.Email).
                    Password.Set(Config.Account.Password).
                    SignIn().
                        Menu.Home().
                            SignIn.Should.Not.Exist().
                            SignUp.Should.Not.Exist();
        }
    }
}