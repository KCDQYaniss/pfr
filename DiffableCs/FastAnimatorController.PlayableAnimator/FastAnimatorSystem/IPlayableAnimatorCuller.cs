namespace FastAnimatorSystem;

public interface IPlayableAnimatorCuller
{

	public bool IsImportantParameterChanged
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_IsImportantParameterChanged() { }

	public bool ProcessAnimator(bool isVisible) { }

	public void set_IsImportantParameterChanged(bool value) { }

}

