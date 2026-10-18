//Type is in global namespace

public class AIGreanageThrowData
{
	public bool CanThrow; //Field offset: 0x10
	public float Ang; //Field offset: 0x14
	public float Force; //Field offset: 0x18
	public Vector3 Direction; //Field offset: 0x1C
	public Vector3 Target; //Field offset: 0x28
	public AIGrenadeThrowPositionPair ThrowPositions; //Field offset: 0x34
	public bool ThrowComplete; //Field offset: 0x4C
	public GameObject HitsObject; //Field offset: 0x50
	public Nullable GrenadeType; //Field offset: 0x58
	private readonly bool _alwaysGood; //Field offset: 0x60
	private readonly float CreatedTime; //Field offset: 0x64

	public AIGreanageThrowData() { }

	public AIGreanageThrowData(GameObject hitsObject) { }

	public AIGreanageThrowData(float ang, float force, Vector3 dir, AIGrenadeThrowPositionPair throwPositions, Vector3 trg, bool alwaysGood, Nullable grenadeType = null) { }

	public bool IsUpToDate() { }

}

