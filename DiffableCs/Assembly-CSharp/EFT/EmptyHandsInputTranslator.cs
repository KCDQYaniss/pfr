namespace EFT;

internal sealed class EmptyHandsInputTranslator : IHandsInputTranslator
{
	private readonly IEmptyHandsController _controller; //Field offset: 0x10

	internal EmptyHandsInputTranslator(IEmptyHandsController controller) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

