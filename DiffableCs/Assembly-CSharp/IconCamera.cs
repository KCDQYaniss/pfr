//Type is in global namespace

public class IconCamera
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__9_0(Light light) { }

	}

	private const string ICON_RENDERING_KEY = "ICON_RENDERING_ON"; //Field offset: 0x0
	private const int TEXTURE_UPSCALE = 2; //Field offset: 0x0
	private readonly IconShadow _iconShadow; //Field offset: 0x10
	private readonly Light[] _cameraLights; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Camera <CameraObject>k__BackingField; //Field offset: 0x20

	public Camera CameraObject
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IconCamera(Camera prefab, string name) { }

	private Texture2D CopyRenderTextureToTexture(RenderTexture renderTexture, int width, int height) { }

	public void Dispose() { }

	[CompilerGenerated]
	public Camera get_CameraObject() { }

	public Texture2D Render(in IntVec2 size) { }

}

