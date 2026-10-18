//Type is in global namespace

public sealed class MetaXRAcousticMaterial : MonoBehaviour, IMaterialDataProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ApplyPropertiesToNative>b__20_0(Transform t) { }

	}

	[SerializeField]
	private MetaXRAcousticMaterialProperties properties; //Field offset: 0x20
	[SerializeField]
	private bool hasCustomData; //Field offset: 0x28
	[SerializeField]
	internal MaterialData customData; //Field offset: 0x30
	private IntPtr materialHandle; //Field offset: 0x38

	internal Color Color
	{
		internal get { } //Length: 103
	}

	public override MaterialData Data
	{
		 get { } //Length: 26
	}

	internal MetaXRAcousticMaterialProperties Properties
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	public MetaXRAcousticMaterial() { }

	internal bool ApplyMaterialProperties() { }

	private static bool ApplyPropertiesToNative(IntPtr handle, MaterialData data) { }

	private static bool ApplyPropertiesToNative(IntPtr handle, MaterialData data, GameObject gameObject) { }

	internal void CopyPresetToCustomData(BuiltinPreset preset) { }

	internal static IntPtr CreateMaterialNativeHandle(MaterialData data = null) { }

	internal void DestroyInternal() { }

	internal static void DestroyMaterialNativeHandle(IntPtr handle) { }

	internal Color get_Color() { }

	public override MaterialData get_Data() { }

	internal MetaXRAcousticMaterialProperties get_Properties() { }

	private override string Meta.XR.Acoustics.IMaterialDataProvider.get_name() { }

	private void OnDestroy() { }

	internal void set_Properties(MetaXRAcousticMaterialProperties value) { }

	private void Start() { }

	internal bool StartInternal() { }

}

