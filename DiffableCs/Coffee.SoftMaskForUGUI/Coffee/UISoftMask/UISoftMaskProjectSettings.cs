namespace Coffee.UISoftMask;

public class UISoftMaskProjectSettings : PreloadedProjectSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ResetAllSoftMasks>b__29_0(IMaskable c) { }

	}

	internal enum SoftMaskableTracker
	{
		Automatic = 0,
		Manual = 1,
	}

	private static bool s_UseStereoMock; //Field offset: 0x0
	[Header("Setting")]
	[SerializeField]
	[Tooltip("Enable SoftMask globally.")]
	internal bool m_SoftMaskEnabled; //Field offset: 0x18
	[SerializeField]
	[Tooltip("Enable stereo rendering for VR devices.")]
	private bool m_StereoEnabled; //Field offset: 0x19
	[SerializeField]
	[Tooltip("Sensitivity of transform that automatically rebuilds the soft mask buffer.")]
	private TransformSensitivity m_TransformSensitivity; //Field offset: 0x1C
	[SerializeField]
	[Tooltip("Determines how to add SoftMaskable components under SoftMask.\nAutomatic: SoftMaskable components are added automatically as needed.\nManual: You need to add SoftMaskable components explicitly.")]
	private SoftMaskableTracker m_SoftMaskable; //Field offset: 0x20
	[Header("Editor")]
	[SerializeField]
	[Tooltip("Hide the automatically generated components.\n  - MaskingShapeContainer\n  - TerminalMaskingShape")]
	private bool m_HideGeneratedComponents; //Field offset: 0x24
	[HideInInspector]
	[SerializeField]
	private ShaderVariantRegistry m_ShaderVariantRegistry; //Field offset: 0x28

	public static bool addSoftMaskableAutomatically
	{
		 get { } //Length: 71
		 set { } //Length: 76
	}

	public static HideFlags hideFlagsForTemp
	{
		 get { } //Length: 84
	}

	public static ShaderVariantRegistry shaderRegistry
	{
		 get { } //Length: 68
	}

	public static ShaderVariantCollection shaderVariantCollection
	{
		 get { } //Length: 77
	}

	public static bool softMaskEnabled
	{
		 get { } //Length: 68
	}

	public static bool stereoEnabled
	{
		 get { } //Length: 194
	}

	public static TransformSensitivity transformSensitivity
	{
		 get { } //Length: 67
		 set { } //Length: 72
	}

	public static bool useStencilOutsideScreen
	{
		 get { } //Length: 3
	}

	public static bool useStereoMock
	{
		 get { } //Length: 59
		 set { } //Length: 80
	}

	public UISoftMaskProjectSettings() { }

	public static bool get_addSoftMaskableAutomatically() { }

	public static HideFlags get_hideFlagsForTemp() { }

	public static ShaderVariantRegistry get_shaderRegistry() { }

	public static ShaderVariantCollection get_shaderVariantCollection() { }

	public static bool get_softMaskEnabled() { }

	public static bool get_stereoEnabled() { }

	public static TransformSensitivity get_transformSensitivity() { }

	public static bool get_useStencilOutsideScreen() { }

	public static bool get_useStereoMock() { }

	private static void ResetAllSoftMasks() { }

	public static void set_addSoftMaskableAutomatically(bool value) { }

	public static void set_transformSensitivity(TransformSensitivity value) { }

	public static void set_useStereoMock(bool value) { }

}

