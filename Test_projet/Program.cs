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
        static void Item(string item)
        {
            // On définit le nom, prénom et salaire d'un professeur.
            if (item == "Teacher")
            {
                Console.WriteLine("Créer un proffesseur");
                Console.WriteLine("ATTENTION -> Introduire toutes les caractères en MAJUSCULE!");
                Console.Write("Prénom : ");
                string firstname = Console.ReadLine();
                Console.Write("Nom : ");
                string lastname = Console.ReadLine();
                Console.Write("Salaire : ");
                int salary = int.Parse(Console.ReadLine());

                // Création de l'objet grâce aux valeurs données.
                Teacher testT = new Teacher(firstname, lastname, salary);

                string folderName = @"c:\Test_create_folder\";  // Spécifier un nom pour le DOSSIER
                string subfolderName = "Sous-Dossier";          // Spécifier un nom pour le SOUS-DOSSIER
                string pathString = System.IO.Path.Combine(folderName, subfolderName);     // Définit le chemin du DOSSIER au SOUS-DOSSIER.
                System.IO.Directory.CreateDirectory(pathString);                           // Création du chemin du DOSSIER au SOUS-DOSSIER.
                string fileName = "Teacher.txt";              // Spécifier un nom pour le fichier
                pathString = System.IO.Path.Combine(pathString, fileName);                 // Définit le chemin du SOUS-DOSSIER au FICHIER.

                // Ajouter du nouveau texte à un fichier existant. 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\Test_create_folder\Sous-Dossier\Teacher.txt", true))
                {
                    file.WriteLine(testT.Firstname + ":" + testT.Lastname + ":" + testT.Salary + ":" + "\n");
                }

                Console.WriteLine("Le proffesseur a bien été créé dans la base de données.\nVous allez revenir au menu");
                Console.ReadKey();


                return;
            }


            // On définit le nom et prénom d'un étudiant.
            else if (item == "Student")
            {
                Console.WriteLine("Créer un étudiant");
                Console.WriteLine("ATTENTION -> Introduire toutes les caractères en MAJUSCULE!");
                Console.Write("Prénom : ");
                string firstname = Console.ReadLine();
                Console.Write("Nom : ");
                string lastname = Console.ReadLine();

                // Création de l'objet grâce aux valeurs données.
                Student testS = new Student(firstname, lastname);

                string folderName = @"c:\Test_create_folder\";  // Spécifier un nom pour le DOSSIER
                string subfolderName = "Sous-Dossier";          // Spécifier un nom pour le SOUS-DOSSIER
                string pathString = System.IO.Path.Combine(folderName, subfolderName);     // Définit le chemin du DOSSIER au SOUS-DOSSIER.
                System.IO.Directory.CreateDirectory(pathString);                           // Création du chemin du DOSSIER au SOUS-DOSSIER.
                string fileName = "Student.txt";              // Spécifier un nom pour le fichier
                pathString = System.IO.Path.Combine(pathString, fileName);                 // Définit le chemin du SOUS-DOSSIER au FICHIER.

                // Ajouter du nouveau texte à un fichier existant. 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\Test_create_folder\Sous-Dossier\Student.txt", true))
                {
                    file.WriteLine(testS.Firstname + ":" + testS.Lastname + ":" + "\n");
                }

                Console.WriteLine("L'étudiant a bien été créé dans la base de données.\nVous allez revenir au menu");
                Console.ReadKey();
                return;
            }


            
            // On définit le nombre d'ECTS, le nom, le code et le proffeseur responsable de l'activité
            else if (item == "Activite")
            {
                Console.WriteLine("Créer une activité");
                Console.WriteLine("ATTENTION -> Introduire toutes les caractères en MAJUSCULE!");
                Console.Write("Nombre ECTS : ");
                int ECTS = int.Parse(Console.ReadLine());
                Console.Write("Nom : ");
                string Name = Console.ReadLine();
                Console.Write("Code : ");
                string Code = Console.ReadLine();
                Console.Write("Proffesseur : ");
                string Teacher = Console.ReadLine();


                // Lis dans le fichier Teacher.txt
                String text = System.IO.File.ReadAllText(@"c:\Test_create_folder\Sous-Dossier\Teacher.txt");
                Char delimiter = ':';
                String[] substrings = text.Split(delimiter);
                foreach (var substring in substrings)
                    if (substring == Teacher)
                    {
                        Console.WriteLine(substring + "trouvé");
                    }
               
                Teacher testB = new Teacher("Emile", "Albert", 2300);
                string nameComplet = testB.Firstname + " " + testB.Lastname ;
                

                // Création de l'objet grâce aux valeurs données.
                //Activity testA = new Activity(ECTS, Name, Code, nameComplet);

                string folderName = @"c:\Test_create_folder\";  // Spécifier un nom pour le DOSSIER
                string subfolderName = "Sous-Dossier";          // Spécifier un nom pour le SOUS-DOSSIER
                string pathString = System.IO.Path.Combine(folderName, subfolderName);     // Définit le chemin du DOSSIER au SOUS-DOSSIER.
                System.IO.Directory.CreateDirectory(pathString);                           // Création du chemin du DOSSIER au SOUS-DOSSIER.
                string fileName = "Activite.txt";              // Spécifier un nom pour le fichier
                pathString = System.IO.Path.Combine(pathString, fileName);                 // Définit le chemin du SOUS-DOSSIER au FICHIER.

                // Ajouter du nouveau texte à un fichier existant. 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\Test_create_folder\Sous-Dossier\Activite.txt", true))
                {
                    file.WriteLine(nameComplet + ":" + "\n");
                    //file.WriteLine(testA.ECTS + ":" + testA.Name + ":" + testA.Code + ":" + testA.testB + ":" + "\n");
                }

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
            string folderName = @"C:\Users\Admin\Documents\Mes Documents\ECAM\(3BA) Informatique C#\Projet\Test_projet\TEST";  // Spécifier un nom pour le DOSSIER
            string subfolderName = "Sous-Dossier";          // Spécifier un nom pour le SOUS-DOSSIER

            string pathString = System.IO.Path.Combine(folderName, subfolderName);     // Définit le chemin du DOSSIER au SOUS-DOSSIER.
            System.IO.Directory.CreateDirectory(pathString);                           // Création du chemin du DOSSIER au SOUS-DOSSIER.


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
                                Item("Activite");
                                break;
                            case 4:
                                Console.WriteLine("Créer une évaluation");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Créer un bulletin");
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.WriteLine("Ok");
                                break;
                            case 7:
                                break;
                        }
                    goto case 0;
                    break;
    

                    case 2:
                        Console.Clear();
                        Console.WriteLine(Listes);

                        int n3 = (int.Parse(Console.ReadLine()));
                        Console.Clear();

                        switch (n3)
                        {
                            case 1:
                                Console.WriteLine("Voici la liste des professeurs : \n");
                                // Lire et afficher les donées du fichier
                                try
                                {
                                    // Lis dans le fichier.
                                    String text = System.IO.File.ReadAllText(@"c:\Test_create_folder\Sous-Dossier\Teacher.txt");
                                    // Ecris ce qui a été lu dans le fichier sur la console.
                                    Console.Write(text);
                                    Console.WriteLine();
                                }

                                // Erreurs
                                catch (System.IO.IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                Console.WriteLine("Tout est repris.");
                                Console.ReadKey();
                                return;
                                break;
                            case 2:
                                Console.WriteLine("Voici la liste des étudiants : \n");
                                // Lire et afficher les donées du fichier
                                try
                                {
                                    // Lis dans le fichier.
                                    String text = System.IO.File.ReadAllText(@"c:\Test_create_folder\Sous-Dossier\Student.txt");
                                    // Ecris ce qui a été lu dans le fichier sur la console.
                                    Console.Write(text);
                                    Console.WriteLine();
                                }

                                // Erreurs
                                catch (System.IO.IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                return;
                                break;

                            case 3:
                                Console.WriteLine("Voici la liste des activités : \n");
                                // Lire et afficher les donées du fichier
                                try
                                {
                                    // Lis dans le fichier.
                                    String text = System.IO.File.ReadAllText(@"c:\Test_create_folder\Sous-Dossier\Activite.txt");
                                    // Ecris ce qui a été lu dans le fichier sur la console.
                                    Console.Write(text);
                                    Console.WriteLine();
                                }

                                // Erreurs
                                catch (System.IO.IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                return;
                                break;

                            case 6:
                                Console.WriteLine("ok");
                                break;

                            case 7:
                                return;

                        }
                        goto case 0;
                        break;

                    case 7:
                        return;

                }
            }

            catch (System.FormatException) { Console.WriteLine("Erreur"); }

        }

    }
}



