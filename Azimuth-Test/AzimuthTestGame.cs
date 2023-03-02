using Azimuth;
using Azimuth.UI;

using Raylib_cs;

using System.Numerics;

namespace Azimuth_Test
{
	public class AzimuthTestGame : Game
	{
		private Button button;
		private ImageWidget image;

		public override void Load()
		{
			image = new ImageWidget(new Vector2(325, 325), new Vector2(200, 200), "God");
			button = new Button(Vector2.Zero, new Vector2(150, 75), Button.RenderSettings.normal);

			UIManager.Add(image);
			UIManager.Add(button);
		}

		public override void Unload() { }
	}
}