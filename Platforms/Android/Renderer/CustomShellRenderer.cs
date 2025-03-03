using Android.Content;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility.Platform.Android; 
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using Ohana.Platforms.Android.Renderer; 
[assembly: ExportRenderer(typeof(Shell), typeof(CustomShellRenderer))]
namespace Ohana.Platforms.Android.Renderer
{
    public class CustomShellRenderer : ShellRenderer
    {
        public CustomShellRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Shell> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                // Customize the TabLayout height, for example:
                if (this.TabLayout != null)
                {
                    this.TabLayout.SetMinimumHeight(70); // Set the desired height
                }
            }
        }
    }
}