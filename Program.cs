using System;
using System.Collections.Generic;

namespace Treino
{  
     
    public class Program
    {
        
        static void Main(string[] args)
        {
          /// <summary>
          //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
	        //If no one likes your post, it doesn't display anything.
	        //If only one person likes your post, it displays: [Friend's Name] likes your post.
	        //If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
          //If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
          //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
          //Depending on the number of names provided, display a message based on the above pattern.
          /// </summary>

            var list = new List<String>();
		
            while(true)
            {
              Console.WriteLine("Write a name:");				
              var input = Console.ReadLine();
              if(String.IsNullOrWhiteSpace(input))
                break;
              else
                list.Add(input);
              
            }
            
            switch(list.Count)
            {
              case 0:
                Console.WriteLine("Nobody likes your post");
                break;
              case 1:
                Console.WriteLine("{0} likes your post", list[0]);
                break;
              case 2:
                Console.WriteLine("{0} and {1} liked your post", list[0], list[1]);
                break;
              default:
                Console.WriteLine("{0} and {1} and {2} other people liked your post", list[0], list[1], (list.Count - 2));
                break;
            }

            //<sumary>
            //2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
	          //Display the reversed name on the console. 
            //</sumary>         
            
            Console.WriteLine("Enter name: ");
            var texto = Console.ReadLine();
            
            string invertendo = new string(texto?.Reverse().ToArray());
            Console.WriteLine(invertendo);
            Console.ReadLine();

           //<sumary>
           //3 - Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
	         //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
           //</sumary>
            var list1 = new List<int>();

            while(list1.Count < 5)
            {
                Console.WriteLine("Input a number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if( list1.Contains(input))
                  Console.WriteLine("Number already exists!");
                  else
                  {
                    list1.Add(input);
                  }
            }

              list1.Sort();
              foreach(var number in list1)
              {
                Console.WriteLine(number);
              }
              
          //<sumary>
          //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. 
	        //Display the unique numbers that the user has entered.
          //</sumary>

            var numbers = new List<int>();
            Console.WriteLine("type a number or type quit to exit: ");

            while(true)
            {
            
              var typing = Console.ReadLine();

              if(typing == "quit")
              {
                break;
              }
              else
              {
                if (!numbers.Contains(Convert.ToInt32(typing)))
                    numbers.Add(Convert.ToInt32(typing));
              }        

            }

            foreach(var n in numbers)
            Console.WriteLine(n); 

          //<sumary>
          //5-Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
          //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
          //otherwise, display the 3 smallest numbers in the list.
          //</sumary>

            Console.WriteLine("Please enter 5 comma seperated numbers");

          do
          {
              var enteredNumbers = Console.ReadLine();

              var numberList = new List<string>(enteredNumbers.Split(','));

              if (String.IsNullOrWhiteSpace(enteredNumbers) || numberList.Count != 5 )
              Console.WriteLine("Invalid List, try again");

              if (numberList.Count == 5)
              {
                  numberList.Sort();

                  const int numToShow = 3;
                  for (var i = 0; i < numToShow; i++)
                  {
                      Console.WriteLine(numberList[i]);
                  }
                  break;
              }
            
          }
          while (true);
            
      }
                
    }
}

