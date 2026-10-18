namespace Microsoft.CSharp.RuntimeBinder.Errors;

internal struct UserStringBuilder
{
	private StringBuilder _strBuilder; //Field offset: 0x0

	private void BeginString() { }

	private string EndString() { }

	private void ErrAppendChar(char ch) { }

	private void ErrAppendId(MessageID id) { }

	private void ErrAppendIndexer(IndexerSymbol indexer, SubstContext pctx) { }

	private void ErrAppendMethod(MethodSymbol meth, SubstContext pctx, bool fArgs) { }

	private void ErrAppendName(Name name) { }

	private void ErrAppendParamList(TypeArray params, bool isParamArray) { }

	private void ErrAppendParentCore(Symbol parent, SubstContext pctx) { }

	private void ErrAppendParentSym(Symbol sym, SubstContext pctx) { }

	private void ErrAppendPrintf(string format, object[] args) { }

	private void ErrAppendProperty(PropertySymbol prop, SubstContext pctx) { }

	private void ErrAppendString(string str) { }

	private void ErrAppendSym(Symbol sym, SubstContext pctx) { }

	private void ErrAppendSym(Symbol sym, SubstContext pctx, bool fArgs) { }

	private void ErrAppendType(CType pType, SubstContext pctx) { }

	private void ErrAppendTypeParameters(TypeArray params, SubstContext pctx) { }

	public bool ErrArgToString(out string psz, ErrArg parg, out bool fUserStrings) { }

	private static string ErrId(MessageID id) { }

	private static string ErrSK(SYMKIND sk) { }

}

