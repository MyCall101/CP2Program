// See https://aka.ms/new-console-template for more information
bool loop = true;
int index = 0;

string[] names = new string[5];
long[] contacts = new long[5];
string[] course = new string[5];
string[] address = new string[5];

while (loop)
{
    //Console.Clear();
    int action = 0;

    DisplayMenu(ref action);

    switch (action)
    {
        case 1: // ADD CONTACT
            AddContact(names,contacts,course,address,index);
            index +=1;
            break;
        case 2: // VIEW CONTACT
            ViewContact(names,contacts,course,address);
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
static void ViewContact(string[] names,long[] contacts,string[] course, string[] address)
{
    Console.WriteLine("\n||================================================================================================================================================||");
    Console.WriteLine("||***************************************************************** CONTACT LIST *****************************************************************||");
    Console.WriteLine("||================================================================================================================================================||");
    Console.WriteLine("||------------>NAME<------------||--->CONTACT #<---||--->COURSE & YEAR<---||------------------------------->ADDRESS<------------------------------||");
    Console.WriteLine("||******************************||*****************||*********************||**********************************************************************||");
    string display = "";
    if (names[0] == null)
    {
        display = String.Format("||{0,30}{1,15}{2,20}{3,79}||", " ", "", "NO CONTACT", " ");
        Console.WriteLine(display);
    }
    else
    {

        for (int i = 0; i <= names.Length - 1; i++)
        {
            if (names[i] != null)
            {
                display = String.Format("||{0,-30}||{1,-17}||{2,-21}||{3,-70}||", names[i], contacts[i], course[i], address[i]);
                Console.WriteLine(display);
                Console.WriteLine("||------------------------------||-----------------||---------------------||----------------------------------------------------------------------||");

            }
            else
            {
                break;
            }
            
        }
    }
//    Console.WriteLine("||================================================================================================================================================||");

}

// Add contact information
static void AddContact(string[] names,long[] contacts,string[] course,string[] address,int index)
{
    
    string name, course_year, _address;
    long contact_number;

    Console.Write("\n\tEnter name : ");
    name = Console.ReadLine();
    names[index] = name;

    contact_number = CheckValidInteger("\n\tContact number : ");
    contacts[index] = contact_number;
    
    Console.Write("\n\tCourse & Year : ");
    course_year = Console.ReadLine();
    course[index] = course_year;


    Console.Write("\n\tAddress : ");
    _address = Console.ReadLine();
    address[index] = _address;
    
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
