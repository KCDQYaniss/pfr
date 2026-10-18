//Type is in global namespace

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True, Inherited = True)]
public class HelpAttribute : PropertyAttribute
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__2_0(char c) { }

	}

	public readonly string Text; //Field offset: 0x18
	public readonly float Height; //Field offset: 0x20

	public HelpAttribute(string text) { }

}

