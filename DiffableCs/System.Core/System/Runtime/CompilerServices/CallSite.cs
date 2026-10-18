namespace System.Runtime.CompilerServices;

public class CallSite
{
	private static CacheDict s_siteCtors; //Field offset: 0x0
	internal readonly CallSiteBinder _binder; //Field offset: 0x10
	internal bool _match; //Field offset: 0x18

	public CallSiteBinder Binder
	{
		 get { } //Length: 5
	}

	internal CallSite(CallSiteBinder binder) { }

	public static CallSite Create(Type delegateType, CallSiteBinder binder) { }

	public CallSiteBinder get_Binder() { }

}

