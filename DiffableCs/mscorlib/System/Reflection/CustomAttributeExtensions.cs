namespace System.Reflection;

[Extension]
public static class CustomAttributeExtensions
{

	[Extension]
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Extension]
	public static T GetCustomAttribute(ParameterInfo element, bool inherit) { }

	[Extension]
	public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType, bool inherit) { }

	[Extension]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	public static T GetCustomAttribute(ParameterInfo element) { }

	[Extension]
	public static T GetCustomAttribute(MemberInfo element, bool inherit) { }

	[Extension]
	public static T GetCustomAttribute(Assembly element) { }

	[Extension]
	public static Attribute GetCustomAttribute(ParameterInfo element, Type attributeType) { }

	[Extension]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Extension]
	public static T GetCustomAttribute(MemberInfo element) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(MemberInfo element, bool inherit) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(Assembly element) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(MemberInfo element) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(ParameterInfo element, Type attributeType) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(MemberInfo element) { }

	[Extension]
	public static IEnumerable GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

}

