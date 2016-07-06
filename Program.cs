using System;
using System.Linq;
using System.IO;

namespace Random_Playlist {
    class Program {
        static void Main(string[] args) {
            var folder = args.Length > 0 ? args[0].TrimEnd('\\') : Directory.GetCurrentDirectory();
            var playlistName = args.Length > 1 ? args[1] : Path.Combine(folder, $"Random {Path.GetFileName(folder)}");
            if (!playlistName.EndsWith(".m3u", StringComparison.OrdinalIgnoreCase)) playlistName = $"{playlistName}.m3u";
            
            if (!Directory.Exists(folder)) {
                Console.WriteLine($"Cannot find folder {folder}");
                return;
            }

            try {
                var rnd = new Random();
                var files = Directory.EnumerateFiles(folder);
                if (playlistName.StartsWith(folder)) {
                    //use relative file names if everything is in the same folder
                    files = files.Select(f => Path.GetFileName(f));
                }
                files = files.Where(f => !f.EndsWith(".m3u"));
                files = files.OrderBy(x => rnd.Next());

                File.WriteAllLines(playlistName, files.ToArray());
                Console.WriteLine($"Successfully created {playlistName}");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
