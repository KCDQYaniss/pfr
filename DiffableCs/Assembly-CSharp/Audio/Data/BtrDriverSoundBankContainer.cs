namespace Audio.Data;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/BtrDriverSoundBankContainer", fileName = "BtrDriverSoundBankContainer")]
public class BtrDriverSoundBankContainer : SoundBankContainerBase
{
	internal class BtrDriverPhrasesByTrigger : SerializableEnumDictionary
	{

		public BtrDriverPhrasesByTrigger() { }

	}

	[SerializeField]
	private BtrDriverPhrasesByTrigger _phraseData; //Field offset: 0x18

	public BtrDriverSoundBankContainer() { }

	public virtual bool TryGetBank(EBtrDriverPhraseTrigger soundType, out SoundBankWithSettings bank) { }

}

