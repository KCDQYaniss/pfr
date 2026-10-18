namespace Sirenix.Serialization;

public class DelegateFormatter`1 : BaseFormatter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x0
		public static Func <>9__8_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <DeserializeImplementation>b__8_0(Type p) { }

		internal string <DeserializeImplementation>b__8_1(Type p) { }

	}

	private static readonly Serializer ObjectSerializer; //Field offset: 0x0
	private static readonly Serializer StringSerializer; //Field offset: 0x0
	private static readonly Serializer TypeSerializer; //Field offset: 0x0
	private static readonly Serializer TypeArraySerializer; //Field offset: 0x0
	private static readonly Serializer DelegateArraySerializer; //Field offset: 0x0
	public readonly Type DelegateType; //Field offset: 0x0

	private static DelegateFormatter`1() { }

	public DelegateFormatter`1() { }

	public DelegateFormatter`1(Type delegateType) { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	protected virtual T GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

}

