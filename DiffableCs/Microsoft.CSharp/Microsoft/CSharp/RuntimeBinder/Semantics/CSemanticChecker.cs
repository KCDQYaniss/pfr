namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal static class CSemanticChecker
{

	public static bool CheckAccess(Symbol symCheck, AggregateType atsCheck, Symbol symWhere, CType typeThru) { }

	public static ACCESSERROR CheckAccess2(Symbol symCheck, AggregateType atsCheck, Symbol symWhere, CType typeThru) { }

	private static ACCESSERROR CheckAccessCore(Symbol symCheck, AggregateType atsCheck, Symbol symWhere, CType typeThru) { }

	public static bool CheckBogus(Symbol sym) { }

	public static void CheckForStaticClass(CType type) { }

	public static bool CheckTypeAccess(CType type, Symbol symWhere) { }

	public static RuntimeBinderException ReportAccessError(SymWithType swtBad, Symbol symWhere, CType typeQual) { }

}

