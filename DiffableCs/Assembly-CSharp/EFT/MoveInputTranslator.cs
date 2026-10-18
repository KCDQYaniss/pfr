namespace EFT;

internal sealed class MoveInputTranslator
{
	private readonly Player _controller; //Field offset: 0x10
	private int _xDirection; //Field offset: 0x18
	private int _yDirection; //Field offset: 0x1C

	public bool InvertX
	{
		 set { } //Length: 35
	}

	public bool InvertY
	{
		 set { } //Length: 35
	}

	internal MoveInputTranslator(Player controller) { }

	public void set_InvertX(bool value) { }

	public void set_InvertY(bool value) { }

	public void TranslateAxes(ref float[] axes) { }

	public ETranslateResult TranslateCommand(ECommand command) { }

}

