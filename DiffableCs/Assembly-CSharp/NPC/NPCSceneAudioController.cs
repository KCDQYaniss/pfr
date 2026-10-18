namespace NPC;

public class NPCSceneAudioController : MonoBehaviourSingleton
{
	[SerializeField]
	private AmbientSoundPlayerGroup _ambientGroup; //Field offset: 0x20
	[SerializeField]
	private bool _enabledReverb; //Field offset: 0x28
	[SerializeField]
	private float _fadeInTime; //Field offset: 0x2C
	[SerializeField]
	private float _fadeOutTime; //Field offset: 0x30
	private SimpleAmbientAudioSystem _simpleAmbientSystem; //Field offset: 0x38

	public NPCSceneAudioController() { }

	public void Clear() { }

	public void Init() { }

	public virtual void OnDestroy() { }

	private void SetAcousticModel(AcousticModel acousticModel) { }

}

