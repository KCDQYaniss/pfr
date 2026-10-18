namespace EFT.UI.Screens;

public interface IBaseScreenController`1 : IScreenController
{

	public bool Disabled
	{
		 set { } //Length: 0
	}

	public bool KeyScreen
	{
		 get { } //Length: 0
	}

	public IBaseScreenController PreviousScreen
	{
		 get { } //Length: 0
	}

	public bool Queued
	{
		 get { } //Length: 0
	}

	public bool Root
	{
		 get { } //Length: 0
	}

	public IBaseScreenController RootScreen
	{
		 get { } //Length: 0
	}

	public void CloseScreenForced() { }

	public Task CloseSelf(bool forced) { }

	public bool get_KeyScreen() { }

	public IBaseScreenController get_PreviousScreen() { }

	public bool get_Queued() { }

	public bool get_Root() { }

	public IBaseScreenController get_RootScreen() { }

	public void QueueScreen(EScreenState screenState) { }

	public void RestoreScreen() { }

	public Task ReturnToRootScreen() { }

	public void set_Disabled(bool value) { }

	public Task ShowPreviousKeyScreen() { }

	public void ShowScreen(EScreenState screenState) { }

	public void ShowScreenAsPrevious() { }

}

