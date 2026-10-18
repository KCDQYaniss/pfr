namespace UnityEngine.UIElements;

public class VisualElementFocusChangeDirection : FocusChangeDirection
{
	private static readonly VisualElementFocusChangeDirection s_Left; //Field offset: 0x0
	private static readonly VisualElementFocusChangeDirection s_Right; //Field offset: 0x8

	public static FocusChangeDirection left
	{
		 get { } //Length: 83
	}

	public static FocusChangeDirection right
	{
		 get { } //Length: 84
	}

	private static VisualElementFocusChangeDirection() { }

	protected VisualElementFocusChangeDirection(int value) { }

	public static FocusChangeDirection get_left() { }

	public static FocusChangeDirection get_right() { }

}

