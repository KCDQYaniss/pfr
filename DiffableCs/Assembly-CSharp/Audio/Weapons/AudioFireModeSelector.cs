namespace Audio.Weapons;

public class AudioFireModeSelector : IAudioFireModeSelector
{
	[CompilerGenerated]
	private EEmitterFireMode <CurrentFireMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Action FireModeChanged; //Field offset: 0x18

	public override event Action FireModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private override EEmitterFireMode CurrentFireMode
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public static IAudioFireModeSelector Default
	{
		 get { } //Length: 53
	}

	public AudioFireModeSelector() { }

	[CompilerGenerated]
	public override void add_FireModeChanged(Action value) { }

	[CompilerGenerated]
	public override EEmitterFireMode get_CurrentFireMode() { }

	public static IAudioFireModeSelector get_Default() { }

	[CompilerGenerated]
	public override void remove_FireModeChanged(Action value) { }

	[CompilerGenerated]
	private void set_CurrentFireMode(EEmitterFireMode value) { }

	public override void SetFireMode(EEmitterFireMode fireMode) { }

}

