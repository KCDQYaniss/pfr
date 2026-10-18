namespace Audio.Weapons;

public interface IAudioFireModeSelector
{

	public event Action FireModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public EEmitterFireMode CurrentFireMode
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_FireModeChanged(Action value) { }

	public EEmitterFireMode get_CurrentFireMode() { }

	[CompilerGenerated]
	public void remove_FireModeChanged(Action value) { }

	public void SetFireMode(EEmitterFireMode fireMode) { }

}

