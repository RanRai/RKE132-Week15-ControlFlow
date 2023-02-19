//Siin teen kuvamisest valiku, soovin ainult filmi nime ja aastat. See on objekt-orjenteeritud lähenemine.

List<Movie> myMovies = new List<Movie>(); //need read peale CLASS tegemist. List salvestab objekti vahemällu. Tühi list, saab andmed myMovies realt
string[] data = GetDataFromMyFile(); //see on massiiv andmetega, iga element on rida failist, rida omakorda on eraldatud semikoolonitega.
//ReadDataFromArray(data); oli selleks, et andmeid failist kuvada, enam ei ole vaja.

foreach(string line in data) //avab data massivi
{
    string[] tempArray= line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries); //loob uue massivi tempArray on ajutine massiiv
    //Split rebib andmed laht, new chart on tunnus uuele andmele.   SSO.REE eemaldab võimalikud tühikud
    //Console.WriteLine("Temp array"); SIIN on AJUTINE KUVAMINE tempArray näitamiseks
    //ReadDataFromArray(tempArray); SIIN on AJUTINE KUVAMINE tempArray näitamiseks
    Movie newMovie = new Movie(tempArray[0], tempArray[2]); //loob uue objekti newMovie, kus annan argumendid tempArray kohal [0] ja [2]
    myMovies.Add(newMovie); //edastab Listi andmed
}   

foreach(Movie movie in myMovies) //loob foreachi kuvamiseks igale reale
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\Ranno\Desktop\tktk\programmeerimise_algkursus_RKE132\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie //classi lõi ENNE päises olevat värki.
{
    string title; //need ei pea olema _- kriipsuga. Classi omadusi nim. field-iks. Tahtsime pealkirja.
    string year; //tahtsime filmi aastat.

    public string Title //getteri tegemine, selleks et saaks hiljem kuvada küsitud andmeid. 
    {
        get { return title; } //getter
    }
    public string Year
    {
        get { return year; } //getter
    }
    //constructor
    public Movie(string _title, string _year) //siin pani kriipsud. String aasta s.p, et loeme neid, ei hakka arvutama. Need andmed tulevad failist.
    {
        title = _title;
        year = _year;
    }
}