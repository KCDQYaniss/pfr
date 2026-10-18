namespace EFT.Dialogs;

public sealed class DialogSetVariableAction : DialogAction
{
	internal sealed class SaveStateData
	{
		[CompilerGenerated]
		private MongoID <VariableId>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private int <Value>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private ESaveStateType <Storage>k__BackingField; //Field offset: 0x2C

		[JsonProperty("saveScope")]
		public private ESaveStateType Storage
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		[JsonProperty("value")]
		public private int Value
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		[JsonProperty("variableId")]
		public private MongoID VariableId
		{
			[CompilerGenerated]
			 get { } //Length: 21
			[CompilerGenerated]
			private set { } //Length: 98
		}

		[JsonConstructor]
		public SaveStateData(MongoID variableId, int value, ESaveStateType storage = 0) { }

		public void Deconstruct(out MongoID variable, out int value, out ESaveStateType type) { }

		[CompilerGenerated]
		public ESaveStateType get_Storage() { }

		[CompilerGenerated]
		public int get_Value() { }

		[CompilerGenerated]
		public MongoID get_VariableId() { }

		[CompilerGenerated]
		private void set_Storage(ESaveStateType value) { }

		[CompilerGenerated]
		private void set_Value(int value) { }

		[CompilerGenerated]
		private void set_VariableId(MongoID value) { }

		public virtual string ToString() { }

	}

	[JsonProperty("variableId")]
	private MongoID _variableId; //Field offset: 0x30
	[JsonProperty("value")]
	private int _value; //Field offset: 0x48
	[JsonProperty("saveScope")]
	private ESaveStateType _storage; //Field offset: 0x4C
	private SaveStateData _variable; //Field offset: 0x50

	public virtual bool Queued
	{
		 get { } //Length: 33
	}

	public virtual EActionType Type
	{
		 get { } //Length: 6
	}

	public SaveStateData Variable
	{
		 get { } //Length: 322
	}

	[JsonConstructor]
	public DialogSetVariableAction() { }

	public DialogSetVariableAction(SaveStateData variable) { }

	public virtual bool get_Queued() { }

	public virtual EActionType get_Type() { }

	public SaveStateData get_Variable() { }

	public virtual string ToString() { }

}

