namespace Audio.AmbientSubsystem.AmbientSplineEmitter.SplineSoundEmitter;

[RequireComponent(typeof(BaseAmbientSoundPlayer))]
public class SoundPlayerSplineTrigger : SplineTriggerAbstract
{
	[SerializeField]
	private BaseAmbientSoundPlayer _ambientSoundPlayer; //Field offset: 0x38

	public SoundPlayerSplineTrigger() { }

	protected virtual void OnAwake() { }

	public virtual void OnTriggered() { }

}

