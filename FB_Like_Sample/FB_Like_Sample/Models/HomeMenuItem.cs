using System;
using System.Collections.Generic;
using System.Text;

namespace FB_Like_Sample.Models
{
    public enum MenuItemType
    {
        Home,
        Profile,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
