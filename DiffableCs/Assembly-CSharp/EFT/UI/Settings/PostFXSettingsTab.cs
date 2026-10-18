namespace EFT.UI.Settings;

public class PostFXSettingsTab : SettingsTab
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__21_0; //Field offset: 0x10
		public static Func <>9__23_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <CreateBlockers>b__14_0(bool value) { }

		internal string <ShowColorBlindness>b__23_0(ColorBlindMode x) { }

		internal string <ShowColorGrading>b__21_0(Filter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		private struct <<ShowVisualizeButton>g__Visualize|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass25_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public SettingsScreenController screenController; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		[AsyncStateMachine(typeof(<<ShowVisualizeButton>g__Visualize|0>d))]
		internal void <ShowVisualizeButton>g__Visualize|0() { }

	}

	[SerializeField]
	private RectTransform _mainToggleRoot; //Field offset: 0x98
	[SerializeField]
	private RectTransform _settingsRoot; //Field offset: 0xA0
	[SerializeField]
	private SettingsTooltip _tooltip; //Field offset: 0xA8
	[SerializeField]
	private SettingFloatSlider _selectFloatSliderTemplate; //Field offset: 0xB0
	[SerializeField]
	private SettingDropDown _dropDownTemplate; //Field offset: 0xB8
	[SerializeField]
	private SettingToggle _toggleLeftTemplate; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _visualizeButton; //Field offset: 0xC8
	private BlockBySettingController _postFxBlockController; //Field offset: 0xD0
	private PostFxSettingsGroup _postFXSettingsGroup; //Field offset: 0xD8
	private SettingsScreenController _screenController; //Field offset: 0xE0
	private int _currentControlIndex; //Field offset: 0xE8

	public PostFXSettingsTab() { }

	public virtual void Close() { }

	private void CreateBlockers() { }

	private void CreateControls() { }

	protected virtual void OnFirstSelect() { }

	public void Show(PostFxSettingsGroup settings, SettingsScreenController screenController = null) { }

	private void ShowAdaptiveSharpen() { }

	private void ShowBrightness() { }

	private void ShowClarity() { }

	private void ShowColorBlindness() { }

	private void ShowColorBlindnessIntensity() { }

	private void ShowColorGrading() { }

	private void ShowColorGradingIntensity() { }

	private void ShowContent(SettingsScreenController screenController) { }

	private void ShowEnablePostFx() { }

	private void ShowLumaSharpen() { }

	private void ShowVisualizeButton(SettingsScreenController screenController) { }

	public virtual Task TakeSettingsFrom(SettingsManager settingsManager) { }

}

