namespace EFT.UI;

public sealed class AppearanceSelector : UIElement
{
	[CompilerGenerated]
	private struct <PlayVoice>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AppearanceSelector <>4__this; //Field offset: 0x20
		public int selectedIndex; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AppearanceSelector <>4__this; //Field offset: 0x20
		public Profile previewProfile; //Field offset: 0x28
		public PlayerIconCreatorMaterialChanger materialChanger; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdatePreview>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AppearanceSelector <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string VOICE_PREVIEW_TOOLTIP = "Appearance/VoicePreview"; //Field offset: 0x0
	private static readonly EquipmentSlot[] HIDDEN_SLOTS; //Field offset: 0x0
	[SerializeField]
	private DropDownBox _voiceSelector; //Field offset: 0x70
	[SerializeField]
	private FaceCardView _faceCardPrefab; //Field offset: 0x78
	[SerializeField]
	private Transform _faceCardsViewport; //Field offset: 0x80
	[SerializeField]
	private ToggleGroup _faceCardToggleGroup; //Field offset: 0x88
	[SerializeField]
	private PlayerProfilePreview _preview; //Field offset: 0x90
	[SerializeField]
	private Image _bearIcon; //Field offset: 0x98
	[SerializeField]
	private Image _usecIcon; //Field offset: 0xA0
	[SerializeField]
	private DefaultUiButtonNewStyle _voicePreviewButton; //Field offset: 0xA8
	private readonly List _faceCards; //Field offset: 0xB0
	private readonly List _heads; //Field offset: 0xB8
	private readonly List _voices; //Field offset: 0xC0
	private readonly Dictionary _voiceTagBanks; //Field offset: 0xC8
	private Profile _previewProfile; //Field offset: 0xD0
	private PlayerIconCreatorMaterialChanger _materialChanger; //Field offset: 0xD8
	private int _selectedHeadIndex; //Field offset: 0xE0
	private int _selectedVoiceIndex; //Field offset: 0xE4
	[CompilerGenerated]
	private Action OnHeadSelected; //Field offset: 0xE8
	[CompilerGenerated]
	private Action OnVoiceSelected; //Field offset: 0xF0

	public event Action OnHeadSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnVoiceSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private static AppearanceSelector() { }

	public AppearanceSelector() { }

	[CompilerGenerated]
	private void <Show>b__24_0() { }

	[CompilerGenerated]
	private void <Show>b__24_1() { }

	[CompilerGenerated]
	public void add_OnHeadSelected(Action value) { }

	[CompilerGenerated]
	public void add_OnVoiceSelected(Action value) { }

	public virtual void Close() { }

	private void CollectAvailableCustomization() { }

	private void DragHandler(PointerEventData pointerData) { }

	private int FindHeadIndex(MongoID headId) { }

	private int FindVoiceIndex(MongoID voiceId) { }

	private string[] GetVoiceNames() { }

	private void HeadValueChangedHandler(int selectedIndex) { }

	private void HideSlots() { }

	[AsyncStateMachine(typeof(<PlayVoice>d__36))]
	private Task PlayVoice(int selectedIndex) { }

	private void PrepareFaceSelector() { }

	private void PrepareVoiceSelector() { }

	private void PreviewVoice() { }

	[CompilerGenerated]
	public void remove_OnHeadSelected(Action value) { }

	[CompilerGenerated]
	public void remove_OnVoiceSelected(Action value) { }

	public void SetHead(MongoID headId) { }

	private void SetSideIconActive(bool active, Nullable side = null) { }

	public void SetVoice(MongoID voiceId) { }

	[AsyncStateMachine(typeof(<Show>d__24))]
	public Task Show(Profile previewProfile, PlayerIconCreatorMaterialChanger materialChanger = null) { }

	[AsyncStateMachine(typeof(<UpdatePreview>d__31))]
	private Task UpdatePreview() { }

	private void VoiceValueChangedHandler(int selectedIndex) { }

}

