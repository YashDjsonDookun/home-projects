using System;
using System.IO;
using System.Diagnostics;

namespace Automation
{
    class Program
    {
        static string projectType;
        static string projectName;
        static string path;
        static void Main(string[] args)
        {

            projectType = args[0];
            if ((projectType.Equals("-h") || projectType.Equals("--help")))
            {
                Console.WriteLine("Automation -h                   ----------   Prints this help Message");
                Console.WriteLine("Automation --help               ----------   Prints this help Message");
                Console.WriteLine("\nUsage example:  Automation <type> <project-name>");
                Console.WriteLine("Automation html <projectName>   ----------   HTML Project");
                Console.WriteLine("Automation java <projectName>   ----------   JAVA Project");
                Console.WriteLine("Automation php <projectName>    ----------   PHP Project");
                Console.WriteLine("Automation python <projectName>    ----------   Python Project");

                Environment.Exit(0);
            }else
            {
                try
                {
                    projectName = args[1];
                }
                catch (Exception e)
                {
                    InvalidInput();
                }


                projectType.ToLower();

                if (projectType.Equals("html") || projectType.Equals("java") || projectType.Equals("php")|| projectType.Equals("python"))
                {
                    NavigateToProjectsDirectory();
                    CreateNewProject(projectType, projectName);
                    Console.WriteLine("Would you like to create and push to a Github Repository? (y/n)");
                    string yesNo = Console.ReadLine();
                    yesNo.ToLower();
                    if (yesNo.Equals("y") || yesNo.Equals("yesNo"))
                    {
                        PushToGithub();
                    }
                    var textEdit = new ProcessStartInfo
		            {
		                FileName = "cmd",
		                RedirectStandardOutput = true,
		                RedirectStandardInput = true,
		                UseShellExecute = false
		            };
                    var openTextEditor = Process.Start(textEdit);
            		openTextEditor.StandardInput.WriteLine($"subl .");
                }
                else
                {
                    InvalidInput();
                }
                
            }            
        }

        public static void InvalidInput()
        {
            Console.WriteLine($"\"{projectType}\" is not a valid Project Type!");
            Console.WriteLine("Usage example:  Automation <type> <project-name>");
            Console.WriteLine("e.g,  Automation html myProject");
            Console.WriteLine("Try Automation -h  or  Automation --help for more info");
            Environment.Exit(0);
        }

        private static string NavigateToProjectsDirectory()
        {
            path = Directory.GetCurrentDirectory();
            if (projectType.Equals("php"))
            {
                path = "P:\\xampp\\htdocs";
                Directory.SetCurrentDirectory(path);
            }
            else
            {
                path = "U:\\Documents\\Projects\\HOME";
                Directory.SetCurrentDirectory(path);
            }

            return path;
        }

        private static string CreateNewProject(string type, string name)
        {
            Directory.CreateDirectory(name);

            path = "U:\\Documents\\Projects\\HOME\\" + name;

            if (type.Equals("html"))
            {
                CreateHtmlProject();
            }
            else if (type.Equals("java"))
            {
                CreateJavaProject();
            }
            else if (type.Equals("php"))
            {
                CreatePhpProject();
            }
            else if (type.Equals("python"))
            {
            	CreatePythonProject();
            }
            return path;
        }

        private static void PushToGithub()
        {
            if (projectType.Equals("php"))
            {
                path = "P:\\xampp\\htdocs\\" + $"{projectName}";
                Directory.SetCurrentDirectory(path);
            }
            else {
                path = "U:\\Documents\\Projects\\HOME\\" + projectName;
                Directory.SetCurrentDirectory(path);
            }
            
            var git = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            var gitRun = Process.Start(git);
            gitRun.StandardInput.WriteLine($"git init");
            gitRun.StandardInput.WriteLine($"hub create -d \"{projectName}\"");
            gitRun.StandardInput.WriteLine($"git add .");
            gitRun.StandardInput.WriteLine($"git commit -m \"first commit\"");
            gitRun.StandardInput.WriteLine($"git remote add origin git@github.com:YashDjsonDookun/" + $"{projectName}" + ".git");
            gitRun.StandardInput.WriteLine($"git push -u origin master");
            gitRun.Close();
        }

        private static void CreateHtmlProject()
        {
            string readMeFile = "README.md";
            string indexFile = "index.html";
            string styleSheet = "style.css";
            string mainJsFile = "main.js";
            
            Directory.SetCurrentDirectory(path);
            FileStream readME = File.Create(readMeFile);
            FileStream index = File.Create(indexFile);
            Directory.SetCurrentDirectory(path);
            Directory.CreateDirectory("assets");
            Directory.SetCurrentDirectory(path + "\\assets");
            Directory.CreateDirectory("images");
            Directory.CreateDirectory("js");
            Directory.SetCurrentDirectory(path + "\\assets" + "\\js");
            FileStream js = File.Create(mainJsFile);
            Directory.SetCurrentDirectory(path + "\\assets");
            Directory.CreateDirectory("css");
            Directory.SetCurrentDirectory(path + "\\assets" + "\\css");
            FileStream style = File.Create(styleSheet);
            Directory.SetCurrentDirectory(path);
        }

        private static void CreatePythonProject()
        {
            string readMeFile = "README.md";
            string appPython = "app.py";

            Directory.SetCurrentDirectory(path);
            FileStream readME = File.Create(readMeFile);
            Directory.CreateDirectory("src");
            Directory.SetCurrentDirectory(path + "\\src");
            FileStream main = File.Create(appPython);
            Directory.SetCurrentDirectory(path);
        }

        private static void CreateJavaProject()
        {
            string readMeFile = "README.md";
            string mainJava = "main.java";

            Directory.SetCurrentDirectory(path);
            FileStream readME = File.Create(readMeFile);
            Directory.CreateDirectory("src");
            Directory.SetCurrentDirectory(path + "\\src");
            FileStream main = File.Create(mainJava);
            Directory.SetCurrentDirectory(path);
        }

        private static void CreatePhpProject()
        {
            // P:\xampp\htdocs - XAMPP
            path = "P:\\xampp\\htdocs\\" + $"{projectName}";

            string readMeFile = "README.md";
            string indexFile = "index.php";
            string styleSheet = "style.css";
            string mainJsFile = "main.js";
            string appPhp = "app.php";

            Directory.SetCurrentDirectory(path);
            FileStream readME = File.Create(readMeFile);
            FileStream index = File.Create(indexFile);
            Directory.SetCurrentDirectory(path);

            Directory.CreateDirectory("assets");
            Directory.SetCurrentDirectory(path + "\\assets");
            Directory.CreateDirectory("images");
            Directory.CreateDirectory("js");
            Directory.CreateDirectory("css");
            Directory.CreateDirectory("src");

            Directory.SetCurrentDirectory(path + "\\assets" + "\\js");
            FileStream js = File.Create(mainJsFile);
            Directory.SetCurrentDirectory(path + "\\assets" + "\\css");
            FileStream style = File.Create(styleSheet);
            Directory.SetCurrentDirectory(path + "\\assets" + "\\src");
            FileStream app = File.Create(appPhp);
            Directory.SetCurrentDirectory(path);
        }
    }
}
