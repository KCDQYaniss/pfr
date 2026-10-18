namespace EFT.GlobalEvents;

public class ObservedPlayerCullingChangedEvent : BaseEvent
{
	private string _profileID; //Field offset: 0x18
	private bool _isVisible; //Field offset: 0x20

	public bool IsVisible
	{
		 get { } //Length: 5
	}

	public string ProfileId
	{
		 get { } //Length: 5
	}

	public ObservedPlayerCullingChangedEvent() { }

	public bool get_IsVisible() { }

	public string get_ProfileId() { }

	public void Invoke(string victimProfileId, bool isVisible) { }

	public virtual void Reset() { }

}

