namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
public static class AndroidJNI
{

	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span args) { }

	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafe]
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void ExceptionClear() { }

	[ThreadSafe]
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	public static bool[] FromBooleanArray(IntPtr array) { }

	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[ThreadSafe]
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr NewLocalRef(IntPtr obj) { }

	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span args) { }

	[ThreadSafe]
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[ThreadSafe]
	public static IntPtr ToBooleanArray(bool[] array) { }

	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	public static IntPtr ToByteArray(byte[] array) { }

	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	public static IntPtr ToCharArray(char* array, int length) { }

	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	public static IntPtr ToFloatArray(float* array, int length) { }

	public static IntPtr ToFloatArray(float[] array) { }

	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	public static IntPtr ToIntArray(int* array, int length) { }

	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	public static IntPtr ToLongArray(long* array, int length) { }

	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafe]
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	[ThreadSafe]
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	public static IntPtr ToSByteArray(sbyte[] array) { }

	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	public static IntPtr ToShortArray(short* array, int length) { }

}

