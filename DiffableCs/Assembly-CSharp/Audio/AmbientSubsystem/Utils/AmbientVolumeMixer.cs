namespace Audio.AmbientSubsystem.Utils;

public class AmbientVolumeMixer
{
	private readonly AudioFader[] _layers; //Field offset: 0x10
	[CompilerGenerated]
	private float <EffectiveVolume>k__BackingField; //Field offset: 0x18

	public float BaseEndVolume
	{
		 get { } //Length: 49
	}

	public float BaseVolume
	{
		 get { } //Length: 49
	}

	public private float EffectiveVolume
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public bool IsBaseFinished
	{
		 get { } //Length: 72
	}

	public bool IsEffectivelySilent
	{
		 get { } //Length: 72
	}

	public AmbientVolumeMixer() { }

	public void FadeTo(EAmbientFadeLayer layer, float target, float duration) { }

	public void ForceUpdateVolume() { }

	public float get_BaseEndVolume() { }

	public float get_BaseVolume() { }

	[CompilerGenerated]
	public float get_EffectiveVolume() { }

	public bool get_IsBaseFinished() { }

	public bool get_IsEffectivelySilent() { }

	public void ResetAll() { }

	[CompilerGenerated]
	private void set_EffectiveVolume(float value) { }

	public void Tick(float dt) { }

}

