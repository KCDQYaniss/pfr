namespace Audio.AudioCulling;

public interface IAudioCullingObject
{

	public event Action AudibleStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public EAudibleState CurrentAudibleState
	{
		 get { } //Length: 0
	}

	public Vector3 CurrentPosition
	{
		 get { } //Length: 0
	}

	public float SqrMaxDistance
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_AudibleStateChanged(Action value) { }

	public void ChangeAudibleState(EAudibleState state) { }

	public EAudibleState get_CurrentAudibleState() { }

	public Vector3 get_CurrentPosition() { }

	public float get_SqrMaxDistance() { }

	[CompilerGenerated]
	public void remove_AudibleStateChanged(Action value) { }

}

