//Type is in global namespace

public class BotSpawnParams
{
	public string Id_spawn; //Field offset: 0x10
	[CompilerGenerated]
	private SpawnTriggerType <TriggerType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ShallBeGroupParams <ShallBeGroup>k__BackingField; //Field offset: 0x20

	public ShallBeGroupParams ShallBeGroup
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public SpawnTriggerType TriggerType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BotSpawnParams() { }

	public string DebugInfo() { }

	[CompilerGenerated]
	public ShallBeGroupParams get_ShallBeGroup() { }

	[CompilerGenerated]
	public SpawnTriggerType get_TriggerType() { }

	[CompilerGenerated]
	public void set_ShallBeGroup(ShallBeGroupParams value) { }

	[CompilerGenerated]
	public void set_TriggerType(SpawnTriggerType value) { }

}

