namespace CpMove
{
    [Serializable]
    public class Move
    {
        public string PlayerName { get; set; }
        public int[] Field { get; set; }
    }
}

//0 -   empty cell
//1 -   0
//2 -   x