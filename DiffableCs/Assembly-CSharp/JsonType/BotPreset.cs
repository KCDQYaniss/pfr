namespace JsonType;

public class BotPreset
{
	public BotDifficulty BotDifficulty; //Field offset: 0x10
	public WildSpawnType Role; //Field offset: 0x14
	public bool UseThis; //Field offset: 0x18
	public float VisibleAngle; //Field offset: 0x1C
	public float VisibleDistance; //Field offset: 0x20
	public float VISIBILITY_CHANGE_SPEED; //Field offset: 0x24
	public float ScatteringPerMeter; //Field offset: 0x28
	public float HearingSense; //Field offset: 0x2C
	public float SCATTERING_DIST_MODIF; //Field offset: 0x30
	public float MAX_AIMING_UPGRADE_BY_TIME; //Field offset: 0x34
	public float FIRST_CONTACT_ADD_SEC; //Field offset: 0x38
	public float COEF_IF_MOVE; //Field offset: 0x3C

	public BotPreset() { }

	public string LogDebugInfo() { }

}

