namespace EFT.UI.Settings;

public abstract class SettingControl : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public SettingControl <>4__this; //Field offset: 0x10
		public Action action; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal void <SetChangeAction>b__0() { }

	}

	[SerializeField]
	private LocalizedText Text; //Field offset: 0x80
	[SerializeField]
	private UiElementBlocker _blocker; //Field offset: 0x88
	protected Action NotifyUserChanged; //Field offset: 0x90
	private SettingsHoverTooltipArea _tooltipSettingsHover; //Field offset: 0x98
	private UiElementBlocker _elementBlocker; //Field offset: 0xA0

	public UiElementBlocker Blocker
	{
		 get { } //Length: 8
	}

	protected abstract Component TargetComponent
	{
		 get { } //Length: 0
	}

	protected SettingControl() { }

	public UiElementBlocker get_Blocker() { }

	protected abstract Component get_TargetComponent() { }

	public SettingsHoverTooltipArea GetOrCreateTooltip() { }

	protected void InitSetting(IGameSetting setting) { }

	public SettingControl SetChangeAction(Action action) { }

	public SettingControl SetName(string newName) { }

	public SettingControl SetSiblingIndex(int index) { }

	public SettingControl SetText(string localizationKey) { }

	public SettingControl SetTooltip(SettingsTooltipData tooltipData, SettingsTooltip tooltipView) { }

	public override void SetValueText(string value) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

