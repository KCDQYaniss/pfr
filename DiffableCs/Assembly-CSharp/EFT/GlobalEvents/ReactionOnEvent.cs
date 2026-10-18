namespace EFT.GlobalEvents;

public class ReactionOnEvent
{
	public List animationBoolNames; //Field offset: 0x10
	public List animationTriggerNames; //Field offset: 0x18
	public AnimationInt animationInt; //Field offset: 0x20
	public AnimationTrack lipSyncData; //Field offset: 0x28
	public bool clearReactionQueue; //Field offset: 0x30

	public ReactionOnEvent() { }

}

