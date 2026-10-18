namespace EFT.UI;

public class HeadSelectionState : EftScreenState
{
	[CompilerGenerated]
	private struct <ShowState>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HeadSelectionState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnNicknameValueChanged; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnNicknameSubmited; //Field offset: 0x98
	[SerializeField]
	private AppearanceSelector _appearanceSelector; //Field offset: 0xA0
	[SerializeField]
	private NicknameField _nicknameField; //Field offset: 0xA8
	private PreliminaryProfileData _profileData; //Field offset: 0xB0
	private Dictionary _previewProfiles; //Field offset: 0xB8
	private PlayerIconCreatorMaterialChanger _materialChanger; //Field offset: 0xC0
	private Profile _previewProfile; //Field offset: 0xC8
	private bool _isNicknameBackendValid; //Field offset: 0xD0

	public event Action OnNicknameSubmited
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnNicknameValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public virtual string NextButtonDisabledTooltip
	{
		 get { } //Length: 281
	}

	public virtual bool ShowNextButtonWhenNotReady
	{
		 get { } //Length: 3
	}

	protected virtual float TransitionDuration
	{
		 get { } //Length: 9
	}

	public HeadSelectionState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	public void add_OnNicknameSubmited(Action value) { }

	[CompilerGenerated]
	public void add_OnNicknameValueChanged(Action value) { }

	public virtual void Close() { }

	public virtual string get_NextButtonDisabledTooltip() { }

	public virtual bool get_ShowNextButtonWhenNotReady() { }

	protected virtual float get_TransitionDuration() { }

	private void HeadSelectedHandler(MongoID headId) { }

	public virtual Task HideState() { }

	public void Init(PreliminaryProfileData profileData, Dictionary profiles, PlayerIconCreatorMaterialChanger materialChanger, string reservedNickname) { }

	public bool NicknameError(ENicknameError error) { }

	public void NicknameForceSubmit() { }

	private void NicknameValueChangeHandler(string nickname) { }

	[CompilerGenerated]
	public void remove_OnNicknameSubmited(Action value) { }

	[CompilerGenerated]
	public void remove_OnNicknameValueChanged(Action value) { }

	[AsyncStateMachine(typeof(<ShowState>d__20))]
	public virtual Task ShowState() { }

	private void SubmitNicknameHandler(string nickname) { }

	private void UpdateStateReady() { }

	private void VoiceSelectedHandler(MongoID voiceId) { }

}

