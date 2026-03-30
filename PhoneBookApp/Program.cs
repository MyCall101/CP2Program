// See https://aka.ms/new-console-template for more information
bool loop = true;
int index = 0;

string[,] persons = new string[5,4];

while (loop)
{
    //Console.Clear();
    int action = 0;

    DisplayMenu(ref action);

    switch (action)
    {
        case 1: // ADD CONTACT
            AddContact(persons,index);
            index +=1;
            break;
        case 2: // VIEW CONTACT
            ViewContact(persons);
            break;
        case 3: // EDIT INFORMATION
            EditContact();
            break;
        case 4: // REMOVE CONTACT
            Console.WriteLine("\n\tCall delete contact.");
            break;
        case 5:
            Console.WriteLine("\n\tExit program.");
            loop = false;
            break;

    }
}

// Edit contact information
static void EditContact()
{
    Console.WriteLine("\n\t==============================");
    Console.WriteLine("\t\tUPDATE INFORMATION");
    Console.WriteLine("\n\t\t[A] - NAME");
    Console.WriteLine("\t\t[B] - CONTACT#");
    Console.WriteLine("\t\t[C] - COURSE&YEAR");
    Console.WriteLine("\t\t[D] - ADDRESS");
    Console.WriteLine("\t\t[E] - EXIT");
    Console.WriteLine("\t==============================");
    
    Console.Write("\tChoose information to update : ");
    string chosen = Console.ReadLine();

}

// View contact information
static void ViewContact(string[,] persons)
{
    Console.WriteLine("\n||================================================================================================================================================||");
    Console.WriteLine("||***************************************************************** CONTACT LIST *****************************************************************||");
    Console.WriteLine("||================================================================================================================================================||");
    Console.WriteLine("||------------>NAME<------------||--->CONTACT #<---||--->COURSE & YEAR<---||------------------------------->ADDRESS<------------------------------||");
    Console.WriteLine("||******************************||*****************||*********************||**********************************************************************||");
    string display = "";
    if (persons[0, 0] == null)
    {
        display = String.Format("||{0,30}{1,15}{2,20}{3,79}||", " ", "", "NO CONTACT", " ");
        Console.WriteLine(display);
        Console.WriteLine("||------------------------------------------------------------------------------------------------------------------------------------------------||");
    }
    else
    {
        for (int i = 0; i <= persons.GetLength(0) - 1; i++)
        {
            if (persons[i,0] != null)
            {
                display = String.Format("||{0,-30}||{1,-17}||{2,-21}||{3,-70}||", persons[i,0], persons[i,1], persons[i,2], persons[i,3]);
                Console.WriteLine(display);
                Console.WriteLine("||------------------------------||-----------------||---------------------||----------------------------------------------------------------------||");
            }
            else
            {
                break;
            }
        }
    }

}

// Add contact information
static void AddContact(string[,] persons,int index)
{
    
    string name, course_year, _address;
    long contact_number;

    Console.Write("\n\tEnter name : ");
    name = Console.ReadLine();
    persons[index,0] = name;

    contact_number = CheckValidInteger("\n\tContact number : ");
    persons[index,1] = contact_number.ToString();
    
    Console.Write("\n\tCourse & Year : ");
    course_year = Console.ReadLine();
    persons[index,2] = course_year;
    
    Console.Write("\n\tAddress : ");
    _address = Console.ReadLine();
    persons[index,3] = _address;
    
}

// Check valid integer input
static long CheckValidInteger(string prompt)
{
    while (true)
    {
        try
        {
            Console.Write(prompt);
            long input = long.Parse(Console.ReadLine());
            return input;
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n\t" + ex.Message);
        }
    }
}

// Display menu
static void DisplayMenu(ref int action)
{
    Console.WriteLine("\n\t=================================");
    Console.WriteLine("\t\tWELCOME TO PHONEBOOK");
    Console.WriteLine("\n\t\t[1] - ADD CONTACT");
    Console.WriteLine("\t\t[2] - VIEW");
    Console.WriteLine("\t\t[3] - EDIT");
    Console.WriteLine("\t\t[4] - REMOVE");
    Console.WriteLine("\t\t[5] - EXIT");
    Console.WriteLine("\t=================================");
    do
    {
        try
        {
            Console.Write("\n\tPlease choose action on the menu : ");
            action = int.Parse(Console.ReadLine());
            if (action >=1 && action <= 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("\n\tInvalid action.!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n\t " + ex.Message);
        }
    } while (action < 1 || action > 5);
    
}
