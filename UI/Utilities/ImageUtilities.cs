using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;

namespace Mesen.Utilities
{
	public static class ImageUtilities
	{
		public static Image FromAsset(string source)
		{
#if EASTPIXEL_BUILD
			return new Image() { Source = new Bitmap(AssetLoader.Open(new Uri("avares://nesbag2/" + source))) };
#else
			return new Image() { Source = new Bitmap(AssetLoader.Open(new Uri("avares://Mesen/" + source))) };
#endif
		}

		public static Bitmap BitmapFromAsset(string source)
		{
#if EASTPIXEL_BUILD
			return new Bitmap(AssetLoader.Open(new Uri("avares://nesbag2/" + source)));
#else
			return new Bitmap(AssetLoader.Open(new Uri("avares://Mesen/" + source)));
#endif
		}
	}
}
