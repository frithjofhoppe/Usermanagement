/* 
 Name: Frithjof Hoppe
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

class Program
{
    static void header(int index)
    {
        Console.WriteLine("\nADRESSVERWALTUNG\n");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Index: {0}", index);
        Console.WriteLine("---------------------------");

    }

    static string menu(int index)
    {
        Console.Clear();
        header(index);

        Console.WriteLine("N => Neuefassen");
        Console.WriteLine("A => Aendern");
        Console.WriteLine("V => vormärts");
        Console.WriteLine("R => Rückwärts");
        Console.WriteLine("Z => Aktuelle Adresse anzeigen");
        Console.WriteLine("P => Zeige Alle Adressen an");
        Console.WriteLine("S => Suchen einer ID");
        Console.WriteLine("L => Löschen eines Indexes\n");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.WriteLine("E => Exit\n");

        Console.Write("Wahl: "); string wahl = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return wahl;
    }

    static void pruefen(int verfahren, ref string ausgabe) // Eingabe überprüfen ( plausibilisieren )
    {
        Console.Clear();
        if (verfahren == 1)
        {
            string[] informationen = new string[5];
            List<string> tempa = new List<string>();

            bool total = false;
            while (!total)
            {
                tempa.Clear();
                string temp = "";
                bool zeichen = true;
                bool laenge = true;
                bool tmp = false;
                bool tmp2 = true;

                Console.Write("Nummer     :");

                temp = Console.ReadLine();

                for (int i = 0; i < temp.Length; i++)
                {
                    string local;
                    local = Convert.ToString(temp[i]);
                    tempa.Add(local);
                }

                if (temp.Length > 4)
                {
                    Console.WriteLine("Die Eingabe ueberschreitet 4 Zeichen");
                    laenge = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    laenge = true;
                }

                Regex ort = new Regex(@"^[0-9]$");

                for (int t = 0; t < tempa.Count; t++)
                {

                    if (ort.IsMatch(tempa[t]))
                    {
                        tmp = true;
                    }

                    else// if(!ort.IsMatch(tempa[t]))
                    {
                        tmp2 = false;
                        // Console.WriteLine("False");
                    }

                }

                if (tmp && tmp2)
                { zeichen = true; }
                else { zeichen = false; }

                if (zeichen == true && laenge == true)
                {

                    Console.ReadKey();
                    Console.WriteLine("Eingabe ist in Ordnung");
                    Thread.Sleep(500);
                    Console.Clear();
                    total = true;
                    ausgabe = temp;
                }

                else if (!zeichen)
                {
                    Console.WriteLine("Eingabe enthält nicht erlaubte Zeichen");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }
        }
        else if (verfahren == 2)
        {
            string[] informationen = new string[5];
            List<string> tempa = new List<string>();

            bool total = false;
            while (!total)
            {
                tempa.Clear();
                string temp = "";
                bool zeichen = true;
                bool laenge = true;
                bool tmp = false;
                bool tmp2 = true;

                Console.Write("Ort        :");

                temp = Console.ReadLine();

                for (int i = 0; i < temp.Length; i++)
                {
                    string local;
                    local = Convert.ToString(temp[i]);
                    tempa.Add(local);
                }

                if (temp.Length > 20)
                {
                    Console.WriteLine("Die Eingabe ueberschreitet 20 Zeichen");
                    laenge = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    laenge = true;
                }

                Regex ort = new Regex(@"^[a-zA-Z]$");

                for (int t = 0; t < tempa.Count; t++)
                {

                    if (ort.IsMatch(tempa[t]))
                    {
                        tmp = true;
                    }

                    else// if(!ort.IsMatch(tempa[t]))
                    {
                        tmp2 = false;
                        // Console.WriteLine("False");
                    }

                }

                if (tmp && tmp2)
                { zeichen = true; }
                else { zeichen = false; }

                if (zeichen == true && laenge == true)
                {

                    Console.ReadKey();
                    Console.WriteLine("Eingabe ist in Ordnung");
                    Thread.Sleep(500);
                    Console.Clear();
                    total = true;
                    ausgabe = temp;
                }

                else if (!zeichen)
                {
                    Console.WriteLine("Eingabe enthält nicht erlaubte Zeichen");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }
        }
        else if (verfahren == 3)
        {
            string[] informationen = new string[5];
            List<string> tempa = new List<string>();

            bool total = false;
            while (!total)
            {
                tempa.Clear();
                string temp = "";
                bool zeichen = true;
                bool laenge = true;
                bool tmp = false;
                bool tmp2 = true;

                Console.Write("Name       :");

                temp = Console.ReadLine();

                for (int i = 0; i < temp.Length; i++)
                {
                    string local;
                    local = Convert.ToString(temp[i]);
                    tempa.Add(local);
                }

                if (temp.Length > 20)
                {
                    Console.WriteLine("Die Eingabe ueberschreitet 20 Zeichen");
                    laenge = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    laenge = true;
                }

                Regex ort = new Regex(@"^[a-zA-Z]$");

                for (int t = 0; t < tempa.Count; t++)
                {

                    if (ort.IsMatch(tempa[t]))
                    {
                        tmp = true;
                    }

                    else// if(!ort.IsMatch(tempa[t]))
                    {
                        tmp2 = false;
                        // Console.WriteLine("False");
                    }

                }

                if (tmp && tmp2)
                { zeichen = true; }
                else { zeichen = false; }

                if (zeichen == true && laenge == true)
                {

                    Console.ReadKey();
                    Console.WriteLine("Eingabe ist in Ordnung");
                    Thread.Sleep(500);
                    Console.Clear();
                    total = true;
                    ausgabe = temp;
                }

                else if (!zeichen)
                {
                    Console.WriteLine("Eingabe enthält nicht erlaubte Zeichen");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }
        }
        else if (verfahren == 4)
        {
            string[] informationen = new string[5];
            List<string> tempa = new List<string>();

            bool total = false;
            while (!total)
            {
                tempa.Clear();
                string temp = "";
                bool zeichen = true;
                bool laenge = true;
                bool tmp = false;
                bool tmp2 = true;

                Console.Write("Vorname    :");

                temp = Console.ReadLine();

                for (int i = 0; i < temp.Length; i++)
                {
                    string local;
                    local = Convert.ToString(temp[i]);
                    tempa.Add(local);
                }

                if (temp.Length > 20)
                {
                    Console.WriteLine("Die Eingabe ueberschreitet 20 Zeichen");
                    laenge = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    laenge = true;
                }

                Regex ort = new Regex(@"^[a-zA-Z]$");

                for (int t = 0; t < tempa.Count; t++)
                {

                    if (ort.IsMatch(tempa[t]))
                    {
                        tmp = true;
                    }

                    else// if(!ort.IsMatch(tempa[t]))
                    {
                        tmp2 = false;
                        // Console.WriteLine("False");
                    }

                }

                if (tmp && tmp2)
                { zeichen = true; }
                else { zeichen = false; }

                if (zeichen == true && laenge == true)
                {

                    Console.ReadKey();
                    Console.WriteLine("Eingabe ist in Ordnung");
                    Thread.Sleep(500);
                    Console.Clear();
                    total = true;
                    ausgabe = temp;
                }

                else if (!zeichen)
                {
                    Console.WriteLine("Eingabe enthält nicht erlaubte Zeichen");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }
        }
        else if (verfahren == 5)
        {
            string[] informationen = new string[5];
            List<string> tempa = new List<string>();

            bool total = false;
            while (!total)
            {
                tempa.Clear();
                string temp = "";
                bool zeichen = true;
                bool laenge = true;
                bool tmp = false;
                bool tmp2 = true;
                                    
                Console.Write("Alter      :");

                temp = Console.ReadLine();

                for (int i = 0; i < temp.Length; i++)
                {
                    string local;
                    local = Convert.ToString(temp[i]);
                    tempa.Add(local);
                }

                if (temp.Length > 3)
                {
                    Console.WriteLine("Die Eingabe ueberschreitet 3 Zeichen");
                    laenge = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    laenge = true;
                }

                Regex ort = new Regex(@"^[0-9]$");

                for (int t = 0; t < tempa.Count; t++)
                {

                    if (ort.IsMatch(tempa[t]))
                    {
                        tmp = true;
                    }

                    else// if(!ort.IsMatch(tempa[t]))
                    {
                        tmp2 = false;
                        // Console.WriteLine("False");
                    }

                }

                if (tmp && tmp2)
                { zeichen = true; }
                else { zeichen = false; }

                if (zeichen == true && laenge == true)
                {

                    Console.ReadKey();
                    Console.WriteLine("Eingabe ist in Ordnung");
                    Thread.Sleep(500);
                    Console.Clear();
                    total = true;
                    ausgabe = temp;
                }

                else if (!zeichen)
                {
                    Console.WriteLine("Eingabe enthält nicht erlaubte Zeichen");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.Clear();
            }
        }

        else if (verfahren == 6)
        {
            List<string> test = new List<string>();
            bool complete = false;

            while (!complete)
            {
                bool erstens = false;
                bool tmp = false;
                bool tmp2 = true;
                string bd = "";
                int position = 0;
                int vor = 0;
                int nach = 0;
                test.Clear();
                while (!erstens)
                {
                    Console.Clear();              
                    Console.Write("Umsatz     :");
                    bd = Console.ReadLine();

                    if (bd.Length > 10)
                    {
                        Console.WriteLine("Die Eingabe ist zu Gross");

                    }
                    else
                    {
                        erstens = true;
                    }
                }

                for (int i = 0; i < bd.Length; i++)
                {
                    string local;
                    local = Convert.ToString(bd[i]);
                    test.Add(local);
                }

                Regex zahl = new Regex(@"^[0-9]$");     //Überprüfung der Eingabe auf numerische Werte
                Regex ausnahme = new Regex(@"^[.]$");   //Überprüfung der Eingabe auf alphanumerische Werte

                for (int i = 0; i < test.Count; i++)
                {
                    if (zahl.IsMatch(test[i]) || ausnahme.IsMatch(test[i]))
                    {
                        tmp = true;
                    }
                    else
                    {
                        tmp2 = false;
                    }
                }

                if (tmp == true && tmp2 == true)
                {
                    int positione = test.LastIndexOf(".");
                    position = positione + 1;
                   // Console.WriteLine("Position des Punlte {0} gesamte laenge {1}", position, test.Count);

                    vor = position - 1;
                    nach = test.Count - positione - 1;
                    //Console.WriteLine("Vor :{0} Nach:{1}", vor, nach);
                  
                    if (test.Contains("."))
                    {
                        if (nach > 2 || vor > 7)
                        {
                            Console.WriteLine("Eingabe enthaelt zu viele Nachkommastellen");
                        }
                        else
                        {
                            Console.WriteLine("Eingabe ist in Ordnung");
                            ausgabe = bd;
                            complete = true;
                        }
                    }
                    else if (bd.Length > 7)
                    {
                        Console.WriteLine("Eingabe enthält zu viele Vorkommastellen");
                    }
                    else
                    {
                        Console.WriteLine("Eingabe ist in Ordnung");
                        ausgabe = bd;
                        complete = true;
                    }
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Eigabe entaehlt nicht erlaubte Zeichen");
                    Thread.Sleep(1000);
                    Console.Clear();
                    
                }

            }
        }

    }

    static int Neu(ref List<string> adr, int index)
    {
        string ort = "";
        string nummer = "";
        string name = "";
        string vorname = "" ;
        string alter = "";
        string umsatz = "";
        pruefen(1, ref nummer);
        pruefen(2, ref ort);
        pruefen(3, ref name);
        pruefen(4, ref vorname);
        pruefen(5, ref alter);
        pruefen(6, ref umsatz);
        Console.Clear();

        Console.WriteLine("Nummer:      {0}", nummer);
        Console.WriteLine("Vorname:     {0}", vorname);
        Console.WriteLine("Nachname:    {0}", name);
        Console.WriteLine("Ort:         {0}", ort);
        Console.WriteLine("Alter:       {0}", alter);
        Console.WriteLine("Umsatz:      {0}\n", umsatz);


        Console.Write("Datensatz speichern? <j/n> "); string wahl = Console.ReadLine().ToUpper();

        if (wahl == "J")
        {
            string zeile = nummer + ";" + name + ";" + vorname + ";" + ort + ";" + alter + ";" + umsatz;
            adr.Add(zeile);
            index++;
        }
        return index;
    }


    static bool frage(int zeilen)
    {
        int zeile = zeilen;
  

        if (zeile == 1)
        {
            Console.Write("Wollen sie die Nummer ändern <j>");
            if (Console.ReadLine() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (zeile == 2)
        {
            Console.Write("Wollen sie den Namen ändern <j>");
            if (Console.ReadLine() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (zeile == 3)
        {
            Console.Write("Wollen sie die Vornamen ändern <j>");
            if (Console.ReadLine() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (zeile == 4)
        {
            Console.Write("Wollen sie dden Ort ändern <j>");
            if (Console.ReadLine() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (zeile == 5)
        {
            Console.Write("Wollen sie das Alter ändern <j>");
            if (Console.ReadLine() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (zeile == 6)
        {
            Console.Write("Wollen sie den Umsatz ändern <j>");
            if (Console.ReadLine() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else { return false; }

    }

    static int Aendern(ref List<string> adr, int index) // Aendern mit plausibilisierung
    {
        int tempindex;
        tempindex = index;

        tempindex = tempindex - 1;
        string[] feld = adr[tempindex].Split(';');
        string[] tmpe = adr[tempindex].Split(';');

        Zeige(ref adr, index);

        string nummer = "";
        string name  = "";
        string vorname ="";
        string ort="";
        string alter="";
        string umsatz="";
        string tmp = "";
        Console.Write("Alte Nummer  {0,-10} : ", feld[0]); if (!frage(1)) { nummer = tmpe[0]; } else { pruefen(1, ref nummer); }  //nummer = check(tmp, feld[0]);
        Console.Write("Alter Name {0,-10} : ", feld[1]); Zeige(ref adr, index); if (!frage(2)) {   name = tmpe[1]; } else { pruefen(3, ref name); } //pruefen(3, ref tmp);// name = check(tmp, feld[1]);
        Console.Write("Alter Vorname   {0,-10} : ", feld[2]); Zeige(ref adr, index); if (!frage(3)) { vorname = tmpe[2]; } else { pruefen(4, ref vorname); } //vorname = check(tmp, feld[2]);
        Console.Write("Alter Ort     {0,-10} : ", feld[3]); Zeige(ref adr, index); if (!frage(4)) { ort = tmpe[3]; } else { pruefen(2, ref ort); }//pruefen(2, ref tmp);ort = check(tmp, feld[3]);
        Console.Write("Altes Alter   {0,-10} : ", feld[4]); Zeige(ref adr, index); if (!frage(5)) { alter = tmpe[4]; } else { pruefen(5, ref alter); }//pruefen(5, ref tmp);alter= check(tmp, feld[4]);
        Console.Write("Alter Umsatz  {0,-10} : ", feld[5]); Zeige(ref adr, index); if (!frage(6)) { umsatz = tmpe[5]; } else { pruefen(6, ref umsatz); }//pruefen(6, ref tmp);umsatz= check(tmp, feld[5]);



        Console.Write("Änderung speichern? <j/n> "); string wahl = Console.ReadLine().ToUpper();

        if (wahl == "J")
        {
            feld[0] = nummer;
            feld[1] = vorname;
            feld[2] = name;
            feld[3] = ort;
            feld[4] = alter;
            feld[5] = umsatz;

            string zeile = nummer + ";" + name + ";" + vorname + ";" + ort + ";" + alter + ";" + umsatz;

            adr.Insert(tempindex, zeile);
            adr.RemoveAt(tempindex + 1);    // alte Zeile löschen
        }
        return index;
    }

    static string check(string value, string oldValue)
    {
        string wert = value;
        if (wert == "") wert = oldValue;
        return wert;
    }

    static int loadAdr(ref List<string> adr)
    {
        if (File.Exists(@filename))
        {
            foreach (string line in File.ReadLines(@"daten.txt"))
                adr.Add(line);
        }
        else
        {
            Console.WriteLine("Das File Daten ist nicht vorhanden. Es werden die Default Werte geladen\n\n");
            Console.ReadKey();

            adr.Add("1000;Gino;Colombo;Lyss;44;120.55");
            adr.Add("1001;Pia;Colombo;Lyss;33;200.45");
            adr.Add("1002;Dario;Colombo;Gümligen;22;300.95");
        }
        Console.WriteLine();

        return adr.Count - 1;
    }

    static void saveAdr(ref List<string> adr)
    {
        Console.Write("Daten speichern? <j/n> "); string wahl = Console.ReadLine().ToUpper();

        if (wahl == "J")
        {
            File.WriteAllLines(@filename, adr);
            Console.WriteLine("\nDaten wurden gesichert");
            Console.ReadKey();
        }
    }

    static void aktadres(ref List<string> adr)
    {
        int show;
        show = index - 1;
        Console.Clear();
        Console.WriteLine("Adresse zum aktuellem Index.");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine(adr[show]);
        Console.ReadLine();
        

    }

    static void alladres(ref List<string> adr)
    {
        Console.Clear();
        Console.WriteLine("Es werden nun alle Adresse aufgelistet");
        Console.WriteLine("--------------------------------------------------------------");

        for (int i = 1; i < adr.Count; i++)
        {
            Console.WriteLine("Zeile" + i + "{0}", adr[i]);
        }
        Console.WriteLine(" ");
        Console.WriteLine("Ende");
        Console.ReadLine();
    }

    


    static int Vorwaerts(ref List<string> adr, int index)
    {
        
        string[]ausgabe;
        int tempindex;
        int max;
        string temp;
        
        Console.Clear();
        Console.WriteLine("Der Index wurde erhöht");
        tempindex = index ;
        max = adr.Count;
      //  max = max - 1;

        if (tempindex == max)
        {
            Console.WriteLine("Keine Einträge mehr vorhanden");
            Console.ReadLine();
            index = 1;
        }
        else
        {

            temp = adr[index];

            ausgabe = temp.Split(';');

            Console.WriteLine("Nummer:      {0}", ausgabe[0]);
            Console.WriteLine("Nachname:    {0}", ausgabe[1]);
            Console.WriteLine("Vorname:     {0}", ausgabe[2]);
            Console.WriteLine("Ort:         {0}", ausgabe[3]);
            Console.WriteLine("Alter:       {0}", ausgabe[4]);
            Console.WriteLine("Umsatz:      {0}", ausgabe[5]);

            Console.WriteLine("Der Index wurde verkleinert");
            Console.ReadLine();
            index++;


        }

        

        return index;
    }

    static void alle(ref List <string> adr)
    {
        string[] ausgabe;
        string temp;
        int max = adr.Count;
        max = max - 1;
        int maximumname = 23;
        int maximum2 = 4;
        int maximumnummer = 8;
        int maximumumsatz = 10;
                                  
        Console.WriteLine("Nummer  Vorname                Nachname               Ort                    Alter   Umsatz    ");
        Console.WriteLine("-----------------------------------------------------------------------------------------------");

        for (int i = 0; i <= max; i++)
        {

            int plus = i;
            temp = adr[plus];
            ausgabe = temp.Split(';');

        


            int tmplaenge;
            tmplaenge = maximumnummer - ausgabe[0].Length;
            Console.Write(ausgabe[0]);
            for (int a = 0; a < tmplaenge; a++)
            {
                Console.Write(" ");
            }

            tmplaenge = maximumname - ausgabe[2].Length;
            Console.Write(ausgabe[2]);
            for (int a = 0; a < tmplaenge; a++)
            {
                Console.Write(" ");
            }

            tmplaenge = maximumname - ausgabe[1].Length;
            Console.Write(ausgabe[1]);
            for (int a = 0; a < tmplaenge; a++)
            {
                Console.Write(" ");
            }

            tmplaenge = maximumname - ausgabe[3].Length;
            Console.Write(ausgabe[3]);
            for (int a = 0; a < tmplaenge; a++)
            {
                Console.Write(" ");
            }

            tmplaenge = maximumnummer - ausgabe[4].Length;
            Console.Write(ausgabe[4]);
            for (int a = 0; a < tmplaenge; a++)
            {
                Console.Write(" ");
            }

            Console.Write(ausgabe[5]);
            Console.WriteLine();


            /* tmplaenge = maximumumsatz - ausgabe[5].Length;
             Console.Write(ausgabe[5]);
             for (int a = 0; a < tmplaenge; a++)
             {
                 Console.Write(" ");
             }
             */
         

        }
        Console.ReadKey();


    }


    static int Rueckwaerts(ref List<string> adr, int index)
    {
        
        string temp;
        string[] ausgabe;
        int tempinex;
        int max;
        max = adr.Count;
        

        tempinex = index - 1;
        Console.Clear();
       
        if (tempinex <= 0)
        {
            Console.WriteLine("Keine Einträge mehr vorhanden");
            Console.ReadLine();
            index = max;
            
        }
        else
        {
            index = index - 1;
            temp = adr[tempinex - 1];

            ausgabe = temp.Split(';');

            Console.WriteLine("Nummer:      {0}", ausgabe[0]);
            Console.WriteLine("Nachname:    {0}", ausgabe[1]);
            Console.WriteLine("Vorname:     {0}", ausgabe[2]);
            Console.WriteLine("Ort:         {0}", ausgabe[3]);
            Console.WriteLine("Alter:       {0}", ausgabe[4]);
            Console.WriteLine("Umsatz:      {0}", ausgabe[5]);


            Console.WriteLine("Der Index wurde verkleinert");
            Console.ReadLine();
            
        }

        return index;


    }

    // alle in der Liste anzeigen
    static int Zeige(ref List<string> adr, int index)
    {
        string[] ausgabe;
        string temp;
        int tempindex;
        Console.Clear();
        Console.WriteLine("Hier wird die Adresse hinter dem aktuellem Index aufgelistet.");
        Console.WriteLine("--------------------------------------------------------------");
        tempindex = index - 1;
        temp = adr[tempindex];

        ausgabe = temp.Split(';');

       // Console.WriteLine("ID:          {0}", ausgabe[]);
        Console.WriteLine("Nummer:      {0}", ausgabe[0]);
        Console.WriteLine("Nachname:    {0}", ausgabe[1]);
        Console.WriteLine("Vorname:     {0}", ausgabe[2]);
        Console.WriteLine("Ort:         {0}", ausgabe[3]);
        Console.WriteLine("Alter:       {0}", ausgabe[4]);
        Console.WriteLine("Umsatz:      {0}", ausgabe[5]);
        Console.ReadKey();
        return index;
    }

    static void suche(ref List<string> adr)
    {
        string eingabe;
        bool suche = false;
        Console.Clear();
        Console.WriteLine("Geben sie die Id ein nach der gesucht werden soll\n");
        Console.Write("ID: ");
        eingabe = Console.ReadLine();

        string[] ausgabe;
        string temp;
        int max = adr.Count;
//        max = max + 1;

        for (int i = 0; i < max; i++)
        {
            int plus = i;
            temp = adr[plus];
            ausgabe = temp.Split(';');
            if (eingabe == ausgabe[0])
            {
                suche = true;
                Console.WriteLine("\nDie ID {0} existiert\n", eingabe);

                Console.WriteLine("Nummer:      {0}", ausgabe[0]);
                Console.WriteLine("Nachname:    {0}", ausgabe[1]);
                Console.WriteLine("Vorname:     {0}", ausgabe[2]);
                Console.WriteLine("Ort:         {0}", ausgabe[3]);
                Console.WriteLine("Alter:       {0}", ausgabe[4]);
                Console.WriteLine("Umsatz:      {0}", ausgabe[5]);
                break;
            }
            else
            { }

        }

        if (suche == false)
        {
            Console.WriteLine("\nDie ID {0} existiert nicht", eingabe);
        }
        
        Console.ReadKey();

    }

    // Ein Datensatz anzeigen
    static int Zeigen(ref List<string> adr, int index)
    {

        return index;

    }

    static int Suchen(ref List<string> adr, int index)
    {
        return index;
    }

    static int Loeschen(ref List<string> adr, int index)
    {
        int temp;
        string eingabe;
        temp = index - 1;

        Console.Clear();
        Console.WriteLine("Der aktuelle Index {0} wird gelöscht",index);
        Console.WriteLine("Sind sie sich sicher j /n ?");
        eingabe = Console.ReadLine();

        if (eingabe == "j")
        {
            adr.RemoveAt(temp);
            File.WriteAllLines(@"daten.txt", adr);
        }


        return index;
    }

//----------------------------------------------------------------------------------------------

    // globale Daten
    static string filename = "daten.txt";
    static List<string> adressen = new List<string>();
    static int index;//= -1;

    // beginn Programm
    static void Main()
    {
        index = loadAdr(ref adressen);
        string wahl = "";
        do
        {
            wahl = menu(index);
            switch (wahl)
            {
                case "N": index = Neu(ref adressen, index); break;
                case "A": index = Aendern(ref adressen, index); break;
                case "V": index = Vorwaerts(ref adressen, index); break;
                case "R": index = Rueckwaerts(ref adressen, index); break;
                case "E": saveAdr(ref adressen); break;
                case "Z": Zeige(ref adressen, index); break;
                case "P": alle(ref adressen); break;
                case "L": Loeschen(ref adressen, index); break;
                case "S": suche(ref adressen); break;
            }

        } while (wahl != "E");
    }
}

