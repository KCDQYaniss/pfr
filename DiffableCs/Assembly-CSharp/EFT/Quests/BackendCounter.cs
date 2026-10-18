namespace EFT.Quests;

public class BackendCounter
{
	[CompilerGenerated]
	private Action OnChanged; //Field offset: 0x10
	public string id; //Field offset: 0x18
	public string qid; //Field offset: 0x20
	private int _value; //Field offset: 0x28

	public event Action OnChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int value
	{
		 get { } //Length: 4
		 set { } //Length: 39
	}

	public BackendCounter() { }

	[CompilerGenerated]
	public void add_OnChanged(Action value) { }

	public int get_value() { }

	[CompilerGenerated]
	public void remove_OnChanged(Action value) { }

	public void set_value(int value) { }

}

