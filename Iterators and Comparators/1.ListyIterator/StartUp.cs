using ListyIteratorNS;

ListyIterator<string> a = new ListyIterator<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList());

string input;

while ((input=Console.ReadLine())!="END")
{
    switch (input)
    {
        case "HasNext":
            Console.WriteLine(a.HasNext());
            break;
        case "Print":
            try
            {
                a.Print();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            break;
        case "Move":
            Console.WriteLine(a.Move());
            break;
        default:
            break;
    }
}