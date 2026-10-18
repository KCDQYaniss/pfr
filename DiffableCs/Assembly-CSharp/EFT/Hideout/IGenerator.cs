namespace EFT.Hideout;

public interface IGenerator : IHideoutStart
{

	public event Action OnWorkingStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsWorking
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnWorkingStateChanged(Action value) { }

	public bool get_IsWorking() { }

	[CompilerGenerated]
	public void remove_OnWorkingStateChanged(Action value) { }

	public void SetSwitchedStatus(bool isOn) { }

	public bool Work(float deltaTime) { }

}

