
List<int> list = new List<int>(); //creation of list
list.Add(1); //adding elements to list
list.Add(2);    
list.Add(3);
list.Add(4);   
list.Add(5);
list.Add(6);


list.ForEach(x => Console.WriteLine(x)); //list all items in the list

list.Sort(); //list items are sorted.
Console.WriteLine("Sorted List");
list.ForEach(x => Console.WriteLine(x)); //Display sorted list

Console.WriteLine("Max number in the list:" +list.Max()); //max number in the list
Console.WriteLine("Min number in the list:" + list.Min()); //min number in the list

//Lets find the max number in the list manually
int currentElement = list[0];
for (int i = 0; i < list.Count; i++) 
{
	while (currentElement < list[i]) 
	{
        currentElement = list[i]; //pass to another element in the list, when highest number is achieved while loop will be done
    }  
}
Console.WriteLine("Highest number in the list:"+currentElement);

//----------------------------  
int[] array = new int[11];   //creation of array with 11 elements.
for (int i = 0; i < array.Length; i++)
{
    array[i] = i; //adding elements which created by for loop to array 
}
foreach (var item in array) //listed all element in the array
{
    Console.WriteLine(item); 
}


int highest = array[0]; //initially highest is the first element of the array
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > highest) // when current element is higher than highest next to another one
        {
            highest = array[i];
        } 
    }
Console.WriteLine("Highest value in the array: "+highest);







