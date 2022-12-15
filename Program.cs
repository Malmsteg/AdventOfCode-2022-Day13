string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
string file = Path.Combine(currentDirectory, "../../../test.txt");
string path = Path.GetFullPath(file);
string[] text = File.ReadAllText(path).Split("\n");