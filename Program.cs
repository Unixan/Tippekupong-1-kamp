namespace Tippekupong
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var match = new Match(bet);
            match.Play();
            var result = match.RightBet() ? "vant" : "tapte";
            Console.WriteLine($"Stillingen ble {match.Score()}.\n\nDu {result}");
        }
    }
}