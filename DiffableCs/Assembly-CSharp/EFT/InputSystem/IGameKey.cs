namespace EFT.InputSystem;

public interface IGameKey
{

	public InputCombination InUseBy
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool IsAxis
	{
		 get { } //Length: 0
	}

	public EKeyPress Press
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool ReleaseNextFrame
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public InputCombination get_InUseBy() { }

	public bool get_IsAxis() { }

	public EKeyPress get_Press() { }

	public bool get_ReleaseNextFrame() { }

	public float GetValue() { }

	public void set_InUseBy(InputCombination value) { }

	public void set_Press(EKeyPress value) { }

	public void set_ReleaseNextFrame(bool value) { }

}

