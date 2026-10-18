namespace EFT.UI;

[UsedImplicitly]
public sealed class VoiceSelector : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "localizationKey"})]
		public static Func <>9__11_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Initialize>b__10_0(CustomizationPlayerVoice voice) { }

		internal string <Show>b__11_2(ValueTuple x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string voiceName; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <ChangeVoiceAsync>b__0(CustomizationPlayerVoice v) { }

	}

	[CompilerGenerated]
	private struct <ChangeVoiceAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VoiceSelector <>4__this; //Field offset: 0x20
		private int <selectedIndex>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private DropDownBox _dropdown; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _button; //Field offset: 0x78
	[SerializeField]
	private GameObject _loader; //Field offset: 0x80
	[SerializeField]
	private CanvasGroup _changeVoiceCanvas; //Field offset: 0x88
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "localizationKey"})]
	private readonly List _availableVoices; //Field offset: 0x90
	private int _currentAppliedVoiceIndex; //Field offset: 0x98
	private int _selectedVoiceIndex; //Field offset: 0x9C
	private VoicePreviewSpeaker _voicePreviewSpeaker; //Field offset: 0xA0
	private Func _onVoiceChanged; //Field offset: 0xA8
	private CustomizationPlayerVoice[] _allVoices; //Field offset: 0xB0

	public VoiceSelector() { }

	[CompilerGenerated]
	private IEnumerable <Show>b__11_0() { }

	[CompilerGenerated]
	private void <Show>b__11_1() { }

	[AsyncStateMachine(typeof(<ChangeVoiceAsync>d__14))]
	private Task ChangeVoiceAsync() { }

	public virtual void Close() { }

	private void DropdownValueChanged(int currentIndex) { }

	public void Initialize(string currentVoice, EPlayerSide side, Func onVoiceChanged) { }

	private void SetChangeButtonAvailable(bool currentSelected) { }

	public void Show(bool profileIsFree) { }

	private void UpdateLoaderStatus(bool status) { }

}

