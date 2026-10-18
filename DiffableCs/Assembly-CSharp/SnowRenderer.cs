//Type is in global namespace

internal sealed class SnowRenderer
{
	private sealed class Data : IDisposable
	{
		[CompilerGenerated]
		private readonly string <Name>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Camera <Camera>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private SnowRendererData <RendererData>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private readonly List <Owners>k__BackingField; //Field offset: 0x38
		private int _width; //Field offset: 0x40
		private int _height; //Field offset: 0x44
		private bool _allowHDR; //Field offset: 0x48
		private SSAA _ssaa; //Field offset: 0x50

		internal Camera Camera
		{
			[CompilerGenerated]
			internal get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		internal string Name
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		internal List Owners
		{
			[CompilerGenerated]
			internal get { } //Length: 5
		}

		internal SnowRendererData RendererData
		{
			[CompilerGenerated]
			internal get { } //Length: 21
			[CompilerGenerated]
			private set { } //Length: 98
		}

		private Data(string name) { }

		internal static Data Create(Camera camera) { }

		public override void Dispose() { }

		[CompilerGenerated]
		internal Camera get_Camera() { }

		[CompilerGenerated]
		internal string get_Name() { }

		[CompilerGenerated]
		internal List get_Owners() { }

		[CompilerGenerated]
		internal SnowRendererData get_RendererData() { }

		internal bool HasOwner(Object owner) { }

		private int Height() { }

		[CompilerGenerated]
		private void set_Camera(Camera value) { }

		[CompilerGenerated]
		private void set_RendererData(SnowRendererData value) { }

		internal bool TryUpdate() { }

		private int Width() { }

	}

	private static SnowRenderer _instance; //Field offset: 0x0
	private readonly List _data; //Field offset: 0x10

	internal static SnowRenderer Instance
	{
		internal get { } //Length: 360
	}

	public SnowRenderer() { }

	internal static SnowRenderer get_Instance() { }

	private Data GetOrCreateData(Camera currentCamera, Object owner) { }

	internal RenderTexture GetOrCreateDisableSnowMask(Camera currentCamera, Object owner) { }

	internal SnowRendererData GetOrCreateSnowRenderData(Camera currentCamera, Object owner) { }

	[CanBeNull]
	private Data TryGetData(Camera currentCamera) { }

	internal void TryUnregister(Object owner) { }

	internal void Unregister(Object owner, Camera currentCamera) { }

	internal void Update() { }

}

