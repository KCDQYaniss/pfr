namespace EFT.UI;

public abstract class BaseEmptyContextInteractions : ContextInteractions
{
	internal enum EEmptyEnum
	{
	}


	public virtual bool HasInteractions
	{
		 get { } //Length: 138
	}

	protected BaseEmptyContextInteractions(ItemUiContext uiContext) { }

	protected virtual void ExecuteInteractionInternal(EEmptyEnum interaction) { }

	public virtual bool get_HasInteractions() { }

	public virtual bool IsActive(EEmptyEnum button) { }

	public virtual IResult IsInteractive(EEmptyEnum button) { }

}

