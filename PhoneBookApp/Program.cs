// See https://aka.ms/new-console-template for more information
bool loop = true;
while (loop)
{
    //Console.Clear();
    int action = 0;
    DisplayMenu(ref action);

    switch (action)
    {
        case 1: // ADD CONTACT
            AddContact();
            break;
        case 2: // VIEW CONTACT
            ViewContact();
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
static void ViewContact()
{
    Console.WriteLine("\n||================================================================================================================================================||");
    Console.WriteLine("||***************************************************************** CONTACT LIST *****************************************************************||");
    Console.WriteLine("||================================================================================================================================================||");
    Console.WriteLine("||------------>NAME<------------||--->CONTACT #<---||--->COURSE & YEAR<---||------------------------------->ADDRESS<------------------------------||");
    Console.WriteLine("||******************************||*****************||*********************||**********************************************************************||");
}

// Add contact information
static void AddContact()
{
    
    string name, course_year, address;
    int contact_number;

    Console.Write("\n\tEnter name : ");
    name = Console.ReadLine();

    contact_number = CheckValidInteger("\n\tContact number : ");
    
    Console.Write("\n\tCourse & Year : ");
    course_year = Console.ReadLine();


    Console.Write("\n\tAddress : ");
    address = Console.ReadLine();
    
}

// Check valid integer input
static int CheckValidInteger(string prompt)
{
    while (true)
    {
        try
        {
            Console.Write(prompt);
            int input = int.Parse(Console.ReadLine());
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
