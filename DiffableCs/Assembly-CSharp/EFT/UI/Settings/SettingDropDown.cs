namespace EFT.UI.Settings;

public sealed class SettingDropDown : SettingControl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0`1
	{
		private sealed class <<BindToEnum>g__GetFormatLocalizesNames|1>d : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			private string <>2__current; //Field offset: 0x0
			private int <>l__initialThreadId; //Field offset: 0x0
			public <>c__DisplayClass4_0 <>4__this; //Field offset: 0x0
			private IEnumerator <>7__wrap1; //Field offset: 0x0

			private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
			public <<BindToEnum>g__GetFormatLocalizesNames|1>d(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

			[DebuggerHidden]
			private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public GameSetting setting; //Field offset: 0x0
		public SettingDropDown <>4__this; //Field offset: 0x0
		public Func stringConverter; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		internal void <BindToEnum>b__0(int index) { }

		[IteratorStateMachine(typeof(<<BindToEnum>g__GetFormatLocalizesNames|1>d))]
		internal IEnumerable <BindToEnum>g__GetFormatLocalizesNames|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0`1
	{
		public SettingDropDown <>4__this; //Field offset: 0x0
		public ReadOnlyCollection variants; //Field offset: 0x0

		public <>c__DisplayClass5_0`1() { }

		internal void <BindTo>b__0(int _) { }

		internal void <BindTo>b__1(T value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0`1
	{
		private struct <<BindDropDownToSetting>g__SetValue|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public <>c__DisplayClass8_0 <>4__this; //Field offset: 0x0
			public T value; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public GameSetting setting; //Field offset: 0x0
		public DropDownBox dropdown; //Field offset: 0x0
		public ReadOnlyCollection variants; //Field offset: 0x0
		public Func stringConverter; //Field offset: 0x0

		public <>c__DisplayClass8_0`1() { }

		internal IEnumerable <BindDropDownToSetting>b__2() { }

		internal void <BindDropDownToSetting>b__3(int index) { }

		[AsyncStateMachine(typeof(<<BindDropDownToSetting>g__SetValue|0>d))]
		internal Task <BindDropDownToSetting>g__SetValue|0(T value) { }

		internal void <BindDropDownToSetting>g__UpdateValue|1() { }

	}

	[CompilerGenerated]
	private static class <BindToEnum>O__4_0`1
	{
		public static Func <0>__GetLocalizedNames; //Field offset: 0x0

	}

	[SerializeField]
	private DropDownBox DropDown; //Field offset: 0xA8

	protected virtual Component TargetComponent
	{
		 get { } //Length: 8
	}

	public SettingDropDown() { }

	public static Action BindDropDownToSetting(DropDownBox dropdown, GameSetting setting, ReadOnlyCollection variants, Func stringConverter, Func validator = null) { }

	public SettingDropDown BindTo(GameSetting setting, ReadOnlyCollection variants, Func stringConverter, bool twoWays = false, Func validator = null) { }

	public SettingDropDown BindToEnum(GameSetting setting, bool twoWays = false, Func validator = null, Func stringConverter = null) { }

	public virtual void Close() { }

	protected virtual Component get_TargetComponent() { }

	public static ReadOnlyCollection GetIndexCollection(ICollection source) { }

	public SettingDropDown SetSpriteAsset(TMP_SpriteAsset asset) { }

	public virtual void SetValueText(string value) { }

	private void UpdateDropDownEnumValue(T value) { }

	private static bool UpdateDropDownValue(DropDownBox dropdown, T value, ReadOnlyCollection variants) { }

}

