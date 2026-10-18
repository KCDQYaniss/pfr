namespace EFT;

internal sealed class HideoutGrenadeInputTranslator : IHandsInputTranslator
{
	private readonly IGrenadeController _controller; //Field offset: 0x10

	public HideoutGrenadeInputTranslator(IGrenadeController controller) { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

