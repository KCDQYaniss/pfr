namespace EFT.UI;

public abstract class SpriteAnimationPlayer : UIElement
{
	[SerializeField]
	protected float _duration; //Field offset: 0x70

	protected SpriteAnimationPlayer() { }

	public override void OnMouseExit() { }

	public override void OnMouseOver() { }

	public override void SetSprites(Sprite idleSprite, Sprite hoverSprite, Sprite[] hoverAnimationSprites = null) { }

}

