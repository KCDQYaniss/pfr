namespace Audio.Data;

public class BtrDriverSoundDataContainer : IDataContainer
{
	private BtrDriverSoundBankContainer _soundContainer; //Field offset: 0x10
	private readonly Dictionary _pathIdToStationTrigger; //Field offset: 0x18
	private readonly Dictionary _playerSideToGreetingTrigger; //Field offset: 0x20

	public static string LocationID
	{
		 get { } //Length: 64
	}

	public BtrDriverSoundDataContainer() { }

	public static string get_LocationID() { }

	public void SetPhrasesData(BtrDriverSoundBankContainer soundContainer) { }

	public bool TryGetBank(EBtrDriverPhraseTrigger trigger, out SoundBankWithSettings bank) { }

	public bool TryGetGreetingTrigger(EPlayerSide playerSide, out EBtrDriverPhraseTrigger trigger) { }

	public bool TryGetNamedStationTrigger(string pathID, out EBtrDriverPhraseTrigger trigger) { }

}

