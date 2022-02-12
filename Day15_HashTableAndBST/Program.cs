using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Console.WriteLine("*********BINARY SEARCH TREE OPERATIONS*********");
             Console.WriteLine("1.Insertion.");
             Console.WriteLine("Enter the option!!!");
             int num = Convert.ToInt32(Console.ReadLine());
              UC1_BST<int> binarySearchTree = new UC1_BST<int>(56);
              switch (num)
              {
                 case 1:
                      binarySearchTree.Insert(30);
                     binarySearchTree.Insert(70);
                     binarySearchTree.Display();
                      break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                     break;
              }
              Console.ReadLine();
          }*/

            /* Console.WriteLine("*********BINARY SEARCH TREE OPERATIONS*********");
             Console.WriteLine("1.Insertion.");
             Console.WriteLine("2.Insert More Elements");


             Console.WriteLine("Enter the option!!!!");
             int num = Convert.ToInt32(Console.ReadLine());
             UC2_BST<int> binarySearchTree = new UC2_BST<int>(56);
             switch (num)
             {
                 case 1:
                     binarySearchTree.Insert(30);
                     binarySearchTree.Insert(70);
                     binarySearchTree.Display();
                    break;
                 case 2:
                     binarySearchTree.Insert(30);
                     binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                     binarySearchTree.Insert(40);
                     binarySearchTree.Insert(11);
                     binarySearchTree.Insert(3);
                     binarySearchTree.Insert(16);
                     binarySearchTree.Insert(60);
                     binarySearchTree.Insert(95);
                     binarySearchTree.Insert(65);
                     binarySearchTree.Insert(63);
                     binarySearchTree.Insert(67);
                     binarySearchTree.Display();
                    binarySearchTree.GetSize();
                    break;
             //    default:
             //        Console.WriteLine("Enter valid option!!!");
             //        break;
             //}
             //Console.ReadLine();*/

            /*Console.WriteLine("*********BINARY SEARCH TREE OPERATIONS*********");
            Console.WriteLine("1.Insertion.");
            Console.WriteLine("2.Insert More Elements");
            Console.WriteLine("3.Search the element");
            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            UC3_BST<int> binarySearchTree = new UC3_BST<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                case 2:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    binarySearchTree.GetSize();
                    break;
                case 3:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    bool result = binarySearchTree.IfExists(63, binarySearchTree);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();

            Console.WriteLine("Hash Tables");*/


             bool flag = true;
              while (flag)
              {
                  Console.WriteLine("\nEnter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.Exit");
                  int option = Convert.ToInt32(Console.ReadLine());
                  switch (option)
                  {
                      case 1:
                          MyMapNode1<string, string> hashtable = new MyMapNode1<string, string>(5);
                          hashtable.Add("0", "To");
                          hashtable.Add("1", "be");
                          hashtable.Add("2", "or");
                          hashtable.Add("3", "not");
                          hashtable.Add("4", "to");
                          hashtable.Add("5", "be");
                          Console.ReadLine();
                          break;
                      case 2:
                          MyMapNode1<string, int> hashtable1 = new MyMapNode1<string, int>(5);
                          string input = "Paranoids are are not paranoid because they are paranoid but because they \n    keep putting themselves deliberately into paranoid avoidable situations\n";
                          Console.WriteLine($"Statement is:- {input}");
                          try
                          {
                              string[] inputArray = input.Split();
                              foreach (string word in inputArray)
                              {
                                  if (hashtable1.Get(word) == 0)
                                  {
                                      hashtable1.Add(word, 1);
                                  }
                                  else
                                  {
                                      int value = hashtable1.Get(word) + 1;
                                      hashtable1.Set(word, value);
                                  }
                              }
                              string[] newInputArray = inputArray.Distinct().ToArray();
                              foreach (var word in newInputArray)
                              {
                                  Console.WriteLine("Frequency of Word occurrence :- \"" + word + "\" is :- " + hashtable1.Get(word));
                              }
                          }
                          catch (Exception ex)
                          {
                              Console.WriteLine(ex.Message);
                          }
                          Console.ReadLine();
                          break;
                      case 3:
                          MyMapNode1<string, int> hashtable11 = new MyMapNode1<string, int>(5);
                          string input11 = "Paranoids are are not paranoid because they are paranoid but because they \n    keep putting themselves deliberately into paranoid avoidable situations\n";
                          Console.WriteLine($"Statement is:- {input11}");
                          try
                          {
                              string[] inputArray = input11.Split();
                              foreach (string word in inputArray)
                              {
                                  if (hashtable11.Get(word) == 0)
                                  {
                                      hashtable11.Add(word, 1);
                                  }
                                  else
                                  {
                                      int value = hashtable11.Get(word) + 1;
                                      hashtable11.Set(word, value);
                                  }
                              }
                              string[] newInputArray = inputArray.Distinct().ToArray();
                              foreach (var word in newInputArray)
                              {
                                  Console.WriteLine("Frequency of Word occurrence :- \"" + word + "\" is :- " + hashtable11.Get(word));
                              }
                          }
                          catch (Exception ex)
                          {
                              Console.WriteLine(ex.Message);
                          }
                          Console.ReadLine();
                          string input1 = "Paranoids are are not paranoid because they are paranoid but because they \n               keep putting themselves deliberately into paranoid avoidable situations\n";
                          Console.WriteLine($"Statement is:- {input1}");
                          hashtable11.Display();
                          try
                          {

                              string[] inputArray = input11.Split();

                              foreach (string word in inputArray)
                              {
                                  if (hashtable11.Get(word) == 0)
                                  {
                                      hashtable11.Add(word, 1);
                                  }
                                  else
                                  {
                                      int value = hashtable11.Get(word) + 1;
                                      hashtable11.Set(word, value);
                                  }
                              }
                              string[] newInputArray = inputArray.Distinct().ToArray();
                              foreach (var word in newInputArray)
                              {
                                  Console.WriteLine("Frequency of Word ccurrence :- \"" + word + "\" is :- " + hashtable11.Get(word));
                              }
                          }
                          catch (Exception ex)
                          {
                              Console.WriteLine(ex.Message);
                          }

                          hashtable11.Remove("avoidable");

                          Console.ReadLine();
                          break;
                      case 4:
                          flag = false;
                          break;
                  }
              }
          }
        }
    }

    

    