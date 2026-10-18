namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionManageTimelineAssetsByExistQuest : CutsceneBaseAction
{
	public TimelineAsset timelineAsset; //Field offset: 0x40
	public List variantsByQuestManage; //Field offset: 0x48
	public int defaultVariantIndex; //Field offset: 0x50

	public CutsceneActionManageTimelineAssetsByExistQuest() { }

	private void ChangeActiveObjectState(GameObject objectToChange, bool activeState) { }

	private void ChangeMuteTrackState(string trackName, bool muteState) { }

	private TrackAsset FindChildTrackByName(TrackAsset parentTrack, string name) { }

	private ManageAssetsByQuestId GetManageVariantByQuest() { }

	public virtual void Init() { }

}

