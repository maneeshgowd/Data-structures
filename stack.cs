
public class HelloWorld
{

    public static void Main(string[] args)
    {

        int top = -1;
        int maxSize = 10;
        int[] stack = new int[maxSize];

        Push(1, ref top, stack);
        Push(2, ref top, stack);
        Push(3, ref top, stack);

        int item3 = Pop(ref top, stack);
        Console.WriteLine($"popped: {item3}");

        Push(4, ref top, stack);
        Push(5, ref top, stack);
        Push(6, ref top, stack);
        Push(7, ref top, stack);
        Push(8, ref top, stack);


        int item1 = Pop(ref top, stack);
        Console.WriteLine($"popped: {item1}");

        int item2 = Pop(ref top, stack);
        Console.WriteLine($"popped: {item2}");


        Push(7, ref top, stack);


        PrintStack(ref top, stack);

        Console.WriteLine($"Top: {top}");
    }

    public static void PrintStack(ref int top, int[] stack)
    {
        for (int i = top; i >= 0; --i)
        {
            Console.WriteLine(stack[i]);
        }
    }

    public static void Push(int item, ref int top, int[] stack)
    {

        bool isFull = IsFull(ref top);

        if (isFull)
            Console.WriteLine("OverFlow");
        else
        {
            ++top;
            stack[top] = item;
        }
    }

    public static int Pop(ref int top, int[] stack)
    {
        bool isEmpty = IsEmpty(ref top);
        int item = stack[top];

        if (isEmpty)
            Console.WriteLine("UnderFlow");
        else
        {
            //stack[top] = 0;
            --top;
        }
        return item;
    }

    public static bool IsFull(ref int top)
    {
        return top == 10;
    }

    public static bool IsEmpty(ref int top)
    {
        return top == -1;
    }
}