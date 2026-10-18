namespace FlyingWormConsole3.LiteNetLib.Utils;

public class NetSerializer
{
	private class BoolSerializer`1 : FastCallSpecific
	{

		public BoolSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class ByteSerializer`1 : FastCallSpecific
	{

		public ByteSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private enum CallType
	{
		Basic = 0,
		Array = 1,
		List = 2,
	}

	private class CharSerializer`1 : FastCallSpecificAuto
	{

		public CharSerializer`1() { }

		protected virtual void ElementRead(NetDataReader r, out char prop) { }

		protected virtual void ElementWrite(NetDataWriter w, ref char prop) { }

	}

	private sealed class ClassInfo`1
	{
		public static ClassInfo Instance; //Field offset: 0x0
		private readonly FastCall[] _serializers; //Field offset: 0x0
		private readonly int _membersCount; //Field offset: 0x0

		public ClassInfo`1(List serializers) { }

		public void Read(T obj, NetDataReader reader) { }

		public void Write(T obj, NetDataWriter writer) { }

	}

	private abstract class CustomType
	{

		protected CustomType() { }

		public abstract FastCall Get() { }

	}

	private sealed class CustomTypeClass`1 : CustomType
	{
		private readonly Func _constructor; //Field offset: 0x0

		public CustomTypeClass`1(Func constructor) { }

		public virtual FastCall Get() { }

	}

	private sealed class CustomTypeStatic`1 : CustomType
	{
		private readonly Action _writer; //Field offset: 0x0
		private readonly Func _reader; //Field offset: 0x0

		public CustomTypeStatic`1(Action writer, Func reader) { }

		public virtual FastCall Get() { }

	}

	private sealed class CustomTypeStruct`1 : CustomType
	{

		public CustomTypeStruct`1() { }

		public virtual FastCall Get() { }

	}

	private class DoubleSerializer`1 : FastCallSpecific
	{

		public DoubleSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class EnumByteSerializer`1 : FastCall
	{
		protected readonly PropertyInfo Property; //Field offset: 0x0
		protected readonly Type PropertyType; //Field offset: 0x0

		public EnumByteSerializer`1(PropertyInfo property, Type propertyType) { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void ReadList(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

		public virtual void WriteList(T inf, NetDataWriter w) { }

	}

	private class EnumIntSerializer`1 : EnumByteSerializer
	{

		public EnumIntSerializer`1(PropertyInfo property, Type propertyType) { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

	}

	private abstract class FastCall`1
	{
		public CallType Type; //Field offset: 0x0

		protected FastCall`1() { }

		public override void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type) { }

		public abstract void Read(T inf, NetDataReader r) { }

		public abstract void ReadArray(T inf, NetDataReader r) { }

		public abstract void ReadList(T inf, NetDataReader r) { }

		public abstract void Write(T inf, NetDataWriter w) { }

		public abstract void WriteArray(T inf, NetDataWriter w) { }

		public abstract void WriteList(T inf, NetDataWriter w) { }

	}

	private sealed class FastCallClass`2 : FastCallSpecific
	{
		private readonly Func _constructor; //Field offset: 0x0

		public FastCallClass`2(Func constructor) { }

		public virtual void Read(TClass inf, NetDataReader r) { }

		public virtual void ReadArray(TClass inf, NetDataReader r) { }

		public virtual void ReadList(TClass inf, NetDataReader r) { }

		public virtual void Write(TClass inf, NetDataWriter w) { }

		public virtual void WriteArray(TClass inf, NetDataWriter w) { }

		public virtual void WriteList(TClass inf, NetDataWriter w) { }

	}

	private abstract class FastCallSpecific`2 : FastCall
	{
		protected Func Getter; //Field offset: 0x0
		protected Action Setter; //Field offset: 0x0
		protected Func GetterArr; //Field offset: 0x0
		protected Action SetterArr; //Field offset: 0x0
		protected Func GetterList; //Field offset: 0x0
		protected Action SetterList; //Field offset: 0x0

		protected FastCallSpecific`2() { }

		public virtual void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type) { }

		public virtual void ReadArray(TClass inf, NetDataReader r) { }

		protected TProperty[] ReadArrayHelper(TClass inf, NetDataReader r) { }

		public virtual void ReadList(TClass inf, NetDataReader r) { }

		protected List ReadListHelper(TClass inf, NetDataReader r, out int len) { }

		public virtual void WriteArray(TClass inf, NetDataWriter w) { }

		protected TProperty[] WriteArrayHelper(TClass inf, NetDataWriter w) { }

		public virtual void WriteList(TClass inf, NetDataWriter w) { }

		protected List WriteListHelper(TClass inf, NetDataWriter w, out int len) { }

	}

	private abstract class FastCallSpecificAuto`2 : FastCallSpecific
	{

		protected FastCallSpecificAuto`2() { }

		protected abstract void ElementRead(NetDataReader r, out TProperty prop) { }

		protected abstract void ElementWrite(NetDataWriter w, ref TProperty prop) { }

		public virtual void Read(TClass inf, NetDataReader r) { }

		public virtual void ReadArray(TClass inf, NetDataReader r) { }

		public virtual void Write(TClass inf, NetDataWriter w) { }

		public virtual void WriteArray(TClass inf, NetDataWriter w) { }

	}

	private sealed class FastCallStatic`2 : FastCallSpecific
	{
		private readonly Action _writer; //Field offset: 0x0
		private readonly Func _reader; //Field offset: 0x0

		public FastCallStatic`2(Action write, Func read) { }

		public virtual void Read(TClass inf, NetDataReader r) { }

		public virtual void ReadArray(TClass inf, NetDataReader r) { }

		public virtual void ReadList(TClass inf, NetDataReader r) { }

		public virtual void Write(TClass inf, NetDataWriter w) { }

		public virtual void WriteArray(TClass inf, NetDataWriter w) { }

		public virtual void WriteList(TClass inf, NetDataWriter w) { }

	}

	private sealed class FastCallStruct`2 : FastCallSpecific
	{
		private TProperty _p; //Field offset: 0x0

		public FastCallStruct`2() { }

		public virtual void Read(TClass inf, NetDataReader r) { }

		public virtual void ReadArray(TClass inf, NetDataReader r) { }

		public virtual void ReadList(TClass inf, NetDataReader r) { }

		public virtual void Write(TClass inf, NetDataWriter w) { }

		public virtual void WriteArray(TClass inf, NetDataWriter w) { }

		public virtual void WriteList(TClass inf, NetDataWriter w) { }

	}

	private class FloatSerializer`1 : FastCallSpecific
	{

		public FloatSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class IntSerializer`1 : FastCallSpecific
	{

		public IntSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class IPEndPointSerializer`1 : FastCallSpecificAuto
	{

		public IPEndPointSerializer`1() { }

		protected virtual void ElementRead(NetDataReader r, out IPEndPoint prop) { }

		protected virtual void ElementWrite(NetDataWriter w, ref IPEndPoint prop) { }

	}

	private class LongSerializer`1 : FastCallSpecific
	{

		public LongSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class SByteSerializer`1 : FastCallSpecific
	{

		public SByteSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class ShortSerializer`1 : FastCallSpecific
	{

		public ShortSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class StringSerializer`1 : FastCallSpecific
	{
		private readonly int _maxLength; //Field offset: 0x0

		public StringSerializer`1(int maxLength) { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class UIntSerializer`1 : FastCallSpecific
	{

		public UIntSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class ULongSerializer`1 : FastCallSpecific
	{

		public ULongSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private class UShortSerializer`1 : FastCallSpecific
	{

		public UShortSerializer`1() { }

		public virtual void Read(T inf, NetDataReader r) { }

		public virtual void ReadArray(T inf, NetDataReader r) { }

		public virtual void Write(T inf, NetDataWriter w) { }

		public virtual void WriteArray(T inf, NetDataWriter w) { }

	}

	private NetDataWriter _writer; //Field offset: 0x10
	private readonly int _maxStringLength; //Field offset: 0x18
	private readonly Dictionary _registeredTypes; //Field offset: 0x20

	public NetSerializer() { }

	public NetSerializer(int maxStringLength) { }

	public T Deserialize(NetDataReader reader) { }

	public bool Deserialize(NetDataReader reader, T target) { }

	public void Register() { }

	private ClassInfo RegisterInternal() { }

	public void RegisterNestedType() { }

	public void RegisterNestedType(Func constructor) { }

	public void RegisterNestedType(Action writer, Func reader) { }

	public void Serialize(NetDataWriter writer, T obj) { }

	public byte[] Serialize(T obj) { }

}

