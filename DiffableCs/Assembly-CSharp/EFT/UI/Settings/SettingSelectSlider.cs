namespace EFT.UI.Settings;

public sealed class SettingSelectSlider : SettingControl
{
	[CompilerGenerated]
	private sealed class <>c__3`1
	{
		public static readonly <>c__3 <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x0
		public static Func <>9__3_1; //Field offset: 0x0

		private static <>c__3`1() { }

		public <>c__3`1() { }

		internal int <BindIndexTo>b__3_0(int input) { }

		internal int <BindIndexTo>b__3_1(int input) { }

	}

	[CompilerGenerated]
	private sealed class <>c__5`1
	{
		public static readonly <>c__5 <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x0
		public static Func <>9__5_1; //Field offset: 0x0

		private static <>c__5`1() { }

		public <>c__5`1() { }

		internal int <BindIndexTo>b__5_0(int input) { }

		internal int <BindIndexTo>b__5_1(Nullable input) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0`1
	{
		public GameSetting setting; //Field offset: 0x0
		public Func indexToSetting; //Field offset: 0x0
		public SettingSelectSlider <>4__this; //Field offset: 0x0
		public Func settingToIndex; //Field offset: 0x0
		public ReadOnlyCollection variants; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal void <BindIndexTo>b__2(int index) { }

		internal void <BindIndexTo>g__SettingChangeHandler|3(int value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0`1
	{
		public ReadOnlyCollection variants; //Field offset: 0x0
		public GameSetting setting; //Field offset: 0x0
		public Func indexToSetting; //Field offset: 0x0
		public SettingSelectSlider <>4__this; //Field offset: 0x0
		public Func settingToIndex; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		internal T <BindIndexTo>b__0(int input) { }

		internal void <BindIndexTo>g__SettingChangeHandler|2(T value) { }

		internal void <BindIndexTo>g__ValueChangeHandler|1(int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0`1
	{
		public GameSetting setting; //Field offset: 0x0
		public Func indexToSetting; //Field offset: 0x0
		public SettingSelectSlider <>4__this; //Field offset: 0x0
		public Func stringConverter; //Field offset: 0x0
		public Func settingToIndex; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		internal void <BindIndexTo>b__2(int index) { }

		internal void <BindIndexTo>g__SettingChangeHandler|3(Nullable value) { }

	}

	[SerializeField]
	private SelectSlider Slider; //Field offset: 0xA8

	protected virtual Component TargetComponent
	{
		 get { } //Length: 8
	}

	public SettingSelectSlider() { }

	public SettingSelectSlider BindIndexTo(GameSetting setting, ReadOnlyCollection variants, Func stringConverter, bool twoWays = false, Func indexToSetting = null, Func settingToIndex = null) { }

	public SettingSelectSlider BindIndexTo(GameSetting setting, ReadOnlyCollection variants, Func stringConverter, bool twoWays = false, Func indexToSetting = null, Func settingToIndex = null) { }

	public SettingSelectSlider BindIndexTo(GameSetting setting, ReadOnlyCollection variants, Func stringConverter, bool twoWays = false, Func indexToSetting = null, Func settingToIndex = null) { }

	protected virtual Component get_TargetComponent() { }

	public virtual void SetValueText(string value) { }

	public static bool UpdateSliderValue(SelectSlider slider, T value, ReadOnlyCollection variants) { }

}

