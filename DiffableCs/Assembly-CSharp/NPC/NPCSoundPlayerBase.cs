namespace NPC;

public abstract class NPCSoundPlayerBase : MonoBehaviour
{
	[SerializeField]
	protected NPCAnimationsEventReceiver _animationsEventReceiver; //Field offset: 0x20
	[SerializeField]
	protected Transform _transformForPlaySounds; //Field offset: 0x28

	protected NPCSoundPlayerBase() { }

	private void Awake() { }

	protected override void Clear() { }

	protected override void OnAwake() { }

	private void OnDestroy() { }

	protected override void OnNeedToPlaySomeSound(string soundID) { }

}

