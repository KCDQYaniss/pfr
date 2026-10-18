namespace EFT;

internal sealed class GrenadeInputTranslator : IHandsInputTranslator
{
	private readonly IGrenadeController _controller; //Field offset: 0x10

	public GrenadeInputTranslator(IGrenadeController controller) { }

	private void ChangeFireMode() { }

	public override void TranslateAxes(ref float[] axes) { }

	public override ETranslateResult TranslateCommand(ECommand command) { }

}

