//Type is in global namespace

public class AICorePoint : MonoBehaviour, INetPoint, IPositionPoint, IAICorePointLink
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <Restore>b__0(AICorePoint x) { }

	}

	[SerializeField]
	private int _id; //Field offset: 0x20
	[SerializeField]
	private int _connectionGroupId; //Field offset: 0x24
	[SerializeField]
	private List _connectionsAtNetId; //Field offset: 0x28
	[SerializeField]
	public List ConnectionsAtNet; //Field offset: 0x30
	private bool _isRestored; //Field offset: 0x38
	public AICorePointPathStruct ForPath; //Field offset: 0x40

	public int ConnectionGroupId
	{
		 get { } //Length: 4
	}

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 4
	}

	public override int Id
	{
		 get { } //Length: 4
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public AICorePoint() { }

	public void AddToName(string addName) { }

	public override void AddWay(int id, INetPoint wayTo) { }

	public override void ClearConnections() { }

	public int get_ConnectionGroupId() { }

	public override AICorePoint get_CorePointInGame() { }

	public override int get_Id() { }

	public override Vector3 get_Position() { }

	public void GizmosDrawWays(float h) { }

	private void OnDrawGizmosSelected() { }

	public void Restore(List corePoints) { }

	public void SetIds(int id, int connectId) { }

}

