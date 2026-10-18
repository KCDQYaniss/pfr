namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal abstract class MethodOrPropertySymbol : ParentSymbol
{
	public uint modOptCount; //Field offset: 0x48
	public bool isStatic; //Field offset: 0x4C
	public bool isOverride; //Field offset: 0x4D
	public bool isOperator; //Field offset: 0x4E
	public bool isParamArray; //Field offset: 0x4F
	public bool isHideByName; //Field offset: 0x50
	[CompilerGenerated]
	private List <ParameterNames>k__BackingField; //Field offset: 0x58
	private bool[] _optionalParameterIndex; //Field offset: 0x60
	private bool[] _defaultParameterIndex; //Field offset: 0x68
	private ConstVal[] _defaultParameters; //Field offset: 0x70
	private CType[] _defaultParameterConstValTypes; //Field offset: 0x78
	private bool[] _marshalAsIndex; //Field offset: 0x80
	private UnmanagedType[] _marshalAsBuffer; //Field offset: 0x88
	public SymWithType swtSlot; //Field offset: 0x90
	public CType RetType; //Field offset: 0x98
	private TypeArray _Params; //Field offset: 0xA0

	public private List ParameterNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public TypeArray Params
	{
		 get { } //Length: 8
		 set { } //Length: 1534
	}

	public MethodOrPropertySymbol() { }

	[CompilerGenerated]
	public List get_ParameterNames() { }

	public TypeArray get_Params() { }

	public AggregateSymbol getClass() { }

	public ConstVal GetDefaultParameterValue(int index) { }

	public CType GetDefaultParameterValueConstValType(int index) { }

	private UnmanagedType GetMarshalAsParameterValue(int index) { }

	public bool HasDefaultParameterValue(int index) { }

	public bool HasOptionalParameters() { }

	public bool IsExpImpl() { }

	private bool IsMarshalAsParameter(int index) { }

	public bool IsParameterOptional(int index) { }

	public bool MarshalAsObject(int index) { }

	[CompilerGenerated]
	private void set_ParameterNames(List value) { }

	public void set_Params(TypeArray value) { }

	public void SetDefaultParameterValue(int index, CType type, ConstVal cv) { }

	public void SetMarshalAsParameter(int index, UnmanagedType umt) { }

	public void SetOptionalParameter(int index) { }

}

