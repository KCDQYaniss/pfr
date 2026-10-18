namespace EFT.NPC;

public class Reaction
{
	public string AudioReactionName; //Field offset: 0x10
	private List _animationBoolNames; //Field offset: 0x18
	private List _animationTriggerNames; //Field offset: 0x20
	private AnimationInt _animationInt; //Field offset: 0x28
	private AnimationTrack _lipSyncData; //Field offset: 0x30
	private Action _actionOnEndReaction; //Field offset: 0x38
	private bool _animReactionEnded; //Field offset: 0x40
	private bool _audioReactionEnded; //Field offset: 0x41
	private bool _clearReactionQueue; //Field offset: 0x42

	public List AnimationBoolNames
	{
		 get { } //Length: 5
	}

	public AnimationInt AnimationInt
	{
		 get { } //Length: 5
	}

	public List AnimationTriggerNames
	{
		 get { } //Length: 5
	}

	public bool AnimReactionEnded
	{
		 get { } //Length: 5
	}

	public bool AudioReactionEnded
	{
		 get { } //Length: 5
	}

	public bool ClearReactionQueue
	{
		 get { } //Length: 5
	}

	public bool HaveAnyData
	{
		 get { } //Length: 106
	}

	public AnimationTrack LipSyncData
	{
		 get { } //Length: 76
	}

	public Reaction() { }

	public List get_AnimationBoolNames() { }

	public AnimationInt get_AnimationInt() { }

	public List get_AnimationTriggerNames() { }

	public bool get_AnimReactionEnded() { }

	public bool get_AudioReactionEnded() { }

	public bool get_ClearReactionQueue() { }

	public bool get_HaveAnyData() { }

	public AnimationTrack get_LipSyncData() { }

	public bool OnEndAnimReaction() { }

	public bool OnEndAudioReaction() { }

	public void SetUp(Action actionOnEndAnimation, List boolNames, List triggerNames, AnimationInt animationInt, AnimationTrack data, bool clearReactionQueue) { }

	private bool TryCallActionOnEndReaction() { }

}

