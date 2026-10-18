namespace EFT.GlobalEvents;

public class GlobalEventsController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0`1
	{
		public Action callback; //Field offset: 0x0
		public GlobalEventsController <>4__this; //Field offset: 0x0
		public Type type; //Field offset: 0x0
		public Action callbackAction; //Field offset: 0x0

		public <>c__DisplayClass15_0`1() { }

		internal void <SubscribeOnEvent>b__0(BaseEvent e) { }

		internal void <SubscribeOnEvent>b__1() { }

	}

	private static GlobalEventsController _instance; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnEventInvoked; //Field offset: 0x8
	private bool _isInited; //Field offset: 0x10
	private Dictionary _eventsSubscribes; //Field offset: 0x18

	public static event Action OnEventInvoked
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public static GlobalEventsController Instance
	{
		 get { } //Length: 383
	}

	public GlobalEventsController() { }

	[CompilerGenerated]
	public static void add_OnEventInvoked(Action value) { }

	public void ApplyEvents() { }

	public void ClearEvents() { }

	public T CreateCommonEvent() { }

	public static T CreateEvent() { }

	public G CreateEvent() { }

	public static GlobalEventsController get_Instance() { }

	public void Initialize() { }

	private void OnBaseEventInvoked(Type eventType, BaseEvent invokedEvent) { }

	[CompilerGenerated]
	public static void remove_OnEventInvoked(Action value) { }

	public Action SubscribeOnEvent(Action callback) { }

	public static bool TryGetEvents(out List eventList) { }

	public static bool TryGetEvents(string eventName, out List eventList) { }

}

