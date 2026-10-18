//Type is in global namespace

public class FinalStatisticSceneSettings : MonoBehaviour
{
	internal struct FinalBackgroundPair
	{
		public EFinalType IconType; //Field offset: 0x0
		public Sprite Sprite; //Field offset: 0x8

	}

	internal struct FinalMusicPair
	{
		public EFinalType MusicType; //Field offset: 0x0
		public AudioClipConfig AudioConfig; //Field offset: 0x8

	}

	internal struct FinalStatisticIconPair
	{
		public EFinalStatisticsIcon IconType; //Field offset: 0x0
		public Sprite Sprite; //Field offset: 0x8

	}

	[SerializeField]
	private List _iconsLibrary; //Field offset: 0x20
	[SerializeField]
	private List _finalBackgroundLibrary; //Field offset: 0x28
	[SerializeField]
	private List _finalMusicLibrary; //Field offset: 0x30
	[SerializeField]
	public FinalRewardView RewardViewTemplate; //Field offset: 0x38
	[SerializeField]
	public StatItemRow RowOriginal; //Field offset: 0x40

	public FinalStatisticSceneSettings() { }

	public bool TryGetBackground(EFinalType iconType, out Sprite icon) { }

	public bool TryGetIcon(EFinalStatisticsIcon iconType, out Sprite icon) { }

	public bool TryGetIcon(EFinalType iconType, bool isPvp, out Sprite icon) { }

	public bool TryGetMusic(EFinalType musicType, out AudioClipConfig clip) { }

}

