namespace EFT.UI;

public sealed class DynamicContextInteraction
{
	public readonly string Id; //Field offset: 0x10
	public readonly string Key; //Field offset: 0x18
	public readonly Sprite Icon; //Field offset: 0x20
	public readonly Enum ButtonType; //Field offset: 0x28
	public readonly IResult State; //Field offset: 0x30
	private readonly Action _callback; //Field offset: 0x38

	public DynamicContextInteraction(string id, string key, Action callback, Sprite icon, Enum buttonType, string error) { }

	public void Execute() { }

}

