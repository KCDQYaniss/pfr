namespace Audio.AmbientSubsystem;

public class RoomAmbientSoundPlayer : ISoundPlayer
{
	private readonly RoomAmbientData _ambientData; //Field offset: 0x10
	private BetterSource _source; //Field offset: 0x18
	[CompilerGenerated]
	private Action Stopped; //Field offset: 0x20
	[CompilerGenerated]
	private Action Played; //Field offset: 0x28
	[CompilerGenerated]
	private Action StartPlay; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsPlaying>k__BackingField; //Field offset: 0x38

	public override event Action Played
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action StartPlay
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event Action Stopped
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private override bool IsPlaying
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 147
		 set { } //Length: 127
	}

	public RoomAmbientSoundPlayer(RoomAmbientData ambientData) { }

	[CompilerGenerated]
	public override void add_Played(Action value) { }

	[CompilerGenerated]
	public override void add_StartPlay(Action value) { }

	[CompilerGenerated]
	public override void add_Stopped(Action value) { }

	public override void FadeIn(float fadeInSec) { }

	public override void FadeOut(float fadeOutSec) { }

	[CompilerGenerated]
	public override bool get_IsPlaying() { }

	public override Vector3 get_Position() { }

	public override void Play() { }

	[CompilerGenerated]
	public override void remove_Played(Action value) { }

	[CompilerGenerated]
	public override void remove_StartPlay(Action value) { }

	[CompilerGenerated]
	public override void remove_Stopped(Action value) { }

	[CompilerGenerated]
	private void set_IsPlaying(bool value) { }

	public override void set_Position(Vector3 value) { }

	public override void SetMute(bool muted, bool useFading = true) { }

	public override void Stop(bool immediate = false) { }

	private void TryReleaseSourceIfNotNull() { }

}

