using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework
{
    public static class Config
    {
        public static string BaseUrl = "https://testing.todorvachev.com/";


        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class UserName
                {
                    public static string FourCharacter = "asdf";
                    public static string ThirteenCharacter = "asdfasdfasdfasdf1";
                }
                public static class Password
                {

                }
                public static class Email
                {

                }
            }
        }

        public static class AlertTexts
        {
            public static string SuccessfullLogin = "Succesful login!";
        }

    }
}
