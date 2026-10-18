namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Hash128Field : TextInputBaseField
{
	private class Hash128Input : TextInputBase
	{

		protected string allowedCharacters
		{
			 get { } //Length: 49
		}

		internal Hash128Input() { }

		internal virtual bool AcceptCharacter(char c) { }

		protected string get_allowedCharacters() { }

		internal static Hash128 Parse(string str) { }

		protected virtual Hash128 StringToValue(string str) { }

	}

	internal class UxmlFactory : UxmlFactory
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10
	internal bool m_UpdateTextFromValue; //Field offset: 0x460

	public virtual Hash128 value
	{
		 get { } //Length: 73
		 set { } //Length: 219
	}

	private static Hash128Field() { }

	public Hash128Field() { }

	public Hash128Field(string label, int maxLength = -1) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(BlurEvent)})]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	public virtual Hash128 get_value() { }

	public virtual void set_value(Hash128 value) { }

	public virtual void SetValueWithoutNotify(Hash128 newValue) { }

	protected virtual Hash128 StringToValue(string str) { }

	internal virtual void UpdateTextFromValue() { }

	internal virtual void UpdateValueFromText() { }

	protected virtual string ValueToString(Hash128 value) { }

}

