namespace EFT.GameTriggers;

public class TriggerZone : MonoBehaviour, ITriggerEntity, IPhysicsTrigger
{
	[CompilerGenerated]
	private sealed class <get_InputTriggerIds>d__26 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

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
		public <get_InputTriggerIds>d__26(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__28 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TriggerZone <>4__this; //Field offset: 0x28

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
		public <get_OutputTriggerIds>d__28(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <MoveInsideRoutine>d__21 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player player; //Field offset: 0x20
		public TriggerZone <>4__this; //Field offset: 0x28
		private Vector3 <startPos>5__2; //Field offset: 0x30

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
		public <MoveInsideRoutine>d__21(int <>1__state) { }

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

	internal enum EBotPolitic
	{
		Default = 0,
		Ignore = 1,
	}

	internal enum ETriggerTag
	{
		None = 0,
		Trap = 1,
	}

	private enum ETriggerZoneMode
	{
		Enter = 0,
		Exit = 1,
		FirstEnter = 2,
		LastExit = 3,
		OnceEnter = 4,
		MoveInside = 5,
	}

	[SerializeField]
	[Tooltip("Режимы:\nEnter - любой вход в зону.\nEnter - любой выход из зоны.\nFirstEnter - первый игрок вошел в зону (сбрасывается после выхода последнего).\nLastExit - последний игрок вышел из зоны.")]
	private ETriggerZoneMode _mode; //Field offset: 0x20
	[SerializeField]
	private string _triggerId; //Field offset: 0x28
	[SerializeField]
	private ETriggerTag _triggerTag; //Field offset: 0x30
	[SerializeField]
	private EBotPolitic _botPolitic; //Field offset: 0x34
	[SerializeField]
	private float _moveDistanceToTrigger; //Field offset: 0x38
	private float _sqrMoveDistanceToTrigger; //Field offset: 0x3C
	private Dictionary _playerInCollidersCount; //Field offset: 0x40
	private Dictionary _playerMoveInsideCoroutines; //Field offset: 0x48
	private HashSet _playersInside; //Field offset: 0x50
	private bool _wasTriggered; //Field offset: 0x58

	public override string Description
	{
		 get { } //Length: 98
	}

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_InputTriggerIds>d__26))]
		 get { } //Length: 80
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__28))]
		 get { } //Length: 175
	}

	public ETriggerTag TriggerTag
	{
		 get { } //Length: 4
	}

	public TriggerZone() { }

	private void Awake() { }

	private void EmitEvent(Player player, string trigger) { }

	public override string get_Description() { }

	public override GameObject get_GameObject() { }

	[IteratorStateMachine(typeof(<get_InputTriggerIds>d__26))]
	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__28))]
	public override IEnumerable get_OutputTriggerIds() { }

	public ETriggerTag get_TriggerTag() { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	[IteratorStateMachine(typeof(<MoveInsideRoutine>d__21))]
	private IEnumerator MoveInsideRoutine(Player player) { }

	public override void OnTriggerEnter(Collider other) { }

	private void OnTriggerEnterAuthority(Player player) { }

	public override void OnTriggerExit(Collider other) { }

	private void OnTriggerExitAuthority(Player player) { }

	private bool ShouldIgnorePlayer(Player player) { }

	public override bool TryRenameId(string oldId, string newId) { }

}

