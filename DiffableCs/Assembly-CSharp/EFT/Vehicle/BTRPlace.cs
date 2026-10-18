namespace EFT.Vehicle;

public class BTRPlace
{
	internal enum EState
	{
		Free = 0,
		Occupied = 1,
	}

	public Transform Point; //Field offset: 0x10
	[CompilerGenerated]
	private EState <State>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnStateChanged; //Field offset: 0x20

	public event Action OnStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private EState State
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BTRPlace() { }

	[CompilerGenerated]
	public void add_OnStateChanged(Action value) { }

	[CompilerGenerated]
	public EState get_State() { }

	[CompilerGenerated]
	public void remove_OnStateChanged(Action value) { }

	[CompilerGenerated]
	private void set_State(EState value) { }

	public void SyncStateFromServer(byte state) { }

}

