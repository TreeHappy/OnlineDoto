using System;
using OpenDotaApi;

namespace OnlineDoto
{
    class Program
    {
        static void Main(string[] args)
        {
            var SteamId = 43593603;
            var openDota = new OpenDota();
            var data = await openDota.Player.GetPlayerAsync(SteamId);

            Console.WriteLine(data.Profile.Avatarfull);
        }
    }
}
