//Type is in global namespace

public class SkirmishResultDebug : MonoBehaviour
{
	public Vector3 FromAgressor; //Field offset: 0x20
	public Vector3 ToVictim; //Field offset: 0x2C
	public string Aggressor; //Field offset: 0x38
	public string Victim; //Field offset: 0x40
	public float Dist; //Field offset: 0x48
	public ESkirmishLogType LogType; //Field offset: 0x4C
	public string Part; //Field offset: 0x50
	public string Ricochet; //Field offset: 0x58
	public string Penetrate; //Field offset: 0x60

	public SkirmishResultDebug() { }

	public void Init(Vector3 from, Vector3 to, string aggressor, string victim, ESkirmishLogType logType, string part, string isRicochet, string isPenetrate) { }

	private void OnDrawGizmosSelected() { }

}

