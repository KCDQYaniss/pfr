namespace EFT.GlobalEvents;

public class ToggleShowInGameCursorEvent : BaseEvent
{
	private bool _show; //Field offset: 0x18

	public bool Show
	{
		 get { } //Length: 5
	}

	public ToggleShowInGameCursorEvent() { }

	public bool get_Show() { }

	public void Invoke(bool show) { }

	public virtual void Reset() { }

}

