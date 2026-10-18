namespace EFT.UI;

public sealed class EmptyContextInteractions : ContextInteractions
{

	public virtual bool HasInteractions
	{
		 get { } //Length: 3
	}

	public EmptyContextInteractions() { }

	protected virtual void ExecuteInteractionInternal(EItemInfoButton interaction) { }

	public virtual bool get_HasInteractions() { }

	public virtual bool IsActive(EItemInfoButton button) { }

	public virtual IResult IsInteractive(EItemInfoButton button) { }

}

