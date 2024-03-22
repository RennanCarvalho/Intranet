namespace Model
{
    public class Suporte
    {
        public Dictionary<string, List<string>>? Arquivos { get; set; } = new Dictionary<string, List<string>>();

        public Suporte()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Suporte");
            List<string>? files = new List<string>();
            foreach (var dir in Directory.GetDirectories(path))
            {
                var dirName = new DirectoryInfo(Path.GetDirectoryName(dir).ToString()).Name;

                files = Directory.GetFiles(dir, "*.*")
                                        .Select(x => Path.GetFileNameWithoutExtension(x))
                                        .OrderBy(x => x)
                                        .ToList();
                if (files.Count == 0)
                    continue;

                Arquivos.Add(Path.GetFileName(dir), files);

            }
        }

    }
}
