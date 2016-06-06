using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab25
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line of code gets the path to the My Documents Folder
            string environment = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal) + "c:\\";

            Console.WriteLine("Enter a file name in My Documents: ");
            string input = Console.ReadLine();

            // concatenate the path to the file name
            string path = environment + input;

            // now we can use the full path to get the document
            StreamReader myFile = new StreamReader(path);

            //Declare an array of 50 to store values in
            int[] fileArray = new int[50];

            //Declare some ints
            int
                i = 0,
                ko = 1,
                numInputs = 0;

            //Create a do whole loop to store inputs in the array
            do
            {
                fileArray[i] = int.Parse(myFile.ReadLine());

                //If the value is zero kick it out of from the do while loop
                if (fileArray[i] == 0)
                {
                    ko = 0;
                }
                else
                {
                    //display the value entered into the array add 1 to numInputs
                    Console.WriteLine($"{fileArray[i]}");
                    i++;
                    numInputs++;
                }
            } while (ko != 0);

            //Display the average and call the find average method
            Console.WriteLine($"The Average: {FindAverage(fileArray, numInputs)}");

            //Halt the program
            Console.ReadLine();
        }

        /// <summary>
        /// Find average method
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        static int FindAverage(int[] arr, int index)
        {
            //Declare some ints
            int 
                average = 0,
                total = 0;

            //Create for loop to find the total of the array
            for (int i = 0; i < index; i++)
            {
                //add each array value to the total
                total =+ arr[i];
            }

            //return the total divided by the number of values received
            return average = total / index;
        }
    }
}
