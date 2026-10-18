namespace CommonAssets.Scripts.Audio.RadioSystem;

public class ServerRadioStation : IRadioStation
{
	[CompilerGenerated]
	private sealed class <PlayBroadcast>d__25 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ServerRadioStation <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <PlayBroadcast>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly bool _restartAfterFinished; //Field offset: 0x10
	private readonly BroadcastGrid _broadcastGrid; //Field offset: 0x18
	private readonly MonoBehaviour _coroutineBehaviour; //Field offset: 0x20
	private readonly BroadcastRule _rule; //Field offset: 0x28
	private float _trackStartTime; //Field offset: 0x30
	private float _crossfadeDuration; //Field offset: 0x34
	private Coroutine _broadcastCoroutine; //Field offset: 0x38
	[CompilerGenerated]
	private readonly ERadioStation <Station>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private BroadcastItemData <CurrentBroadcastItem>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private float <CurrentBroadcastTime>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private EBroadcastState <BroadcastState>k__BackingField; //Field offset: 0x54

	public private EBroadcastState BroadcastState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override BroadcastItemData CurrentBroadcastItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override float CurrentBroadcastTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public override ERadioStation Station
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ServerRadioStation(ERadioStation station, BroadcastItemsContainer container, BroadcastRule rule, MonoBehaviour coroutineBehaviour) { }

	[CompilerGenerated]
	public EBroadcastState get_BroadcastState() { }

	[CompilerGenerated]
	public override BroadcastItemData get_CurrentBroadcastItem() { }

	[CompilerGenerated]
	public override float get_CurrentBroadcastTime() { }

	[CompilerGenerated]
	public override ERadioStation get_Station() { }

	public override void Pause() { }

	[IteratorStateMachine(typeof(<PlayBroadcast>d__25))]
	private IEnumerator PlayBroadcast() { }

	[CompilerGenerated]
	private void set_BroadcastState(EBroadcastState value) { }

	[CompilerGenerated]
	private void set_CurrentBroadcastItem(BroadcastItemData value) { }

	[CompilerGenerated]
	private void set_CurrentBroadcastTime(float value) { }

	public override void StartBroadcast() { }

	public override void StopBroadcast() { }

}

