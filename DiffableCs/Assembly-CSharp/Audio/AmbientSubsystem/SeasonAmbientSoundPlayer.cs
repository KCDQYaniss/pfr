namespace Audio.AmbientSubsystem;

public class SeasonAmbientSoundPlayer : BaseRandomAmbientSoundPlayer, ISeasonDependent
{
	internal class SeasonRandomTimeRange : SerializableEnumDictionary
	{

		public SeasonRandomTimeRange() { }

	}

	internal class SeasonSoundBanks : SerializableEnumDictionary
	{

		public SeasonSoundBanks() { }

	}

	[HideInInspector]
	[SerializeField]
	private SeasonSoundBanks _seasonAmbientBanks; //Field offset: 0x120
	[HideInInspector]
	[SerializeField]
	private SeasonRandomTimeRange _seasonRandomTimeRange; //Field offset: 0x128
	private SoundBank _currentBank; //Field offset: 0x130
	private bool _seasonInitialized; //Field offset: 0x138
	private ESeasonStatus _currentSeason; //Field offset: 0x139

	protected virtual SoundBank CurrentBank
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public SeasonAmbientSoundPlayer() { }

	protected virtual bool CanPlay() { }

	protected virtual SoundBank get_CurrentBank() { }

	protected virtual float GetRandomDelay() { }

	protected virtual void set_CurrentBank(SoundBank value) { }

	public override void SetSeasonStatus(ESeasonStatus targetSeasonStatus) { }

	private bool TryGetSoundBankBySeason(ESeasonStatus seasonStatus, out SoundBank bank) { }

}

