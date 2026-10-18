namespace EFT.BackEnd;

internal struct Diagnosis
{
	[CompilerGenerated]
	private readonly EDiagnosisSource <Source>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <Succeed>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x8

	internal string Description
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 5
	}

	internal EDiagnosisSource Source
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 3
	}

	internal bool Succeed
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 5
	}

	internal Diagnosis(EDiagnosisSource source, bool succeed, string description) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal string get_Description() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal EDiagnosisSource get_Source() { }

	[CompilerGenerated]
	[IsReadOnly]
	internal bool get_Succeed() { }

}

