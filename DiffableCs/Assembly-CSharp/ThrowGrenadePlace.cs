//Type is in global namespace

public class ThrowGrenadePlace : MonoBehaviour, IPositionPoint
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Vector3 pos; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal Door <Init>b__0(Door x1, Door x2) { }

	}

	public float GrenadeMass; //Field offset: 0x20
	public float GrenadeForce; //Field offset: 0x24
	public Transform From; //Field offset: 0x28
	public Transform Target; //Field offset: 0x30
	public float AngleForThrow; //Field offset: 0x38
	public float ThrowForce; //Field offset: 0x3C
	public Door Door; //Field offset: 0x40
	public bool IsOk; //Field offset: 0x48
	public Vector3 DoorPos; //Field offset: 0x4C
	public bool HaveDoor; //Field offset: 0x58
	private readonly Vector3 ThrowHeight; //Field offset: 0x5C

	public override Vector3 Position
	{
		 get { } //Length: 138
	}

	public ThrowGrenadePlace() { }

	public void DrawGizmos() { }

	private Door FindDoor(AIGreanageThrowData aiGreandeOutData) { }

	public override Vector3 get_Position() { }

	public AIGreanageThrowData GetData() { }

	public void Init(IEnumerable allDoors) { }

	public bool IsNowValid() { }

	public bool IsValid(string id, bool withSubDoor) { }

	public void OnDrawGizmosSelected() { }

}

