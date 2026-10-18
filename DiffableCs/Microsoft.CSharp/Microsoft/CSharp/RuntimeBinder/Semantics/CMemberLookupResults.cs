namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal class CMemberLookupResults
{
	internal class CMethodIterator
	{
		private readonly AggregateSymbol _context; //Field offset: 0x10
		private readonly TypeArray _containingTypes; //Field offset: 0x18
		private readonly CType _qualifyingType; //Field offset: 0x20
		private readonly Name _name; //Field offset: 0x28
		private readonly int _arity; //Field offset: 0x30
		private readonly symbmask_t _mask; //Field offset: 0x38
		private readonly EXPRFLAG _flags; //Field offset: 0x40
		private readonly ArgInfos _nonTrailingNamedArguments; //Field offset: 0x48
		private int _currentTypeIndex; //Field offset: 0x50
		[CompilerGenerated]
		private MethodOrPropertySymbol <CurrentSymbol>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private AggregateType <CurrentType>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private bool <IsCurrentSymbolInaccessible>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		private bool <IsCurrentSymbolBogus>k__BackingField; //Field offset: 0x69
		[CompilerGenerated]
		private bool <IsCurrentSymbolMisnamed>k__BackingField; //Field offset: 0x6A

		public bool AtEnd
		{
			 get { } //Length: 9
		}

		public bool CanUseCurrentSymbol
		{
			 get { } //Length: 1060
		}

		public private MethodOrPropertySymbol CurrentSymbol
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private AggregateType CurrentType
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private bool IsCurrentSymbolBogus
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private bool IsCurrentSymbolInaccessible
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private bool IsCurrentSymbolMisnamed
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public CMethodIterator(Name name, TypeArray containingTypes, CType qualifyingType, AggregateSymbol context, int arity, EXPRFLAG flags, symbmask_t mask, ArgInfos nonTrailingNamedArguments) { }

		private bool CheckArgumentNames() { }

		private bool FindNextMethod() { }

		private bool FindNextTypeForInstanceMethods() { }

		public bool get_AtEnd() { }

		public bool get_CanUseCurrentSymbol() { }

		[CompilerGenerated]
		public MethodOrPropertySymbol get_CurrentSymbol() { }

		[CompilerGenerated]
		public AggregateType get_CurrentType() { }

		[CompilerGenerated]
		public bool get_IsCurrentSymbolBogus() { }

		[CompilerGenerated]
		public bool get_IsCurrentSymbolInaccessible() { }

		[CompilerGenerated]
		public bool get_IsCurrentSymbolMisnamed() { }

		public bool MoveNext() { }

		[CompilerGenerated]
		private void set_CurrentSymbol(MethodOrPropertySymbol value) { }

		[CompilerGenerated]
		private void set_CurrentType(AggregateType value) { }

		[CompilerGenerated]
		private void set_IsCurrentSymbolBogus(bool value) { }

		[CompilerGenerated]
		private void set_IsCurrentSymbolInaccessible(bool value) { }

		[CompilerGenerated]
		private void set_IsCurrentSymbolMisnamed(bool value) { }

	}

	[CompilerGenerated]
	private readonly TypeArray <ContainingTypes>k__BackingField; //Field offset: 0x10
	private readonly Name _pName; //Field offset: 0x18

	private TypeArray ContainingTypes
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public CMemberLookupResults(TypeArray containingTypes, Name name) { }

	[CompilerGenerated]
	private TypeArray get_ContainingTypes() { }

	public CMethodIterator GetMethodIterator(CType qualifyingType, AggregateSymbol context, int arity, EXPRFLAG flags, symbmask_t mask, ArgInfos nonTrailingNamedArguments) { }

}

