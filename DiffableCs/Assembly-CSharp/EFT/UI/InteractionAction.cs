namespace EFT.UI;

public class InteractionAction
{
	public string Name; //Field offset: 0x10
	public bool Disabled; //Field offset: 0x18
	public string TargetName; //Field offset: 0x20
	public Action Action; //Field offset: 0x28

	public InteractionAction() { }

}

