namespace EFT.ItemGameSounds;

public class ItemImpactSoundProfile
{
	private class SurfaceSoundDictionary : SerializableEnumDictionary
	{

		public SurfaceSoundDictionary() { }

	}

	[SerializeField]
	private string _soundId; //Field offset: 0x10
	[SerializeField]
	private SurfaceSoundDictionary _soundBanks; //Field offset: 0x18

	public string SoundID
	{
		 get { } //Length: 5
	}

	public ItemImpactSoundProfile() { }

	public string get_SoundID() { }

	public bool TryGetBank(ESurfaceSound surface, out SoundBank bank) { }

}

