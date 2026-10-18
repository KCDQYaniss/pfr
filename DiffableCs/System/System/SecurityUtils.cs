namespace System;

internal static class SecurityUtils
{

	private static void DemandGrantSet(Assembly assembly) { }

	private static void DemandReflectionAccess(Type type) { }

	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	private static bool HasReflectionPermission(Type type) { }

	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	internal static object SecureCreateInstance(Type type) { }

	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	internal static object SecureCreateInstance(Type type, object[] args) { }

}

