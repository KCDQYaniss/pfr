namespace EFT;

internal sealed class RecorderInputTranslator : IHandsInputTranslator
{
	private readonly IRecorderController _controller; //Field offset: 0x10

	internal RecorderInputTranslator(IRecorderController controller) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

