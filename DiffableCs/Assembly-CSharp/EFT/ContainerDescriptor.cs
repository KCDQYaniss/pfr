namespace EFT;

[GenerateBinarySerialization]
public sealed class ContainerDescriptor
{
	[Nullable]
	public Nullable ParentId; //Field offset: 0x10
	public string ContainerId; //Field offset: 0x30

	public ContainerDescriptor() { }

	public ContainerDescriptor(string parentId, string containerId) { }

	public virtual string ToString() { }

}

