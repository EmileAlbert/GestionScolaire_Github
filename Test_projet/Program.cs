using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_projet
{
    class Program
    {
        //Probleme d'affichage (-)
        static void ReadFile(string file)
        {
            // Lire et afficher les donées du fichier
            try
            {
                // Lis dans le fichier.
                String text = @"C:\Users\Admin\Documents\Mes Documents\ECAM\(3BA) Informatique C#\GestionScolaire_Github\Files_GestionScolaireb" + file ;
                // Ecris ce qui a été lu dans le fichier sur la console.

                string line = " ";
                int counter = 0;
                string res = "";

                System.IO.StreamReader var = new System.IO.StreamReader(text);
                while ((line = var.ReadLine()) != null)
                {
                    Char sep = ':';
                    String[] split = line.Split(sep);

                    res += "-";
                    foreach (string value in split ) { res += value; }
                    res += "\n";
                    counter++;
                }

                Console.WriteLine(res);
                Console.WriteLine("\nVous allez revenir au menu");
            }

            // Erreurs
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            
            
        }

        static void WriteFile(string filetxt, string str)
        {
            string folderName = @"C:\Users\Admin\Documents\Mes Documents\ECAM\(3BA) Informatique C#\GestionScolaire_Github\";  // Spécifier un nom pour le DOSSIER
            string subfolderName = "Files_GestionScolaire";          // Spécifier un nom pour le SOUS-DOSSIER
            string pathString = System.IO.Path.Combine(folderName, subfolderName);     // Définit le chemin du DOSSIER au SOUS-DOSSIER.
            System.IO.Directory.CreateDirectory(pathString);                           // Création du chemin du DOSSIER au SOUS-DOSSIER.
            string fileName = filetxt;              // Spécifier un nom pour le fichier
            pathString = System.IO.Path.Combine(pathString, fileName);                 // Définit le chemin du SOUS-DOSSIER au FICHIER.

            using(System.IO.StreamWriter file = new System.IO.StreamWriter(pathString, true))
            {
                file.WriteLine(str);
            }
            

        }

        static string[] FindObjectValue(string filetxt, string name)
        {
            string path = @"C:\Users\Admin\Documents\Mes Documents\ECAM\(3BA) Informatique C#\GestionScolaire_Github\Files_GestionScolaire" + filetxt;
            String[] erreur = { "erreur" };
            
            int counter = 0;
            string line;
            
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                Char sep = ':';
                String[] split = line.Split(sep);

                if (split[1] == name) {return split; }
                counter++;
            }
            return erreur;
            
        }
    

        static void Item(string item)
        {
            // On entre les données de création du professeur ( le nom, prénom et salaire )
            if (item == "Teacher")
            {
                Console.WriteLine("Créer un professeur");
                Console.Write("Prénom : ");
                string firstname = Console.ReadLine();
                Console.Write("Nom : ");
                string lastname = Console.ReadLine();
                Console.Write("Salaire : ");
                int salary = int.Parse(Console.ReadLine());

                // Création de l'objet grâce aux valeurs données.
                Teacher Prof = new Teacher(firstname, lastname, salary);
                
                //Ecriture dans le fichier 
                string str = Prof.Firstname + ":" + Prof.Lastname + ":" + Prof.Salary + ":" + "\n";
                WriteFile("Teacher.txt", str);

                Console.WriteLine("Le proffesseur a bien été créé dans la base de données.\nVous allez revenir au menu");
                Console.ReadKey();
                return;
            }
            
            // On définit le nom et prénom d'un étudiant.
            else if (item == "Student")
            {
                Console.WriteLine("Créer un étudiant");
                Console.Write("Prénom : ");
                string firstname = Console.ReadLine();
                Console.Write("Nom : ");
                string lastname = Console.ReadLine();

                // Création de l'objet grâce aux valeurs données.
                Student testS = new Student(firstname, lastname);
                
                string str = testS.Firstname + ":" + testS.Lastname + ":" + "\n";
                WriteFile("Student.txt", str);

                Console.WriteLine("L'étudiant a bien été créé dans la base de données.\nVous allez revenir au menu");
                Console.ReadKey();
                return;
            }


            
            // On définit le nombre d'ECTS, le nom, le code et le proffeseur responsable de l'activité
            else if (item == "Activite")
            {
                Console.WriteLine("Créer une activité");
                Console.Write("Nombre ECTS : ");
                int ECTS = int.Parse(Console.ReadLine());
                Console.Write("Nom : ");
                string Name = Console.ReadLine();
                Console.Write("Code : ");
                string Code = Console.ReadLine();
                Console.Write("Attention , le professeur doit déjà être encodé");
                Console.Write("Nom du proffesseur : ");
                string teacher = Console.ReadLine();

                //Recréation de l'objet teacher
                String[] data = FindObjectValue("Teacher.txt", teacher);                    
                Teacher Prof = new Teacher(data[1], data[0], int.Parse(data[2]));
                
                // Création de l'objet grâce aux valeurs données.
                Activity Cours = new Activity(ECTS, Name, Code, Prof);

                string str = Cours.ECTS + ":" + Cours.Name + ":" + Cours.Code + Prof.Firstname + ":" + "\n";
                WriteFile("Activity.txt", str);

                Console.WriteLine(Cours);
                Console.WriteLine("L'activité a bien été créé dans la base de données.\nVous allez revenir au menu");
                Console.ReadKey();
                return;
                
            }
            /*
            // On définit l'évaluation d'un élève.
            else if (item == "Evaluation")
            {
                Console.WriteLine("Créer une évaluation");
                //Entrez un objet ?
                //Appréciation et Note 
                //Student testE = new Evaluation(Activity);

                // Création de l'objet grâce aux valeurs données.
                Evaluation testE = new Evaluation(ECTS, Name, Code, Teacher);

                string folderName = @"c:\Test_create_folder\";  // Spécifier un nom pour le DOSSIER
                string subfolderName = "Sous-Dossier";          // Spécifier un nom pour le SOUS-DOSSIER
                string pathString = System.IO.Path.Combine(folderName, subfolderName);     // Définit le chemin du DOSSIER au SOUS-DOSSIER.
                System.IO.Directory.CreateDirectory(pathString);                           // Création du chemin du DOSSIER au SOUS-DOSSIER.
                string fileName = "Student.txt";              // Spécifier un nom pour le fichier
                pathString = System.IO.Path.Combine(pathString, fileName);                 // Définit le chemin du SOUS-DOSSIER au FICHIER.

                // Ajouter du nouveau texte à un fichier existant. 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\Test_create_folder\Sous-Dossier\Student.txt", true))
                {
                    file.WriteLine(testA.ECTS + ":" + testA.Name + ":" + testA.Code + ":" + testA.Teacher + ":" + "\n");
                }

                Console.WriteLine("L'évaluation a bien été créé dans la base de données.\nVous allez revenir au menu");
                Console.ReadKey();
                return;
            }
            */

            else { Console.Write("Error"); }
        }

        static void Main()
        {

//Création d'objet en mode console

            string Accueil =
@"********** Gestion Etablissement **********
1. Gérer et créer des instances 
2. Voir les listes déjà faites

7.Quitter";

            string CreaObjet =
@"********** Création des Objets ********** 
1. Créer Professeur 
2. Créer Etudiant
3. Créer Activité  
4. Créer Evaluation
5. Créer bulletin

6. Revenir a l'acceuil
7. Quitter";

            string Listes =
@"********** Création des Objets ********** 
1. Listes des professeurs 
2. Liste des étudiants
3. Liste des activités  
4. Liste des évaluations
5. Liste des bulletins

6. Revenir a l'acceuil
7. Quitter";

            try
            {
                Console.Clear();
                Console.WriteLine(Accueil);
                int n = (int.Parse(Console.ReadLine()));
                Console.Clear();

                switch (n)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine(Accueil);

                        int var = int.Parse(Console.ReadLine());

                        if (var == 1) { goto case 1; }
                        if (var == 2) { goto case 2; }
                        else { break; }
                        

                    case 1:
                        Console.Clear();
                        Console.WriteLine(CreaObjet);

                        int n2 = (int.Parse(Console.ReadLine()));
                        Console.Clear();
                        

                        switch (n2)
                        {
                            case 1:
                                Item("Teacher");
                                break;
                            case 2:
                                Item("Student");
                                break;
                            case 3:
                                Item("Activity");
                                break;
                            case 4:
                                Console.WriteLine("Créer une évaluation");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Créer un bulletin");
                                Console.ReadKey();
                                break;
                           case 7:
                                break;
                        }
                        goto case 0;

                    case 2:
                        Console.Clear();
                        Console.WriteLine(Listes);

                        int n3 = (int.Parse(Console.ReadLine()));
                        Console.Clear();

                        switch (n3)
                        {
                            case 1:
                                Console.WriteLine("Voici la liste des professeurs : \n");
                                ReadFile("Teacher.txt");
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine("Voici la liste des étudiants : \n");
                                ReadFile("Student.txt");
                                Console.ReadKey();
                                break;

                            case 3:
                                Console.WriteLine("Voici la liste des activités : \n");
                                ReadFile("Activity.txt");
                                Console.ReadKey();
                                break;

                            case 6:
                                Console.WriteLine("ok");
                                break;

                            case 7:
                                return;

                        }
                        goto case 0;
                  }
            }

            catch (System.FormatException) { Console.WriteLine("Erreur"); }

        }

    }
}



