namespace EFT.Hideout;

public sealed class ProductionSchemesCollection
{
	[CompilerGenerated]
	private ProductionScheme[] <ProductionSchemes>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ScavCaseScheme[] <ScavCaseSchemes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private CultistsScheme[] <CultistsSchemes>k__BackingField; //Field offset: 0x20

	[JsonProperty("cultistRecipes")]
	public private CultistsScheme[] CultistsSchemes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("recipes")]
	public private ProductionScheme[] ProductionSchemes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonProperty("scavRecipes")]
	public private ScavCaseScheme[] ScavCaseSchemes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ProductionSchemesCollection() { }

	[CompilerGenerated]
	public CultistsScheme[] get_CultistsSchemes() { }

	[CompilerGenerated]
	public ProductionScheme[] get_ProductionSchemes() { }

	[CompilerGenerated]
	public ScavCaseScheme[] get_ScavCaseSchemes() { }

	[CompilerGenerated]
	private void set_CultistsSchemes(CultistsScheme[] value) { }

	[CompilerGenerated]
	private void set_ProductionSchemes(ProductionScheme[] value) { }

	[CompilerGenerated]
	private void set_ScavCaseSchemes(ScavCaseScheme[] value) { }

}

