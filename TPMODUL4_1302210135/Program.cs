using System;

class DoorMachine
{
    static void Main(string[] args)
    {
        DoorMachine doorMachine = new DoorMachine();

        doorMachine.Open(); //Pintu tidak terkunci
        doorMachine.Close(); //Pintu tertutup
        doorMachine.Close(); //Pintu sudah tertutup
        doorMachine.Open(); // Pintu tidak terkunci

    }
}

public class DoorMachine
{
    private DoorState state;

    public DoorMachine()
    {
        state = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void Open()
    {
        if (state == DoorState.Terkunci)
        {
            state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else if (state == DoorState.Terbuka)
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
        else if (state == DoorState.Tertutup)
        {
            Console.WriteLine("Pintu masih tertutup");
        }
    }
    public void Close()
    {
        if (state == DoorState.Terkunci)
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
        else if (state == DoorState.Terbuka)
        {
            state == DoorState.Tertutup;
            Console.WriteLine("Pintu tertutup");
        }
        else if (state == DoorState.Tertutup)
        {
            Console.WriteLine("Pintu sudah tertutup");
        }
    }
}

public enum DoorState
{
    Terkunci,
    Terbuka,
    Tertutup
}