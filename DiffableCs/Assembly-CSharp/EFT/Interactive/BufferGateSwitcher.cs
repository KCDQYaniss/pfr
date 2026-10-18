namespace EFT.Interactive;

public class BufferGateSwitcher : Switch
{
	[CompilerGenerated]
	private sealed class <SmoothDoorOpenCoroutine>d__17 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BufferGateSwitcher <>4__this; //Field offset: 0x20
		public EDoorState state; //Field offset: 0x28
		public bool isLocalInteraction; //Field offset: 0x29
		public float speed; //Field offset: 0x2C

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
		public <SmoothDoorOpenCoroutine>d__17(int <>1__state) { }

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

	[SerializeField]
	private bool _isOpeningEntranceGates; //Field offset: 0x210
	[SerializeField]
	private AudioClip _successfulInteractionSound; //Field offset: 0x218
	[SerializeField]
	private AudioClip _rejectedInteractionSound; //Field offset: 0x220
	private BufferGates _gates; //Field offset: 0x228
	private BufferInnerZone _bufferInnerZone; //Field offset: 0x230
	private IPlayer _lastOpeningPlayer; //Field offset: 0x238
	private bool _interactionWithoutSound; //Field offset: 0x240
	[CompilerGenerated]
	private Action OnIntercatWithSwitch; //Field offset: 0x248

	public event Action OnIntercatWithSwitch
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public EDoorState BufferGatesState
	{
		 get { } //Length: 45
	}

	public bool Interactable
	{
		 get { } //Length: 33
	}

	public BufferGateSwitcher() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0(EDoorState state, bool isLocalInteraction, float speed) { }

	[CompilerGenerated]
	public void add_OnIntercatWithSwitch(Action value) { }

	protected virtual bool CanStartInteraction(EDoorState state, bool logFalse = false) { }

	public EDoorState get_BufferGatesState() { }

	public bool get_Interactable() { }

	private void PlayInteractionSound(bool isSuccessful) { }

	[CompilerGenerated]
	public void remove_OnIntercatWithSwitch(Action value) { }

	public void SetNextInteractionWithoutSound() { }

	public void SetUpReferences(BufferZoneContainer bufferZoneContainer) { }

	[IteratorStateMachine(typeof(<SmoothDoorOpenCoroutine>d__17))]
	protected virtual IEnumerator SmoothDoorOpenCoroutine(EDoorState state, bool isLocalInteraction, float speed = 1) { }

}

