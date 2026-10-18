namespace EFT.NextObservedPlayer;

public sealed class ObservedPlayerDoorInteractionState : BaseObservedPlayerState
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__2_0; //Field offset: 0x8
		public static Action <>9__9_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <CompleteState>b__9_0(float <p0>) { }

		internal void <OnStateEnter>b__2_0(float <p0>) { }

	}

	private Action _currentStateHandler; //Field offset: 0x58

	public ObservedPlayerDoorInteractionState(IObservedPlayerStateContext context) { }

	private void CompleteHandler(float progress) { }

	private void CompleteState() { }

	private void CreateKeyHandler(float progress) { }

	public virtual void OnStateEnter(float normalizedTime) { }

	public virtual void OnStateExit(float normalizedTime) { }

	public virtual void OnStateMove(float normalizedTime) { }

	public virtual ObservedPlayerAnimatorModel ProcessCommand(ObservedPlayerAnimatorModel model, EPlayerState command) { }

	private void SnapHandler(float progress) { }

}

