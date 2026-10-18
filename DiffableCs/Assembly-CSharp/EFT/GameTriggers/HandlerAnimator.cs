namespace EFT.GameTriggers;

public class HandlerAnimator : MonoBehaviour, ITriggerEntity
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <get_InputTriggerIds>b__11_0(AnimatorAction animationAction) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string oldId; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <TryRenameId>b__0(AnimatorAction action) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public AnimatorAction animatorAction; //Field offset: 0x10
		public HandlerAnimator <>4__this; //Field offset: 0x50

		public <>c__DisplayClass9_0() { }

		internal void <Start>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <get_OutputTriggerIds>d__13 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
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
		public <get_OutputTriggerIds>d__13(int <>1__state) { }

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

	private struct AnimatorAction
	{
		public string TriggerId; //Field offset: 0x0
		public AnimatorActionBool BoolAction; //Field offset: 0x8
		public AnimatorActionInt IntAction; //Field offset: 0x18
		public AnimatorActionFloat FloatAction; //Field offset: 0x28
		public AnimatorActionTrigger AnimationTriggerAction; //Field offset: 0x38

		public void Execute(Animator animator) { }

	}

	private struct AnimatorActionBool
	{
		public string Name; //Field offset: 0x0
		public bool Value; //Field offset: 0x8

	}

	private struct AnimatorActionFloat
	{
		public string Name; //Field offset: 0x0
		public float Value; //Field offset: 0x8

	}

	private struct AnimatorActionInt
	{
		public string Name; //Field offset: 0x0
		public int Value; //Field offset: 0x8

	}

	private struct AnimatorActionTrigger
	{
		public string TriggerName; //Field offset: 0x0

	}

	[SerializeField]
	private AnimatorAction[] _animatorActions; //Field offset: 0x20
	[SerializeField]
	private Animator _target; //Field offset: 0x28

	public override GameObject GameObject
	{
		 get { } //Length: 78
	}

	public override IEnumerable InputTriggerIds
	{
		 get { } //Length: 354
	}

	public override bool IsClientAuthority
	{
		 get { } //Length: 3
	}

	public override IEnumerable OutputTriggerIds
	{
		[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__13))]
		 get { } //Length: 80
	}

	public HandlerAnimator() { }

	public override GameObject get_GameObject() { }

	public override IEnumerable get_InputTriggerIds() { }

	public override bool get_IsClientAuthority() { }

	[IteratorStateMachine(typeof(<get_OutputTriggerIds>d__13))]
	public override IEnumerable get_OutputTriggerIds() { }

	private void OnValidate() { }

	private void Start() { }

	public override bool TryRenameId(string oldId, string newId) { }

	private bool ValidateTarget(Animator target) { }

}

