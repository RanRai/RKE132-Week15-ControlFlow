List<Gift> myGifts = new List<Gift>();
string[] giftsFromFile = GetDataFromMyFile();

foreach (string line in giftsFromFile)
{
    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
    Gift newGift = new Gift(tempArray[0], tempArray[1]);
    myGifts.Add(newGift); //edastab Listi andmed
}

foreach (Gift giftFromList in myGifts) //loob foreachi kuvamiseks igale reale
{
    Console.WriteLine($"{giftFromList.Name} wants {giftFromList.Present}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\frozen.txt";
    string[] dataFromFile = File.ReadAllLines(filePath);
    return dataFromFile; //seda õppejõud välja ei pakkunud, aga siin TESTIS tahtis
}

class Gift
{
    string name;
    string present;
    public Gift(string _name, string _present)
    {
        name = _name;
        present = _present;
    }
    public string Name
    {
        get { return name; }
    }
    public string Present
    {
        get { return present; }
    }

}