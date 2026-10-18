namespace EFT;

public sealed class NarratePlayerOwner : EftGamePlayerOwner
{

	public NarratePlayerOwner() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

