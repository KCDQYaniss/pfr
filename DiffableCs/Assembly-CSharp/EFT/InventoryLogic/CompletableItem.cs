namespace EFT.InventoryLogic;

public class CompletableItem : Item
{
	internal sealed class CompletableCondition
	{
		[CompilerGenerated]
		private MongoID <CompletableItem>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <IsCompleted>k__BackingField; //Field offset: 0x28

		[JsonProperty("CompletableItem")]
		public MongoID CompletableItem
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			 set { } //Length: 98
		}

		[JsonProperty("IsCompleted")]
		public bool IsCompleted
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public CompletableCondition() { }

		[CompilerGenerated]
		public MongoID get_CompletableItem() { }

		[CompilerGenerated]
		public bool get_IsCompleted() { }

		[CompilerGenerated]
		public void set_CompletableItem(MongoID value) { }

		[CompilerGenerated]
		public void set_IsCompleted(bool value) { }

	}

	internal sealed class QuestStatusCondition
	{
		[CompilerGenerated]
		private string <QuestId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private bool <Started>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private bool <Completed>k__BackingField; //Field offset: 0x19
		[CompilerGenerated]
		private bool <Failed>k__BackingField; //Field offset: 0x1A

		[JsonProperty("Completed")]
		public bool Completed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		[JsonProperty("Failed")]
		public bool Failed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		[JsonProperty("QuestId")]
		public string QuestId
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		[JsonProperty("Started")]
		public bool Started
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public QuestStatusCondition() { }

		[CompilerGenerated]
		public bool get_Completed() { }

		[CompilerGenerated]
		public bool get_Failed() { }

		[CompilerGenerated]
		public string get_QuestId() { }

		[CompilerGenerated]
		public bool get_Started() { }

		public bool IsStatusMatch(EQuestStatus status) { }

		[CompilerGenerated]
		public void set_Completed(bool value) { }

		[CompilerGenerated]
		public void set_Failed(bool value) { }

		[CompilerGenerated]
		public void set_QuestId(string value) { }

		[CompilerGenerated]
		public void set_Started(bool value) { }

	}

	private readonly CompletableTemplate _template; //Field offset: 0x78

	public bool IsPersonal
	{
		 get { } //Length: 45
	}

	public float NotificationDuration
	{
		 get { } //Length: 31
	}

	public virtual bool QuestItem
	{
		 get { } //Length: 3
	}

	public CompletableCondition[] RequiredCompletedItems
	{
		 get { } //Length: 30
	}

	public int RequiredLevel
	{
		 get { } //Length: 29
	}

	public QuestStatusCondition[] RequiredQuestsStatus
	{
		 get { } //Length: 30
	}

	public CompletableItem(string id, CompletableTemplate template) { }

	public bool AllowForSide(EPlayerSide side) { }

	public bool get_IsPersonal() { }

	public float get_NotificationDuration() { }

	public virtual bool get_QuestItem() { }

	public CompletableCondition[] get_RequiredCompletedItems() { }

	public int get_RequiredLevel() { }

	public QuestStatusCondition[] get_RequiredQuestsStatus() { }

}

