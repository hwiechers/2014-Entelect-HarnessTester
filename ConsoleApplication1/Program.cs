using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new [] {
                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "   !A..#   #...B   " + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "   !B..#   #..A!   " + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "   A ..#   #..B!   " + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "     ..# B #.. A   " + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "     ..#   #..     " + Environment.NewLine +
                "####.#.##A##.#.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.##A##.#.####" + Environment.NewLine +
                "     ..#   #..     " + Environment.NewLine +
                "####.#.##B##.#.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                
                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#.......#.####" + Environment.NewLine +
                "####.#.##B##.#.####" + Environment.NewLine +
                "     ..#   #..     " + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "####.#...A...#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",

                
                "###################" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#*##.###.#.###.##*#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "#.##.#.#####.#.##.#" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "####.###.#.###.####" + Environment.NewLine +
                "####.#...A...#.####" + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "     ..#   #..     " + Environment.NewLine +
                "####.#.## ##.#.####" + Environment.NewLine +
                "####.#...B...#.####" + Environment.NewLine +
                "####.#.#####.#.####" + Environment.NewLine +
                "#........#........#" + Environment.NewLine +
                "#.##.###.#.###.##.#" + Environment.NewLine +
                "#*.#...........#.*#" + Environment.NewLine +
                "##.#.#.#####.#.#.##" + Environment.NewLine +
                "#....#...#...#....#" + Environment.NewLine +
                "#.######.#.######.#" + Environment.NewLine +
                "#.................#" + Environment.NewLine +
                "###################",
            };

            var ply = 0;
            if (File.Exists("ply.txt"))
            {
                ply = int.Parse(File.ReadAllText("ply.txt"));
            }

            if (ply >= output.Length)
            {
                File.Delete("ply.txt");
                return;
            }

            File.AppendAllText("log.txt", 
                string.Format("Ply {0}", ply) + Environment.NewLine +
                File.ReadAllText(args[0]) + Environment.NewLine);

            File.WriteAllText("ply.txt", (ply + 1).ToString());

            File.WriteAllText("game.state", output[ply]);
        }
    }
}
