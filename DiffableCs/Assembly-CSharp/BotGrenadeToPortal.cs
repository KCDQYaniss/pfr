//Type is in global namespace

public class BotGrenadeToPortal : BotData
{
	[CompilerGenerated]
	private struct <>c__DisplayClass15_0
	{
		public float d; //Field offset: 0x0

	}

	private const float THROW_PLACE_POSSIBLE_THROW = 15; //Field offset: 0x0
	private const float MaxThrowSDist = 2500; //Field offset: 0x0
	private const float MaxEnemyToPortalSDist = 100; //Field offset: 0x0
	private const float PERIOD_GRENADE_TO_PORTALS = 25; //Field offset: 0x0
	private static List _listOfPossibleAng; //Field offset: 0x0
	private float _nextCheck; //Field offset: 0x18
	private int _indexAng; //Field offset: 0x1C
	private bool _canThrow; //Field offset: 0x20

	private static BotGrenadeToPortal() { }

	public BotGrenadeToPortal(BotOwner owner) { }

	[CompilerGenerated]
	internal static float <DirectionOffset>g__oneOff|15_0(ref <>c__DisplayClass15_0 unnamed_param_0) { }

	private bool CanDoThrow(ISpatialPortal portal, out AIGreanageThrowData aiGreanageThrowData) { }

	private void Check() { }

	private bool CheckPortalsToThrow(List portals, EnemyInfo enemy) { }

	private void CheckThrowPlace(EnemyInfo enemy) { }

	private void CheckThrowPlace(IAIDataGrenedaThrowPlace grenedaThrowPlace, EnemyInfo enemy) { }

	private void DirectionOffset(Vector3 dir) { }

	public void ManualUpdate() { }

}

