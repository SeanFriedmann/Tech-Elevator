namespace Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        

        public Airplane (string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true && totalNumberOfSeats <= this.AvailableFirstClassSeats )
            {
                int number = this.BookedFirstClassSeats;
               number = BookedFirstClassSeats + totalNumberOfSeats;
                this.BookedFirstClassSeats = number;
                //BookedFirstClassSeats += totalNumberOfSeats;

                return true;
            }
            else if (forFirstClass == false && totalNumberOfSeats <= this.AvailableCoachSeats)
            {
                int numberCoach = this.BookedCoachSeats;
                numberCoach = BookedCoachSeats + totalNumberOfSeats;
                this.BookedCoachSeats = numberCoach;
               // BookedCoachSeats += totalNumberOfSeats; 
                return true;
            }

            //else if (AvailableFirstClassSeats < BookedFirstClassSeats)
            //{
            //    return false;
            //}
            return false;
            }
               
            
           

           
        }
    }

