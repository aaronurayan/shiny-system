namespace Azimuth.GameStates
{
	public interface IGameState
	{
		// ReSharper disable once CommentTypo
		// Resharper disable once IncosistentNaming
		public string ID { get; }

		public void Load();
		public void Unload();
		public void Update(float _deltaTime);
		public void Draw();
	}
}