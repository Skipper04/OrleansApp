using System;
using System.Threading.Tasks;
using Orleans;

namespace Client
{
    public class Program
    {
        public static int Main(string[] args)
        {
            return RunMainAsync().Result;
        }

        public static async Task<int> RunMainAsync()
        {
            try
            {
                await using (var client = await ConnectClient())
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return await Task.FromResult(1);
        }
        
        private static async Task<IClusterClient> ConnectClient()
        {
            var client = new ClientBuilder()
                .Build();
            await client.Connect();
            Console.WriteLine("Client successfully connected to silo host \n");
            return client;
        }
    }
}