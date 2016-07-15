using System.Threading.Tasks;
using Orleans;
using MyGrainInterfaces;
using System;

namespace MyGrains
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class Grain1 : Grain, IGrain1
    {
        private string text = "Hello World!";

        public Task<string> SayHello(string greeting)
        {
            var oldText = text;
            text = greeting;
            return Task.FromResult(oldText);
        }
    }
}
