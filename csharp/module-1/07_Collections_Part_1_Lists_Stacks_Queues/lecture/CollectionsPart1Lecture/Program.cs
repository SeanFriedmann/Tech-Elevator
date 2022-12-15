using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
		/*
		 * ARRAYS
		 */
		//double[] averageScores = new double[20];
	 //   averageScores[0] = 3.0; 
		 


        static void Main(string[] args)
        {

			string[] staff = new string[6];
			staff[0] = "David";
			staff[1] = "Tori";
			staff[2] = "Ben";
			staff[3] = "John";
			staff[4] = "Chelsea";
			staff[5] = "Kaitlin";

			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");
			//T: standin for 'Type'
			List<string> names = new List<string>();
			// (); calls constructor for list
			names.Add("Frodo");
			names.Add("Sam");
			names.Add("Pippin");
			names.Add("Merry");
			names.Add("Gandalf");
			names.Add("Aragorn");
			names.Add("Boromir");
			names.Add("Gimli");
			names.Add("Legolas");
			//adds item to end of list




			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			for (int i = 0; i < names.Count; i++) //lists have .count, arrays have .length
			{
				Console.WriteLine(names[i]);
			}


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			names.Add("Sam");
			for (int i = 0; i < names.Count; i++) //lists have .count, arrays have .length
			{
				Console.WriteLine(names[i]);
			}


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			names.Insert(2, "David");
			for (int i = 0; i < names.Count; i++) //lists have .count, arrays have .length
			{
				Console.WriteLine(names[i]);
			}

			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			names.RemoveAt(2); //index of
			names.Remove("David"); //name itself
			
			for (int i = 0; i < names.Count; i++) //lists have .count, arrays have .length
			{
				Console.WriteLine(names[i]);
			}


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			//names.Contains("Boromir");
			bool isItemInList = names.Contains("Gandalf");
            Console.WriteLine($"Is Gandalf in the names list? {isItemInList}");


			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			int gandalfIndex = 0;
			//for (int i = 0; i < names.Count; i++)
			//         {
			//	if (names[i] == "Gandalf")
			//             {
			//		gandalfIndex = i;
			//             }
			//         }


			//Console.WriteLine(gandalfIndex);

			gandalfIndex = names.IndexOf("Gandalf"); //returns -1 if "" in indexOf doesnt exist in list collection
			Console.WriteLine(gandalfIndex);

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] namesArray = names.ToArray();
			for (int i = 0; i <namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }
			

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");


			names.Sort(); //void return type gives back nothing
				//sort changes the list
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
			//no good way to change back to the original list, once its sorted its changed
            //rely on [i] to find wanted value

			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			//Loop through names, run the code block on every item in the collection
			//foreach (<data type> <var name> in <collection>)
			foreach (string name in names)//'name' is a variable, placeholder
            {
                Console.WriteLine(name);
            }

            string myWord = "Tech Elevator";
			foreach (char letter in myWord)
            {
                Console.WriteLine(letter);
            }

			//COLLECTIONS WITH CLASSES

			List<dog> dogs = new List<dog>();
			dog davidsDog = new dog();
			davidsDog.Name = "Jerry";
			davidsDog.Age = 6;
			davidsDog.Breed = "Shepard-Mix";

			dog zachsDog = new dog();
			zachsDog.Name = "Rosy";
			zachsDog.Age = 5;
			zachsDog.Breed = "Pitbull";

			dogs.Add(zachsDog);
			dogs.Add(davidsDog);

			//data type, variable name, in collection
			foreach (dog dogNames in dogs)
			{
				Console.WriteLine(dogNames.Name); //if you forget .Name it will give CollectionsPart1Lecutre.dog
			}


			//LIST WITH BOOLS
			List<bool> isWeekend = new List<bool>();

			//Tuesday first day
			isWeekend.Add(false);
			isWeekend.Add(false);
			isWeekend.Add(false);
			isWeekend.Add(false);
			isWeekend.Add(true);
			isWeekend.Add(true);
			isWeekend.Add(false);


			
			foreach(bool dayIsWeekend in isWeekend)
            {
                Console.WriteLine(dayIsWeekend);
            }

			//QUEUE
			//first in, first out
			Queue<dog> dogQueue = new Queue<dog>();
			dogQueue.Enqueue(zachsDog);
			dogQueue.Enqueue(davidsDog);

			dogQueue.Dequeue();

			//STACK
			//deck of cards, can only pull or add from very top
			Stack<dog> dogStack = new Stack<dog>();
			dogStack.Push(zachsDog);
			dogStack.Push(davidsDog);

			dog Jerry = dogStack.Pop();
            //Console.WriteLine(	dogStack.Peek); dogStack.Peek;

			//LINKED LISTS

		}
	}
}
