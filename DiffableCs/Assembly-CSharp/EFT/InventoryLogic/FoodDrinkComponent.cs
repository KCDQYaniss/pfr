namespace EFT.InventoryLogic;

public sealed class FoodDrinkComponent : ItemComponent, IRelativeComponent, IItemComponent
{
	[Diffable]
	public float HpPercent; //Field offset: 0x18
	private readonly IFoodDrinkComponentTemplate _template; //Field offset: 0x20

	public float MaxResource
	{
		 get { } //Length: 75
	}

	public override float RelativeValue
	{
		 get { } //Length: 98
	}

	public FoodDrinkComponent(Item item, IFoodDrinkComponentTemplate template) { }

	public float get_MaxResource() { }

	public override float get_RelativeValue() { }

}

