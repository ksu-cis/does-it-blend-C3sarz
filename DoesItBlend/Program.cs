using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> items = new List<IBlendable>();
            items.Add(new Strawberry());
            items.Add(new Banana());
            items.Add(new Mango());
            items.Add(new IceCubes());
            items.Add(new CellPhone());
            items.Add(new Tomato());

            string result = "";
            foreach(IBlendable item in items)
            {
                result += item.Blend() + "\n";
            }
            Console.WriteLine(result);
        }
    }
}
