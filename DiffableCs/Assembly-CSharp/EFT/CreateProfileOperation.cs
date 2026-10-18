namespace EFT;

public abstract class CreateProfileOperation : Operation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnNicknameValidate>b__13_0(string error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public CreateProfileOperation <>4__this; //Field offset: 0x10
		public Task reservedNicknameTask; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <PrepareCharacterCreationScreenAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public CreateProfileOperation <>4__this; //Field offset: 0x10
		public ISideSelectionScreenController sideSelectionScreenController; //Field offset: 0x18
		public bool cancelledByBack; //Field offset: 0x20

		public <>c__DisplayClass14_0() { }

		internal void <ShowSideSelectionScreen>b__0() { }

		internal void <ShowSideSelectionScreen>g__BackRequested|2() { }

		internal void <ShowSideSelectionScreen>g__Closed|3() { }

		internal void <ShowSideSelectionScreen>g__NicknameChanged|1(string nickname) { }

	}

	[CompilerGenerated]
	private struct <CreateProfile>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CreateProfileOperation <>4__this; //Field offset: 0x20
		public PreliminaryProfileData preliminaryProfile; //Field offset: 0x28
		private IResult <result>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ObtainNewCustomizations>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CreateProfileOperation <>4__this; //Field offset: 0x20
		private CustomizationSolver <customizationSolver>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PrepareCharacterCreationScreenAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CreateProfileOperation <>4__this; //Field offset: 0x20
		private <>c__DisplayClass12_0 <>8__1; //Field offset: 0x28
		public bool allowCancellation; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class PreliminaryProfileData
	{
		public string Nickname; //Field offset: 0x10
		public string HeadId; //Field offset: 0x18
		public string VoiceId; //Field offset: 0x20
		public readonly HashSet SelectedPerkIds; //Field offset: 0x28
		private EPlayerSide _side; //Field offset: 0x30
		[CompilerGenerated]
		private bool <HasSide>k__BackingField; //Field offset: 0x34

		public private bool HasSide
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public EPlayerSide Side
		{
			 get { } //Length: 4
			 set { } //Length: 8
		}

		public PreliminaryProfileData() { }

		[CompilerGenerated]
		public bool get_HasSide() { }

		public EPlayerSide get_Side() { }

		[CompilerGenerated]
		private void set_HasSide(bool value) { }

		public void set_Side(EPlayerSide value) { }

		public void SetSelectedPerks(IEnumerable perks) { }

	}

	protected static Profile _bearProfile; //Field offset: 0x0
	protected static Profile _usecProfile; //Field offset: 0x8
	private readonly PreliminaryProfileData _preliminaryProfile; //Field offset: 0x38
	protected IEftSession _session; //Field offset: 0x40
	protected readonly AFKMonitor _afkMonitor; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Cancelled>k__BackingField; //Field offset: 0x50

	public private bool Cancelled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected CreateProfileOperation() { }

	[AsyncStateMachine(typeof(<CreateProfile>d__17))]
	private Task CreateProfile(PreliminaryProfileData preliminaryProfile) { }

	[CompilerGenerated]
	public bool get_Cancelled() { }

	protected abstract ISetNicknameScreenController GetSetNicknameScreenController(string reservedNickname) { }

	protected abstract ISideSelectionScreenController GetSideSelectionScreenController(Profile bearProfile, Profile usecProfile, PreliminaryProfileData profileData, IClientSession session, bool canCancel, string reservedNickname) { }

	[AsyncStateMachine(typeof(<ObtainNewCustomizations>d__18))]
	private Task ObtainNewCustomizations() { }

	private void OnNicknameValidate(string nickname, ISideSelectionScreenController screenController) { }

	private void PrepareCharacterCreationScreen() { }

	protected void PrepareCharacterCreationScreen(bool allowCancellation) { }

	[AsyncStateMachine(typeof(<PrepareCharacterCreationScreenAsync>d__12))]
	private Task PrepareCharacterCreationScreenAsync(bool allowCancellation) { }

	[CompilerGenerated]
	private void set_Cancelled(bool value) { }

	protected void ShowSideSelectionScreen(bool allowCancellation, string reservedNickname) { }

}

