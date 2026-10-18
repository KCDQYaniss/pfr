namespace EFT.GlobalEvents;

public class NPCGlobalEventsReacting : MonoBehaviour
{
	internal class AnimationInt
	{
		public string paramName; //Field offset: 0x10
		public bool randomizeValue; //Field offset: 0x18
		public int paramValue; //Field offset: 0x1C
		public int minValue; //Field offset: 0x20
		public int maxValue; //Field offset: 0x24

		public AnimationInt() { }

		public int GetValue() { }

	}

	[SerializeField]
	private List eventsFilters; //Field offset: 0x20
	private Dictionary eventsFiltersDictionary; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnNeedReactOnEvent; //Field offset: 0x30

	public event Action OnNeedReactOnEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public NPCGlobalEventsReacting() { }

	[CompilerGenerated]
	public void add_OnNeedReactOnEvent(Action value) { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnSomeFilterPassed(BaseEventFilter filter, BaseEvent passedEvent) { }

	[CompilerGenerated]
	public void remove_OnNeedReactOnEvent(Action value) { }

}

