namespace EFT.NPC;

public class NPCEventWithActionManager
{
	private static NPCEventWithActionManager _instance; //Field offset: 0x0
	private Dictionary actionsOnEndFeedback; //Field offset: 0x10

	public static NPCEventWithActionManager Instance
	{
		 get { } //Length: 383
	}

	public NPCEventWithActionManager() { }

	public T CreateEventWithActionOnEndFeedback(Action actionOnEndFeedback) { }

	public static NPCEventWithActionManager get_Instance() { }

	public Action GetActionOnEndFeedback(int eventID) { }

}

