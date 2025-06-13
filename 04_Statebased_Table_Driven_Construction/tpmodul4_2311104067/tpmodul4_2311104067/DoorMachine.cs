using System;

public enum DoorState { Terkunci, Terbuka }

public class DoorMachine
{
    private DoorState stateSekarang;

    public DoorMachine()
    {
        stateSekarang = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void GantiState(DoorState newState)
    {
        stateSekarang = newState;

        if (stateSekarang == DoorState.Terkunci)
            Console.WriteLine("Pintu terkunci");
        else if (stateSekarang == DoorState.Terbuka)
            Console.WriteLine("Pintu tidak terkunci");
    }
}

