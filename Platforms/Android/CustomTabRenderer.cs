using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Content;
using Google.Android.Material.Tabs;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Android.Graphics.Color;

namespace MauiApp1.Platforms.Android
{
    public class CustomTabRenderer : ShellRenderer
    {
        public CustomTabRenderer(Context context) : base(context)
        {

        }
        protected override IShellTabLayoutAppearanceTracker CreateTabLayoutAppearanceTracker(ShellSection shellSection)
        {
            return new CustomTabLayoutAppearanceTracker(shellSection);
        }

    }
    internal class CustomTabLayoutAppearanceTracker : IShellTabLayoutAppearanceTracker
    {
        public CustomTabLayoutAppearanceTracker(ShellSection shellSection)
        {

        }
        public void Dispose()
        {

        }
        public void ResetAppearance(TabLayout tabLayout)
        {
            
        }
        public void SetAppearance(TabLayout tabLayout, ShellAppearance appearance)
        {
            tabLayout.TabMode = TabLayout.ModeFixed;
            tabLayout.SetBackgroundColor(Color.White);
            tabLayout.SetTabTextColors(Color.DarkGray, Color.Black);
            tabLayout.SetSelectedTabIndicatorColor(Color.Black);
        }
    }
}
