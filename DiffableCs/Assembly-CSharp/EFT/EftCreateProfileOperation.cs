namespace EFT;

public sealed class EftCreateProfileOperation : CreateProfileOperation
{
	[CompilerGenerated]
	private struct <Execute>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession session; //Field offset: 0x20
		public bool allowCancellation; //Field offset: 0x28
		private EftCreateProfileOperation <operation>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public EftCreateProfileOperation() { }

	[AsyncStateMachine(typeof(<Execute>d__0))]
	public static Task Execute(IEftSession session, bool allowCancellation = false) { }

	protected virtual ISetNicknameScreenController GetSetNicknameScreenController(string reservedNickname) { }

	protected virtual ISideSelectionScreenController GetSideSelectionScreenController(Profile bearProfile, Profile usecProfile, PreliminaryProfileData profileData, IClientSession session, bool canCancel, string reservedNickname) { }

}

