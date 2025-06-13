using System;

public enum State { Berdiri, Tengkurap }

public class PosisiKarakterGame
{
    private State stateSekarang;

    public PosisiKarakterGame()
    {
        stateSekarang = State.Berdiri;
        Console.WriteLine("posisi standby");
    }

    public void GantiState(State newState)
    {
        stateSekarang = newState;

        if (stateSekarang == State.Berdiri)
            Console.WriteLine("posisi standby");
        else if (stateSekarang == State.Tengkurap)
            Console.WriteLine("posisi istirahat");
    }
}
