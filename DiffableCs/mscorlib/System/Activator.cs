namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Activator))]
[ComVisible(True)]
public sealed class Activator
{

	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture) { }

	internal static ObjectHandle CreateInstance(string assemblyString, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo, ref StackCrawlMark stackMark) { }

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstance which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo) { }

	public static T CreateInstance() { }

	public static object CreateInstance(Type type, bool nonPublic) { }

	public static ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { }

	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	public static object CreateInstance(Type type) { }

	public static object CreateInstance(Type type, object[] args, object[] activationAttributes) { }

	public static object CreateInstance(Type type, object[] args) { }

	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	public static ObjectHandle CreateInstance(string assemblyName, string typeName) { }

	public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { }

	public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { }

	[Obsolete("Methods which use evidence to sandbox are obsolete and will be removed in a future release of the .NET Framework. Please use an overload of CreateInstanceFrom which does not take an Evidence parameter. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.")]
	public static ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo) { }

	private static ObjectHandle CreateInstanceFromInternal(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityInfo) { }

}

