#region InitialSetup
using Class09;

TextHelper.TextGenerator("Check if the folder exists.", ConsoleColor.Cyan);
string relativeFolderPath = "../../../StreamFolder";
if (!Directory.Exists(relativeFolderPath))
{
    Directory.CreateDirectory(relativeFolderPath);
    TextHelper.TextGenerator("Creating StreamFolder", ConsoleColor.Green);

}

TextHelper.TextGenerator("Check if the file exists.", ConsoleColor.Cyan);
string relativeFilePath = relativeFolderPath + "/streamFile.txt";
if (!Directory.Exists(relativeFilePath))
{
    File.Create(relativeFilePath).Close();
    TextHelper.TextGenerator("File created", ConsoleColor.Green);

}

#endregion

#region FileManipulation with streams
TextHelper.TextGenerator("\n\n\n Writing in the newly created file with the StreamWriter", ConsoleColor.Cyan);
StreamWriter sw = new StreamWriter(relativeFilePath);
sw.WriteLine("I am writing in the file with StreamWriter");
sw.Close();


TextHelper.TextGenerator("\n\n\n Writing in the newly created file with the StreamWriter COMPLETED", ConsoleColor.Green);


TextHelper.TextGenerator("\n\n\n Writing in the newly created file with the StreamWriter. But we are using [USING]", ConsoleColor.Green);

using (sw = new StreamWriter(relativeFilePath, true))
{
    sw.WriteLine("Hello we are in the USING");
    sw.WriteLine("PA PA PAP A");
    sw.WriteLine("Team team team");
    TextHelper.TextGenerator("\n\n\n USING is closed now", ConsoleColor.Green);


}

using (StreamReader sr = new StreamReader(relativeFilePath))
{
    string text = sr.ReadToEnd();
    TextHelper.TextGenerator("Reading from the stream file...", ConsoleColor.Cyan);
    TextHelper.TextGenerator(text, ConsoleColor.Cyan);

}
#endregion