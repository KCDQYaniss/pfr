namespace EFT.Hideout;

public class HideoutAmbientAudioFilter : AmbientAudioFilterBase
{
	[SerializeField]
	private float _targetFrequency; //Field offset: 0x20
	[SerializeField]
	private float _targetVolume; //Field offset: 0x24
	[SerializeField]
	private float _targetDuration; //Field offset: 0x28
	private bool _isActive; //Field offset: 0x2C

	public HideoutAmbientAudioFilter() { }

	public virtual void Apply() { }

	public virtual void ResetToDefault() { }

}

