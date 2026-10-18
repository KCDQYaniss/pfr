namespace EFT;

public abstract class BaseCustomizationFilter : ICustomizationFilter
{

	protected abstract HashSet AllowedParts
	{
		 get { } //Length: 0
	}

	protected BaseCustomizationFilter() { }

	public override BodyCustomization FilterCustomization(BodyCustomization customization) { }

	protected abstract HashSet get_AllowedParts() { }

}

