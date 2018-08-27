using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using QBitNinja.Client;

namespace ConsoleApplicationBlockChain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! " + new Key().GetWif(Network.Main));

            Key privateKey = new Key();
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(publicKey);
             // Console.WriteLine(publicKey.GetAddress(Network.Main)); // 1PUYsjwfNmX64wS368ZR5FMouTtUmvtmTY
            //Console.WriteLine(publicKey.GetAddress(Network.TestNet)); // n3zWAo2eBnxLr3ueohXnuAa8mTVBhxmPhq

            var publicKeyHash = publicKey.Hash;

            Console.WriteLine(publicKeyHash);

            QBitNinjaClient client = new QBitNinjaClient(Network.TestNet);

            //   var mainNetAddress = publicKeyHash.GetAddress(Network.Main);

            Console.ReadLine();
        }
    }
}
