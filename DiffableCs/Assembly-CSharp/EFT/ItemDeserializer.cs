namespace EFT;

public static class ItemDeserializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__7_0(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__10`1
	{
		public static readonly <>c__10 <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x0
		public static Func <>9__10_1; //Field offset: 0x0

		private static <>c__10`1() { }

		public <>c__10`1() { }

		internal object <GetProperties>b__10_0(TObject it, FieldMetaInfo member) { }

		internal object <GetProperties>b__10_1(TObject it, PropertyMetaInfo member) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public IItemComponent component; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetItemProperties>b__0(PropertyMetaInfo prop) { }

		internal bool <GetItemProperties>b__1(FieldMetaInfo prop) { }

	}

	private abstract class AbstractMemberMetaInfo
	{
		public readonly string Name; //Field offset: 0x10
		public readonly MemberInfo MemberInfo; //Field offset: 0x18
		public readonly JsonPropertyAttribute JsonPropertyAttribute; //Field offset: 0x20
		public readonly ComponentAttribute[] ComponentAtrributes; //Field offset: 0x28
		public readonly DefaultValueAttribute DefaultValueAttribute; //Field offset: 0x30
		public readonly DiffableAttribute DiffableAttribute; //Field offset: 0x38

		public abstract Type MemberType
		{
			 get { } //Length: 0
		}

		protected AbstractMemberMetaInfo(MemberInfo memberInfo) { }

		public abstract Type get_MemberType() { }

		public abstract object GetValue(object obj) { }

		public abstract void SetValue(object obj, object value) { }

	}

	private sealed class FieldMetaInfo : MemberMetaInfo
	{

		public virtual Type MemberType
		{
			 get { } //Length: 42
		}

		public FieldMetaInfo(FieldInfo memberInfo) { }

		public virtual Type get_MemberType() { }

		public virtual object GetValue(object obj) { }

		public virtual void SetValue(object obj, object value) { }

	}

	private abstract class MemberMetaInfo`1 : AbstractMemberMetaInfo
	{
		public readonly TMemberInfo MemberInfo; //Field offset: 0x0

		public MemberMetaInfo`1(TMemberInfo memberInfo) { }

	}

	private sealed class PropertyMetaInfo : MemberMetaInfo
	{

		public virtual Type MemberType
		{
			 get { } //Length: 42
		}

		public PropertyMetaInfo(PropertyInfo memberInfo) { }

		public virtual Type get_MemberType() { }

		public virtual object GetValue(object it) { }

		public virtual void SetValue(object obj, object value) { }

	}

	private sealed class TypeMetaInfo
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x8
			public static Func <>9__6_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal FieldMetaInfo <.ctor>b__6_0(FieldInfo m) { }

			internal PropertyMetaInfo <.ctor>b__6_1(PropertyInfo m) { }

		}

		private readonly Type _classType; //Field offset: 0x10
		public readonly string Name; //Field offset: 0x18
		public readonly FieldMetaInfo[] Fields; //Field offset: 0x20
		public readonly PropertyMetaInfo[] Properties; //Field offset: 0x28
		private readonly Dictionary _fieldInfos; //Field offset: 0x30
		private readonly Dictionary _propertyInfos; //Field offset: 0x38

		public TypeMetaInfo(Type classType) { }

		public AbstractMemberMetaInfo GetMember(string name) { }

	}

	private static readonly Dictionary _typeMetaInfos; //Field offset: 0x0

	private static ItemDeserializer() { }

	public static Item CreateItem(Item item, UnparsedData properties) { }

	[CanBeNull]
	public static T CreateItemLocation(UnparsedData locationData) { }

	public static Dictionary GetItemProperties(Item item) { }

	private static void GetNonDefaultValues(TObject item, TMember[] members, IDictionary result, Func getValue) { }

	private static Dictionary GetProperties(TObject obj) { }

	private static TypeMetaInfo GetTypeMetaInfo(Type type) { }

	public static UnparsedData SaveItemLocation(LocationInGrid itemLocation) { }

	public static UnparsedData SaveItemLocation(int stackSlotPosition) { }

}

