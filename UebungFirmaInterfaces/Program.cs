using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungFirmaInterfaces
{
    /*
 * Aufgabe: Überlegen Sie sich, wie Sie mit Hilfe Ihres bisher erlangten Wissens
 *          unser Firma- bzw. Mitarbeiter-Szenario etwas anders entwerfen bzw. 
 *          modellieren könnten und implementieren Sie ihre gefundene Lösung.
 * 
 *          Berücksichtigen Sie dabei auch die Möglichkeit, dass sich der Status
 *          eines Mitarbeiters ändern, d.h. bspw. ein 'Gehaltsempfaenger' zu einem
 *          'Lohnempfaenger' werden kann und stellen Sie die hierfür notwendige
 *          Funktionalität bereit.
 * 
 *          Passen Sie dazu bitte auch unsere bisherige Implementierung der
 *          Klasse 'Firma' entsprechend an, so dass diese weiterhin Mitarbeiter
 *          verwalten kann, eine Status-Änderung für Mitarbeiter bereitstellt 
 *          und geeignete Informationen über alle Mitarbeiter liefert.
 */


    public interface Itest1
    {

        int Zahl1
        {
            get;
            set;
        }

        int Zahl2
        {
            get;
            set;
        }

        void printe();
        int addiere(int a, int b);
    }



    /*
    public interface Itest2
    {
        int Zahl1
        {
            get;
            set;
        }

        int Zahl2
        {
            get;
            set;
        }

        void printe();
        int addiere(int a, int b);
    }
    */


    public class MyClass : Itest1
    {
        private int x;
        private int y;


        public MyClass()
        {
            this.x = 0;
            this.y = 0;
        }

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public int Zahl1
        {
            get { return this.x;  }
            set { this.x = value; }

        }

        public int Zahl2
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public void printe()
        {
            Console.WriteLine("Hallo Interface 1... x: {0}\ty: {1}", this.x, this.y);
        }

        public int addiere(int a, int b)
        {
            return a + b;
        }   
    }





    public interface IPersonal
    {

        // Properties
      
        string name { get; set; } // müsste man dann ja bei beiden machen, doppelter code, ist ja quatsch
        int nummer { get; set; }


        // Methoden
        void drucke();
    }




    public class Mitarbeiter //: IPersonal
    {


    }

    public class Lohnempfaenger
    {

    }

    public class Gehaltsempfaenger
    {

    }




    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Uebung zu Interfaces mit Firma-Beispiel");




            Console.ReadKey();

        }
    }
}
