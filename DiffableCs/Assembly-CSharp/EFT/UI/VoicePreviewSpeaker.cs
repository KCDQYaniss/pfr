namespace EFT.UI;

public sealed class VoicePreviewSpeaker
{
	[CompilerGenerated]
	private struct <PlayVoice>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string voiceName; //Field offset: 0x20
		public Func canPlay; //Field offset: 0x28
		public VoicePreviewSpeaker <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public VoicePreviewSpeaker() { }

	private AudioClip Play(TagBank bank) { }

	[AsyncStateMachine(typeof(<PlayVoice>d__0))]
	public Task PlayVoice(string voiceName, Func canPlay = null) { }

}

