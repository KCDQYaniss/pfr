namespace EFT.GlobalEvents;

public class ObservedPlayerChangedEquipEvent : BaseEvent
{
	private string _profileID; //Field offset: 0x18

	public string ProfileId
	{
		 get { } //Length: 5
	}

	public ObservedPlayerChangedEquipEvent() { }

	public string get_ProfileId() { }

	public void Invoke(string victimProfileId) { }

	public virtual void Reset() { }

}

