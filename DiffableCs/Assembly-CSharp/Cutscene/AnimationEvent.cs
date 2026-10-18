namespace Cutscene;

public class AnimationEvent
{
	public int stateHash; //Field offset: 0x10
	public float time; //Field offset: 0x14
	public AnimationTrack fire; //Field offset: 0x18

	public float duration
	{
		 get { } //Length: 20
	}

	public string hint
	{
		 get { } //Length: 76
	}

	public AnimationEvent() { }

	public float get_duration() { }

	public string get_hint() { }

}

