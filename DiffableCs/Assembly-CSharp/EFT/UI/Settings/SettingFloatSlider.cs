namespace EFT.UI.Settings;

public sealed class SettingFloatSlider : SettingControl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public GameSetting setting; //Field offset: 0x10
		public SettingFloatSlider <>4__this; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <BindTo>g__ValueChangeHandler|0(float value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public GameSetting setting; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <BindTo>b__0(float value) { }

	}

	[SerializeField]
	private NumberSlider Slider; //Field offset: 0xA8

	protected virtual Component TargetComponent
	{
		 get { } //Length: 8
	}

	public SettingFloatSlider() { }

	public SettingFloatSlider BindTo(GameSetting setting, int minValue, int maxValue) { }

	public SettingFloatSlider BindTo(GameSetting setting, float minValue, float maxValue, string format) { }

	protected virtual Component get_TargetComponent() { }

}

