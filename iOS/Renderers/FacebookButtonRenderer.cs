using Congreg8.Controls;
using Congreg8.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FacebookButton), typeof(FacebookButtonRenderer))]
namespace Congreg8.iOS.Renderers
{
    public class FacebookButtonRenderer : ButtonRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			//base.OnElementChanged(e);

            if(base.Control == null){
                SetNativeControl(new Facebook.LoginKit.LoginButton()
                {
                    LoginBehavior = Facebook.LoginKit.LoginBehavior.Native
                });
			}

		}
	}
}
