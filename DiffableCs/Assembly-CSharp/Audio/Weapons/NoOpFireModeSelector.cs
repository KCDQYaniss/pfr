namespace Audio.Weapons;

public class NoOpFireModeSelector : IAudioFireModeSelector
{
	[CompilerGenerated]
	private Action FireModeChanged; //Field offset: 0x10

	public override event Action FireModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override EEmitterFireMode CurrentFireMode
	{
		 get { } //Length: 3
	}

	public NoOpFireModeSelector() { }

	[CompilerGenerated]
	public override void add_FireModeChanged(Action value) { }

	public override EEmitterFireMode get_CurrentFireMode() { }

	[CompilerGenerated]
	public override void remove_FireModeChanged(Action value) { }

	public override void SetFireMode(EEmitterFireMode fireMode) { }

}

