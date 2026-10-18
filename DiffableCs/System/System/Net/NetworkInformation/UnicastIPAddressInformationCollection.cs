namespace System.Net.NetworkInformation;

[DefaultMember("Item")]
public class UnicastIPAddressInformationCollection : ICollection, IEnumerable, IEnumerable
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

	protected private UnicastIPAddressInformationCollection() { }

	public override void Add(UnicastIPAddressInformation address) { }

	public override void Clear() { }

	public override bool Contains(UnicastIPAddressInformation address) { }

	public override void CopyTo(UnicastIPAddressInformation[] array, int offset) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override IEnumerator GetEnumerator() { }

	internal void InternalAdd(UnicastIPAddressInformation address) { }

	public override bool Remove(UnicastIPAddressInformation address) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

