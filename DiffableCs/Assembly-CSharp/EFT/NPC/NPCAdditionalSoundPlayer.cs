namespace EFT.NPC;

public class NPCAdditionalSoundPlayer : NPCSoundPlayerBase
{
	internal struct AudioClipWithID
	{
		public string ID; //Field offset: 0x0
		public AudioClip clip; //Field offset: 0x8

	}

	[SerializeField]
	private List _clips; //Field offset: 0x30
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0x38
	private Dictionary _clipsByID; //Field offset: 0x40

	public NPCAdditionalSoundPlayer() { }

	protected virtual void OnAwake() { }

	protected virtual void OnNeedToPlaySomeSound(string soundID) { }

}

