namespace EFT.UI.Settings;

public sealed class SettingToggle : SettingControl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public GameSetting setting; //Field offset: 0x10
		public SettingToggle <>4__this; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <BindTo>g__ValueChangeHandler|0(bool value) { }

	}

	[SerializeField]
	private UpdatableToggle Toggle; //Field offset: 0xA8

	protected virtual Component TargetComponent
	{
		 get { } //Length: 8
	}

	public SettingToggle() { }

	public SettingToggle BindTo(GameSetting setting) { }

	protected virtual Component get_TargetComponent() { }

}

