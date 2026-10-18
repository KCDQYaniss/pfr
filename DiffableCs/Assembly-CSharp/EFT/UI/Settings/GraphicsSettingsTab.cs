namespace EFT.UI.Settings;

public class GraphicsSettingsTab : SettingsTab
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_0; //Field offset: 0x8
		public static Func <>9__33_1; //Field offset: 0x10
		public static Func <>9__33_6; //Field offset: 0x18
		public static Func <>9__33_7; //Field offset: 0x20
		public static Func <>9__33_9; //Field offset: 0x28
		public static Func <>9__33_10; //Field offset: 0x30
		public static Func <>9__35_0; //Field offset: 0x38
		public static Func <>9__35_5; //Field offset: 0x40
		public static Func <>9__36_0; //Field offset: 0x48
		public static Func <>9__36_5; //Field offset: 0x50
		public static Func <>9__37_0; //Field offset: 0x58
		public static Func <>9__38_0; //Field offset: 0x60
		public static Func <>9__43_0; //Field offset: 0x68
		public static Func <>9__44_0; //Field offset: 0x70
		public static Func <>9__62_0; //Field offset: 0x78
		public static Func <>9__63_0; //Field offset: 0x80

		private static <>c() { }

		public <>c() { }

		internal bool <CreateBlockers>b__33_0(bool value) { }

		internal bool <CreateBlockers>b__33_1(bool value) { }

		internal bool <CreateBlockers>b__33_10() { }

		internal bool <CreateBlockers>b__33_6(ENvidiaReflexMode value) { }

		internal bool <CreateBlockers>b__33_7(ESamplingMode value) { }

		internal bool <CreateBlockers>b__33_9() { }

		internal AspectRatio <ShowAspectRatio>b__36_0(EftDisplaySettings settings) { }

		internal string <ShowAspectRatio>b__36_5(AspectRatio x) { }

		internal byte <ShowDisplays>b__38_0(EftDisplaySettings settings) { }

		internal FullScreenMode <ShowFullScreen>b__37_0(EftDisplaySettings settings) { }

		internal string <ShowMipStreamingBuffer>b__62_0(int x) { }

		internal string <ShowMipStreamingDiskUsage>b__63_0(int x) { }

		internal string <ShowObjectQuality>b__43_0(float x) { }

		internal string <ShowOverallVisibility>b__44_0(float x) { }

		internal EftResolution <ShowResolution>b__35_0(EftDisplaySettings settings) { }

		internal string <ShowResolution>b__35_5(EftResolution x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public GraphicsSettingsTab <>4__this; //Field offset: 0x10
		public SettingDropDown control; //Field offset: 0x18
		public GameSettingProxy settingProxy; //Field offset: 0x20

		public <>c__DisplayClass35_0() { }

		internal void <ShowResolution>b__1(EftDisplaySettings _) { }

		internal void <ShowResolution>b__2() { }

		internal Task <ShowResolution>g__SetResolution|4(EftResolution resolution) { }

		internal void <ShowResolution>g__UpdateValues|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public GraphicsSettingsTab <>4__this; //Field offset: 0x10
		public SettingDropDown control; //Field offset: 0x18
		public GameSettingProxy settingProxy; //Field offset: 0x20

		public <>c__DisplayClass36_0() { }

		internal void <ShowAspectRatio>b__1(EftDisplaySettings _) { }

		internal void <ShowAspectRatio>b__2() { }

		internal Task <ShowAspectRatio>g__SetAspectRatio|4(AspectRatio ratio) { }

		internal void <ShowAspectRatio>g__UpdateValues|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public SettingDropDown control; //Field offset: 0x10
		public GameSettingProxy settingProxy; //Field offset: 0x18
		public ReadOnlyCollection variants; //Field offset: 0x20
		public GraphicsSettingsTab <>4__this; //Field offset: 0x28

		public <>c__DisplayClass37_0() { }

		internal void <ShowFullScreen>b__1(EftDisplaySettings _) { }

		internal Task <ShowFullScreen>g__SetFullScreenMode|4(FullScreenMode mode) { }

		internal void <ShowFullScreen>g__UpdateValues|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public GraphicsSettingsTab <>4__this; //Field offset: 0x10
		public SettingDropDown control; //Field offset: 0x18
		public GameSettingProxy settingProxy; //Field offset: 0x20

		public <>c__DisplayClass38_0() { }

		internal void <ShowDisplays>b__1(EftDisplaySettings _) { }

		internal void <ShowDisplays>b__2() { }

		internal Task <ShowDisplays>g__SetDisplay|5(byte displayIndex) { }

		internal void <ShowDisplays>g__UpdateValues|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public ReadOnlyCollection variants; //Field offset: 0x10
		public GraphicsSettingsTab <>4__this; //Field offset: 0x18

		public <>c__DisplayClass41_0() { }

		internal void <ShowTextureQuality>b__1(int _) { }

		internal string <ShowTextureQuality>g__StringConverter|0(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public ReadOnlyCollection variants; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal string <ShowShadowsQuality>g__StringConverter|0(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		private struct <<ChangeDisplaySettings>g__ApplySettings|2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass75_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<ChangeDisplaySettings>g__RevertSettings|3>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass75_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public GraphicsSettingsTab <>4__this; //Field offset: 0x10
		public GameSetting displaySettings; //Field offset: 0x18
		public EftDisplaySettings oldSettings; //Field offset: 0x20
		public EDLSSMode oldDlssMode; //Field offset: 0x38

		public <>c__DisplayClass75_0() { }

		internal void <ChangeDisplaySettings>b__0() { }

		internal void <ChangeDisplaySettings>b__1() { }

		[AsyncStateMachine(typeof(<<ChangeDisplaySettings>g__ApplySettings|2>d))]
		internal Task <ChangeDisplaySettings>g__ApplySettings|2() { }

		[AsyncStateMachine(typeof(<<ChangeDisplaySettings>g__RevertSettings|3>d))]
		internal Task <ChangeDisplaySettings>g__RevertSettings|3() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GetQualityFromIndex; //Field offset: 0x0
		public static Func <1>__GetIndexFromQuality; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <ChangeDisplaySettings>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GraphicsSettingsTab <>4__this; //Field offset: 0x20
		public EftDisplaySettings newSettings; //Field offset: 0x28
		private <>c__DisplayClass75_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <RefreshDropDownsCoroutine>d__72 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GraphicsSettingsTab <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <RefreshDropDownsCoroutine>d__72(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const string ULTRA = "Settings/Graphics/Ultra"; //Field offset: 0x0
	private const string HIGH = "Settings/Graphics/High"; //Field offset: 0x0
	private const string MEDIUM = "Settings/Graphics/Medium"; //Field offset: 0x0
	private const string LOW = "Settings/Graphics/Low"; //Field offset: 0x0
	private const string VERY_LOW = "Settings/Graphics/VeryLow"; //Field offset: 0x0
	public static readonly string[] GraphicsQualityPresets; //Field offset: 0x0
	[SerializeField]
	private Transform _settingsContainer; //Field offset: 0x98
	[SerializeField]
	private ScrollRect _settingsScroll; //Field offset: 0xA0
	[SerializeField]
	private SettingsTooltip _tooltip; //Field offset: 0xA8
	[SerializeField]
	private SettingDropDown _dropDownTemplate; //Field offset: 0xB0
	[SerializeField]
	private SettingToggle _toggleTemplate; //Field offset: 0xB8
	[SerializeField]
	private SettingSelectSlider _selectSliderTemplate; //Field offset: 0xC0
	[SerializeField]
	private SettingFloatSlider _selectFloatSliderTemplate; //Field offset: 0xC8
	[SerializeField]
	private SettingSelectSlider _selectSliderWideTemplate; //Field offset: 0xD0
	private GraphicsSettingsGroup _tempSettings; //Field offset: 0xD8
	private GraphicsSettingsGroup _originalSettings; //Field offset: 0xE0
	private BlockBySettingController _vSyncBlockController; //Field offset: 0xE8
	private BlockBySettingController _framerateBlockController; //Field offset: 0xF0
	private BlockBySettingController _dlssOnBlockController; //Field offset: 0xF8
	private BlockBySettingController _dlssOffBlockController; //Field offset: 0x100
	private BlockBySettingController _fsr2BlockController; //Field offset: 0x108
	private BlockBySettingController _fsr3BlockController; //Field offset: 0x110
	private BlockBySettingController _nvidiaReflexBlockController; //Field offset: 0x118
	private BlockBySettingController _samplingBlockController; //Field offset: 0x120
	private BlockController _inRaidBlockController; //Field offset: 0x128
	private BlockController _nvidiaReflexNotAvailableBlockController; //Field offset: 0x130
	private BlockController _dlssNotAvailableBlockController; //Field offset: 0x138
	private bool _isInRaidBlockersActive; //Field offset: 0x140
	private bool _textureMessageShown; //Field offset: 0x141
	private int _currentControlIndex; //Field offset: 0x144
	private Action _screenValidation; //Field offset: 0x148

	private static GraphicsSettingsTab() { }

	public GraphicsSettingsTab() { }

	[CompilerGenerated]
	private bool <CreateBlockers>b__33_2(EDLSSMode _) { }

	[CompilerGenerated]
	private bool <CreateBlockers>b__33_3(EDLSSMode _) { }

	[CompilerGenerated]
	private bool <CreateBlockers>b__33_4(EFSR2Mode _) { }

	[CompilerGenerated]
	private bool <CreateBlockers>b__33_5(EFSR3Mode _) { }

	[CompilerGenerated]
	private bool <CreateBlockers>b__33_8() { }

	[CompilerGenerated]
	private void <ShowAmdFsr22>b__50_0(EftDisplaySettings _) { }

	[CompilerGenerated]
	private bool <ShowAmdFsr22>g__FSR2ModeValidator|50_1(int modeIndex) { }

	[CompilerGenerated]
	private void <ShowAmdFsr3>b__51_0(EftDisplaySettings _) { }

	[CompilerGenerated]
	private bool <ShowAmdFsr3>g__FSR3ModeValidator|51_1(int modeIndex) { }

	[CompilerGenerated]
	internal static string <ShowDisplays>g__StringConverter|38_4(byte value) { }

	[CompilerGenerated]
	internal static bool <ShowDlssPreset>g__DLSSPresetValidator|49_0(int modeIndex) { }

	[CompilerGenerated]
	internal static string <ShowFullScreen>g__StringConverter|37_3(FullScreenMode mode) { }

	[CompilerGenerated]
	private void <ShowHqColor>b__64_0(bool _) { }

	[CompilerGenerated]
	private void <ShowHqColor>g__ShowValueChangedMessage|64_1() { }

	[CompilerGenerated]
	private bool <ShowNvidiaDlss>g__DLSSModeValidator|48_0(int modeIndex) { }

	[CompilerGenerated]
	private void <ShowOverallQuality>g__ApplyQualitySettings|40_0(Nullable quality) { }

	[CompilerGenerated]
	internal static string <ShowOverallQuality>g__StringConverter|40_1(string input) { }

	[CompilerGenerated]
	private void <ShowVolumeLight>b__47_0(ESSRMode _) { }

	[CompilerGenerated]
	private void <ShowVolumeLight>b__47_1(EFSR2Mode _) { }

	[CompilerGenerated]
	private void <ShowVolumeLight>b__47_2(EFSR3Mode _) { }

	[CompilerGenerated]
	private void <ShowVolumeLight>g__FixVolumetricQuality|47_5() { }

	[CompilerGenerated]
	private void <ShowVolumeLight>g__ShowVolumetricLightChangedMessage|47_4() { }

	[CompilerGenerated]
	private bool <ShowVolumeLight>g__VolumetricLightQualityValidator|47_3(int modeIndex) { }

	[AsyncStateMachine(typeof(<ChangeDisplaySettings>d__75))]
	private Task ChangeDisplaySettings(EftDisplaySettings newSettings) { }

	private void CreateBlockers() { }

	private void CreateControls() { }

	private void LateUpdate() { }

	protected virtual void OnFirstSelect() { }

	[IteratorStateMachine(typeof(<RefreshDropDownsCoroutine>d__72))]
	private IEnumerator RefreshDropDownsCoroutine() { }

	private void SetGraphicQualityLabelToCustom() { }

	public void Show(GraphicsSettingsGroup graphicsSettings, bool isInRaidBlockersActive) { }

	private void ShowAmdFsr22() { }

	private void ShowAmdFsr3() { }

	private void ShowAnisoFilter() { }

	private void ShowAntialiasing() { }

	private void ShowAspectRatio() { }

	private void ShowChromaticAberration() { }

	private void ShowCloudQuality() { }

	private void ShowDisableFramerate() { }

	private void ShowDisplays() { }

	private void ShowDlssPreset() { }

	private void ShowFullScreen() { }

	private void ShowGameFramerate() { }

	private void ShowGrassShadow() { }

	private void ShowHbao() { }

	private void ShowHqColor() { }

	private void ShowInstancingLights() { }

	private void ShowLobbyFramerate() { }

	private void ShowMipStreaming() { }

	private void ShowMipStreamingBuffer() { }

	private void ShowMipStreamingDiskUsage() { }

	private void ShowNoise() { }

	private void ShowNvidiaDlss() { }

	private void ShowNvidiaReflex() { }

	private void ShowObjectQuality() { }

	private void ShowOptimizeTarkovStreets() { }

	private void ShowOverallQuality() { }

	private void ShowOverallVisibility() { }

	private void ShowResampling() { }

	private void ShowResolution() { }

	private void ShowShadowsQuality() { }

	private void ShowSharpen() { }

	private void ShowSsr() { }

	private void ShowTextureQuality() { }

	private void ShowTextureQualityChangedMessage() { }

	private void ShowVolumeLight() { }

	private void ShowVSync() { }

	private void ShowZBlur() { }

	public virtual Task TakeSettingsFrom(SettingsManager settingsManager) { }

	private void ValidateScreen() { }

}

