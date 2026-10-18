namespace System.Net.NetworkInformation;

[DefaultMember("Item")]
public class GatewayIPAddressInformationCollection : ICollection, IEnumerable, IEnumerable
{
	private Collection addresses; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 122
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	protected private GatewayIPAddressInformationCollection() { }

	public override void Add(GatewayIPAddressInformation address) { }

	public override void Clear() { }

	public override bool Contains(GatewayIPAddressInformation address) { }

	public override void CopyTo(GatewayIPAddressInformation[] array, int offset) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override IEnumerator GetEnumerator() { }

	internal void InternalAdd(GatewayIPAddressInformation address) { }

	public override bool Remove(GatewayIPAddressInformation address) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

