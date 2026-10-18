namespace Audio.AmbientSubsystem;

public interface ISoundPlayer
{

	public event Action Played
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action StartPlay
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action Stopped
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsPlaying
	{
		 get { } //Length: 0
	}

	public Vector3 Position
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Played(Action value) { }

	[CompilerGenerated]
	public void add_StartPlay(Action value) { }

	[CompilerGenerated]
	public void add_Stopped(Action value) { }

	public void FadeIn(float fadeInSec) { }

	public void FadeOut(float fadeOutSec) { }

	public bool get_IsPlaying() { }

	public Vector3 get_Position() { }

	public void Play() { }

	[CompilerGenerated]
	public void remove_Played(Action value) { }

	[CompilerGenerated]
	public void remove_StartPlay(Action value) { }

	[CompilerGenerated]
	public void remove_Stopped(Action value) { }

	public void set_Position(Vector3 value) { }

	public void SetMute(bool muted, bool useFading = true) { }

	public void Stop(bool immediate = false) { }

}

