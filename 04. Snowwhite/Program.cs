using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    public class Dwarf
    {
        public Dwarf(string name, string hatColor, int phisics)
        {
            Name = name.Trim();
            HatColor = hatColor.Trim();
            Physics = phisics;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dwarfsDict = new Dictionary<string, Dictionary<string, int>>();

            List<Dwarf> dwarfList = new List<Dwarf>();

            string command;

            while ((command = Console.ReadLine()) != "Once upon a time")
             {
                string[] splittedCommand = command.Split("<:>", StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = splittedCommand[0];
                string dwarfHatColor = splittedCommand[1];
                int dwarfPhysics = int.Parse(splittedCommand[2]);
                Dwarf currentDwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);

                if (dwarfList.Count == 0)
                {
                    dwarfList.Add(currentDwarf);
                }
                else
                {
                    ModifyDwarfsList(dwarfList, currentDwarf);
                }
            }

            var orderedDwarfList = dwarfList
                .OrderByDescending(x => x.Physics);

            var test = orderedDwarfList.GroupBy(x => x.HatColor).OrderByDescending(x=>x.Count()).ToList();


                //.ThenByDescending(x => x.HatColor.Count())
                //.ThenByDescending(x => x.Name);

            foreach (var dwarf in orderedDwarfList)
            {
                var currentName = dwarf.Name;
                var currentHatColor = dwarf.HatColor;
                var currentPhysics = dwarf.Physics;

                Console.WriteLine($"({currentHatColor}) {currentName} <-> {currentPhysics}");
            }
        }
        static void ModifyDwarfsList(List<Dwarf> dwarfList, Dwarf currentDwarf)
        {
            var currentName = currentDwarf.Name;
            var currentHatColor = currentDwarf.HatColor;
            var currentPhysics = currentDwarf.Physics;
            List<Dwarf> CurrentdwarfList = dwarfList;
            if (dwarfList.Any(x => x.Name == currentName && x.HatColor == currentHatColor))
            {
                var existingDwarf = dwarfList.First(x => x.Name == currentName && x.HatColor == currentHatColor);
                if (existingDwarf.Physics < currentPhysics)
                {
                    existingDwarf.Physics = currentPhysics;
                }
            }
            else
            {
                dwarfList.Add(currentDwarf);
            }

            //foreach (var item in CurrentdwarfList)
            //{
            //    if (item.Name == currentName && item.HatColor != currentHatColor)
            //    {
            //        dwarfList.Add(currentDwarf);
            //        break;
            //    }
            //    else if(item.Name == currentName && item.HatColor == currentHatColor)
            //    {
            //        if (item.Physics < currentPhysics)
            //        {
            //            item.Physics = currentPhysics;
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        dwarfList.Add(currentDwarf);
            //        break;
            //    }
            //}
        }
    }
}
