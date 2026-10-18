namespace Cutscene;

[CreateAssetMenu(menuName = "uLipSync/Backed data with random variants")]
public class LipSyncBackedDataRandomVariants : ScriptableObject
{
	[SerializeField]
	private BakedData[] bakedData; //Field offset: 0x18

	public BakedData[] BakedData
	{
		 get { } //Length: 5
	}

	public LipSyncBackedDataRandomVariants() { }

	public BakedData[] get_BakedData() { }

}

