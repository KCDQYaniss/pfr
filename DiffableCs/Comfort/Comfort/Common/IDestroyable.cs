namespace Comfort.Common;

public interface IDestroyable
{

	public event Action DestroyedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool Destroyed
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DestroyedEvent(Action value) { }

	public bool get_Destroyed() { }

	[CompilerGenerated]
	public void remove_DestroyedEvent(Action value) { }

}

