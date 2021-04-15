using FB_Like_Sample.Interface;
using FB_Like_Sample.iOS.DependencyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSKeyboardHelper))]
namespace FB_Like_Sample.iOS.DependencyService
{
    public class iOSKeyboardHelper : IKeyboardHelper
    {
        public void HideKeyboard()
        {
            UIApplication.SharedApplication.KeyWindow.EndEditing(true);
        }
    }
}