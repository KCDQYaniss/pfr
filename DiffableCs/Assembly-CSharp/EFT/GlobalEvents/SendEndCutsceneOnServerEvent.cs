namespace EFT.GlobalEvents;

public class SendEndCutsceneOnServerEvent : BaseEvent
{
	private int _cutsceneID; //Field offset: 0x18
	private string _sceneName; //Field offset: 0x20

	public int CutsceneID
	{
		 get { } //Length: 4
	}

	public string SceneName
	{
		 get { } //Length: 5
	}

	public SendEndCutsceneOnServerEvent() { }

	public int get_CutsceneID() { }

	public string get_SceneName() { }

	public void Invoke(string sceneName, int cutsceneID) { }

	public virtual void Reset() { }

}

