//Type is in global namespace

public class CirclePacker : MonoBehaviour
{
	internal class Circle
	{
		public Vector2 Pos; //Field offset: 0x10
		public float Radius; //Field offset: 0x18
		public float Alpha; //Field offset: 0x1C

		public Circle() { }

	}

	private static readonly int _size; //Field offset: 0x0
	public bool Generate; //Field offset: 0x20
	public int Seed; //Field offset: 0x24
	public int Count; //Field offset: 0x28
	[MinMaxVec2(0, 1, -1)]
	public Vector2 Radius; //Field offset: 0x2C
	[Range(0.8, 1.2)]
	public float TuneSize; //Field offset: 0x34
	[Range(1, 255)]
	public int Iterations; //Field offset: 0x38
	[Range(0, 1)]
	public float AlphaRandomness; //Field offset: 0x3C
	public int TextureSize; //Field offset: 0x40
	public bool FadeMips; //Field offset: 0x44
	[MinMaxVec2(0, 1, -1)]
	public Vector2 FadeMinMax; //Field offset: 0x48
	public Material Material; //Field offset: 0x50
	public Material ViewMaterial; //Field offset: 0x58
	public bool ExportTexture; //Field offset: 0x60
	private RenderTexture _outputTexture; //Field offset: 0x68
	private Circle[] _circles; //Field offset: 0x70

	private static CirclePacker() { }

	public CirclePacker() { }

	private static void CalcAlpha(Circle[] circles, float randomness) { }

	private static void DrawQuad(Vector2 center, float size) { }

	private static void Export(Texture2D texture, bool asAsset) { }

	private static void FadeMipMaps(Texture2D texture, float a, float b) { }

	private static Vector2 FixDirection(Vector2 v) { }

	private static Vector2 FixPosition(Vector2 v) { }

	private static void Iterate(Circle[] circles, int iterationCount) { }

	private void OnValidate() { }

	private static void Render(Circle[] circles, Material material, int pass, float tuneSize) { }

	private static Texture2D ToTex(RenderTexture renderTexture, bool mipMaps) { }

}

