namespace System.Linq.Expressions.Compiler;

internal static class DelegateHelpers
{
	public class TypeInfo
	{
		public Type DelegateType; //Field offset: 0x10
		public Dictionary TypeChain; //Field offset: 0x18

		public TypeInfo() { }

	}

	internal sealed class VBCallSiteDelegate0`1 : MulticastDelegate
	{

		public VBCallSiteDelegate0`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance) { }

	}

	internal sealed class VBCallSiteDelegate1`1 : MulticastDelegate
	{

		public VBCallSiteDelegate1`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1) { }

	}

	internal sealed class VBCallSiteDelegate2`1 : MulticastDelegate
	{

		public VBCallSiteDelegate2`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1, ref object arg2) { }

	}

	internal sealed class VBCallSiteDelegate3`1 : MulticastDelegate
	{

		public VBCallSiteDelegate3`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3) { }

	}

	internal sealed class VBCallSiteDelegate4`1 : MulticastDelegate
	{

		public VBCallSiteDelegate4`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4) { }

	}

	internal sealed class VBCallSiteDelegate5`1 : MulticastDelegate
	{

		public VBCallSiteDelegate5`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5) { }

	}

	internal sealed class VBCallSiteDelegate6`1 : MulticastDelegate
	{

		public VBCallSiteDelegate6`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6) { }

	}

	internal sealed class VBCallSiteDelegate7`1 : MulticastDelegate
	{

		public VBCallSiteDelegate7`1(object object, IntPtr method) { }

		public override object Invoke(T callSite, object instance, ref object arg1, ref object arg2, ref object arg3, ref object arg4, ref object arg5, ref object arg6, ref object arg7) { }

	}

	private static TypeInfo _DelegateCache; //Field offset: 0x0

	private static DelegateHelpers() { }

	internal static Type GetActionType(Type[] types) { }

	internal static Type GetFuncType(Type[] types) { }

	private static bool IsByRef(DynamicMetaObject mo) { }

	internal static Type MakeDeferredSiteDelegate(DynamicMetaObject[] args, Type returnType) { }

	private static Type MakeNewCustomDelegate(Type[] types) { }

	internal static Type MakeNewDelegate(Type[] types) { }

	private static TypeInfo NextTypeInfo(Type initialArg, TypeInfo curTypeInfo) { }

	private static Type TryMakeVBStyledCallSite(Type[] types) { }

}

