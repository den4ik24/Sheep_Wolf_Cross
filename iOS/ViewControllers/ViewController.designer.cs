// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Sheep_Wolf.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField animalChoice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem ButtonAddAnimal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem CircleOfLife { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelNumberAnimal { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView listOfSheeps { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView mainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView pictureToast { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textNameOfAnimals { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView toastIOS { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView toastView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel typeOfAnimal { get; set; }
        [Action ("ButtonAddAnimal_TouchUpInside:")]
        partial void ButtonAddAnimal_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (animalChoice != null) {
                animalChoice.Dispose ();
                animalChoice = null;
            }

            if (ButtonAddAnimal != null) {
                ButtonAddAnimal.Dispose ();
                ButtonAddAnimal = null;
            }

            if (CircleOfLife != null) {
                CircleOfLife.Dispose ();
                CircleOfLife = null;
            }

            if (LabelNumberAnimal != null) {
                LabelNumberAnimal.Dispose ();
                LabelNumberAnimal = null;
            }

            if (listOfSheeps != null) {
                listOfSheeps.Dispose ();
                listOfSheeps = null;
            }

            if (mainView != null) {
                mainView.Dispose ();
                mainView = null;
            }

            if (pictureToast != null) {
                pictureToast.Dispose ();
                pictureToast = null;
            }

            if (textNameOfAnimals != null) {
                textNameOfAnimals.Dispose ();
                textNameOfAnimals = null;
            }

            if (toastIOS != null) {
                toastIOS.Dispose ();
                toastIOS = null;
            }

            if (toastView != null) {
                toastView.Dispose ();
                toastView = null;
            }

            if (typeOfAnimal != null) {
                typeOfAnimal.Dispose ();
                typeOfAnimal = null;
            }
        }
    }
}