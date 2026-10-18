//Type is in global namespace

public class AIExfiltrationPoint : IAICorePointLink
{
	[CompilerGenerated]
	private readonly AICorePoint <CorePointInGame>k__BackingField; //Field offset: 0x10
	[SerializeField]
	private int _id; //Field offset: 0x18
	[SerializeField]
	private Vector3 _pos; //Field offset: 0x1C
	[SerializeField]
	private List _posAdditional; //Field offset: 0x28
	private AICorePoint _core; //Field offset: 0x30
	[SerializeField]
	private int _coreId; //Field offset: 0x38
	[SerializeField]
	private string _name; //Field offset: 0x40
	[CompilerGenerated]
	private ExfiltrationPoint <ExfiltrationPoint>k__BackingField; //Field offset: 0x48

	public override AICorePoint CorePointInGame
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private ExfiltrationPoint ExfiltrationPoint
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float ExfiltrationTime
	{
		 get { } //Length: 40
	}

	public int Id
	{
		 get { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public override Vector3 Position
	{
		 get { } //Length: 19
	}

	public AIExfiltrationPoint(int id, Vector3 stayPoint, AICorePoint core, ExfiltrationPoint exfiltration) { }

	public void AddPositionAdditional(Vector3 pos) { }

	public void DrawGizmos() { }

	[CompilerGenerated]
	public override AICorePoint get_CorePointInGame() { }

	[CompilerGenerated]
	public ExfiltrationPoint get_ExfiltrationPoint() { }

	public float get_ExfiltrationTime() { }

	public int get_Id() { }

	public string get_Name() { }

	public override Vector3 get_Position() { }

	public Vector3 GetPosition(BotOwner owner) { }

	public void LinkExfiltration(ExfiltrationPoint point) { }

	public void Restore(AICorePointHolder coresHolder) { }

	[CompilerGenerated]
	private void set_ExfiltrationPoint(ExfiltrationPoint value) { }

}

