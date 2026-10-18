namespace EFT.Vaulting;

public class VaultingSoundSet
{
	internal class VaultingSoundElement
	{
		[FormerlySerializedAs("SoundStateType")]
		public EVaultingSoundState SoundState; //Field offset: 0x10
		public SoundBank SoundBank; //Field offset: 0x18
		public VolumeRange VolumeRange; //Field offset: 0x20

		public VaultingSoundElement() { }

	}

	[SerializeField]
	private List VaultingBanks; //Field offset: 0x10

	public VaultingSoundSet() { }

	public bool TryGetSoundElement(EVaultingSoundState soundState, out VaultingSoundElement element) { }

}

