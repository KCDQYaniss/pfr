namespace EFT.GlobalEvents;

public abstract class BaseEventFilter : MonoBehaviour
{
	[CompilerGenerated]
	private Action OnFilterPassed; //Field offset: 0x20

	public event Action OnFilterPassed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected BaseEventFilter() { }

	[CompilerGenerated]
	public void add_OnFilterPassed(Action value) { }

	private void Awake() { }

	protected abstract bool IsFilterPassed(BaseEvent eventToFilter) { }

	private void OnDestroy() { }

	private void OnEventInvoked(BaseEvent invokedEvent) { }

	[CompilerGenerated]
	public void remove_OnFilterPassed(Action value) { }

}

