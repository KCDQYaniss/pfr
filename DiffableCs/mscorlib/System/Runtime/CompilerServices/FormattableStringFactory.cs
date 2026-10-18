namespace System.Runtime.CompilerServices;

public static class FormattableStringFactory
{
	private sealed class ConcreteFormattableString : FormattableString
	{
		private readonly string _format; //Field offset: 0x10
		private readonly object[] _arguments; //Field offset: 0x18

		public virtual int ArgumentCount
		{
			 get { } //Length: 26
		}

		public virtual string Format
		{
			 get { } //Length: 5
		}

		internal ConcreteFormattableString(string format, object[] arguments) { }

		public virtual int get_ArgumentCount() { }

		public virtual string get_Format() { }

		public virtual object GetArgument(int index) { }

		public virtual object[] GetArguments() { }

		public virtual string ToString(IFormatProvider formatProvider) { }

	}


	public static FormattableString Create(string format, object[] arguments) { }

}

