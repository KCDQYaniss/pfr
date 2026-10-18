namespace RuntimeInspector;

public static class EditorGUIImitation
{
	private class SliderState
	{
		public float dragStartPos; //Field offset: 0x10
		public float dragStartValue; //Field offset: 0x14
		public bool isDragging; //Field offset: 0x18

		public SliderState() { }

	}


	public static Bounds BoundsField(Bounds value, GUILayoutOption[] options) { }

	public static Color ColorField(Color value, GUILayoutOption[] options) { }

	public static AnimationCurve CurveField(AnimationCurve value, GUILayoutOption[] options) { }

	private static float DragLable(string name, float value, GUILayoutOption[] options) { }

	private static float DragValue(float value, Rect rect) { }

	public static float FloatField(string name, float value) { }

	public static float FloatField(string name, float value, GUILayoutOption[] lable, GUILayoutOption[] field) { }

	public static int IntField(string name, int value) { }

	public static int IntField(string name, int value, GUILayoutOption[] lable, GUILayoutOption[] field) { }

	public static Object ObjectField(Object value, Type type, GUILayoutOption[] options) { }

	public static Rect RectField(Rect value) { }

	public static Vector2 Vector2Field(Vector2 value) { }

	public static Vector3 Vector3Field(Vector3 value) { }

	public static Vector4 Vector4Field(Vector4 value, GUILayoutOption[] options) { }

}

