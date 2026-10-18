namespace EFT.UI.Settings;

public sealed class SoundSettingsTab : SettingsTab
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_0; //Field offset: 0x8
		public static Func <>9__33_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <BindDeviceDropDown>b__31_0(string x) { }

		internal string <ShowSettingSelectSlider>b__33_0(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public SettingDropDown deviceDropDown; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <ShowDenoiseAmountDropDown>b__0() { }

	}

	private readonly ReadOnlyCollection _variants; //Field offset: 0x98
	[SerializeField]
	private Transform _slidersSection; //Field offset: 0xA0
	[SerializeField]
	private Transform _togglesSection; //Field offset: 0xA8
	[SerializeField]
	[Space]
	private SettingSelectSlider _selectSliderPrefab; //Field offset: 0xB0
	[SerializeField]
	private SettingFloatSlider _floatSliderPrefab; //Field offset: 0xB8
	[SerializeField]
	private SettingDropDown _dropDownPrefab; //Field offset: 0xC0
	[SerializeField]
	private SettingToggle _togglePrefab; //Field offset: 0xC8
	[SerializeField]
	[Space]
	private UiElementBlocker _voipEnableBlocker; //Field offset: 0xD0
	[SerializeField]
	private UiElementBlocker _voipBanBlocker; //Field offset: 0xD8
	[SerializeField]
	private CustomTextMeshProUGUI _voipBanMessageText; //Field offset: 0xE0
	[SerializeField]
	private GameObject _voipBanMessage; //Field offset: 0xE8
	[SerializeField]
	[Space]
	private Transform _voipDropDownsSection; //Field offset: 0xF0
	[SerializeField]
	private Transform _voipSlidersSection; //Field offset: 0xF8
	[SerializeField]
	private SettingsTooltip _tooltip; //Field offset: 0x100
	private SoundSettingsGroup _soundSettings; //Field offset: 0x108
	private SoundSettingsController _controller; //Field offset: 0x110
	private ProfileInfo _profileInfo; //Field offset: 0x118
	private ProfileBan _voipBan; //Field offset: 0x120
	private int _cachedSeconds; //Field offset: 0x128
	private SettingDropDown _deviceEnumDropDown; //Field offset: 0x130
	private SettingDropDown _deviceCollectionDropDown; //Field offset: 0x138
	private SettingToggle _voipEnabledToggle; //Field offset: 0x140
	private bool _audioConfigurationSubscribed; //Field offset: 0x148

	public SoundSettingsTab() { }

	[CompilerGenerated]
	private void <ShowDeviceDropDown>b__30_0() { }

	[CompilerGenerated]
	private void <ShowVoipSection>b__36_0() { }

	private void BanChangedHandler(EBanType banType = 2) { }

	private void BindDeviceDropDown(GameSetting setting, ReadOnlyCollection devices) { }

	public virtual void Close() { }

	private void CloseWarningMessage() { }

	protected virtual void OnFirstSelect() { }

	protected virtual void OnSelect() { }

	private void RefreshVoipBanMessage() { }

	private void RefreshVoipSection(bool isDeviceChanged) { }

	public void Show(SoundSettingsGroup soundSettings, ProfileInfo profileInfo) { }

	private void ShowDenoiseAmountDropDown(GameSetting setting, Transform container) { }

	private void ShowDeviceDropDown() { }

	private void ShowDeviceDropDown(GameSetting setting, Transform container, ReadOnlyCollection devices) { }

	private void ShowSettingSelectSlider(GameSetting setting) { }

	private void ShowSettingToggle(GameSetting setting) { }

	private void ShowVoipEnabledToggle() { }

	private void ShowVoipSection() { }

	private void ShowWarningMessage(string message) { }

	public virtual Task TakeSettingsFrom(SettingsManager settingsManager) { }

	private void Update() { }

	private void UpdateVoipEnabledBlocker(bool value) { }

}

