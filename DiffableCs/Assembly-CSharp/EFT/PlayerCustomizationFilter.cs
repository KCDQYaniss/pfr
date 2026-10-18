namespace EFT;

public sealed class PlayerCustomizationFilter : BaseCustomizationFilter
{
	public static readonly PlayerCustomizationFilter Default; //Field offset: 0x0
	[CompilerGenerated]
	private readonly HashSet <AllowedParts>k__BackingField; //Field offset: 0x10

	protected virtual HashSet AllowedParts
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static PlayerCustomizationFilter() { }

	public PlayerCustomizationFilter() { }

	[CompilerGenerated]
	protected virtual HashSet get_AllowedParts() { }

}

