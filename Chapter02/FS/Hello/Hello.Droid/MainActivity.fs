namespace Hello.Droid

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

[<Activity (Label = "Hello.Droid", MainLauncher = true)>]
type MainActivity () =
    inherit Xamarin.Forms.Platform.Android.FormsAppCompatActivity ()

    override this.OnCreate (bundle) =
        ToolbarResource = Resource.Layout.toolbar
        TabLayoutResource = Resource.Layout.tabs

        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init(this, bundle)
        this.LoadApplication(Hello.App())



