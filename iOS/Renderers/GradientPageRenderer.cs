using Congreg8.Core.Controls;
using Congreg8.Core.ViewModels;
using Congreg8.iOS.Renderers;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GradientPage<SignInPageViewModel>), typeof(GradientPageRenderer))]
[assembly: ExportRenderer(typeof(GradientPage<Congreg8PageViewModel>), typeof(GradientPageRenderer))]

namespace Congreg8.iOS.Renderers
{

    public class GradientPageRenderer : PageRenderer
    {
        public CAGradientLayer gradient;
        public GradientPageRenderer()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            gradient = new CAGradientLayer();
            gradient.Frame = View.Bounds;
            gradient.NeedsDisplayOnBoundsChange = true;
            gradient.MasksToBounds = true;
            gradient.Colors = new CGColor[] {  UIColor.FromRGB(247, 245, 245).CGColor, UIColor.FromRGB(21, 107, 156).CGColor };
            View.Layer.InsertSublayer(gradient, 0);

        }
        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();
            gradient.Frame = View.Bounds;
        }
    }
}
