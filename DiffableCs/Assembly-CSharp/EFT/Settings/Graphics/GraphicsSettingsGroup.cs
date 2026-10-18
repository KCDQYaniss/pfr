namespace EFT.Settings.Graphics;

public sealed class GraphicsSettingsGroup : SettingsGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__58_0; //Field offset: 0x8
		public static Func <>9__58_1; //Field offset: 0x10
		public static Func <>9__58_2; //Field offset: 0x18
		public static Func <>9__58_3; //Field offset: 0x20
		public static Func <>9__58_4; //Field offset: 0x28
		public static Func <>9__58_5; //Field offset: 0x30
		public static Func <>9__58_6; //Field offset: 0x38
		public static Func <>9__58_7; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__58_0(int value) { }

		internal int <.ctor>b__58_1(int value) { }

		internal float <.ctor>b__58_2(float value) { }

		internal int <.ctor>b__58_3(int value) { }

		internal int <.ctor>b__58_4(int value) { }

		internal float <.ctor>b__58_5(float value) { }

		internal float <.ctor>b__58_6(float value) { }

		internal ENvidiaReflexMode <.ctor>b__58_7(ENvidiaReflexMode value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public byte displayIndex; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal bool <GetStoredDisplaySettings>b__0(StoredDisplaySettings stored) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public EftDisplaySettings displaySettings; //Field offset: 0x10

		public <>c__DisplayClass65_0() { }

		internal bool <StoreDisplaySettings>b__0(StoredDisplaySettings stored) { }

	}

	[CompilerGenerated]
	private struct <ApplyDisplaySettingsAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GraphicsSettingsGroup <>4__this; //Field offset: 0x20
		public EftDisplaySettings displaySettings; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const long DLSS_BALANCED_TRIGGER = 3686400; //Field offset: 0x0
	private const long DLSS_PERFORMANCE_TRIGGER = 8294400; //Field offset: 0x0
	public readonly List Stored; //Field offset: 0x18
	public readonly GameSetting DisplaySettings; //Field offset: 0x20
	[CompilerGenerated]
	private bool <InApplyDisplaySettingsProcess>k__BackingField; //Field offset: 0x28
	public readonly GameSetting GraphicsQuality; //Field offset: 0x30
	public readonly GameSetting ShadowsQuality; //Field offset: 0x38
	public readonly GameSetting TextureQuality; //Field offset: 0x40
	public readonly GameSetting CloudsQuality; //Field offset: 0x48
	public readonly GameSetting SDMode; //Field offset: 0x50
	public readonly GameSetting VSync; //Field offset: 0x58
	public readonly GameSetting LobbyFramerate; //Field offset: 0x60
	public readonly GameSetting GameFramerate; //Field offset: 0x68
	public readonly GameSetting DisableGameFramerateLimit; //Field offset: 0x70
	public readonly GameSetting SuperSampling; //Field offset: 0x78
	public readonly GameSetting AnisotropicFiltering; //Field offset: 0x80
	public readonly GameSetting OverallVisibility; //Field offset: 0x88
	public readonly GameSetting LodBias; //Field offset: 0x90
	public readonly GameSetting MipStreamingBufferSize; //Field offset: 0x98
	public readonly GameSetting MipStreamingIOCount; //Field offset: 0xA0
	public readonly GameSetting Ssao; //Field offset: 0xA8
	public readonly GameSetting Sharpen; //Field offset: 0xB0
	public readonly GameSetting SSR; //Field offset: 0xB8
	public readonly GameSetting AntiAliasing; //Field offset: 0xC0
	public readonly GameSetting NVidiaReflex; //Field offset: 0xC8
	public readonly GameSetting HighQualityFog; //Field offset: 0xD0
	public readonly GameSetting GrassShadow; //Field offset: 0xD8
	public readonly GameSetting ChromaticAberrations; //Field offset: 0xE0
	public readonly GameSetting Noise; //Field offset: 0xE8
	public readonly GameSetting ZBlur; //Field offset: 0xF0
	public readonly GameSetting AreaLightsInstancing; //Field offset: 0xF8
	public readonly GameSetting HighQualityColor; //Field offset: 0x100
	public readonly GameSetting SdTarkovStreets; //Field offset: 0x108
	public readonly GameSetting VolumetricLight; //Field offset: 0x110
	public readonly GameSetting DLSSMode; //Field offset: 0x118
	public readonly GameSetting FSR2Mode; //Field offset: 0x120
	public readonly GameSetting FSR3Mode; //Field offset: 0x128
	public readonly GameSetting DLSSPreset; //Field offset: 0x130
	[CanBeNull]
	private readonly GraphicsSettingsController _controller; //Field offset: 0x138
	[CompilerGenerated]
	private string <SystemMessageLocale>k__BackingField; //Field offset: 0x140

	public bool DLSSEnabled
	{
		 get { } //Length: 155
	}

	public bool FSR2Enabled
	{
		 get { } //Length: 155
	}

	public bool FSR3Enabled
	{
		 get { } //Length: 155
	}

	public private bool InApplyDisplaySettingsProcess
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public float ShadowDistance
	{
		 get { } //Length: 216
	}

	public float SuperSamplingFactor
	{
		 get { } //Length: 255
	}

	[JsonProperty]
	public string SystemMessage
	{
		 set { } //Length: 82
	}

	[JsonIgnore]
	public private string SystemMessageLocale
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public GraphicsSettingsGroup(GraphicsSettingsController controller) { }

	private Task ApplyDisplaySettings(EftDisplaySettings displaySettings) { }

	[AsyncStateMachine(typeof(<ApplyDisplaySettingsAsync>d__60))]
	private Task ApplyDisplaySettingsAsync(EftDisplaySettings displaySettings) { }

	public virtual GraphicsSettingsGroup Clone() { }

	private EDLSSMode DLSSModeProcessor(EDLSSMode mode) { }

	private EFSR2Mode FSR2ModeProcessor(EFSR2Mode mode) { }

	private EFSR3Mode FSR3ModeProcessor(EFSR3Mode mode) { }

	public bool get_DLSSEnabled() { }

	public bool get_FSR2Enabled() { }

	public bool get_FSR3Enabled() { }

	[CompilerGenerated]
	public bool get_InApplyDisplaySettingsProcess() { }

	public float get_ShadowDistance() { }

	public float get_SuperSamplingFactor() { }

	[CompilerGenerated]
	public string get_SystemMessageLocale() { }

	public static int GetDLSSQuality(EDLSSMode mode) { }

	private static float GetMaxShadowVisibility(int shadowQuality) { }

	public float GetMipStreamingBias() { }

	public EftDisplaySettings GetStoredDisplaySettings(byte displayIndex) { }

	public EftDisplaySettings GetStoredDisplaySettings(FullScreenMode mode) { }

	private void GetStoredDisplaySettings(ref EftDisplaySettings displaySettings) { }

	public static float GetSuperSamplingFromQuality(ESamplingMode quality) { }

	private static EDLSSMode GetValidatedDLSSMode(EDLSSMode mode, EftResolution resolution) { }

	private static EFSR2Mode GetValidatedFSR2Mode(EFSR2Mode mode, EftResolution resolution) { }

	private static EFSR3Mode GetValidatedFSR3Mode(EFSR3Mode mode, EftResolution resolution) { }

	public static bool Is1XSampling(ESamplingMode samplingQuality) { }

	public bool IsDLSSEnabled() { }

	public bool IsDLSSModeAllowed(EDLSSMode mode) { }

	public bool IsFSR2Enabled() { }

	public bool IsFSR2ModeAllowed(EFSR2Mode mode) { }

	public bool IsFSR3Enabled() { }

	public bool IsFSR3ModeAllowed(EFSR3Mode mode) { }

	public bool IsTaaEnabled() { }

	public bool IsTaaHigh() { }

	public bool IsVolumetricQualityAllowed(ESSRMode mode) { }

	[CompilerGenerated]
	private void set_InApplyDisplaySettingsProcess(bool value) { }

	public void set_SystemMessage(string value) { }

	[CompilerGenerated]
	private void set_SystemMessageLocale(string value) { }

	private void StoreDisplaySettings(EftDisplaySettings displaySettings) { }

	public static int TextureQualityToMipBias(int quality) { }

	private static void ValidateStoredDisplayResolution(ref EftDisplaySettings displaySettings) { }

	private ESSRMode VolumetricModeProcessor(ESSRMode mode) { }

}

