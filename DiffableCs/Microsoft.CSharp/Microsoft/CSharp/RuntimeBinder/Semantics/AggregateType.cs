namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class AggregateType : CType
{
	[CompilerGenerated]
	private sealed class <get_TypeHierarchy>d__17 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private AggregateType <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AggregateType <>4__this; //Field offset: 0x28
		private CType[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private AggregateType <agg>5__4; //Field offset: 0x40

		private override AggregateType System.Collections.Generic.IEnumerator<Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_TypeHierarchy>d__17(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>.GetEnumerator() { }

		[DebuggerHidden]
		private override AggregateType System.Collections.Generic.IEnumerator<Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private AggregateType _baseType; //Field offset: 0x18
	private TypeArray _ifacesAll; //Field offset: 0x20
	private TypeArray _winrtifacesAll; //Field offset: 0x28
	private Type _associatedSystemType; //Field offset: 0x30
	public Nullable ConstraintError; //Field offset: 0x38
	public bool AllHidden; //Field offset: 0x3A
	public bool DiffHidden; //Field offset: 0x3B
	[CompilerGenerated]
	private readonly AggregateType <OuterType>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly AggregateSymbol <OwningAggregate>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly TypeArray <TypeArgsThis>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly TypeArray <TypeArgsAll>k__BackingField; //Field offset: 0x58

	public virtual Type AssociatedSystemType
	{
		 get { } //Length: 107
	}

	public AggregateType BaseClass
	{
		 get { } //Length: 588
	}

	public virtual ConstValKind ConstValKind
	{
		 get { } //Length: 344
	}

	public virtual FUNDTYPE FundamentalType
	{
		 get { } //Length: 268
	}

	public TypeArray IfacesAll
	{
		 get { } //Length: 287
	}

	public virtual bool IsClassType
	{
		 get { } //Length: 33
	}

	private bool IsCollectionType
	{
		private get { } //Length: 891
	}

	public virtual bool IsDelegateType
	{
		 get { } //Length: 33
	}

	public virtual bool IsEnumType
	{
		 get { } //Length: 33
	}

	public virtual bool IsInterfaceType
	{
		 get { } //Length: 33
	}

	public virtual bool IsNonNullableValueType
	{
		 get { } //Length: 20
	}

	public virtual bool IsNumericType
	{
		 get { } //Length: 121
	}

	public virtual bool IsPredefined
	{
		 get { } //Length: 30
	}

	public virtual bool IsReferenceType
	{
		 get { } //Length: 58
	}

	public virtual bool IsSimpleOrEnum
	{
		 get { } //Length: 120
	}

	public virtual bool IsSimpleOrEnumOrString
	{
		 get { } //Length: 133
	}

	public virtual bool IsSimpleType
	{
		 get { } //Length: 112
	}

	public virtual bool IsStaticClass
	{
		 get { } //Length: 46
	}

	public virtual bool IsStructType
	{
		 get { } //Length: 33
	}

	public virtual bool IsValueType
	{
		 get { } //Length: 49
	}

	public AggregateType OuterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AggregateSymbol OwningAggregate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual PredefinedType PredefinedType
	{
		 get { } //Length: 29
	}

	public TypeArray TypeArgsAll
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public TypeArray TypeArgsThis
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IEnumerable TypeHierarchy
	{
		[IteratorStateMachine(typeof(<get_TypeHierarchy>d__17))]
		 get { } //Length: 175
	}

	public virtual AggregateType UnderlyingEnumType
	{
		 get { } //Length: 27
	}

	public TypeArray WinRTCollectionIfacesAll
	{
		 get { } //Length: 518
	}

	public AggregateType(AggregateSymbol parent, TypeArray typeArgsThis, AggregateType outerType) { }

	private Type CalculateAssociatedSystemType() { }

	public virtual Type get_AssociatedSystemType() { }

	public AggregateType get_BaseClass() { }

	public virtual ConstValKind get_ConstValKind() { }

	public virtual FUNDTYPE get_FundamentalType() { }

	public TypeArray get_IfacesAll() { }

	public virtual bool get_IsClassType() { }

	private bool get_IsCollectionType() { }

	public virtual bool get_IsDelegateType() { }

	public virtual bool get_IsEnumType() { }

	public virtual bool get_IsInterfaceType() { }

	public virtual bool get_IsNonNullableValueType() { }

	public virtual bool get_IsNumericType() { }

	public virtual bool get_IsPredefined() { }

	public virtual bool get_IsReferenceType() { }

	public virtual bool get_IsSimpleOrEnum() { }

	public virtual bool get_IsSimpleOrEnumOrString() { }

	public virtual bool get_IsSimpleType() { }

	public virtual bool get_IsStaticClass() { }

	public virtual bool get_IsStructType() { }

	public virtual bool get_IsValueType() { }

	[CompilerGenerated]
	public AggregateType get_OuterType() { }

	[CompilerGenerated]
	public AggregateSymbol get_OwningAggregate() { }

	public virtual PredefinedType get_PredefinedType() { }

	[CompilerGenerated]
	public TypeArray get_TypeArgsAll() { }

	[CompilerGenerated]
	public TypeArray get_TypeArgsThis() { }

	[IteratorStateMachine(typeof(<get_TypeHierarchy>d__17))]
	public IEnumerable get_TypeHierarchy() { }

	public virtual AggregateType get_UnderlyingEnumType() { }

	public TypeArray get_WinRTCollectionIfacesAll() { }

	public virtual AggregateType GetAts() { }

	public virtual bool IsPredefType(PredefinedType pt) { }

}

