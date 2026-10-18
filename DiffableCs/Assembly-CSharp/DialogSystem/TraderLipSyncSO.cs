namespace DialogSystem;

[CreateAssetMenu(fileName = "TraderLipSyncSO", menuName = "ScriptableObjects/Dialog/TraderLipSyncSO")]
public class TraderLipSyncSO : ScriptableObject
{
	internal class LipSyncEntry
	{
		public ETraderType TraderType; //Field offset: 0x10
		public LipSyncDictionary LipSyncDict; //Field offset: 0x18

		public LipSyncEntry() { }

	}

	[SerializeField]
	private List _entries; //Field offset: 0x18
	private Dictionary _cache; //Field offset: 0x20

	private Dictionary Dictionary
	{
		private get { } //Length: 680
	}

	public TraderLipSyncSO() { }

	private Dictionary get_Dictionary() { }

	public bool TryGetValue(ETraderType key, out LipSyncDictionary lypSync) { }

}

