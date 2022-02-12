using Foundation;
using Intents;
using IntentsUI;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(XamarinAddToSiriButton.MainPage), typeof(XamarinAddToSiriButton.iOS.SiriShortcutPageRenderer))]
namespace XamarinAddToSiriButton.iOS
{
    partial class SiriShortcutPageRenderer : PageRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var siriButton = new INUIAddVoiceShortcutButton(INUIAddVoiceShortcutButtonStyle.Automatic);
            siriButton.Shortcut = new INShortcut(ShortcutAction.CreateShortcut());
            siriButton.Delegate = this;
            siriButton.TranslatesAutoresizingMaskIntoConstraints = false;

            this.View.AddSubview(siriButton);
            this.View.CenterXAnchor.ConstraintEqualTo(siriButton.CenterXAnchor).Active = true;
            this.View.CenterYAnchor.ConstraintEqualTo(siriButton.CenterYAnchor).Active = true;
        }
    }

    partial class SiriShortcutPageRenderer : IINUIAddVoiceShortcutButtonDelegate
    {
        public void PresentAddVoiceShortcut(INUIAddVoiceShortcutViewController addVoiceShortcutViewController, INUIAddVoiceShortcutButton addVoiceShortcutButton)
        {
            addVoiceShortcutViewController.Delegate = this;
            addVoiceShortcutViewController.PresentationController.Delegate = this;
            this.PresentViewController(addVoiceShortcutViewController, true, null);
        }

        public void PresentEditVoiceShortcut(INUIEditVoiceShortcutViewController editVoiceShortcutViewController, INUIAddVoiceShortcutButton addVoiceShortcutButton)
        {
            editVoiceShortcutViewController.Delegate = this;
            editVoiceShortcutViewController.PresentationController.Delegate = this;
            this.PresentViewController(editVoiceShortcutViewController, true, null);
        }
    }

    partial class SiriShortcutPageRenderer : IINUIAddVoiceShortcutViewControllerDelegate
    {
        public void DidCancel(INUIAddVoiceShortcutViewController controller)
        {
            controller.DismissViewController(true, null);
        }

        public void DidFinish(INUIAddVoiceShortcutViewController controller, INVoiceShortcut voiceShortcut, NSError error)
        {
            controller.DismissViewController(true, null);
        }
    }

    partial class SiriShortcutPageRenderer : IINUIEditVoiceShortcutViewControllerDelegate
    {
        public void DidCancel(INUIEditVoiceShortcutViewController controller)
        {
            controller.DismissViewController(true, null);
        }

        public void DidDelete(INUIEditVoiceShortcutViewController controller, NSUuid deletedVoiceShortcutIdentifier)
        {
            controller.DismissViewController(true, null);
        }

        public void DidUpdate(INUIEditVoiceShortcutViewController controller, INVoiceShortcut voiceShortcut, NSError error)
        {
            controller.DismissViewController(true, null);
        }
    }

    partial class SiriShortcutPageRenderer : IUIAdaptivePresentationControllerDelegate
    {
    }
}