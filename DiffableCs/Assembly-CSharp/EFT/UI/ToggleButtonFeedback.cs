namespace EFT.UI;

public abstract class ToggleButtonFeedback : ButtonFeedback
{
	[SerializeField]
	protected EUISoundType _toggleOnSound; //Field offset: 0xA8
	[SerializeField]
	protected EUISoundType _toggleOffSound; //Field offset: 0xAC

	protected abstract bool IsToggledOn
	{
		 get { } //Length: 0
	}

	protected ToggleButtonFeedback() { }

	protected abstract bool get_IsToggledOn() { }

	protected virtual void PlayPointerClickSound() { }

}

