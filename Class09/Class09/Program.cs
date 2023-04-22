#region Directory manipulation

using Class09;

TextHelper.TextGenerator("Working with the file system", ConsoleColor.Cyan);
string currentDirectory = Directory.GetCurrentDirectory();
TextHelper.TextGenerator($"Currently we are here: {currentDirectory}", ConsoleColor.Magenta);
string relativePath = "../../../";
TextHelper.TextGenerator("\n\n============== FOLDER=================== \n\n", ConsoleColor.Cyan);
TextHelper.TextGenerator("Check if folder exists", ConsoleColor.Cyan);

bool doesFolderExist = Directory.Exists(relativePath + "/DemoFolder");

if (doesFolderExist)
{
    Console.WriteLine("Folder exists");
}
else
{
    Console.WriteLine("Folder does not exist");
}

TextHelper.TextGenerator("\n\n============== CREATING FOLDER =================== \n\n", ConsoleColor.Cyan);

if (!doesFolderExist) {
    TextHelper.TextGenerator("Creating new folder", ConsoleColor.Cyan);
    Directory.CreateDirectory(relativePath + "DemoFolder");
}
else
{
    TextHelper.TextGenerator("Cannot create, such folder already exists", ConsoleColor.Cyan);

}



TextHelper.TextGenerator("\n\n============== DELETE FOLDER =================== \n\n", ConsoleColor.Cyan);

if (doesFolderExist)
{
    TextHelper.TextGenerator("Deleting folder", ConsoleColor.Cyan);
    Directory.Delete(relativePath + "/DemoFolder",true);
    TextHelper.TextGenerator("Folder is deleted", ConsoleColor.Cyan);

}
else
{
    TextHelper.TextGenerator("Cannot delete, such folder already exists", ConsoleColor.Cyan);

}


#endregion
#region File manipulation
TextHelper.TextGenerator("\n\n=================FILE==================\n\n", ConsoleColor.Yellow);
string relativeFilePath = "../../../FolderWithFile";

if (!Directory.Exists(relativeFilePath))
{
    Directory.CreateDirectory(relativeFilePath);
    TextHelper.TextGenerator("Creating folder", ConsoleColor.Green);

}
else
{
    Console.WriteLine("The folder exists");
}

TextHelper.TextGenerator("\n\n=================Creating file==================\n\n", ConsoleColor.Yellow);
string file = string.Empty;
file = "/test.txt";
string fileFullPath = relativeFilePath + file;
if (!File.Exists(fileFullPath))
{
    File.Create(fileFullPath).Close();
    TextHelper.TextGenerator("Creating file", ConsoleColor.Green);
    File.WriteAllText(fileFullPath, "sssssssssss");

}
else
{
    TextHelper.TextGenerator("Such file already exists", ConsoleColor.Green);
    File.WriteAllText(fileFullPath, "Writing in the file because it already exists");
    File.AppendAllText(fileFullPath, "  blablabla");
    File.ReadAllText(fileFullPath);
}
//TextHelper.TextGenerator("\n\n=================ADDING TEXT==================\n\n", ConsoleColor.Yellow);
//Console.WriteLine("Writing in File");
//File.WriteAllText(fileFullPath, "blabla bla bla blaa bla blabla bla bla blaa bla ");

//string fileText = File.ReadAllText(fileFullPath);
//Console.WriteLine("THIS IS THE FILE TEXT" + fileText);

////Console.WriteLine(fileFullPath);
//Console.WriteLine("EMPTYING FILE");
//File.WriteAllText(fileFullPath,"");
//fileText = File.ReadAllText(fileFullPath);
//Console.WriteLine("THIS IS THE FILE TEXT AFTER DELETE : " + fileText);


TextHelper.TextGenerator("\n\n=================Reading from file==================\n\n", ConsoleColor.Yellow);

if (File.Exists(fileFullPath))
{
    string fileText = File.ReadAllText(fileFullPath);
    Console.WriteLine(fileText);
}

#endregion