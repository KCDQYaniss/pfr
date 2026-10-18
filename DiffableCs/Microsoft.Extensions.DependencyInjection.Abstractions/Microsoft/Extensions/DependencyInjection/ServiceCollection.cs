namespace Microsoft.Extensions.DependencyInjection;

[DebuggerDisplay("{DebuggerToString(),nq}")]
[DebuggerTypeProxy(typeof(ServiceCollectionDebugView))]
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class ServiceCollection : IServiceCollection, IList, ICollection, IEnumerable, IEnumerable
{
	private sealed class ServiceCollectionDebugView
	{

	}

	private readonly List _descriptors; //Field offset: 0x10
	private bool _isReadOnly; //Field offset: 0x18

	public override int Count
	{
		 get { } //Length: 65
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 5
	}

	public override ServiceDescriptor Item
	{
		 get { } //Length: 112
		 set { } //Length: 137
	}

	public ServiceCollection() { }

	private void CheckReadOnly() { }

	public override void Clear() { }

	public override bool Contains(ServiceDescriptor item) { }

	public override void CopyTo(ServiceDescriptor[] array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public override ServiceDescriptor get_Item(int index) { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(ServiceDescriptor item) { }

	public override void Insert(int index, ServiceDescriptor item) { }

	public override bool Remove(ServiceDescriptor item) { }

	public override void RemoveAt(int index) { }

	public override void set_Item(int index, ServiceDescriptor value) { }

	private override void System.Collections.Generic.ICollection<Microsoft.Extensions.DependencyInjection.ServiceDescriptor>.Add(ServiceDescriptor item) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private static void ThrowReadOnlyException() { }

}

