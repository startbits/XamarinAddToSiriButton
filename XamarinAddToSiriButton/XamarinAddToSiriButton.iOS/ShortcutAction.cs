using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace XamarinAddToSiriButton.iOS
{
    internal static class ShortcutAction
    {
        private static string ActionName => $"{NSBundle.MainBundle.BundleIdentifier}.ShortcutAction";

        internal static NSUserActivity CreateShortcut()
        {
            var userActivity = new NSUserActivity(ActionName);
            userActivity.PersistentIdentifier = ActionName;
            userActivity.Title = "Shortcut";
            userActivity.SuggestedInvocationPhrase = "Open Sesame";
            return userActivity;
        }
    }
}