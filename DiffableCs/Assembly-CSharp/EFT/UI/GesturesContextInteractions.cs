namespace EFT.UI;

public sealed class GesturesContextInteractions : ContextInteractions
{
	private readonly Action _selectAction; //Field offset: 0x38

	public GesturesContextInteractions(Action onSelected) { }

	protected virtual void ExecuteInteractionInternal(ECommand interaction) { }

	public virtual bool IsActive(ECommand button) { }

	public virtual IResult IsInteractive(ECommand button) { }

}

