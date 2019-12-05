using System;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace Assignment4
{
    public class Arena
    {
        public uint Capacity { get; private set; }
        public string ArenaName { get; private set; }
        public uint Turns { get; private set; } = 0;
        public uint MonsterCount { get; private set; } = 0;
        public Monster[] Field { get; private set; }
        public Arena(string arenaName, uint capacity)
        {
            ArenaName = arenaName;
            Capacity = capacity;

            Field = new Monster[Capacity];
        }

        public void LoadMonsters(string filePath)
        {
            /* Format  : Name,ElementType,Health,AttackStat,DefenseStat
             * example : MyMonster1,Earth,100,20,10
             * data[]  : 0,1,2,3,4
             */
            using (var reader = new StreamReader(File.Open(filePath, FileMode.Open)))
            {
                for (int i = 0; i < Capacity; i++)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        Field[i] = null;
                        return;
                    }
                    else
                    {
                        string[] data = line.Split(',');
                        EElementType elementType = 0;
                        if (data[1] == "Fire")
                        {
                            elementType = EElementType.Fire;
                        }
                        else if (data[1] == "Water")
                        {
                            elementType = EElementType.Water;
                        }
                        else if (data[1] == "Wind")
                        {
                            elementType = EElementType.Wind;
                        }
                        else if (data[1] == "Earth")
                        {
                            elementType = EElementType.Earth;
                        }

                        Field[i] = new Monster(data[0], elementType, Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4]));
                    }
                }
            }
        }

        public void GoToNextTurn()
        {
            Turns++;

            for (int i = 0;  i < Capacity && Field[i] != null; i++)
            {
                if (i != Capacity - 1 && Field[i + 1] != null)
                {
                    Field[i].Attack(Field[i + 1]);                    
                }
                else
                {
                    if (i != 0)
                    {
                        Field[i].Attack(Field[0]);
                    }
                }

                for (int k = 0; k < Capacity && Field[k] != null; k++)
                { 
                    if (Field[k].Health == 0)
                    {
                        for (int n = k; n < Capacity && Field[n] != null; n++)
                        {
                            if (n != Capacity - 1)
                            {
                                Field[n] = Field[n + 1];
                            }
                            else
                            {
                                Field[n] = null;
                            }
                        }
                    }
                }
            }
        }

        public Monster GetHealthiest()
        {
            Monster Healthiest = Field[0];
            for (int i = 1; i < Capacity; i++)
            {
                if (Field[i] == null)
                {
                    break;
                }

                if (Healthiest.Health < Field[i].Health)
                {
                    Healthiest = Field[i];
                }
            }

            return Healthiest;
        }
    }
}
