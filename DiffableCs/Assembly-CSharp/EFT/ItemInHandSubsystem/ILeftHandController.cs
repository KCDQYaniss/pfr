namespace EFT.ItemInHandSubsystem;

public interface ILeftHandController
{

	public event Action OnTakeOrRemoveItem
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool InAction
	{
		 get { } //Length: 0
	}

	public bool IsUsing
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnTakeOrRemoveItem(Action value) { }

	public void Dispose() { }

	public bool get_InAction() { }

	public bool get_IsUsing() { }

	[CompilerGenerated]
	public void remove_OnTakeOrRemoveItem(Action value) { }

	public void RemoveItem(float speed = 1) { }

	public void ToggleHand(Item item) { }

}

