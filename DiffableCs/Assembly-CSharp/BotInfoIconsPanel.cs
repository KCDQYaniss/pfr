//Type is in global namespace

public class BotInfoIconsPanel : MonoBehaviour
{
	private static readonly Color AimObstacleNoneColor; //Field offset: 0x0
	private static readonly Color AimObstacleGrassColor; //Field offset: 0x10
	private static readonly Color AimObstacleTreeColor; //Field offset: 0x20
	private static readonly Color AimObstacleSmokeColor; //Field offset: 0x30
	public BotInfoIcon GrenadeObj; //Field offset: 0x20
	public BotInfoIcon HaveTargetCover; //Field offset: 0x28
	public BotInfoIcon CoverObj; //Field offset: 0x30
	public BotInfoIcon EnemyVisibleObj; //Field offset: 0x38
	public BotInfoIcon LookThoughtGrass; //Field offset: 0x40
	public BotInfoIcon AimObstacleTypeIcon; //Field offset: 0x48
	public BotInfoIcon CanShoot; //Field offset: 0x50
	public BotInfoIcon InBuildingTarget; //Field offset: 0x58
	public BotInfoIcon InBuildingMe; //Field offset: 0x60
	public BotInfoIcon UnderFire; //Field offset: 0x68
	public BotInfoIcon HealObj; //Field offset: 0x70
	public BotInfoIcon DamagedObj; //Field offset: 0x78
	public BotInfoIcon SurgicalObj; //Field offset: 0x80
	public BotInfoIcon StimulatorObj; //Field offset: 0x88
	public BotInfoIcon BotMoverCurrentStateIcon; //Field offset: 0x90
	public BotInfoIcon ParametersChange; //Field offset: 0x98
	public TextMeshProUGUI AmmoRemainField; //Field offset: 0xA0
	public Image IconsBackImageUpper; //Field offset: 0xA8
	public Image IconsBackImageLower; //Field offset: 0xB0
	public BotInfoIcon UnderbarrelLauncherActivityIcon; //Field offset: 0xB8
	public BotInfoIcon UnderbarrelLauncherAmmoIcon; //Field offset: 0xC0
	private Color _noMedsColor; //Field offset: 0xC8
	private RectTransform _rectTransf; //Field offset: 0xD8

	public RectTransform RectTransform
	{
		 get { } //Length: 192
	}

	private static BotInfoIconsPanel() { }

	public BotInfoIconsPanel() { }

	private void EnsureAimObstacleTypeIcon() { }

	public RectTransform get_RectTransform() { }

	private static Color GetAimObstacleTypeColor(ELookObstacleType aimObstacleType) { }

	public void SetBackgroundColor(Color color) { }

	private void UpdateAimObstacleTypeIcon(ELookObstacleType aimObstacleType) { }

	public void UpdateIcons(DebugBotStruct actorDataStruct, EEnemyPartVisibleType panelsPlayerVisibleType, ELookObstacleType aimObstacleType = 0) { }

}

