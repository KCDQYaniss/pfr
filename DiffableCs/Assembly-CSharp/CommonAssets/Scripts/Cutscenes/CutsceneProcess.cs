namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneProcess
{
	public MapTimelineData currentTimelineData; //Field offset: 0x10
	public string currentCutsceneId; //Field offset: 0x68
	public int processId; //Field offset: 0x70
	public List playersInCurrentView; //Field offset: 0x78
	public int playersCutsceneViewed; //Field offset: 0x80
	public float afterStartTimeElapsed; //Field offset: 0x84
	public float syncEventTimer; //Field offset: 0x88
	public bool fixedTimeOn; //Field offset: 0x8C

	public CutsceneProcess() { }

}

