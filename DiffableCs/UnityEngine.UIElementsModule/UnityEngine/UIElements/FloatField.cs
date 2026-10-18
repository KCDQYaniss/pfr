namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FloatField : TextValueField
{
	private class FloatInput : TextValueInput
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 83
		}

		private FloatField parentFloatField
		{
			private get { } //Length: 115
		}

		internal FloatInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

		protected virtual string get_allowedCharacters() { }

		private FloatField get_parentFloatField() { }

		protected virtual float StringToValue(string str) { }

		protected virtual string ValueToString(float v) { }

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

	private FloatInput floatInput
	{
		private get { } //Length: 132
	}

	private static FloatField() { }

	public FloatField() { }

	public FloatField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private FloatInput get_floatInput() { }

	protected virtual float StringToValue(string str) { }

	protected virtual string ValueToString(float v) { }

}

