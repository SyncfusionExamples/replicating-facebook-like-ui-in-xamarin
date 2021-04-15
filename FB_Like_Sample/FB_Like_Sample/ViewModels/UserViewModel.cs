using FB_Like_Sample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FB_Like_Sample.ViewModels
{
    internal class UserViewModel
    {
        public static void AddStatusImagesForPerson(Person person)
        {
            person.Images = new List<string>()
            {
                person.UserID+"Status001.png",
                person.UserID+"Status002.png",
            };
        }
        public static void AddAboutUsForPerson(Person person)
        {
            switch (person.UserID)
            {
                case "User000":

                    person.StatusMessage = "The value of an idea lies in the using of it.";

                    person.About = new Dictionary<AboutType, string>()
                    {
                        {AboutType.Position, "Seniror Software Developer in Syncfusion Software Solutions, Chennai" },
                        {AboutType.Work, "Working in .Net platforms (WPF | Xamarin | Flutter | Asp.Net)" },
                        {AboutType.Education, "Studied B.E (Computer Science) in University of Cambridge"},
                        {AboutType.Living, "Living in USA"},
                        {AboutType.Native, "Native is Canada"},
                        {AboutType.Joined,"Joined on March 11 2000"},
                        {AboutType.Following,"26 Following"},
                        {AboutType.Followers,"6 Followers"}
                    };

                    break;
                case "User001":

                    person.StatusMessage = "Creativity is thinking up new things. Innovation is doing new things.";

                    person.About = new Dictionary<AboutType, string>()
                    {
                        {AboutType.Position, "Seniror Testing Engineer in Syncfusion Software Solutions, Chennai"},
                        {AboutType.Work, "Working in .Net platforms (WPF | Xamarin | Flutter | Asp.Net)"},
                        {AboutType.Education, "Studied B.E (Computer Science) in University of British Columbia"},
                        {AboutType.Living,"Living in USA"},
                        {AboutType.Native,"Native is Columbia"},
                        {AboutType.Joined,"Joined on April 22 2000"},
                        {AboutType.Following,"16 Following"},
                        {AboutType.Followers,"8 Followers"}
                    };

                    break;

                case "User002":

                    person.StatusMessage = "The best way to predict the future is to create it.";

                    person.About = new Dictionary<AboutType, string>()
                    {
                        {AboutType.Position, "Seniror UX Designer in Syncfusion Software Solutions, Chennai"},
                        {AboutType.Work, "Working in WebSite designing"},
                        {AboutType.Education, "Studied MA Visual Communication - Birmingham City University"},
                        {AboutType.Living,"Living in USA"},
                        {AboutType.Native,"Native is Birmingham"},
                        {AboutType.Joined,"Joined on May 15 2000"},
                        {AboutType.Following,"36 Following"},
                        {AboutType.Followers,"10 Followers"}
                    };

                    break;
                case "User003":

                    person.StatusMessage = "Be an innovator, not an imitator.";

                    person.About = new Dictionary<AboutType, string>()
                    {
                        {AboutType.Position, "Product Manager in Syncfusion Software Solutions, Chennai" },
                        {AboutType.Work, "Working in .Net platforms (Blazor | Angular | Asp.Net)" },
                        {AboutType.Education, "Studied B.E (Computer Science) in University of Washington"},
                        {AboutType.Living,"Living in USA"},
                        {AboutType.Native,"Native is Washington"},
                        {AboutType.Joined,"Joined on June 18 1995"},
                        {AboutType.Following,"86 Following"},
                        { AboutType.Followers,"25 Followers"}
                    };

                    break;
                case "User004":

                    person.StatusMessage = "The best way to predict the future is to create it.";

                    person.About = new Dictionary<AboutType, string>()
                    {
                        {AboutType.Position, "Team Lead in Syncfusion Software Solutions, Chennai" },
                        {AboutType.Work, "Working in .Net platforms (Xamarin | Flutter | UWP)"},
                        {AboutType.Education, "Studied MCA in Tokyo Institute of Technology"},
                        {AboutType.Living,"Living in USA"},
                        {AboutType.Native,"Native is Tokyo"},
                        {AboutType.Joined,"Joined on April 22 2000"},
                        {AboutType.Following,"36 Following"},
                        {AboutType.Followers,"10 Followers"}
                    };

                    break;
                default:
                    break;
            }
        }
    }
}
