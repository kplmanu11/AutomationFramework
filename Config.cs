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
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";

                }
                public static class Email
                {
                    public static string Nouser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDomain = "example@";
                    public static string NoExtension = "example@example";
                }
            }
        }

        public static class AlertTexts
        {
            public static string SuccessfullLogin = "Succesful login!";
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLengthOutOfRange = "Password should not be empty / length be between 5 to 12";
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string About = "About";
        }

    }
}
