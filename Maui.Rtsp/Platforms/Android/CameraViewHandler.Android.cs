using Android.Content;
using Android.Views;
using Maui.Rtsp.Controls;
using Microsoft.Maui.Handlers;

namespace Maui.Rtsp.Handlers
{
    public class CameraViewHandler : ViewHandler<ICameraView, SurfaceView>
    {
        public static IPropertyMapper<ICameraView, CameraViewHandler> Mapper = new PropertyMapper<ICameraView, CameraViewHandler>(ViewHandler.ViewMapper)
        {
            [nameof(ICameraView.Url)] = MapUrl
        };

        public CameraViewHandler() : base(Mapper)
        {
        }

        protected override SurfaceView CreatePlatformView()
        {
            return new SurfaceView(Android.App.Application.Context);
        }

        public static void MapUrl(CameraViewHandler handler, ICameraView view)
        {
        }
    }
}
