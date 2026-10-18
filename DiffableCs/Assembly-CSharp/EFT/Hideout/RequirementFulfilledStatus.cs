namespace EFT.Hideout;

public sealed class RequirementFulfilledStatus : UIElement
{
	[SerializeField]
	private Image _requirementIcon; //Field offset: 0x70
	[SerializeField]
	private Sprite _fulfilledSprite; //Field offset: 0x78
	[SerializeField]
	private Sprite _failedSprite; //Field offset: 0x80

	public RequirementFulfilledStatus() { }

	public void Show(bool fulfilled) { }

}

