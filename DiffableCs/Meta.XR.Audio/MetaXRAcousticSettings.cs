//Type is in global namespace

public class MetaXRAcousticSettings : ScriptableObject
{
	[Tooltip("This is the path inside your Unity project which will store all baked geometry files.")]
	internal const string AcousticFileRootDir = "StreamingAssets/Acoustics"; //Field offset: 0x0
	private static MetaXRAcousticSettings instance; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Select which type of acoustic modeling system is used to generate reverb and reflections.")]
	private AcousticModel acousticModel; //Field offset: 0x18
	[SerializeField]
	[Tooltip("When enabled and using geometry, all spatailized AudioSources will diffract (propagate around corners and obstructions)")]
	private bool diffractionEnabled; //Field offset: 0x1C
	[SerializeField]
	[Tooltip("Geometry will exclude children with these tags")]
	private string[] excludeTags; //Field offset: 0x20
	[SerializeField]
	[Tooltip("When you bake an acoustic map, also bake all the acoustic geometry files")]
	private bool mapBakeWriteGeo; //Field offset: 0x28

	public AcousticModel AcousticModel
	{
		 get { } //Length: 4
		 set { } //Length: 104
	}

	internal bool DiffractionEnabled
	{
		internal get { } //Length: 5
		internal set { } //Length: 103
	}

	internal string[] ExcludeTags
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	public static MetaXRAcousticSettings Instance
	{
		 get { } //Length: 709
	}

	[Tooltip("If enabled, acoustic geometry files will also be written when baking an acoustic map")]
	internal bool MapBakeWriteGeo
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	public MetaXRAcousticSettings() { }

	internal void ApplyAllSettings() { }

	public AcousticModel get_AcousticModel() { }

	internal bool get_DiffractionEnabled() { }

	internal string[] get_ExcludeTags() { }

	public static MetaXRAcousticSettings get_Instance() { }

	internal bool get_MapBakeWriteGeo() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void OnBeforeSceneLoadRuntimeMethod() { }

	public void set_AcousticModel(AcousticModel value) { }

	internal void set_DiffractionEnabled(bool value) { }

	internal void set_ExcludeTags(string[] value) { }

	internal void set_MapBakeWriteGeo(bool value) { }

}

