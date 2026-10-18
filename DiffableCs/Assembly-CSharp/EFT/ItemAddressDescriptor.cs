namespace EFT;

[GenerateBinarySerialization]
public abstract class ItemAddressDescriptor
{
	public ContainerDescriptor Container; //Field offset: 0x10

	protected ItemAddressDescriptor() { }

	public virtual string ToString() { }

}

