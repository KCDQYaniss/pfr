namespace EFT;

internal sealed class UsableItemInputTranslator : IHandsInputTranslator
{
	private readonly IUsableItemController _controller; //Field offset: 0x10

	public UsableItemInputTranslator(IUsableItemController controller) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

