namespace Assets.Scripts.Utils;

public class StateMachine
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__10_0(Enum e, float f) { }

	}

	internal sealed class ActionDel : MulticastDelegate
	{

		public ActionDel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool start, bool end, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool start, bool end) { }

	}

	private class Event
	{
		private class Case
		{
			public Func _action; //Field offset: 0x10
			public int _state; //Field offset: 0x18

			public Case() { }

		}

		private List _cases; //Field offset: 0x10
		private Func _func; //Field offset: 0x18
		public int DefaultState; //Field offset: 0x20

		public Event() { }

		public void AddCase(Func action, int state) { }

		public int GetNextState() { }

		public void SetFunc(Func func) { }

	}

	private class State
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <.cctor>b__8_0(bool s, bool e) { }

		}

		private static readonly ActionDel None; //Field offset: 0x0
		public Enum My; //Field offset: 0x10
		public ActionDel Action; //Field offset: 0x18
		public float Duration; //Field offset: 0x20
		public Dictionary Events; //Field offset: 0x28
		public int OnTimeEndState; //Field offset: 0x30

		private static State() { }

		public State() { }

		public void Initialize(Enum my, ActionDel action, float duration, int onTimeEndState) { }

	}

	private State[] _states; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnStartState; //Field offset: 0x18
	private State _current; //Field offset: 0x20
	private State _next; //Field offset: 0x28
	private State _nextFromEvent; //Field offset: 0x30
	private float _cashedNextTime; //Field offset: 0x38

	public event Action OnStartState
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public Enum CurrentState
	{
		 get { } //Length: 27
	}

	public StateMachine(Type stateEnumType, Enum defaultEvent) { }

	[CompilerGenerated]
	public void add_OnStartState(Action value) { }

	public void AddState(Enum state, ActionDel action = null) { }

	public void AddState(Enum state, float duration, Enum onTimeEndState, ActionDel action = null) { }

	public void AddTransition(Enum fromState, Enum event, Func action) { }

	public void AddTransition(Enum fromState, Enum event, Func action, Enum toState) { }

	public void AddTransition(Enum fromState, Enum event, Enum toState) { }

	private void AddTransition(Enum fromState, Enum event, Enum toState, Func action) { }

	public void DoEvent(Enum event) { }

	public void FixCurrentStateDuration(float newDuration) { }

	public Enum get_CurrentState() { }

	[CompilerGenerated]
	public void remove_OnStartState(Action value) { }

	public void SetNextState(Enum state) { }

	public void SetStateDuration(Enum state, float newDuration) { }

	public void SetStateImmediate(Enum state) { }

	private void StartAnimation(Enum state, float duration) { }

	private bool TimePassed() { }

	public void Update() { }

}

