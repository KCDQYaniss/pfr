namespace EFT.InventoryLogic;

public class AnimationVariantsComponent : ItemComponent
{
	private readonly IAnimationVariantsComponentTemplate _template; //Field offset: 0x18

	public int VariantsNumber
	{
		 get { } //Length: 75
	}

	public AnimationVariantsComponent(Item item, IAnimationVariantsComponentTemplate template) { }

	public int get_VariantsNumber() { }

}

