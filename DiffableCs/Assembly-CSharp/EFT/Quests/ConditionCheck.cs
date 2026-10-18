namespace EFT.Quests;

public struct ConditionCheck
{
	[CompilerGenerated]
	private int <identity>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private object <testValue>k__BackingField; //Field offset: 0x8

	public int identity
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public object testValue
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ConditionCheck(object[] fields) { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_identity() { }

	[CompilerGenerated]
	[IsReadOnly]
	public object get_testValue() { }

	[CompilerGenerated]
	public void set_identity(int value) { }

	[CompilerGenerated]
	public void set_testValue(object value) { }

	public ConditionCheck Test(object value) { }

}

