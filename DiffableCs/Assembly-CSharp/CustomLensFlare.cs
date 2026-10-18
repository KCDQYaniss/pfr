//Type is in global namespace

public class CustomLensFlare
{
	internal class Element
	{
		public float Position; //Field offset: 0x10
		public float Size; //Field offset: 0x14
		public float Rotation; //Field offset: 0x18
		public Color Color; //Field offset: 0x1C
		public int X; //Field offset: 0x2C
		public int Y; //Field offset: 0x30
		public int Width; //Field offset: 0x34
		public int Heigth; //Field offset: 0x38
		private Vector3[] _texCoords; //Field offset: 0x40
		private Vector2 _halfSize; //Field offset: 0x48
		private float _screenAspect; //Field offset: 0x50

		public Element() { }

		public void Calc(Vector2 texScale, float screenAspect) { }

		public void Draw(Vector2 pos, float distance, float alpha) { }

	}

	public Material FlareMaterial; //Field offset: 0x10
	public int GridSize; //Field offset: 0x18
	public Element[] Elements; //Field offset: 0x20
	private Vector2 _center; //Field offset: 0x28

	public CustomLensFlare() { }

	public void Draw(Vector2 positionOnScreen) { }

	public void Initialize() { }

}

