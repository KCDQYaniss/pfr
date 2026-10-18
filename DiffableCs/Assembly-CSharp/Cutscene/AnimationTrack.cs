namespace Cutscene;

public class AnimationTrack
{
	public BakedData lipSyncBackedData; //Field offset: 0x10
	public LipSyncBackedDataRandomVariants lipSyncBackedDataRandomRange; //Field offset: 0x18
	private List randomLipSyncData; //Field offset: 0x20
	private BakedData selectedLipSyncData; //Field offset: 0x28

	public float duration
	{
		 get { } //Length: 613
	}

	public bool HaveData
	{
		 get { } //Length: 374
	}

	public string hint
	{
		 get { } //Length: 502
	}

	public AnimationTrack() { }

	public float get_duration() { }

	public bool get_HaveData() { }

	public string get_hint() { }

	public BakedData GetBackedDataForPlay() { }

}

