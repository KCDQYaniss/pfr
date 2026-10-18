namespace CommonAssets.Scripts.Cutscenes;

public struct MapTimelineData
{
	public string cutsceneId; //Field offset: 0x0
	public string sceneName; //Field offset: 0x8
	public float timelineDuration; //Field offset: 0x10
	public string[] startActionsId; //Field offset: 0x18
	public string[] endActionsId; //Field offset: 0x20
	public bool canSkip; //Field offset: 0x28
	public bool hasSubtitles; //Field offset: 0x29
	public string subtitleId; //Field offset: 0x30
	public TimelineAsset timeline; //Field offset: 0x38
	public List timelineObjectsName; //Field offset: 0x40
	public List timelineObjects; //Field offset: 0x48
	public CutsceneAudioDataSO audioData; //Field offset: 0x50

}

