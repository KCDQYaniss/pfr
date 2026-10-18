namespace EFT.UI;

[CreateAssetMenu(fileName = "SeasonsRanksConfig", menuName = "Scriptable objects/SeasonsRanksConfig")]
public class SeasonsRanksConfig : ScriptableObject
{
	public const string RANK_NAME_FORMAT = "Seasons/Ranks/Rank/{0}"; //Field offset: 0x0
	[SerializeField]
	public Sprite[] RankIcons; //Field offset: 0x18
	[SerializeField]
	public Sprite[] RankIconsUI; //Field offset: 0x20

	public int RanksCount
	{
		 get { } //Length: 26
	}

	public SeasonsRanksConfig() { }

	public int get_RanksCount() { }

	public Sprite GetRankIcon(int rankId) { }

	public string GetRankName(int rankId) { }

	public Sprite GetRankUiIcon(int rankId) { }

	public bool TryGetRankUiIcon(int rankId, out Sprite sprite) { }

}

