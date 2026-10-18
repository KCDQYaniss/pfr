namespace EFT;

[Extension]
public static class TaskConditionCounterDescriptorExtensions
{

	[Extension]
	public static TaskConditionCounterDescriptor ReadTaskConditionCounterDescriptor(NetworkReader reader) { }

	[Extension]
	public static void WriteTaskConditionCounterDescriptor(NetworkWriter writer, TaskConditionCounterDescriptor target) { }

}

