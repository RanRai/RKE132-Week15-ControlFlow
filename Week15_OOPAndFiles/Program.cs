//failist andmete võtmine ja kuvamine

string[] data = GetDataFromMyFile(); //seda rida hetkel vaja ei oleks, kuid on vaja OOP funktsiooni juures
ReadDataFromArray(data);

static string[] GetDataFromMyFile() //funktsioon static, et tagastaks string tüüpi andmeid
{
    string filePath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\movies.txt"; //koht kus andmed asuvad
    return File.ReadAllLines(filePath); //tagastab andmed vahemälusse, mis failist leiab. Vahemälusse jääb üks massiiv faili andmetega.
}

static void ReadDataFromArray(string[] someArray) //funktsioon, mis lihtsalt kuvab andmed
{
    foreach(string line in someArray) //võtab iga elemendi (rea)
    {
        Console.WriteLine(line); //siin kuvab
    }
}