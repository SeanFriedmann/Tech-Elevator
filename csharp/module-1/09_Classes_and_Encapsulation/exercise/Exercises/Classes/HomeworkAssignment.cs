
namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        
        public int EarnedMarks { get; set; }

        private int possibleMarks { get; set; }

        public int PossibleMarks
        {
            get
            {
                return possibleMarks;
            }
            set
            {
                this.possibleMarks = value;
            }
        }

        //private int PossibleMarks { get; set; }

        private string submitterName { get; set; }
        
        public string SubmitterName
        {
            get
            {
                return submitterName;
            }
            set
            {
                this.submitterName = value;
            }
        }

        public string LetterGrade
        {
            get
            {
                double output = (((double)EarnedMarks) / ((double)PossibleMarks)) * 100;
                if (output >= 90)
                {
                    return "A";
                }
                else if (output >= 80 && output <= 89)
                {
                    return "B";
                }
                else if (output >= 70 && output <= 79)
                {
                    return "C";
                }
                else if (output >= 60 && output <= 69)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }


        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }

        //public HomeworkAssignment(int possibleMarks, int earnedMarks, string letterGrade)
        //{
        //    //this.PossibleMarks = possibleMarks;
        //    //this.EarnedMarks = earnedMarks;
        //    //this.LetterGrade = letterGrade;
        //    double output = (((double)earnedMarks) / ((double)possibleMarks)) * 100;
        //    if (output >= 90)
        //    {
        //        letterGrade = "A";
        //    }
        //    else if (output >= 80 && output <= 89)
        //    {
        //        letterGrade = "B";
        //    }
        //    else if (output >= 70 && output <= 79)
        //    {
        //        letterGrade = "C";
        //    }
        //   else if (output >= 60 && output <= 69)
        //    {
        //        letterGrade = "D";
        //    }
        //    else
        //    {
        //        letterGrade = "F";
        //    }

            
        }
        

        



    }

