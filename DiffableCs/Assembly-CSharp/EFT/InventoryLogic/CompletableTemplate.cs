namespace EFT.InventoryLogic;

public class CompletableTemplate : ItemTemplate
{
	[CompilerGenerated]
	private float <NotificationDuration>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private int <RequiredLevel>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private QuestStatusCondition[] <QuestConditions>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private CompletableCondition[] <CompletableConditions>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private bool <AllowBear>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private bool <AllowUsec>k__BackingField; //Field offset: 0x161
	[CompilerGenerated]
	private bool <AllowSavage>k__BackingField; //Field offset: 0x162

	[JsonProperty("AllowBear")]
	public bool AllowBear
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[JsonProperty("AllowSavage")]
	public bool AllowSavage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[JsonProperty("AllowUsec")]
	public bool AllowUsec
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[JsonProperty("CompletableConditions")]
	public CompletableCondition[] CompletableConditions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonProperty("NotificationDuration")]
	public float NotificationDuration
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	[JsonProperty("QuestConditions")]
	public QuestStatusCondition[] QuestConditions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	[JsonProperty("RequiredLevel")]
	public int RequiredLevel
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public CompletableTemplate() { }

	[CompilerGenerated]
	public bool get_AllowBear() { }

	[CompilerGenerated]
	public bool get_AllowSavage() { }

	[CompilerGenerated]
	public bool get_AllowUsec() { }

	[CompilerGenerated]
	public CompletableCondition[] get_CompletableConditions() { }

	[CompilerGenerated]
	public float get_NotificationDuration() { }

	[CompilerGenerated]
	public QuestStatusCondition[] get_QuestConditions() { }

	[CompilerGenerated]
	public int get_RequiredLevel() { }

	[CompilerGenerated]
	public void set_AllowBear(bool value) { }

	[CompilerGenerated]
	public void set_AllowSavage(bool value) { }

	[CompilerGenerated]
	public void set_AllowUsec(bool value) { }

	[CompilerGenerated]
	public void set_CompletableConditions(CompletableCondition[] value) { }

	[CompilerGenerated]
	public void set_NotificationDuration(float value) { }

	[CompilerGenerated]
	public void set_QuestConditions(QuestStatusCondition[] value) { }

	[CompilerGenerated]
	public void set_RequiredLevel(int value) { }

}

