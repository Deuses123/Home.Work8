namespace Home.Work8;

public class SquaredArray
{
    private int[] array;

    public SquaredArray(int size)
    {
        array = new int[size];
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value * value;
        }
    }

    public override string ToString()
    {
        return string.Join(" ", array);
    }
}
